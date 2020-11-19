namespace Doctor
{
    partial class Email
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxFrom = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxTo = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxSubject = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxBody = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "To :  ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject :  ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body :  ";
            // 
            // TextBoxFrom
            // 
            this.TextBoxFrom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxFrom.Location = new System.Drawing.Point(287, 99);
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(152, 23);
            this.TextBoxFrom.TabIndex = 4;
            this.TextBoxFrom.Click += new System.EventHandler(this.TextBoxFrom_Click);
            // 
            // TextBoxTo
            // 
            this.TextBoxTo.Location = new System.Drawing.Point(287, 154);
            this.TextBoxTo.Name = "TextBoxTo";
            this.TextBoxTo.Size = new System.Drawing.Size(152, 23);
            this.TextBoxTo.TabIndex = 5;
            this.TextBoxTo.Click += new System.EventHandler(this.TextBoxTo_Click);
            // 
            // TextBoxSubject
            // 
            this.TextBoxSubject.Location = new System.Drawing.Point(287, 202);
            this.TextBoxSubject.Name = "TextBoxSubject";
            this.TextBoxSubject.Size = new System.Drawing.Size(210, 23);
            this.TextBoxSubject.TabIndex = 6;
            // 
            // TextBoxBody
            // 
            this.TextBoxBody.Location = new System.Drawing.Point(287, 280);
            this.TextBoxBody.Name = "TextBoxBody";
            this.TextBoxBody.Size = new System.Drawing.Size(297, 140);
            this.TextBoxBody.TabIndex = 7;
            this.TextBoxBody.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 39);
            this.label5.TabIndex = 8;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(322, 436);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(212, 50);
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Text = "Send Email ";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(96, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(651, 54);
            this.label6.TabIndex = 28;
            this.label6.Text = "                                Compose Mail";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 526);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxBody);
            this.Controls.Add(this.TextBoxSubject);
            this.Controls.Add(this.TextBoxTo);
            this.Controls.Add(this.TextBoxFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox TextBoxFrom;
        private MetroFramework.Controls.MetroTextBox TextBoxTo;
        private MetroFramework.Controls.MetroTextBox TextBoxSubject;
        private System.Windows.Forms.RichTextBox TextBoxBody;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label6;
    }
}