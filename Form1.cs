using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static String uid = "db";
        public static String password = "1234";
        public static String database = "test_db";
        public static String server = "192.168.0.17";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            Console.WriteLine(text);
            String Constr = "SERVER=" + server + "; DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";";// 위의 선언한 변수 값 적용
            //String Constr = "SERVER=localhost; DATABASE=test; UID=test; PASSWORD=1234;";
            SqlConnection conn = new SqlConnection(Constr); // constr의 값을 conn으로 반환하여 넣어줌 
            conn.Open();

            String sql = $"insert into T1 values('{text}')";//쿼리문 
            SqlCommand cmd = new SqlCommand(sql, conn);//new SqlCommand(쿼리문,연결문(SqlConnection에서 선언한 conn)))
            int sdr = cmd.ExecuteNonQuery();//데이터 읽기

            
            conn.Close();
            
            Form2 f2 = new Form2();
            f2.Show();

        }
    }
}
