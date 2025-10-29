using System;
using System.IO;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "BS in Information Technology", "BS in Computer Science", "BS in Business Administration", "BS in Hospitality Management" });
            comboBox2.Items.AddRange(new string[] { "Male", "Female" });

            btnRegister.Click += btnRegister_Click;
            btnRecords.Click += btnRecords_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = textBox1.Text;
            string lastName = textBox2.Text;
            string age = textBox3.Text;
            string program = comboBox1.Text;
            string firstName = textBox4.Text;
            string middleInitial = textBox5.Text;
            string gender = comboBox2.Text;
            string contactNo = textBox6.Text;
            string birthday = dateTimePicker1.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(studentNo))
            {
                MessageBox.Show("Please enter a Student Number before registering.", "Warning");
                return;
            }

            string[] registrationInfo =
            {
                "Student No: " + studentNo,
                "Last Name: " + lastName,
                "First Name: " + firstName,
                "Middle Initial: " + middleInitial,
                "Age: " + age,
                "Birthday: " + birthday,
                "Gender: " + gender,
                "Program: " + program,
                "Contact Number: " + contactNo
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, studentNo + ".txt")))
            {
                foreach (string info in registrationInfo)
                {
                    outputFile.WriteLine(info);
                }
            }

            MessageBox.Show("Registration successfully saved as " + studentNo + ".txt", "Success");
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord recordForm = new FrmStudentRecord();
            recordForm.Show();
            this.Hide();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
