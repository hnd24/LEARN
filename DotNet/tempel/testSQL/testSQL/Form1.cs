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
    
    public partial class Form1 : Form
    {

        // Tạo 2 biến cục bộ
        String strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=test1;Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlcon == null)
                {
                    sqlcon = new SqlConnection(strCon);
                }
                
                //Open Connect
                if(sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    MessageBox.Show("Connected Successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if(sqlcon != null && sqlcon.State == ConnectionState.Open)
            {
                sqlcon?.Close();
                MessageBox.Show("Unconnected Successfully");

            }
            else
            {
                MessageBox.Show("Connect not available");

            }
        }
    }
}
