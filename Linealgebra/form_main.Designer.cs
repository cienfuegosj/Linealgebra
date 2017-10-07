namespace Linealgebra
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.btn_determinant = new System.Windows.Forms.Button();
            this.btn_gauss = new System.Windows.Forms.Button();
            this.btn_inverse = new System.Windows.Forms.Button();
            this.btn_transpose = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_addsub = new System.Windows.Forms.Button();
            this.btn_power = new System.Windows.Forms.Button();
            this.btn_eigenvectors = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.lbl_author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_determinant
            // 
            this.btn_determinant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_determinant.Location = new System.Drawing.Point(24, 21);
            this.btn_determinant.Name = "btn_determinant";
            this.btn_determinant.Size = new System.Drawing.Size(129, 54);
            this.btn_determinant.TabIndex = 0;
            this.btn_determinant.Text = "Determinant";
            this.btn_determinant.UseVisualStyleBackColor = true;
            this.btn_determinant.Click += new System.EventHandler(this.btn_determinant_Click);
            // 
            // btn_gauss
            // 
            this.btn_gauss.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gauss.Location = new System.Drawing.Point(24, 99);
            this.btn_gauss.Name = "btn_gauss";
            this.btn_gauss.Size = new System.Drawing.Size(129, 54);
            this.btn_gauss.TabIndex = 0;
            this.btn_gauss.Text = "Gauss-Jordan Elimination";
            this.btn_gauss.UseVisualStyleBackColor = true;
            this.btn_gauss.Click += new System.EventHandler(this.btn_gauss_Click);
            // 
            // btn_inverse
            // 
            this.btn_inverse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inverse.Location = new System.Drawing.Point(24, 181);
            this.btn_inverse.Name = "btn_inverse";
            this.btn_inverse.Size = new System.Drawing.Size(129, 54);
            this.btn_inverse.TabIndex = 0;
            this.btn_inverse.Text = "Inverse Matrix";
            this.btn_inverse.UseVisualStyleBackColor = true;
            this.btn_inverse.Click += new System.EventHandler(this.btn_inverse_Click);
            // 
            // btn_transpose
            // 
            this.btn_transpose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transpose.Location = new System.Drawing.Point(196, 21);
            this.btn_transpose.Name = "btn_transpose";
            this.btn_transpose.Size = new System.Drawing.Size(129, 54);
            this.btn_transpose.TabIndex = 0;
            this.btn_transpose.Text = "Matrix Transpose";
            this.btn_transpose.UseVisualStyleBackColor = true;
            this.btn_transpose.Click += new System.EventHandler(this.btn_transpose_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplication.Location = new System.Drawing.Point(196, 99);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(129, 54);
            this.btn_multiplication.TabIndex = 0;
            this.btn_multiplication.Text = "Matrix Multiplication";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_addsub
            // 
            this.btn_addsub.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsub.Location = new System.Drawing.Point(196, 181);
            this.btn_addsub.Name = "btn_addsub";
            this.btn_addsub.Size = new System.Drawing.Size(129, 54);
            this.btn_addsub.TabIndex = 0;
            this.btn_addsub.Text = "Matrix Addition / Subtraction";
            this.btn_addsub.UseVisualStyleBackColor = true;
            this.btn_addsub.Click += new System.EventHandler(this.btn_addsub_Click);
            // 
            // btn_power
            // 
            this.btn_power.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_power.Location = new System.Drawing.Point(358, 21);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(129, 54);
            this.btn_power.TabIndex = 0;
            this.btn_power.Text = "Matrix Power";
            this.btn_power.UseVisualStyleBackColor = true;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // btn_eigenvectors
            // 
            this.btn_eigenvectors.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eigenvectors.Location = new System.Drawing.Point(358, 99);
            this.btn_eigenvectors.Name = "btn_eigenvectors";
            this.btn_eigenvectors.Size = new System.Drawing.Size(129, 54);
            this.btn_eigenvectors.TabIndex = 0;
            this.btn_eigenvectors.Text = "Eigenvectors";
            this.btn_eigenvectors.UseVisualStyleBackColor = true;
            this.btn_eigenvectors.Click += new System.EventHandler(this.btn_eigenvectors_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Location = new System.Drawing.Point(358, 181);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(129, 54);
            this.btn_info.TabIndex = 0;
            this.btn_info.Text = "Info...";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_author.Location = new System.Drawing.Point(193, 261);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(157, 15);
            this.lbl_author.TabIndex = 1;
            this.lbl_author.Text = "Author: Javier Cienfuegos Jr";
            // 
            // form_main
            // 
            this.ClientSize = new System.Drawing.Size(513, 295);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.btn_inverse);
            this.Controls.Add(this.btn_gauss);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_addsub);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_eigenvectors);
            this.Controls.Add(this.btn_power);
            this.Controls.Add(this.btn_transpose);
            this.Controls.Add(this.btn_determinant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.Text = "Linealgebra";
            this.Load += new System.EventHandler(this.form_main_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_determinant;
        private System.Windows.Forms.Button btn_gauss;
        private System.Windows.Forms.Button btn_inverse;
        private System.Windows.Forms.Button btn_transpose;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_addsub;
        private System.Windows.Forms.Button btn_power;
        private System.Windows.Forms.Button btn_eigenvectors;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Label lbl_author;
    }
}

