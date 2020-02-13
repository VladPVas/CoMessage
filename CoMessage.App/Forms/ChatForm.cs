using CoMessage.App.UiLib.Renders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

using CoMessage.App.Extensions;
using static CoMessage.App.UiLib.Renders.ChatItemRender;
using CoMessageApp.CoMessageService;
using CommonModel = CoMessage.Model.Common;
using CoMessage.Model.Common.OperationResults;

namespace CoMessageApp.Forms
{
    public partial class ChatForm : Form, CoMessageApp.CoMessageService.ICoMessageServiceCallback
    {
        CoMessageServiceClient _server = null;
        
        private bool _isFormLoaded = false;

        private Pen   _upSplitPen    = new Pen(Color.Azure, 45);
        private Pen   _btChatInfoPen = new Pen(Color.LightGray, 2);
        private Image _avatarImage   = Image.FromFile(Globals.IconsPath + "icons8_info_24px.png");

        Dictionary<DrawItemState,ChatListItemRender> _renders = new Dictionary<DrawItemState, ChatListItemRender>(2);

        static ChatItemRender _chatLeftItemRender = new ChatItemRender {
            Dock                 = DockStyle.Left,
            StripBackgroundColor = Color.FromArgb(67, 69, 77),
            ShowStatusIcon       = false
        };
        static ChatItemRender _chatRightItemRender = new ChatItemRender {
            Dock                 = DockStyle.Right,
            StripBackgroundColor = Color.FromArgb(67, 69, 77)
        };


        public ChatForm()
        {
            InitializeComponent();

            _renders.Add (
                DrawItemState.Selected,
                new ChatListItemRender { BackgroundColor = Color.FromArgb(67, 69, 77) }
            );

            _renders.Add (
                DrawItemState.Default,
                new ChatListItemRender { BackgroundColor = Color.FromArgb(45, 47, 50) }
            );

            _server = new CoMessageServiceClient(new InstanceContext(this));
        }
      

        private void ChatForm_Load(object sender, EventArgs e)
        {
            _isFormLoaded = false;

            lbUserNickname.Text = Program.UserInfo.Nickname;
            Program.UserInfo.NicknameChanged += UserInfo_NicknameChanged;

            //~SetEllipseRegionForControls();
            lbxChatList.BackColor = Color.FromArgb(45, 47, 50);
            SaveControlWidthAlignedByChatList();

            string[] texts = new string[]
            {
                "000. Друзья, это просто раз-рыв сердца. Очень хороший, добрый и немного учащий, нас - зрителей, ценить то, что нам так дорого, что мы привыкли упускать это - дорогое" +
                "Хочется сказать, именно от себя, это прекрасный тайтл, может я и сам придумал в ходе просмотра выше сказанное, но при просмотре, мне стало тепло и уютно, моим эмоциям не было и конца." +
                "Ух, что-то расписался, если вам нравятся хорошие тайтлы, с красивой рисовкой и захватывающим дух, прошу не слушайте никого и просто посмотрите, я надеюсь тебе понравится"
                , "111. =================================================================="
                , "222. Друзья, это просто раз-рыв сердца. Очень хороший, добрый и немного учащий, нас - зрителей, ценить то, что нам так дорого, что мы привыкли упускать это - дорогое"
                , "333. нравятся хорошие тайтлы, с красивой рисовкой и захватывающим дух, прошу не слушайте никого и просто "
            };


            lbxChat.Items.Clear();
            _isFormLoaded = true;

            for (int i = 0; i < 20; ++i)
            {
                var renderInfo = new ChatItemRenderInfo
                {
                    Message = new CommonModel.Message
                    {
                        DataAsString = texts[i & 0x03]
                    }
                };
                lbxChat.Items.Add(renderInfo);
            }

            reWriteMessage.Select();
        }

        private void UserInfo_NicknameChanged(object sender, string newNickname)
        {
            lbUserNickname.Text = newNickname;
        }

        private void lbxChatList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.State.HasFlag(DrawItemState.Selected))
                _renders[DrawItemState.Selected]
                    .Render(
                        e.Graphics,
                        e.Bounds,
                        _avatarImage,
                        "<Nick_Name>",
                        "krpiojeroilhjgoierngoieroip");
            else
                _renders[DrawItemState.Default]
                    .Render(
                        e.Graphics,
                        e.Bounds,
                        _avatarImage,
                        "<Nick_Name>",
                        "krpiojeroilhjgoierngoieroip");
        }

        private void btShowChatList_Click(object sender, EventArgs e)
        {
            ChangeChatListVisible(!pnlChatList.Visible);
            btShowChatList.Text = pnlChatList.Visible ? "<<" : ">>";
        }

        List<Control> _controlsAlignedByChatList = new List<Control>(3);
        private void SaveControlWidthAlignedByChatList()
        {
            _controlsAlignedByChatList.Add(pnlMain);
            _controlsAlignedByChatList.Add(lbxChat);
            _controlsAlignedByChatList.Add(reWriteMessage);
        }

        private void ChangeChatListVisible(bool isChatListVisible, bool doChangeVisibleChatList =true)
        {
            if (doChangeVisibleChatList)
                pnlChatList.Visible = isChatListVisible;

            int widthToAdd = (pnlChatList.Visible ? -pnlChatList.Width : +pnlChatList.Width);
            foreach (var widget in _controlsAlignedByChatList)
            {
                int x     = widget.Left  -widthToAdd;
                int width = widget.Width +widthToAdd;
                widget.SetBounds(x, widget.Location.Y, width, widget.Height);
            }

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbUserStatus_Click(object sender, EventArgs e)
        {

        }

        Size MeasureChatItemFullSize(int index, Graphics graphics = null, bool doSetRenderInfo = true)
        {
            if (index < 0 || lbxChat.Items.Count <= index)
                return new Size();

            Size size = new Size(lbxChat.ClientSize.Width, lbxChat.ItemHeight);

            var renderInfo = lbxChat.Items[index] as ChatItemRenderInfo;
            if (renderInfo == null)
                return size;

            ItemSizes itemSizes = MeasureChatItemSizes (
                renderInfo.Message, 
                (index % 2 == 0) ? _chatRightItemRender : _chatLeftItemRender
            );

            if (doSetRenderInfo)
                renderInfo.ItemSizes = itemSizes;

            return renderInfo.ItemSizes.Full;
        }

        ItemSizes MeasureChatItemSizes(CommonModel.Message message, ChatItemRender chatItemRender, Graphics graphics =null)
        {
            if (graphics == null)
                graphics = lbxChat.CreateGraphics();

            return chatItemRender.MeasureItemsSizes (
                graphics,
                new Rectangle(0, 0, lbxChat.ClientSize.Width, lbxChat.ClientSize.Height),
                message
            );
        }

        private void lbxChat_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (!_isFormLoaded)
                return;

            var itemSize = MeasureChatItemFullSize(e.Index, e.Graphics);
            e.ItemWidth = itemSize.Width;
            e.ItemHeight = itemSize.Height;
        }

        private void lbxChat_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (!_isFormLoaded)
                return;

            var itemInfo = (ChatItemRenderInfo)lbxChat.Items[e.Index];

            using ( var pic = new PictureBox() )
            {
                ChatItemRender cir = (e.Index % 2 == 0) ? _chatRightItemRender : _chatLeftItemRender;

                cir.Render (
                    e.Graphics,
                    e.Bounds,
                    pic.Image,
                    itemInfo.Message,
                    itemInfo.ItemSizes
                );
            }
        }

        private void lbxChat_SizeChanged(object sender, EventArgs e)
        {
            lbxChat.Visible = false;

            for (int idx = 0; idx < lbxChat.Items.Count; ++idx)
            {
                var itemHeight = MeasureChatItemFullSize(idx);
                Win32.SendMessage(lbxChat.Handle, Win32.LB_SETITEMHEIGHT, idx, (IntPtr)itemHeight.Height);
            }

            lbxChat.Visible = true;
        }

        CommonModel.MessageStatus GetNextMessageStatus(CommonModel.MessageStatus status)
        {
            if (status == CommonModel.MessageStatus.Sending)   return CommonModel.MessageStatus.Seen;
            if (status == CommonModel.MessageStatus.Seen)      return CommonModel.MessageStatus.Delivered;
            if (status == CommonModel.MessageStatus.Delivered) return CommonModel.MessageStatus.Sending;

            return CommonModel.MessageStatus.Sending;
        }

        private void lbxChat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbxChat.IndexFromPoint(e.Location);
            var info = (ChatItemRenderInfo)lbxChat.Items[index];

            info.Message.Status = GetNextMessageStatus(info.Message.Status);
            lbxChat.Refresh();
            //lbxChat.Items[index] = info;
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
            reWriteMessage.Text = string.Empty;
        }

        void SendMessage(string text =null)
        {
            if (string.IsNullOrEmpty(text))
                text = reWriteMessage.Text;

            text = text.Trim();
            if (text.Length == 0)
                return;

            var newMessage = new CommonModel.Message
            {
                Status       = CoMessage.Model.Common.MessageStatus.Sending,
                DataAsString = text,
                SendTime     = DateTime.Now
            };

            var index = lbxChat.Items.Count;

            var itemSizes = MeasureChatItemSizes(
                newMessage,
                (index % 2 == 0) ? _chatRightItemRender : _chatLeftItemRender
            );

            lbxChat.Items.Add(new ChatItemRenderInfo { Message = newMessage, ItemSizes = itemSizes });
            lbxChat.SetSelected(index, true);
        }

        private void reWriteMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
                reWriteMessage.Text = string.Empty;
            }
        }

        Dictionary< Guid, List<CoMessage.Model.Common.Message> > _chatMessages 
            = new Dictionary< Guid, List<CoMessage.Model.Common.Message> >();

        public void ReceiveMessage(CoMessage.Model.Common.Message message)
        {
            return;

            //~~~
            //return AddChatMessage(message)
            //        ? OperationCode.Success
            //        : OperationCode.E_Unknown;
        }

        private bool AddChatMessage(CoMessage.Model.Common.Message message)
        {
            //if (_server.ChatHasUser(message.ChatID, Program.UserInfo.ID))
            _chatMessages[message.ChatID].Add(message);

            return true;

        }

        KeyValuePair<int,List<CommonModel.Message>> GetChatListAndMessageIndexByMessageID(Guid messageID)
        {
            foreach (var pair in _chatMessages)
                for (int i = 0; i < pair.Value.Count; ++i)
                {
                    var message = pair.Value[i];
                    if (message.ID == messageID)
                        return new KeyValuePair<int,List<CommonModel.Message>>(i, pair.Value);
                }

            return new KeyValuePair<int, List<CommonModel.Message>>(-1, null);
        }

        public void DeleteMessage(Guid messageID)
        {
            var msgIndexAndListPair = GetChatListAndMessageIndexByMessageID(messageID);
            if (msgIndexAndListPair.Key < 0)
                return;

            msgIndexAndListPair.Value.RemoveAt(msgIndexAndListPair.Key);

            Invalidate();
        }

        public void ServiceNotify(CommonModel.ServiceNotifyData notifyData)
        {
            throw new NotImplementedException();
        }
    }

    class ChatItemRenderInfo
    {
        public CommonModel.Message      Message;
        public ChatItemRender.ItemSizes ItemSizes;
    }
}