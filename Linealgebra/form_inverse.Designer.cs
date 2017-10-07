namespace Linealgebra
{
    partial class form_inverse
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
            this.lbl_inverse = new System.Windows.Forms.Label();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.cbox_dimension = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_inverse
            // 
            this.lbl_inverse.AutoSize = true;
            this.lbl_inverse.ForeColor = System.Drawing.Color.Red;
            this.lbl_inverse.Location = new System.Drawing.Point(12, 21);
            this.lbl_inverse.Name = "lbl_inverse";
            this.lbl_inverse.Size = new System.Drawing.Size(36, 17);
            this.lbl_inverse.TabIndex = 0;
            this.lbl_inverse.Text = " A−1";
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_prompt.Location = new System.Drawing.Point(12, 49);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(275, 17);
            this.lbl_prompt.TabIndex = 0;
            this.lbl_prompt.Text = "Please select the dimension of the matrix.";
            // 
            // cbox_dimension
            // 
            this.cbox_dimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbox_dimension.Location = new System.Drawing.Point(15, 82);
            this.cbox_dimension.Name = "cbox_dimension";
            this.cbox_dimension.Size = new System.Drawing.Size(62, 25);
            this.cbox_dimension.TabIndex = 1;
            // 
            // form_inverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 197);
            this.Controls.Add(this.cbox_dimension);
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.lbl_inverse);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_inverse";
            this.Text = "Matrix Inverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inverse;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.ComboBox cbox_dimension;
    }
}