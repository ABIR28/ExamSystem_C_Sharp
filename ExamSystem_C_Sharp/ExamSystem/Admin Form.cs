using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class Teacher_Form : Form
    {
        string conString = "Data Source=DESKTOP-8JL9QSO\\ABIR;Initial Catalog=connection;Integrated Security=True";
        public Teacher_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void Teacher_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
