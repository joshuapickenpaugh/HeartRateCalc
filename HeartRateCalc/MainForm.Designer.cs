namespace HeartRateCalc
{
    partial class MainForm
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblDisplayOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(12, 25);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 0;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(118, 25);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 1;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(224, 25);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(96, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalc.Location = new System.Drawing.Point(12, 158);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 29);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblDisplayOutput
            // 
            this.lblDisplayOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayOutput.Location = new System.Drawing.Point(12, 48);
            this.lblDisplayOutput.Name = "lblDisplayOutput";
            this.lblDisplayOutput.Size = new System.Drawing.Size(308, 107);
            this.lblDisplayOutput.TabIndex = 5;
            this.lblDisplayOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Year of birth:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(220, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 199);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplayOutput);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Name = "MainForm";
            this.Text = "Heart Rate Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblDisplayOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

