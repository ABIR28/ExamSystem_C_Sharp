using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ExamSystem
{
    public partial class Teacher_LogIn_Form : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        
        //Teacher_LogIn_Form t1 = new Teacher_LogIn_Form();
        public Teacher_LogIn_Form()
        {
            InitializeComponent();
        }
        //public string id { get; set; }
        //public string password { get; set; }
        //static List<Teacher_LogIn_Form> students = new List<Teacher_LogIn_Form>

        //{
        //    new Teacher_LogIn_Form = { id="Admin",password="1234",}
            
        //    }
       // public string conString = "Data Source=DESKTOP-8JL9QSO\\ABIR;Initial Catalog=connection;Integrated Security=True" ;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8JL9QSO\ABIR;Initial Catalog=connection;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From login where id='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                {}
                this.Hide();
                Teacher_Form tf = new Teacher_Form();
                tf.Show();
            }           /*if (dt.Rows[0][0] == "admin")
            {
                this.Hide();
                Teacher_Form tf = new Teacher_Form();
                tf.Show();
            }*/
            else
            {
                MessageBox.Show("Please insert right id and password");
            }
        }
        private void Teacher_LogIn_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forget_Password fp=new Forget_Password();
            fp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
