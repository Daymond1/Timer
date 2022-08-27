using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;




namespace timer
{
    public partial class config : Form
    {
        public config()
        {

            InitializeComponent();
            
            textBox_telegram_token.Text = Properties.Settings.Default.Telegram_Token.ToString();
            textBox_telegram_chatid.Text = Properties.Settings.Default.Telegram_Chat_ID.ToString();
            textBox_hmsg.Text = Properties.Settings.Default.Telegram_HMSG.ToString();
            textBox_bmsg.Text = Properties.Settings.Default.Telegram_BMSG.ToString();
            domainUpDown_Hour.Text = Properties.Settings.Default.Timer_Hour.ToString();
            domainUpDown_Min.Text = Properties.Settings.Default.Timer_Min.ToString();
            textBox_select_prog.Text = Properties.Settings.Default.Select_Program.ToString();
            checkBox_turn_on_timer.Checked = Properties.Settings.Default.CheckBox_Timer;
            checkBox_autorun.Checked = Properties.Settings.Default.ChekBox_Autorun;
            checkBox_PowerOff.Checked = Properties.Settings.Default.CheckBox_PowerOff;
            checkBox_Reboot.Checked = Properties.Settings.Default.CheckBox_Reboot;
            checkBox_Sleeping.Checked = Properties.Settings.Default.CheckBox_SleepingM;
            Properties.Settings.Default.Save();

        }

        private void config_Load(object sender, EventArgs e)
        {
          
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Telegram_Token = textBox_telegram_token.Text;
            Properties.Settings.Default.Telegram_Chat_ID = textBox_telegram_chatid.Text;
            Properties.Settings.Default.Telegram_HMSG = textBox_hmsg.Text;
            Properties.Settings.Default.Telegram_BMSG = textBox_bmsg.Text;
            Properties.Settings.Default.Timer_Hour = domainUpDown_Hour.Text;
            Properties.Settings.Default.Timer_Min = domainUpDown_Min.Text;
            Properties.Settings.Default.Select_Program = textBox_select_prog.Text;
            Properties.Settings.Default.CheckBox_Timer = checkBox_turn_on_timer.Checked;
            Properties.Settings.Default.ChekBox_Autorun = checkBox_autorun.Checked;
            Properties.Settings.Default.CheckBox_PowerOff = checkBox_PowerOff.Checked;
            Properties.Settings.Default.CheckBox_Reboot = checkBox_Reboot.Checked;
            Properties.Settings.Default.CheckBox_SleepingM = checkBox_Sleeping.Checked;

            Properties.Settings.Default.Save();
            MessageBox.Show("Save", "Test", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private async void button_test_Click(object sender, EventArgs e)
        {
            var Token = new TelegramBotClient(textBox_telegram_token.Text);
            try
            {
                var msg = await Token.SendTextMessageAsync(textBox_telegram_chatid.Text, SystemInformation.ComputerName + " Say: test message");
                MessageBox.Show("SEND", "TEST MSG", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                
                if (textBox_telegram_token.TextLength != 46 || textBox_telegram_chatid.TextLength != 9)
                {
                    MessageBox.Show("Opps...something wrong...\nCheck the correctness of the entered data.\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
            }


        }

        private void textBox_bmsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_select_prog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Executable files (*.exe, *.bat)|*.exe;*.bat";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                textBox_select_prog.Text = Path.GetDirectoryName(openFileDialog1.FileName) + @"\" + Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox_turn_on_timer.Checked == true)
            {
                
                domainUpDown_Hour.Enabled = true;
                domainUpDown_Min.Enabled = true;
                checkBox_PowerOff.Enabled = true;
                checkBox_Reboot.Enabled = true;
                checkBox_Sleeping.Enabled = true;
            }
            else
            {
                domainUpDown_Hour.Enabled = false;
                domainUpDown_Min.Enabled = false;
                checkBox_PowerOff.Enabled = false;
                checkBox_Reboot.Enabled = false;
                checkBox_Sleeping.Enabled = false;
                domainUpDown_Hour.Text = "0";
                domainUpDown_Min.Text = "0";
            }
        }




        private void checkBox_autorun_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_autorun.Checked == true)
            {
            
                const string appName = "testik";
                const string regPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
                using (RegistryKey registryKeyStartup = Registry.LocalMachine.OpenSubKey(regPath, true))
                {
                    registryKeyStartup.SetValue(
                        appName, string.Format("\"{0}\"", System.Reflection.Assembly.GetExecutingAssembly().Location));
                }
            }
            else
            {
                const string appName = "testik";
                const string regPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

                using (RegistryKey registryKeyStartup = Registry.LocalMachine.OpenSubKey(regPath, true))
                {
                    registryKeyStartup.DeleteValue(appName, false);
                }
            }
        }

        private void textBox_telegram_token_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
