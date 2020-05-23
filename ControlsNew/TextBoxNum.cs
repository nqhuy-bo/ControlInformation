using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ControlsNew
{
    public class TextBoxNum:TextBox
    {
        ErrorProvider err = new ErrorProvider();
        public TextBoxNum()
        {
            this.KeyPress += TextBoxNum_KeyPress;
        }

        void TextBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                err.SetError(this,"Chỉ được nhập số");
            }
        }
    }
}
