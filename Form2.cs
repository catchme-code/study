using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace C_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       


        private void Form2_Load_1(object sender, EventArgs e)
        {
            //오라클 연결
            String conInfo = "Data Source=192.168.0.4:1521; User Id=C##test; Password=1234";
            OracleConnection con = new OracleConnection(conInfo);
            con.Open();


            String sql = "select * from test";

            OracleCommand cmd = new OracleCommand(sql, con);


            OracleDataReader odr = cmd.ExecuteReader();
            while (odr.Read()) {
                listBox2.Items.Add(odr.GetString(0));
            }

            con.Close();

           
        }
    }
}
