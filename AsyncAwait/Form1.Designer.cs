namespace AsyncAwait
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
            this.clickme = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonStatus1 = new System.Windows.Forms.Button();
            this.buttonStatus2 = new System.Windows.Forms.Button();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickme
            // 
            this.clickme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickme.Location = new System.Drawing.Point(25, 12);
            this.clickme.Name = "clickme";
            this.clickme.Size = new System.Drawing.Size(135, 53);
            this.clickme.TabIndex = 0;
            this.clickme.Text = "Click Me";
            this.clickme.UseVisualStyleBackColor = true;
            this.clickme.Click += new System.EventHandler(this.clickme_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(314, 26);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 24);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "label1";
            // 
            // buttonStatus1
            // 
            this.buttonStatus1.Location = new System.Drawing.Point(25, 98);
            this.buttonStatus1.Name = "buttonStatus1";
            this.buttonStatus1.Size = new System.Drawing.Size(135, 23);
            this.buttonStatus1.TabIndex = 2;
            this.buttonStatus1.Text = "Status 1";
            this.buttonStatus1.UseVisualStyleBackColor = true;
            this.buttonStatus1.Click += new System.EventHandler(this.buttonStatus1_Click);
            // 
            // buttonStatus2
            // 
            this.buttonStatus2.Location = new System.Drawing.Point(25, 138);
            this.buttonStatus2.Name = "buttonStatus2";
            this.buttonStatus2.Size = new System.Drawing.Size(135, 23);
            this.buttonStatus2.TabIndex = 3;
            this.buttonStatus2.Text = "Status2";
            this.buttonStatus2.UseVisualStyleBackColor = true;
            this.buttonStatus2.Click += new System.EventHandler(this.buttonStatus2_Click);
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Location = new System.Drawing.Point(315, 103);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(35, 13);
            this.labelStatus1.TabIndex = 4;
            this.labelStatus1.Text = "label1";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Location = new System.Drawing.Point(315, 143);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(35, 13);
            this.labelStatus2.TabIndex = 5;
            this.labelStatus2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 218);
            this.Controls.Add(this.labelStatus2);
            this.Controls.Add(this.labelStatus1);
            this.Controls.Add(this.buttonStatus2);
            this.Controls.Add(this.buttonStatus1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.clickme);
            this.Name = "Form1";
            this.Text = "Async Await";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickme;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonStatus1;
        private System.Windows.Forms.Button buttonStatus2;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.Label labelStatus2;
    }
}

