namespace AskesLøg
{
    partial class Form1
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
            this.btn_pedal = new System.Windows.Forms.Button();
            this.label_url = new System.Windows.Forms.LinkLabel();
            this.label_ip = new System.Windows.Forms.LinkLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_threads = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ready = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_dns_ip = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label_threadCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pedal
            // 
            this.btn_pedal.Location = new System.Drawing.Point(432, 58);
            this.btn_pedal.Name = "btn_pedal";
            this.btn_pedal.Size = new System.Drawing.Size(75, 23);
            this.btn_pedal.TabIndex = 0;
            this.btn_pedal.Text = "CHARGE!";
            this.btn_pedal.UseVisualStyleBackColor = true;
            this.btn_pedal.Click += new System.EventHandler(this.btn_pedal_Click);
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(13, 2);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(32, 13);
            this.label_url.TabIndex = 3;
            this.label_url.TabStop = true;
            this.label_url.Text = "URL:";
            this.label_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_url_LinkClicked);
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(12, 45);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(20, 13);
            this.label_ip.TabIndex = 4;
            this.label_ip.TabStop = true;
            this.label_ip.Text = "IP:";
            this.label_ip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_ip_LinkClicked);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 137);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label_threads
            // 
            this.label_threads.AutoSize = true;
            this.label_threads.Location = new System.Drawing.Point(13, 118);
            this.label_threads.Name = "label_threads";
            this.label_threads.Size = new System.Drawing.Size(49, 13);
            this.label_threads.TabIndex = 6;
            this.label_threads.TabStop = true;
            this.label_threads.Text = "Threads:";
            this.label_threads.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_threads_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 64);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text to send:";
            // 
            // btn_ready
            // 
            this.btn_ready.Location = new System.Drawing.Point(433, 18);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(75, 23);
            this.btn_ready.TabIndex = 9;
            this.btn_ready.Text = "Ready?";
            this.btn_ready.UseVisualStyleBackColor = true;
            this.btn_ready.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IP:";
            // 
            // label_dns_ip
            // 
            this.label_dns_ip.AutoSize = true;
            this.label_dns_ip.Location = new System.Drawing.Point(155, 23);
            this.label_dns_ip.Name = "label_dns_ip";
            this.label_dns_ip.Size = new System.Drawing.Size(0, 13);
            this.label_dns_ip.TabIndex = 11;
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(15, 19);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(100, 20);
            this.tb_url.TabIndex = 12;
            this.tb_url.Text = "pikken";
            this.tb_url.TextChanged += new System.EventHandler(this.tb_url_TextChanged);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(15, 62);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 20);
            this.tb_ip.TabIndex = 13;
            this.tb_ip.TextChanged += new System.EventHandler(this.tb_ip_TextChanged);
            // 
            // label_threadCount
            // 
            this.label_threadCount.AutoSize = true;
            this.label_threadCount.Location = new System.Drawing.Point(68, 118);
            this.label_threadCount.Name = "label_threadCount";
            this.label_threadCount.Size = new System.Drawing.Size(0, 13);
            this.label_threadCount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.label_threadCount);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label_dns_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ready);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_threads);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.btn_pedal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pedal;
        private System.Windows.Forms.LinkLabel label_url;
        private System.Windows.Forms.LinkLabel label_ip;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.LinkLabel label_threads;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_dns_ip;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label_threadCount;
    }
}

