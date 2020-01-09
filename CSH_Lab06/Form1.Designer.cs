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
            this.greska1.Location = new System.Drawing.Point(62, 295);
            this.greska1.Name = "greska1";
            this.greska1.Size = new System.Drawing.Size(361, 189);
            this.greska1.TabIndex = 1;
            // 
            // bookView1
            // 
            this.bookView1.Location = new System.Drawing.Point(452, 12);
            this.bookView1.Name = "bookView1";
            this.bookView1.Size = new System.Drawing.Size(723, 617);
            this.bookView1.TabIndex = 2;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(12, 12);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(434, 234);
            this.login1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 630);
            this.Controls.Add(this.bookView1);
            this.Controls.Add(this.greska1);
            this.Controls.Add(this.login1);
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

