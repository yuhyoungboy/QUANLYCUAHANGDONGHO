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

namespace Poject_QUANLYCUAHANGDONGHO
{
    
    public partial class Form1 : Form
    {
        string sqlstring = @"Data Source=KE-INIZUKO\SQLEXPRESS;Initial Catalog=QL_CUAHANGDONGHO;Integrated Security=True";
        SqlConnection sqlCon = null;
       
      
        public Form1()
        {

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(sqlstring);


            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                //  MessageBox.Show("Connected Sucessfully");

            }
            InitializeComponent();
        }

        private void btn_FindCus_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;


            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(sqlstring);


            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
                //  MessageBox.Show("Connected Sucessfully");

            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = "FIND_CUS";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idpara = new SqlParameter("@PHONE", SqlDbType.NVarChar);
            idpara.Value = textBox5.Text;

            cmd.Parameters.Add(idpara);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox6.Text = reader.GetString(0) ;
                textBox2.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
            }
            else
            {
                MessageBox.Show("KHÔNG THẤY");
            }

            reader.Close();
            sqlCon.Close();

        }
    }
}
