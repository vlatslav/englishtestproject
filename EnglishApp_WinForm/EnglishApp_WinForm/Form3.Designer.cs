namespace EnglishApp_WinForm
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonNxt = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.btn_returntomain = new System.Windows.Forms.Button();
            this.timerNext = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 389);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "sss";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Controls.Add(this.buttonA);
            this.flowLayoutPanel1.Controls.Add(this.buttonB);
            this.flowLayoutPanel1.Controls.Add(this.buttonC);
            this.flowLayoutPanel1.Controls.Add(this.buttonD);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 407);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(934, 49);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.White;
            this.buttonA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonA.Location = new System.Drawing.Point(3, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(226, 43);
            this.buttonA.TabIndex = 0;
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(235, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(226, 43);
            this.buttonB.TabIndex = 1;
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(467, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(225, 43);
            this.buttonC.TabIndex = 2;
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(698, 3);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(229, 44);
            this.buttonD.TabIndex = 3;
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonNxt
            // 
            this.buttonNxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.buttonNxt.Enabled = false;
            this.buttonNxt.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonNxt.FlatAppearance.BorderSize = 0;
            this.buttonNxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNxt.Location = new System.Drawing.Point(853, 461);
            this.buttonNxt.Name = "buttonNxt";
            this.buttonNxt.Size = new System.Drawing.Size(94, 29);
            this.buttonNxt.TabIndex = 0;
            this.buttonNxt.Text = ">>";
            this.buttonNxt.UseVisualStyleBackColor = false;
            this.buttonNxt.Click += new System.EventHandler(this.buttonNxt_Click);
            this.buttonNxt.MouseEnter += new System.EventHandler(this.buttonON);
            this.buttonNxt.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.Location = new System.Drawing.Point(11, 461);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonON);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // btn_returntomain
            // 
            this.btn_returntomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.btn_returntomain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_returntomain.Location = new System.Drawing.Point(369, 457);
            this.btn_returntomain.Name = "btn_returntomain";
            this.btn_returntomain.Size = new System.Drawing.Size(214, 37);
            this.btn_returntomain.TabIndex = 4;
            this.btn_returntomain.Text = "Back to the menu";
            this.btn_returntomain.UseVisualStyleBackColor = false;
            this.btn_returntomain.Click += new System.EventHandler(this.btn_returntomainClick);
            this.btn_returntomain.MouseEnter += new System.EventHandler(this.buttonON);
            this.btn_returntomain.MouseLeave += new System.EventHandler(this.buttonOFF);
            // 
            // timerNext
            // 
            this.timerNext.Interval = 1000;
            this.timerNext.Tick += new System.EventHandler(this.timerNext_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(958, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNxt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_returntomain);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private Button buttonNxt;
        private Button buttonBack;
        private Button btn_returntomain;
        private Label label1;
        private System.Windows.Forms.Timer timerNext;
    }
}