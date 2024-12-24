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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kütüphanee1
{
    public partial class Form_User_Login : Form
    {
        private string connectionString;
        public Form_User_Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["E_KÜTÜPHANE2ConnectionString"].ConnectionString;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string c_name=txt_name.Text.ToString();
            string c_surname=txt_surname.Text.ToString();
            string c_tel=masked_tel.Text.ToString();
            c_tel = c_tel.Replace("(", "").Replace(")", "").Replace("_", "");
            c_tel = "0" + c_tel;
            string c_mail=txt_mail.Text.ToString();

            try
            {
                using (SqlConnection connection= new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd= new SqlCommand("sp_insert_into_Table_Member",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@member_name", c_name);
                        cmd.Parameters.AddWithValue("@member_surname",c_surname);
                        cmd.Parameters.AddWithValue("@member_telephone_number", c_tel);
                        cmd.Parameters.AddWithValue("@member_email", c_mail);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("KAYIT BAŞARIYLA EKLENDİ !");

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA=" + ex.Message);
                throw;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALEYNA-A\\SQLEXPRESS;Initial Catalog=E-KÜTÜPHANE2;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Member", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
           /* try
            {
                using (SqlConnection connection=new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd=new SqlCommand("sp_select_Table_Member",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt= new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        connection.Open();
                        da.Fill(dt);
                        dataGridView1.DataSource= dt;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA=" + ex);

                throw;
            }*/
        }

        private void btn_starting_update_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
               DataGridViewRow selectedRow= dataGridView1.SelectedRows[0];
                int c_id = int.Parse(selectedRow.Cells[0].Value.ToString());
                string c_name= selectedRow.Cells[1].Value.ToString();
                string c_surname=selectedRow.Cells[2].Value.ToString();
                string c_tel=selectedRow.Cells[3].Value.ToString();
                string c_mail=selectedRow.Cells[4].Value.ToString();

                if (c_tel.StartsWith("0"))
                {
                    c_tel = c_tel.Remove(0, 1);
                    c_tel=c_tel.Replace("(","").Replace(")","").Replace("_","").Replace(" ","");
                }
                try
                {
                    txt_name.Text = c_name;
                    txt_surname.Text = c_surname;
                    txt_mail.Text = c_mail;
                    masked_tel.Text = c_tel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AKTARMA İŞLEMİ SIRASINDA HATA OLUŞTU"+ex.Message);


                    throw;
                }

            }
            else
            {
                MessageBox.Show("LÜTFEN,GÜNCELLEMEK İÇİN BİR KAYIT SEÇİNİZ");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selected_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string c_name=txt_name.Text;
            string c_surname=txt_surname.Text;
            string c_tel=masked_tel.Text;
            string c_mail=txt_mail.Text;
            c_tel = c_tel.Replace("(", "").Replace(")", "").Replace("_", "").Replace(" ", "");
            
            try
            {
                using (SqlConnection connection=new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_update_Table_Member",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@member_id",selected_ID);
                        cmd.Parameters.AddWithValue("@member_name", c_name);
                        cmd.Parameters.AddWithValue("@member_surname", c_surname);
                        cmd.Parameters.AddWithValue("@member_telephone_number", c_tel);
                        cmd.Parameters.AddWithValue("@member_email", c_mail);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("KAYIT BAŞARIYLA GÜNCELLENDİ","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("GÜNCELLEME İŞLEMİ ESNASINDA HATA OLUŞTU" + ex.Message);
                txt_name.Clear();
                txt_surname.Clear();
                txt_mail.Clear();
                masked_tel.Clear();



                throw;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ALEYNA-A\\SQLEXPRESS;Initial Catalog=E-KÜTÜPHANE2;Integrated Security=True");

                int selectedRowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
               
                try
                {
                    //;Trust Server Certificate=true");
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete from Table_Member where member_id=('" + selectedRowId + "') ", baglanti);
                    komut.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("hata" + ex);

                }
                finally
                {
                    if (baglanti != null)
                        baglanti.Close();
                   

                }

            }
        }
    }

    /*


    MessageBox.Show("BU KAYDI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?");
    try
    {
        using (SqlConnection connection=new SqlConnection(connectionString))
        {
            using (SqlCommand cmd=new SqlCommand("sp_delete_Table_Member",connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@member_id",selectedRowId);
                connection.Open();
                cmd.ExecuteNonQuery();

            }

        }

    }
    catch (Exception ex)

    {
        MessageBox.Show("SİLME İŞLEMİ ESNASINDA BİR SORUN OLUŞTU");

        throw;
    }

}
else
{
    MessageBox.Show("LÜTFEN SİLİNECEK BİR KAYIT SEÇİNİZ");
}*/
}
    
