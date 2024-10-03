using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            

            //오라클 연결
            String conInfo = "Data Source=192.168.0.4:1521; User Id=C##test; Password=1234";
            OracleConnection con = new OracleConnection(conInfo);
            con.Open();

            //slq 실행 준비
                  
            String sql = "insert into test values(:str)";

            OracleCommand cmd = new OracleCommand(sql,con);

            cmd.Parameters.Add(new OracleParameter("str",text));



            //sql 실행
            //cmd.ExecuteNonQuery(); -> select 이 외
            //cmd.ExecuteReader -> select 일때
            int odr = cmd.ExecuteNonQuery();

            con.Close();
     

            Form2 f2 = new Form2();
            f2.Show();
            


                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
