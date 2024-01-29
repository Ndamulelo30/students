using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.RemoveCurrent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentsDataSet.tbStudents' table. You can move, or remove it, as needed.
            this.tbStudentsTableAdapter.Fill(this.dbStudentsDataSet.tbStudents);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.EndEdit();
            tbStudentsTableAdapter.Update(dbStudentsDataSet.tbStudents);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource.MovePrevious();
        }
    }
}
