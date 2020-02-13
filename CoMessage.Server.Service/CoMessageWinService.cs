using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;

namespace CoMessage.Server.Service
{
    public static class CoMessageWinService
    {
        static ServiceHost _serviceHost = null;

        static readonly string c_HostIP   = "localhost";
        static readonly ushort c_HostBasePort = 9990;

        static CoMessageWinService()
        {
            //ServiceName = "CoMessage.Service";
        }

        public static void Main(string[] args)
        {
            //ServiceBase.Run( new CoMessageWinService() );
            Start(args);

            Console.WriteLine("Host is started at " + _serviceHost.BaseAddresses[0].AbsoluteUri);
            Console.ReadLine();
            Console.WriteLine("Stopping...");
            Stop();
        }

        static void Start(string[] args)
        {
            if (_serviceHost != null)
                _serviceHost.Close();

            Uri[] baseAddresses =
            {
                new Uri("net.tcp://" + c_HostIP + ":" + (c_HostBasePort+1).ToString()),
                new Uri("http://"    + c_HostIP + ":" + (c_HostBasePort+2).ToString())
            };

            _serviceHost = new ServiceHost( typeof(CoMessageService), baseAddresses );

            var netTcpBinding = new NetTcpBinding();

            // 67108864 => 64 Мебибайт
            netTcpBinding.MaxBufferPoolSize                   = (int)67108864;
            netTcpBinding.MaxBufferSize                       = 67108864;
            netTcpBinding.MaxReceivedMessageSize              = (int)67108864;
            netTcpBinding.TransferMode                        = TransferMode.Buffered;
            netTcpBinding.ReaderQuotas.MaxArrayLength         = 67108864;
            netTcpBinding.ReaderQuotas.MaxBytesPerRead        = 67108864;
            netTcpBinding.ReaderQuotas.MaxStringContentLength = 67108864;

            netTcpBinding.MaxConnections = 100;
            //To maxmize MaxConnections you have 
            //to assign another port for mex endpoint

            //and configure ServiceThrottling as well
            ServiceThrottlingBehavior throttle = _serviceHost.Description.Behaviors.Find<ServiceThrottlingBehavior>();
            if (throttle == null)
            {
                throttle = new ServiceThrottlingBehavior();
                throttle.MaxConcurrentCalls = 100;
                throttle.MaxConcurrentSessions = 100;
                _serviceHost.Description.Behaviors.Add(throttle);
            }

            // Enable reliable session and keep the connection alive for 20 hours.
            netTcpBinding.ReceiveTimeout                    = new TimeSpan(20, 0, 0);
            netTcpBinding.ReliableSession.Enabled           = true;
            netTcpBinding.ReliableSession.InactivityTimeout = new TimeSpan(20, 0, 10);

            _serviceHost.AddServiceEndpoint(
                typeof(ICoMessageService), 
                netTcpBinding, 
                //"tcp"
                baseAddresses[0].AbsoluteUri
            );

            var mBehave = new ServiceMetadataBehavior();
            mBehave.HttpGetEnabled  = true;
            mBehave.HttpsGetEnabled = true;
            _serviceHost.Description.Behaviors.Add(mBehave);


            var dbgBehave = _serviceHost.Description.Behaviors.Find<ServiceDebugBehavior>();
            if (dbgBehave == null)
            {
                dbgBehave = new ServiceDebugBehavior();
                _serviceHost.Description.Behaviors.Add(dbgBehave);
            }
            dbgBehave.IncludeExceptionDetailInFaults = true;


            _serviceHost.AddServiceEndpoint(
                typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexTcpBinding(),
                "net.tcp://" + c_HostIP + ":" + c_HostBasePort.ToString() + "/mex"
            );

            _serviceHost.Open();
        }

        private static void _serviceHost_Faulted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static void Stop()
        {
            if (_serviceHost != null)
                _serviceHost.Close();

            _serviceHost = null;
        }

    }
}
