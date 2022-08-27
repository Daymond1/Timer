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
using System.Threading;
using System.Threading.Tasks;
using System.IO;



namespace timer
{
    public partial class Form1 : Form
    {

        public Thread myThread;
        public Form1()
        {
            InitializeComponent();
           
                      
            string localByName = Path.GetFileName(Properties.Settings.Default.Select_Program);
                  
            button_killprocess.Visible = false;
            thread_task();

            autorun();


        }
        public async Task thread_task()
        {
            myThread = new Thread(new ThreadStart(this.start));
        }
        private void button_conf_Click(object sender, EventArgs e)
        {
            config config = new config();
            config.ShowDialog();
        }

        public async Task func2Async()
        {
            var Token = new TelegramBotClient(Properties.Settings.Default.Telegram_Token);
            var bmsg = await Token.SendTextMessageAsync(Properties.Settings.Default.Telegram_Chat_ID, SystemInformation.ComputerName + " " + Properties.Settings.Default.Telegram_BMSG);        }


        public async void button1_Click(object sender, EventArgs e, object newthread)
        {
            


        }



        public async void start() {

            var Token = new TelegramBotClient(Properties.Settings.Default.Telegram_Token);
            int time = ((Convert.ToInt32(Properties.Settings.Default.Timer_Hour) * 60) + (Convert.ToInt32(Properties.Settings.Default.Timer_Min)) * 60000);
            

                if (time > 0)
                {

                    var hmsg = await Token.SendTextMessageAsync(Properties.Settings.Default.Telegram_Chat_ID, SystemInformation.ComputerName + " " + Properties.Settings.Default.Telegram_HMSG);
                    System.Diagnostics.Process.Start(Properties.Settings.Default.Select_Program);

                     await Task.Delay(time);
                    kill_proces();
                    var bmsg = await Token.SendTextMessageAsync(Properties.Settings.Default.Telegram_Chat_ID, SystemInformation.ComputerName + " " + Properties.Settings.Default.Telegram_BMSG);
                button_start.Text = "Start";
                button_start.Enabled = true;
                button_killprocess.Visible = false;
                button_kill_autorun.Visible = false;
                power_supply();
                }

            if (time == 0)
                {
                    var msg = await Token.SendTextMessageAsync(Properties.Settings.Default.Telegram_Chat_ID, SystemInformation.ComputerName + " " + "I work without a timer");
                    System.Diagnostics.Process.Start(Properties.Settings.Default.Select_Program);
                power_supply();


            }




        }

        async public void button_start_Click(object sender, EventArgs e)
        {
            var Token = new TelegramBotClient(Properties.Settings.Default.Telegram_Token);


            Process[] localByName = Process.GetProcessesByName(Path.GetFileName(Properties.Settings.Default.Select_Program));
            try
            {
                start();
                button_start.Text = "Active";
                button_start.Enabled = false;
                button_killprocess.Visible = true;
            }
            catch
            {
                if (Properties.Settings.Default.Select_Program == null)
                {
                    MessageBox.Show("Huy", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
           
           



        }
        public void kill_proces()
        {

            string localByName = Path.GetFileName(Properties.Settings.Default.Select_Program);

            localByName = localByName.Substring(0, localByName.Length - 4);

            System.Diagnostics.Process[] etc = System.Diagnostics.Process.GetProcesses();//получим процессы
            foreach (System.Diagnostics.Process anti in etc)//обойдем каждый процесс
                if (anti.ProcessName.ToLower().Contains(localByName.ToLower())) anti.Kill();//найдем нужный и убьем

            
           
        }

        private void button_killprocess_Click(object sender, EventArgs e)
        {

           kill_proces();
            button_start.Enabled = true;
            button_killprocess.Visible = false;

        }

        public void autorun()
        {
            if (Properties.Settings.Default.ChekBox_Autorun == true)
            {
                button_start.Text = "Active autorun";
                button_start.Enabled = false;
                button_killprocess.Visible = false;
                button_kill_autorun.Visible = true;
                start();
            }
            else
            {
                button_kill_autorun.Visible = false;

            }

        }
       
   
            
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_kill_autorun_Click(object sender, EventArgs e)
        {
            kill_proces();
            button_start.Text = "Start";
            button_start.Enabled = true;
            button_killprocess.Visible = false;
            button_kill_autorun.Visible = false;

        }

        public void power_supply()
        {

            if (Properties.Settings.Default.CheckBox_Timer == true)
            {
                if (Properties.Settings.Default.CheckBox_PowerOff == true)
                {
                    System.Diagnostics.Process.Start("shutdown.exe", "-s -t -5");
                }
                if (Properties.Settings.Default.CheckBox_Reboot == true)
                {

                    System.Diagnostics.Process.Start("shutdown.exe", "-r -t 5");
                }
                if (Properties.Settings.Default.CheckBox_SleepingM == true)
                {
                    System.Windows.Forms.Application.SetSuspendState(PowerState.Suspend, false, false);

                }
            }

        }
    }
}
