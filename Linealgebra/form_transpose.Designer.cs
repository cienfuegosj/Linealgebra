namespace Linealgebra
{
    partial class form_transpose
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
            this.lbl_transpose = new System.Windows.Forms.Label();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.lbl_numRows = new System.Windows.Forms.Label();
            this.lbl_numCols = new System.Windows.Forms.Label();
            this.cbox_numRows = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbox_numCols = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_transpose
            // 
            this.lbl_transpose.AutoSize = true;
            this.lbl_transpose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transpose.ForeColor = System.Drawing.Color.Red;
            this.lbl_transpose.Location = new System.Drawing.Point(13, 25);
            this.lbl_transpose.Name = "lbl_transpose";
            this.lbl_transpose.Size = new System.Drawing.Size(61, 17);
            this.lbl_transpose.TabIndex = 0;
            this.lbl_transpose.Text = "trans (A)";
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prompt.Location = new System.Drawing.Point(12, 53);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(280, 17);
            this.lbl_prompt.TabIndex = 0;
            this.lbl_prompt.Text = "Please select the dimensions of the matrix.";
            // 
            // lbl_numRows
            // 
            this.lbl_numRows.AutoSize = true;
            this.lbl_numRows.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numRows.Location = new System.Drawing.Point(13, 86);
            this.lbl_numRows.Name = "lbl_numRows";
            this.lbl_numRows.Size = new System.Drawing.Size(115, 17);
            this.lbl_numRows.TabIndex = 0;
            this.lbl_numRows.Text = "Number of Rows";
            // 
            // lbl_numCols
            // 
            this.lbl_numCols.AutoSize = true;
            this.lbl_numCols.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numCols.Location = new System.Drawing.Point(12, 114);
            this.lbl_numCols.Name = "lbl_numCols";
            this.lbl_numCols.Size = new System.Drawing.Size(138, 17);
            this.lbl_numCols.TabIndex = 0;
            this.lbl_numCols.Text = "Number of Columns";
            // 
            // cbox_numRows
            // 
            this.cbox_numRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numRows.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numRows.FormattingEnabled = true;
            this.cbox_numRows.Items.AddRange(new object[] {
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
            this.cbox_numRows.Location = new System.Drawing.Point(171, 83);
            this.cbox_numRows.Name = "cbox_numRows";
            this.cbox_numRows.Size = new System.Drawing.Size(51, 25);
            this.cbox_numRows.TabIndex = 1;
            // 
            // cbox_numCols
            // 
            this.cbox_numCols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numCols.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numCols.FormattingEnabled = true;
            this.cbox_numCols.Items.AddRange(new object[] {
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
            this.cbox_numCols.Location = new System.Drawing.Point(171, 111);
            this.cbox_numCols.Name = "cbox_numCols";
            this.cbox_numCols.Size = new System.Drawing.Size(51, 25);
            this.cbox_numCols.TabIndex = 1;
            // 
            // form_transpose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 185);
            this.Controls.Add(this.cbox_numCols);
            this.Controls.Add(this.cbox_numRows);
            this.Controls.Add(this.lbl_numCols);
            this.Controls.Add(this.lbl_numRows);
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.lbl_transpose);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_transpose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix Transpose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_transpose;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Label lbl_numRows;
        private System.Windows.Forms.Label lbl_numCols;
        private System.Windows.Forms.ComboBox cbox_numRows;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbox_numCols;
    }
}