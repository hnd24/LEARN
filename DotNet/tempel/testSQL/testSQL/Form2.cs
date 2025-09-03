using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace testSQL
{
    public partial class Form2 : Form
    {
        String strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection SqlCon = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            if (SqlCon == null)
            {
                SqlCon = new SqlConnection(strCon);
            }
            if (SqlCon.State == ConnectionState.Closed)
            {
                SqlCon.Open();
            }

            //đối tượng thực thi truy vấn 
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandText = "SELECT * FROM VATTU";

            //gửi truy vấn và kết nối 
            Sqlcmd.Connection = SqlCon;

            SqlDataReader reader = Sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                string maVT = reader.GetString(0);
                string maVT1 = reader.GetString(1);
                string maVT2 = reader.GetString(2);
                float maVT3 = reader.GetFloat(3);

                ListViewItem lv1 = new ListViewItem(maVT);
                lv1.SubItems.Add(maVT1);
                lv1.SubItems.Add(maVT2); 
                lv1.SubItems.Add(maVT3.ToString());

                listView1.Items.Add(lv1);


            }

            reader.Close();

            //nhận kết quả 
            //int resuld = (int)Sqlcmd.ExecuteScalar();
            //MessageBox.Show(" " + resuld);



        }











        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
