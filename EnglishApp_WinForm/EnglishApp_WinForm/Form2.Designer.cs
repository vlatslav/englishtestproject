namespace EnglishApp_WinForm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_click = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 412);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(345, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 126);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Location = new System.Drawing.Point(416, 268);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(297, 53);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "Start Test";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            this.btn_submit.MouseEnter += new System.EventHandler(this.btn_submit_MouseOn);
            this.btn_submit.MouseLeave += new System.EventHandler(this.btn_submit_MouseOFF);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 382);
            this.panel1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(0, 304);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 76);
            this.button5.TabIndex = 9;
            this.button5.Text = "Button1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            this.button5.MouseEnter += new System.EventHandler(this.buttonON);
            this.button5.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(0, 228);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 76);
            this.button4.TabIndex = 8;
            this.button4.Text = "Button1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseEnter += new System.EventHandler(this.buttonON);
            this.button4.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 152);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 76);
            this.button3.TabIndex = 6;
            this.button3.Text = "Button1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseEnter += new System.EventHandler(this.buttonON);
            this.button3.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Button1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseEnter += new System.EventHandler(this.buttonON);
            this.button2.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseEnter += new System.EventHandler(this.buttonON);
            this.button1.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // pnl_click
            // 
            this.pnl_click.BackColor = System.Drawing.Color.Transparent;
            this.pnl_click.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_click.Location = new System.Drawing.Point(274, 8);
            this.pnl_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_click.Name = "pnl_click";
            this.pnl_click.Size = new System.Drawing.Size(6, 45);
            this.pnl_click.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 413);
            this.Controls.Add(this.pnl_click);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_submit;
        private Panel panel1;
        private Button button1;
        private Panel pnl_click;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
    }
}