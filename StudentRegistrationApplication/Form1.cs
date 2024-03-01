using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
       
    {
        public Form1()
        {
           
            InitializeComponent();
            string[] array = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i);
            }
            
            foreach (string month in array)
            {
                comboBox2.Items.Add(month);
            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Bachelor of Science in Computer Science");
            arrayList.Add("Bachelor of Science in Information Technology");
            arrayList.Add("Bachelor of Science in Information Systems");
            arrayList.Add("Bachelor of Science in Computer Engineering");

            foreach (string prog in arrayList)
            {
                comboBox4.Items.Add(prog);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName, lastName, middleName;
            string gender = "";
         
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            middleName = textBox3.Text;
            if (radioButton1.Checked)
            {
               gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            MessageBox.Show("Student name: " + firstName + " " +"\n"+ "Gender: " + gender+ " " + "\n" + "Date of birth: " 
                + comboBox1.Text + "/" + comboBox2.Text + "/"+ comboBox3.Text + "\nProgram: "+ comboBox4.Text);   
        }
    }
}
