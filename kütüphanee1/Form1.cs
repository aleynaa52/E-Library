using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace kütüphanee1
{
    public partial class Form1 : Form
    {
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["E_KÜTÜPHANE2ConnectionString"].ConnectionString;
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection=new SqlConnection(connectionString))
                {
                    connection.Open();
                    if(connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("1 SANİYE SONRA YÖNLENDİRİLECEKSİNİZ.", "BAĞLANTI AÇIK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                Thread.Sleep(1000);
                Form_User_Login form2=new Form_User_Login();
                this.Hide();
                form2.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex);
                throw;
            }
        }
    }
}
