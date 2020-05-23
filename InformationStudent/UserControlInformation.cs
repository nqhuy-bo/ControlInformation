using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectSQL;
namespace InformationStudent
{
    public partial class UserControlInformation: UserControl
    {
        public UserControlInformation()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNumberIDStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String[] info = new String[6];
                ConnectionDB con = new ConnectionDB();
                info = con.connectDataBase("QLSinhVien", textBoxNumberIDStudent.Text.ToString().Trim());
                if (info[1] != null)
                {

                    lblNameSV.Text = info[1].ToString();
                    lblMaLop.Text = info[2].ToString();
                    lblNgaySinh.Text = info[3].ToString();
                    lblGioiTinh.Text = info[4].ToString();
                    lblCMND.Text = info[5].ToString();
                }
                else
                {
                    MessageBox.Show(this, "Không tìm thấy thông tin", "Thông báo"); 
                }
            }
        }

        
    }
}
