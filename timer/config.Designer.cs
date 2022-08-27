namespace timer
{
    partial class config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.button_save = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.textBox_telegram_token = new System.Windows.Forms.TextBox();
            this.textBox_telegram_chatid = new System.Windows.Forms.TextBox();
            this.textBox_hmsg = new System.Windows.Forms.TextBox();
            this.textBox_bmsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown_Hour = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown_Min = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_select_prog = new System.Windows.Forms.Button();
            this.textBox_select_prog = new System.Windows.Forms.TextBox();
            this.checkBox_turn_on_timer = new System.Windows.Forms.CheckBox();
            this.checkBox_autorun = new System.Windows.Forms.CheckBox();
            this.checkBox_PowerOff = new System.Windows.Forms.CheckBox();
            this.checkBox_Reboot = new System.Windows.Forms.CheckBox();
            this.checkBox_Sleeping = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(152, 202);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 44);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(277, 202);
            this.button_test.Margin = new System.Windows.Forms.Padding(4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(236, 44);
            this.button_test.TabIndex = 1;
            this.button_test.Text = "Test Telegram msg";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // textBox_telegram_token
            // 
            this.textBox_telegram_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_telegram_token.Location = new System.Drawing.Point(152, 23);
            this.textBox_telegram_token.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_telegram_token.MaxLength = 46;
            this.textBox_telegram_token.Multiline = true;
            this.textBox_telegram_token.Name = "textBox_telegram_token";
            this.textBox_telegram_token.PasswordChar = '*';
            this.textBox_telegram_token.Size = new System.Drawing.Size(401, 37);
            this.textBox_telegram_token.TabIndex = 2;
            this.textBox_telegram_token.TextChanged += new System.EventHandler(this.textBox_telegram_token_TextChanged);
            // 
            // textBox_telegram_chatid
            // 
            this.textBox_telegram_chatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_telegram_chatid.Location = new System.Drawing.Point(152, 69);
            this.textBox_telegram_chatid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_telegram_chatid.MaxLength = 9;
            this.textBox_telegram_chatid.Multiline = true;
            this.textBox_telegram_chatid.Name = "textBox_telegram_chatid";
            this.textBox_telegram_chatid.PasswordChar = '*';
            this.textBox_telegram_chatid.Size = new System.Drawing.Size(401, 37);
            this.textBox_telegram_chatid.TabIndex = 3;
            // 
            // textBox_hmsg
            // 
            this.textBox_hmsg.Location = new System.Drawing.Point(152, 114);
            this.textBox_hmsg.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hmsg.Multiline = true;
            this.textBox_hmsg.Name = "textBox_hmsg";
            this.textBox_hmsg.Size = new System.Drawing.Size(401, 37);
            this.textBox_hmsg.TabIndex = 4;
            // 
            // textBox_bmsg
            // 
            this.textBox_bmsg.Location = new System.Drawing.Point(152, 160);
            this.textBox_bmsg.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_bmsg.Multiline = true;
            this.textBox_bmsg.Name = "textBox_bmsg";
            this.textBox_bmsg.Size = new System.Drawing.Size(401, 34);
            this.textBox_bmsg.TabIndex = 5;
            this.textBox_bmsg.TextChanged += new System.EventHandler(this.textBox_bmsg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telegram Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telegram Chat ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hello MSG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "By MSG";
            // 
            // domainUpDown_Hour
            // 
            this.domainUpDown_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown_Hour.Items.Add("0");
            this.domainUpDown_Hour.Items.Add("1");
            this.domainUpDown_Hour.Items.Add("2");
            this.domainUpDown_Hour.Items.Add("3");
            this.domainUpDown_Hour.Items.Add("4");
            this.domainUpDown_Hour.Items.Add("5");
            this.domainUpDown_Hour.Items.Add("6");
            this.domainUpDown_Hour.Items.Add("7");
            this.domainUpDown_Hour.Items.Add("8");
            this.domainUpDown_Hour.Items.Add("9");
            this.domainUpDown_Hour.Items.Add("10");
            this.domainUpDown_Hour.Items.Add("11");
            this.domainUpDown_Hour.Items.Add("12");
            this.domainUpDown_Hour.Items.Add("13");
            this.domainUpDown_Hour.Items.Add("14");
            this.domainUpDown_Hour.Items.Add("15");
            this.domainUpDown_Hour.Items.Add("16");
            this.domainUpDown_Hour.Items.Add("17");
            this.domainUpDown_Hour.Items.Add("18");
            this.domainUpDown_Hour.Items.Add("19");
            this.domainUpDown_Hour.Items.Add("20");
            this.domainUpDown_Hour.Items.Add("21");
            this.domainUpDown_Hour.Items.Add("22");
            this.domainUpDown_Hour.Items.Add("23");
            this.domainUpDown_Hour.Items.Add("24");
            this.domainUpDown_Hour.Location = new System.Drawing.Point(315, 292);
            this.domainUpDown_Hour.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown_Hour.Name = "domainUpDown_Hour";
            this.domainUpDown_Hour.ReadOnly = true;
            this.domainUpDown_Hour.Size = new System.Drawing.Size(73, 31);
            this.domainUpDown_Hour.TabIndex = 10;
            this.domainUpDown_Hour.Text = "0";
            this.domainUpDown_Hour.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // domainUpDown_Min
            // 
            this.domainUpDown_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDown_Min.Items.Add("0");
            this.domainUpDown_Min.Items.Add("1");
            this.domainUpDown_Min.Items.Add("2");
            this.domainUpDown_Min.Items.Add("3");
            this.domainUpDown_Min.Items.Add("4");
            this.domainUpDown_Min.Items.Add("5");
            this.domainUpDown_Min.Items.Add("6");
            this.domainUpDown_Min.Items.Add("7");
            this.domainUpDown_Min.Items.Add("8");
            this.domainUpDown_Min.Items.Add("9");
            this.domainUpDown_Min.Items.Add("10");
            this.domainUpDown_Min.Items.Add("11");
            this.domainUpDown_Min.Items.Add("12");
            this.domainUpDown_Min.Items.Add("13");
            this.domainUpDown_Min.Items.Add("14");
            this.domainUpDown_Min.Items.Add("15");
            this.domainUpDown_Min.Items.Add("16");
            this.domainUpDown_Min.Items.Add("17");
            this.domainUpDown_Min.Items.Add("18");
            this.domainUpDown_Min.Items.Add("19");
            this.domainUpDown_Min.Items.Add("20");
            this.domainUpDown_Min.Items.Add("21");
            this.domainUpDown_Min.Items.Add("22");
            this.domainUpDown_Min.Items.Add("23");
            this.domainUpDown_Min.Items.Add("24");
            this.domainUpDown_Min.Items.Add("25");
            this.domainUpDown_Min.Items.Add("26");
            this.domainUpDown_Min.Items.Add("27");
            this.domainUpDown_Min.Items.Add("28");
            this.domainUpDown_Min.Items.Add("29");
            this.domainUpDown_Min.Items.Add("30");
            this.domainUpDown_Min.Items.Add("31");
            this.domainUpDown_Min.Items.Add("32");
            this.domainUpDown_Min.Items.Add("33");
            this.domainUpDown_Min.Items.Add("34");
            this.domainUpDown_Min.Items.Add("35");
            this.domainUpDown_Min.Items.Add("36");
            this.domainUpDown_Min.Items.Add("37");
            this.domainUpDown_Min.Items.Add("38");
            this.domainUpDown_Min.Items.Add("39");
            this.domainUpDown_Min.Items.Add("40");
            this.domainUpDown_Min.Items.Add("41");
            this.domainUpDown_Min.Items.Add("42");
            this.domainUpDown_Min.Items.Add("43");
            this.domainUpDown_Min.Items.Add("44");
            this.domainUpDown_Min.Items.Add("45");
            this.domainUpDown_Min.Items.Add("46");
            this.domainUpDown_Min.Items.Add("47");
            this.domainUpDown_Min.Items.Add("48");
            this.domainUpDown_Min.Items.Add("49");
            this.domainUpDown_Min.Items.Add("50");
            this.domainUpDown_Min.Items.Add("51");
            this.domainUpDown_Min.Items.Add("52");
            this.domainUpDown_Min.Items.Add("53");
            this.domainUpDown_Min.Items.Add("54");
            this.domainUpDown_Min.Items.Add("55");
            this.domainUpDown_Min.Items.Add("56");
            this.domainUpDown_Min.Items.Add("57");
            this.domainUpDown_Min.Items.Add("58");
            this.domainUpDown_Min.Items.Add("59");
            this.domainUpDown_Min.Items.Add("60");
            this.domainUpDown_Min.Location = new System.Drawing.Point(396, 292);
            this.domainUpDown_Min.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown_Min.Name = "domainUpDown_Min";
            this.domainUpDown_Min.ReadOnly = true;
            this.domainUpDown_Min.Size = new System.Drawing.Size(72, 31);
            this.domainUpDown_Min.TabIndex = 11;
            this.domainUpDown_Min.Text = "0";
            this.domainUpDown_Min.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hour";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Min";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_select_prog
            // 
            this.button_select_prog.Location = new System.Drawing.Point(16, 379);
            this.button_select_prog.Margin = new System.Windows.Forms.Padding(4);
            this.button_select_prog.Name = "button_select_prog";
            this.button_select_prog.Size = new System.Drawing.Size(145, 28);
            this.button_select_prog.TabIndex = 14;
            this.button_select_prog.Text = "Select program";
            this.button_select_prog.UseVisualStyleBackColor = true;
            this.button_select_prog.Click += new System.EventHandler(this.button_select_prog_Click);
            // 
            // textBox_select_prog
            // 
            this.textBox_select_prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_select_prog.Location = new System.Drawing.Point(169, 368);
            this.textBox_select_prog.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_select_prog.Multiline = true;
            this.textBox_select_prog.Name = "textBox_select_prog";
            this.textBox_select_prog.Size = new System.Drawing.Size(384, 50);
            this.textBox_select_prog.TabIndex = 15;
            // 
            // checkBox_turn_on_timer
            // 
            this.checkBox_turn_on_timer.AutoSize = true;
            this.checkBox_turn_on_timer.Location = new System.Drawing.Point(20, 255);
            this.checkBox_turn_on_timer.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_turn_on_timer.Name = "checkBox_turn_on_timer";
            this.checkBox_turn_on_timer.Size = new System.Drawing.Size(151, 20);
            this.checkBox_turn_on_timer.TabIndex = 16;
            this.checkBox_turn_on_timer.Text = "Turn off the timer task";
            this.checkBox_turn_on_timer.UseVisualStyleBackColor = true;
            this.checkBox_turn_on_timer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_autorun
            // 
            this.checkBox_autorun.AutoSize = true;
            this.checkBox_autorun.Location = new System.Drawing.Point(20, 215);
            this.checkBox_autorun.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_autorun.Name = "checkBox_autorun";
            this.checkBox_autorun.Size = new System.Drawing.Size(71, 20);
            this.checkBox_autorun.TabIndex = 17;
            this.checkBox_autorun.Text = "Autorun";
            this.checkBox_autorun.UseVisualStyleBackColor = false;
            this.checkBox_autorun.CheckedChanged += new System.EventHandler(this.checkBox_autorun_CheckedChanged);
            // 
            // checkBox_PowerOff
            // 
            this.checkBox_PowerOff.AutoSize = true;
            this.checkBox_PowerOff.Location = new System.Drawing.Point(20, 292);
            this.checkBox_PowerOff.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_PowerOff.Name = "checkBox_PowerOff";
            this.checkBox_PowerOff.Size = new System.Drawing.Size(104, 20);
            this.checkBox_PowerOff.TabIndex = 18;
            this.checkBox_PowerOff.Text = "Power Off PC";
            this.checkBox_PowerOff.UseVisualStyleBackColor = true;
            // 
            // checkBox_Reboot
            // 
            this.checkBox_Reboot.AutoSize = true;
            this.checkBox_Reboot.Location = new System.Drawing.Point(20, 320);
            this.checkBox_Reboot.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Reboot.Name = "checkBox_Reboot";
            this.checkBox_Reboot.Size = new System.Drawing.Size(92, 20);
            this.checkBox_Reboot.TabIndex = 19;
            this.checkBox_Reboot.Text = "Reboot PC";
            this.checkBox_Reboot.UseVisualStyleBackColor = true;
            // 
            // checkBox_Sleeping
            // 
            this.checkBox_Sleeping.AutoSize = true;
            this.checkBox_Sleeping.Location = new System.Drawing.Point(20, 348);
            this.checkBox_Sleeping.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Sleeping.Name = "checkBox_Sleeping";
            this.checkBox_Sleeping.Size = new System.Drawing.Size(118, 20);
            this.checkBox_Sleeping.TabIndex = 20;
            this.checkBox_Sleeping.Text = "Sleeping mode";
            this.checkBox_Sleeping.UseVisualStyleBackColor = true;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 421);
            this.Controls.Add(this.checkBox_Sleeping);
            this.Controls.Add(this.checkBox_Reboot);
            this.Controls.Add(this.checkBox_PowerOff);
            this.Controls.Add(this.checkBox_autorun);
            this.Controls.Add(this.checkBox_turn_on_timer);
            this.Controls.Add(this.textBox_select_prog);
            this.Controls.Add(this.button_select_prog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.domainUpDown_Min);
            this.Controls.Add(this.domainUpDown_Hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_bmsg);
            this.Controls.Add(this.textBox_hmsg);
            this.Controls.Add(this.textBox_telegram_chatid);
            this.Controls.Add(this.textBox_telegram_token);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(587, 460);
            this.MinimumSize = new System.Drawing.Size(587, 460);
            this.Name = "config";
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.TextBox textBox_telegram_token;
        private System.Windows.Forms.TextBox textBox_telegram_chatid;
        private System.Windows.Forms.TextBox textBox_hmsg;
        private System.Windows.Forms.TextBox textBox_bmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown_Hour;
        private System.Windows.Forms.DomainUpDown domainUpDown_Min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_select_prog;
        private System.Windows.Forms.TextBox textBox_select_prog;
        private System.Windows.Forms.CheckBox checkBox_turn_on_timer;
        private System.Windows.Forms.CheckBox checkBox_autorun;
        private System.Windows.Forms.CheckBox checkBox_PowerOff;
        private System.Windows.Forms.CheckBox checkBox_Reboot;
        private System.Windows.Forms.CheckBox checkBox_Sleeping;
    }
}