
namespace timer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_start = new System.Windows.Forms.Button();
            this.button_conf = new System.Windows.Forms.Button();
            this.button_killprocess = new System.Windows.Forms.Button();
            this.button_kill_autorun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.button_start.Location = new System.Drawing.Point(16, 15);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(285, 112);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_conf
            // 
            this.button_conf.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_conf.Location = new System.Drawing.Point(16, 166);
            this.button_conf.Margin = new System.Windows.Forms.Padding(4);
            this.button_conf.Name = "button_conf";
            this.button_conf.Size = new System.Drawing.Size(285, 108);
            this.button_conf.TabIndex = 1;
            this.button_conf.Text = "Settings";
            this.button_conf.UseVisualStyleBackColor = true;
            this.button_conf.Click += new System.EventHandler(this.button_conf_Click);
            // 
            // button_killprocess
            // 
            this.button_killprocess.Location = new System.Drawing.Point(59, 85);
            this.button_killprocess.Margin = new System.Windows.Forms.Padding(4);
            this.button_killprocess.Name = "button_killprocess";
            this.button_killprocess.Size = new System.Drawing.Size(196, 30);
            this.button_killprocess.TabIndex = 2;
            this.button_killprocess.Text = "Kill Process";
            this.button_killprocess.UseVisualStyleBackColor = true;
            this.button_killprocess.Visible = false;
            this.button_killprocess.Click += new System.EventHandler(this.button_killprocess_Click);
            // 
            // button_kill_autorun
            // 
            this.button_kill_autorun.Location = new System.Drawing.Point(59, 86);
            this.button_kill_autorun.Margin = new System.Windows.Forms.Padding(4);
            this.button_kill_autorun.Name = "button_kill_autorun";
            this.button_kill_autorun.Size = new System.Drawing.Size(196, 28);
            this.button_kill_autorun.TabIndex = 3;
            this.button_kill_autorun.Text = "kill autorun process";
            this.button_kill_autorun.UseVisualStyleBackColor = true;
            this.button_kill_autorun.Click += new System.EventHandler(this.button_kill_autorun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 295);
            this.Controls.Add(this.button_kill_autorun);
            this.Controls.Add(this.button_killprocess);
            this.Controls.Add(this.button_conf);
            this.Controls.Add(this.button_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(336, 334);
            this.MinimumSize = new System.Drawing.Size(336, 334);
            this.Name = "Form1";
            this.Text = "Timer Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_conf;
        private System.Windows.Forms.Button button_killprocess;
        private System.Windows.Forms.Button button_kill_autorun;
    }
}

