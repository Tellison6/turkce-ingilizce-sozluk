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

namespace sozluk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server =OZHANTELLIOGLU\\SQLEXPRESS ; initial catalog = dbSozluk; integrated security = sspi");



        private void button1_Click(object sender, EventArgs e)
        {
            string turkce = txtTurkce.Text;
            string ing = txtIng.Text;
            SqlCommand komut = new SqlCommand("insert into kelimeler values ('" + turkce + "','" + ing + "')", con);
            
            con.Open();
            komut.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Yeni Kelime Eklendi", "Kayıt Başarılı");



            txtTurkce.Text = "";
            txtIng.Text = "";




        }
    }
}
