using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoMessage.App.UiLib.Controls
{
    public class ListBoxEx : ListBox
    {
        public bool ShowScrollBars
        {
            get => _ShowScrollBars;
            set
            {
                if (_ShowScrollBars == value)
                    return;

                _ShowScrollBars = value;
                if (IsHandleCreated)
                    RecreateHandle();
            }
        }
        protected bool _ShowScrollBars;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                if (!_ShowScrollBars) cp.Style &= 0x0020_0000;
                return cp;
            }
        }
    }
}
