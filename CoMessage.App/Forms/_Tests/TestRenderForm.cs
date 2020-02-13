using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoMessage.App.UiLib.Renders;
using CommonModel = CoMessage.Model.Common;

namespace CoMessageApp.Forms._Tests
{
    public partial class TestRenderForm : Form
    {
        public TestRenderForm()
        {
            InitializeComponent();

            _renders.Add(DrawItemState.Selected,
                new ChatListItemRender {
                    BackgroundColor = Color.FromArgb(67, 69, 77),
                    //NickBrush = new SolidBrush(Color.LightGray)
                }
            );
            _renders.Add(DrawItemState.Default,
                new ChatListItemRender {
                    BackgroundColor = Color.FromArgb(45, 47, 50)
                }
            );
        }

        Image _avatartImage = Image.FromFile(Globals.IconsPath +@"icons8_info_24px.png");
        Dictionary<DrawItemState, ChatListItemRender> _renders = new Dictionary<DrawItemState, ChatListItemRender>(2);

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.State.HasFlag(DrawItemState.Selected))
                _renders[DrawItemState.Selected]
                    .Render(
                        e.Graphics,
                        e.Bounds,
                        _avatartImage,
                        "Nick sdfsdf asdf asdf asdf asdf asdf asdf sadf sadfasdfsdtgqwetwertreswt d",
                        "Nick: Lorem Ipsum - это текст-'рыба', часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной 'рыбой' для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum."
                    );
            else
                _renders[DrawItemState.Default]
                    .Render(
                        e.Graphics,
                        e.Bounds,
                        _avatartImage,
                        "Nick sdfsdf asdf asdf asdf asdf asdf asdf sadf sadfasdfsdtgqwetwertreswt d",
                        "Nick: Lorem Ipsum - это текст-'рыба', часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной 'рыбой' для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum."
                    );



        }

        private void ChatListBoxRenderForm_Load(object sender, EventArgs e)
        {
            listBox1.BackColor = Color.FromArgb(45, 47, 50);
        }


        CommonModel.Message g_message = new CommonModel.Message
        {
            DataAsString  = "Lorem Ipsum -|p, это текст-'рыба',-|p, часто используемый в печати -|p, и вэб-дизайне. Lorem Ipsum является стандартной 'рыбой' для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum.",
            //DeliveredTime = DateTime.Now.ToLocalTime()
        };

        ChatItemRender chatItemRender = new ChatItemRender();
        private void TestRenderForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(10,10,40,40);
            e.Graphics.DrawRectangle(SystemPens.Highlight, r);
            //chatItemRender.Render(e.Graphics, messageBox, null, g_message);
        }
    }
}
