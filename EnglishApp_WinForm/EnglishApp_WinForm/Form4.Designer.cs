namespace EnglishApp_WinForm
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lbl_test = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_passed_or_not = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_test.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_test.Image = ((System.Drawing.Image)(resources.GetObject("lbl_test.Image")));
            this.lbl_test.Location = new System.Drawing.Point(131, 130);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(62, 30);
            this.lbl_test.TabIndex = 0;
            this.lbl_test.Text = "Test: ";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_result.Image = ((System.Drawing.Image)(resources.GetObject("lbl_result.Image")));
            this.lbl_result.Location = new System.Drawing.Point(131, 165);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(81, 30);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "Result: ";
            // 
            // lbl_passed_or_not
            // 
            this.lbl_passed_or_not.AutoSize = true;
            this.lbl_passed_or_not.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_passed_or_not.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_passed_or_not.Image = ((System.Drawing.Image)(resources.GetObject("lbl_passed_or_not.Image")));
            this.lbl_passed_or_not.Location = new System.Drawing.Point(131, 202);
            this.lbl_passed_or_not.Name = "lbl_passed_or_not";
            this.lbl_passed_or_not.Size = new System.Drawing.Size(0, 30);
            this.lbl_passed_or_not.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(350, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back to the menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(131, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Work on problems";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_passed_or_not);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_test);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_test;
        private Label lbl_result;
        private Label lbl_passed_or_not;
        private Button button1;
        private Button button2;
    }
}