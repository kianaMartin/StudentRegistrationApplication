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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName, firstName, middleName;
            string gender = "";
            string programApply = comboBox4.Text;
            string day = comboBox1.Text;
            string month = comboBox2.Text;
            string year = comboBox3.Text;
            lastName = textBox1.Text;
            firstName = textBox2.Text;
            middleName = textBox3.Text;

        
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            if (firstName != null && middleName != null && lastName != null && (radioButton1.Checked || radioButton2.Checked) && day != "-Day-" && month != "-Month-" && year != "-Year-" && programApply != null)
            {
                stInfo(firstName, middleName, lastName, gender, day, month, year, programApply);

            }
            else if (firstName != null && middleName == " " && lastName != null && !radioButton1.Checked && !radioButton2.Checked && day == "-Day-" && month == "-Month-" && year == "-Year-" && programApply != null)
            {
                stInfo(firstName, lastName, programApply);
            }
            else if (firstName != null && middleName != null && lastName != null && !radioButton1.Checked && !radioButton2.Checked && day == "-Day-" && month == "-Month-" && year == "-Year-" && programApply != null)
            {
                stInfo(firstName, middleName, lastName, programApply);
            }
        }
        private void stInfo(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string programApply)
        {
            MessageBox.Show("Student Name: " + lastName + " " + firstName + " " + middleName + "\n" + "Gender: " + gender + "\nProgram: " + programApply + "\n" +
                "Date of birth: " + day + " / " + month + " / " + year);
        }
        private void stInfo(string firstName, string middleName, string lastName, string programApply)
        {
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " + lastName + "\n" +
                "Program: " + programApply);
        }
        private void stInfo(string firstName, string lastName, string programApply)
        {
            MessageBox.Show("Student name: " + firstName + " " + lastName + "\n" +
                "Program: " + programApply);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }
        private void DisplayStudentInfo(string message)
        {
            MessageBox.Show(message, "Student Information");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Profiles";
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}

      
