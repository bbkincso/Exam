using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;

namespace ABCCollegeRegistration
{
    public partial class Form1 : Form
    {
        readonly int NameMinLength = 2;
        string ConferenceIDRegEx;

        public Form1()
        {
            InitializeComponent();
            ConferenceIDRegEx = ConfigurationManager.AppSettings["ConferenceID"];
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string conferenceID = txtConferenceID.Text;
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string id = txtOrganization.Text;
            string message = "";

            if (!Regex.IsMatch(conferenceID, ConferenceIDRegEx))
            {
                MessageBox.Show("Conference ID is not correct. Registration Failed");
                txtConferenceID.Focus();
            }

            else
            {

                if (firstName.Length< NameMinLength || surname.Length< NameMinLength)
                {
                    
                    if (firstName.Length < NameMinLength && surname.Length < NameMinLength)
                    {
                        message = "Firstname and surname are invalid";
                        txtSurname.Focus();
                    }
                    else if (firstName.Length < NameMinLength)
                    {
                        message = "Firstname is invalid";
                        txtFirstName.Focus();
                    }
                    else
                    {
                        message = "Surname is invalid";
                        txtSurname.Focus();
                    }

                    MessageBox.Show(message);
                }
                else
                {
                    using (Stream stream = File.Open(@"C:\Users\Kancsi\Documents\ABCCollegeRegistration.txt", FileMode.OpenOrCreate))
                    {
                        using (BinaryWriter writer = new BinaryWriter(stream))
                        {
                            try
                            {
                                writer.Write(txtFirstName.Text);
                                writer.Write(txtSurname.Text);
                                writer.Write(txtOrganization.Text);
                                writer.Write(txtConferenceID.Text);
                                MessageBox.Show("Binary file created and written to successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
    }
}
