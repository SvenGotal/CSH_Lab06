namespace CSH_Lab06
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
            this.greska1 = new CSH_Lab06.Greska();
            this.bookView1 = new CSH_Lab06.BookView();
            this.login1 = new CSH_Lab06.Login();
            this.SuspendLayout();
            // 
            // greska1
            // 
            this.greska1.Location = new System.Drawing.Point(41, 192);
            this.greska1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.greska1.Name = "greska1";
            this.greska1.Size = new System.Drawing.Size(241, 123);
            this.greska1.TabIndex = 1;
            // 
            // bookView1
            // 
            this.bookView1.Location = new System.Drawing.Point(301, 8);
            this.bookView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.bookView1.Name = "bookView1";
            this.bookView1.Size = new System.Drawing.Size(482, 401);
            this.bookView1.TabIndex = 2;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(8, 8);
            this.login1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(289, 152);
            this.login1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 409);
            this.Controls.Add(this.bookView1);
            this.Controls.Add(this.greska1);
            this.Controls.Add(this.login1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Greska greska1;
        private BookView bookView1;
        private Login login1;
    }
}

