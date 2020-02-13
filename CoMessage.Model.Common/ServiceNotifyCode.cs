using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoMessage.Model.Common
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>The prefix "S_" means "Success". On the contrary, the prefix "E_" means "Error".</remarks>
    public enum ServiceNotifyCode
    {
        Unknown = 0,
        S_Login,
        E_Login,
        
        S_Logout,
        E_Logout,
        
        S_Signin,
        E_Signin,
        
        S_Signout,
        E_Signout
    }
}
