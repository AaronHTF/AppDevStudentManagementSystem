using StudentManagementSystem.StudentDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AddStudentForm : Form
    {
        String firstName;
        String lastName;
        String dateOfBirth;
        String email;
        String phone;
        String street;
        String city;
        String province;
        String postalCode;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            getDataFromTextBoxes();
            this.studentsTableAdapter.InsertStudent(firstName, lastName, dateOfBirth, email, phone, city, postalCode, province, street);
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);
        }

        private void getDataFromTextBoxes()
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            dateOfBirth = dateOfBirthPicker.Value.ToString();
            email = emailTextBox.Text;
            phone = phoneNumberTextBox.Text;
            street = streetTextBox.Text;
            city = cityTextBox.Text;
            province = provinceTextBox.Text;
            postalCode = postalCodeTextBox.Text;
        }
    }
}
