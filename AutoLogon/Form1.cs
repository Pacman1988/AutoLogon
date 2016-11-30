using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AutoLogon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_autologon.Checked == true)
            {
                lb_domainname.Visible = true;
                lb_username.Visible = true;
                lb_password.Visible = true;
                lb_passwordcheck.Visible = true;

                tf_domainname.Visible = true;
                tf_username.Visible = true;
                tf_password.Visible = true;
                tf_passwordcheck.Visible = true;
            }
            if (cb_autologon.Checked == false)
            {
                lb_domainname.Visible = false;
                lb_username.Visible = false;
                lb_password.Visible = false;
                lb_passwordcheck.Visible = false;

                tf_domainname.Visible = false;
                tf_username.Visible = false;
                tf_password.Visible = false;
                tf_passwordcheck.Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey basekey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Environment.MachineName, RegistryView.Registry64);
            RegistryKey key = basekey.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true);

            // Keys setzen
            //key.SetValue("AutoAdminLogon", "1");
            //key.SetValue("DefaultDomainName", "test");

            if (cb_autologon.Checked == false)
            {
                MessageBox.Show("Autologon: off");
            }


            if (cb_autologon.Checked == true)
            {
                if (string.IsNullOrEmpty(tf_domainname.Text))
                {
                    MessageBox.Show("Domainname is empty");
                }

                if (string.IsNullOrEmpty(tf_username.Text))
                {
                    MessageBox.Show("Username is empty");
                }

                if (tf_password.Text != tf_passwordcheck.Text)
                {
                    MessageBox.Show("Passwords are'nt the same");

                }
                if (tf_domainname.Text != "" && tf_username.Text != "")
                {
                    MessageBox.Show("Autologon: on" + Environment.NewLine
                        + "Domain: " + tf_domainname.Text + Environment.NewLine
                        + "Username: " + tf_username.Text + Environment.NewLine
                        + "Password: " + tf_password.Text + Environment.NewLine
                        + "Passwordcheck: " + tf_passwordcheck.Text);
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Funktion bauen
            RegistryKey basekey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Environment.MachineName, RegistryView.Registry64);
            RegistryKey key = basekey.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");

            // Autoadminlogon auslesen
            Object reg_autoadminlogon = key.GetValue("AutoAdminLogon");
            var read_autoadminlogon = Convert.ToString(reg_autoadminlogon);
            debug_autologon.Text = (read_autoadminlogon);


            if (read_autoadminlogon == "1")
            {
                cb_autologon.Checked = true;
            }
            else
            {
                cb_autologon.Checked = false;
            }

            // Domainname auslesen
            Object reg_defaultdomainname = key.GetValue("DefaultDomainName");
            var read_defaultdomainname = Convert.ToString(reg_defaultdomainname);
            debug_domainname.Text = (read_defaultdomainname);

            if (read_defaultdomainname != "")
            {
                tf_domainname.Text = read_defaultdomainname;
            }

            // Username auslesen
            Object reg_defaultusername = key.GetValue("DefaultUserName");
            var read_defaultusername = Convert.ToString(reg_defaultusername);
            debug_username.Text = (read_defaultusername);

            if (read_defaultusername != "")
            {
                tf_username.Text = read_defaultusername;
            }

            // DefaultPassword auslesen
            Object reg_defaultpassword = key.GetValue("DefaultPassword");
            var read_defaultpassword = Convert.ToString(reg_defaultpassword);
            debug_password.Text = (read_defaultpassword);

            if (read_defaultpassword != "")
            {
                tf_password.Text = read_defaultpassword;
            }





        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            // Funktion bauen
            RegistryKey basekey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Environment.MachineName, RegistryView.Registry64);
            RegistryKey key = basekey.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");

            // Autoadminlogon auslesen
            Object reg_autoadminlogon = key.GetValue("AutoAdminLogon");
            var read_autoadminlogon = Convert.ToString(reg_autoadminlogon);
            debug_autologon.Text = (read_autoadminlogon);


            if (read_autoadminlogon == "1")
            {
                cb_autologon.Checked = true;
            }
            else
            {
                cb_autologon.Checked = false;
            }

            // Domainname auslesen
            Object reg_defaultdomainname = key.GetValue("DefaultDomainName");
            var read_defaultdomainname = Convert.ToString(reg_defaultdomainname);
            debug_domainname.Text = (read_defaultdomainname);

            if (read_defaultdomainname != "")
            {
                tf_domainname.Text = read_defaultdomainname;
            }

            // Username auslesen
            Object reg_defaultusername = key.GetValue("DefaultUserName");
            var read_defaultusername = Convert.ToString(reg_defaultusername);
            debug_username.Text = (read_defaultusername);

            if (read_defaultusername != "")
            {
                tf_username.Text = read_defaultusername;
            }

            // DefaultPassword auslesen
            Object reg_defaultpassword = key.GetValue("DefaultPassword");
            var read_defaultpassword = Convert.ToString(reg_defaultpassword);
            debug_password.Text = (read_defaultpassword);

            if (read_defaultpassword != "")
            {
                tf_password.Text = read_defaultpassword;
            }
        }
    }
}
