namespace test1
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.BackColor = System.Drawing.SystemColors.Info;
            this.lblSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSoA.Location = new System.Drawing.Point(47, 67);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(147, 41);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Nhap A :";
            this.lblSoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoB
            // 
            this.lblSoB.BackColor = System.Drawing.SystemColors.Info;
            this.lblSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSoB.Location = new System.Drawing.Point(47, 148);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(147, 41);
            this.lblSoB.TabIndex = 0;
            this.lblSoB.Text = "Nhap B :";
            this.lblSoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(242, 67);
            this.txtSoA.Multiline = true;
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(228, 41);
            this.txtSoA.TabIndex = 0;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(242, 148);
            this.txtSoB.Multiline = true;
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(228, 41);
            this.txtSoB.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Location = new System.Drawing.Point(570, 67);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(177, 122);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSum.Location = new System.Drawing.Point(52, 258);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(122, 55);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnReset.Location = new System.Drawing.Point(143, 351);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 55);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSub.Location = new System.Drawing.Point(232, 258);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(122, 55);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label lblResult;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSub;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

