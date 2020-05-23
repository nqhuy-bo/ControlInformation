using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectSQL
{
    public class ConnectionDB
    {
        SqlConnection con;
        DataTable table;

        public void connect()
        {

        }
        public void TestConnect(String tenSQL)
        {
            string tenMay = System.Environment.MachineName;
            String cn = @"Data Source=" + tenMay + ";Initial Catalog=" + tenSQL + ";Integrated Security=True";
            try
            {
                con = new SqlConnection(cn);

                con.Open();
                MessageBox.Show("Kết nối thành công", "Ahihi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Kết nối tới CSDL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ExcuteQuery(string pQuery)
        {
            con.Open();
            table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(pQuery, con);
            da.Fill(table);
            con.Close();
            return table;

        }

        //===============
      //Lấy thông tin một sinh viên

        public String[] getDataStudent(String tenSQL,String maSV)
        {
            String[] info = new String[6];
            String kq="";
            string tenMay = Environment.MachineName;
            //string tenMay = System.Environment.MachineName;
            //Tạo đối tượng Connection
            SqlConnection con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Sử dụng Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            con.ConnectionString = @"Data Source=" + tenMay + ";Initial Catalog=" + tenSQL + ";Integrated Security=True";
            con.Open(); // mở kết nối

            String sql = "Select * from SINHVIEN where MASV='"+maSV+"'";
            //tạo đối tượng DataSet
            DataSet ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                info[0] = row["MASV"].ToString();
                info[1] = row["TENSV"].ToString();
                info[2] = row["MALOP"].ToString();
                info[3] = row["NGAYSINH"].ToString();
                info[4] = row["GIOITINH"].ToString();
                info[5] = row["CMND"].ToString();

            }
                
            
            return info;
        }
    }
}
