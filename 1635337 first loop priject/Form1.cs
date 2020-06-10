using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1635337_first_loop_priject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = "Mo";
            string mypassword = "12345";

            int attempt = 1;
            int maxattempts = 3;

            public Form1()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void BtnLogin_Click(object sender, EventArgs e)
            {

                while (attempt <= maxattempts)
                {
                    if (TxtUser.Text != username)



                }

                else
                {  // username is correct
                    // so check password
                    if (TxtPassword.Text != "12345")
                    {
                        attempt++;
                        // incorrect password attempt++;
                        Message

                { // username is incorrect
                            MessageBox.Show("invalid username," + (maxattempts - attempt) +
                                "attempts remaining");
                            TxtUser.Clear();

                            attempt++;
                            return;
                            Box.Show("incorrect password" + (maxattempts - attempt) +
                                                        "attempts remaining");
                            TxtPassword.Clear();

                            return;
                        }

                    else


                        {
                            // both are correct
                            attempt = 0; // reset the number of attempts
                            MessageBox.Show("Login Successfull");
                            BtnLogin.Text =
                                "Logout";


                        }
                    }
                }
            }
