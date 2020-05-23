using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectSQL;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectionDB con = new ConnectionDB();
            con.TestConnect(textBoxNameSQL.Text.ToString().Trim());
        }

        
    }
}
