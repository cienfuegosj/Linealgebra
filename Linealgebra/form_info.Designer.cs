namespace Linealgebra
{
    partial class form_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_info));
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_github = new System.Windows.Forms.Label();
            this.linklbl_github = new System.Windows.Forms.LinkLabel();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_website = new System.Windows.Forms.Label();
            this.linklbl_website = new System.Windows.Forms.LinkLabel();
            this.lbl_license = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(64, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(182, 166);
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // lbl_github
            // 
            this.lbl_github.AutoSize = true;
            this.lbl_github.Location = new System.Drawing.Point(50, 204);
            this.lbl_github.Name = "lbl_github";
            this.lbl_github.Size = new System.Drawing.Size(48, 13);
            this.lbl_github.TabIndex = 1;
            this.lbl_github.Text = "Github:";
            // 
            // linklbl_github
            // 
            this.linklbl_github.AutoSize = true;
            this.linklbl_github.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linklbl_github.Location = new System.Drawing.Point(105, 204);
            this.linklbl_github.Name = "linklbl_github";
            this.linklbl_github.Size = new System.Drawing.Size(171, 13);
            this.linklbl_github.TabIndex = 2;
            this.linklbl_github.TabStop = true;
            this.linklbl_github.Text = "www.github.com/cienfuegosj";
            this.linklbl_github.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(50, 226);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(179, 13);
            this.lbl_author.TabIndex = 3;
            this.lbl_author.Text = "Author:   Javier Cienfuegos Jr.";
            // 
            // lbl_website
            // 
            this.lbl_website.AutoSize = true;
            this.lbl_website.Location = new System.Drawing.Point(50, 250);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(57, 13);
            this.lbl_website.TabIndex = 3;
            this.lbl_website.Text = "Website:";
            // 
            // linklbl_website
            // 
            this.linklbl_website.AutoSize = true;
            this.linklbl_website.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linklbl_website.Location = new System.Drawing.Point(105, 250);
            this.linklbl_website.Name = "linklbl_website";
            this.linklbl_website.Size = new System.Drawing.Size(86, 13);
            this.linklbl_website.TabIndex = 4;
            this.linklbl_website.TabStop = true;
            this.linklbl_website.Text = "cienfuegosj.io";
            this.linklbl_website.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // lbl_license
            // 
            this.lbl_license.AutoSize = true;
            this.lbl_license.Location = new System.Drawing.Point(50, 272);
            this.lbl_license.Name = "lbl_license";
            this.lbl_license.Size = new System.Drawing.Size(129, 13);
            this.lbl_license.TabIndex = 3;
            this.lbl_license.Text = "License: MIT License";
            // 
            // form_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 339);
            this.Controls.Add(this.linklbl_website);
            this.Controls.Add(this.lbl_license);
            this.Controls.Add(this.lbl_website);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.linklbl_github);
            this.Controls.Add(this.lbl_github);
            this.Controls.Add(this.pic_logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linealgebra Info";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_github;
        private System.Windows.Forms.LinkLabel linklbl_github;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_website;
        private System.Windows.Forms.LinkLabel linklbl_website;
        private System.Windows.Forms.Label lbl_license;
    }
}