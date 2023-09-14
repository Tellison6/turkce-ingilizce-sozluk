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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server =OZHANTELLIOGLU\\SQLEXPRESS ; initial catalog = dbSozluk; integrated security = sspi");

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Kelimeler ", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;


            radioButton1.Checked = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Kelimeler where turkce like '" + textBox1.Text + "%' ", con);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;


                
            }
            else if (radioButton2.Checked)
            {
                SqlCommand komut = new SqlCommand("select * from Kelimeler where ingilizce like '" + textBox1.Text + "%' ", con);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;


                
            }

        }
    }
}
