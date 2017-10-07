namespace Linealgebra
{
    partial class form_determinant
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
            this.lbl_deta = new System.Windows.Forms.Label();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.cbox_dimension = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_deta
            // 
            this.lbl_deta.AutoSize = true;
            this.lbl_deta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deta.ForeColor = System.Drawing.Color.Red;
            this.lbl_deta.Location = new System.Drawing.Point(22, 20);
            this.lbl_deta.Name = "lbl_deta";
            this.lbl_deta.Size = new System.Drawing.Size(52, 17);
            this.lbl_deta.TabIndex = 0;
            this.lbl_deta.Text = "det (A)";
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prompt.Location = new System.Drawing.Point(22, 56);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(275, 17);
            this.lbl_prompt.TabIndex = 1;
            this.lbl_prompt.Text = "Please select the dimension of the matrix.";
            // 
            // cbox_dimension
            // 
            this.cbox_dimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_dimension.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_dimension.FormattingEnabled = true;
            this.cbox_dimension.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbox_dimension.Location = new System.Drawing.Point(25, 84);
            this.cbox_dimension.Name = "cbox_dimension";
            this.cbox_dimension.Size = new System.Drawing.Size(62, 24);
            this.cbox_dimension.TabIndex = 2;
            // 
            // form_determinant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 185);
            this.Controls.Add(this.cbox_dimension);
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.lbl_deta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_determinant";
            this.Text = "Matrix Determinant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_deta;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.ComboBox cbox_dimension;
    }
}