namespace Linealgebra
{
    partial class form_multiplication
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
            this.lbl_multiplication = new System.Windows.Forms.Label();
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.lbl_numRowsB = new System.Windows.Forms.Label();
            this.lbl_numColsB = new System.Windows.Forms.Label();
            this.lbl_numRowsA = new System.Windows.Forms.Label();
            this.lbl_numColsA = new System.Windows.Forms.Label();
            this.cbox_numRowsA = new System.Windows.Forms.ComboBox();
            this.cbox_numColsA = new System.Windows.Forms.ComboBox();
            this.cbox_numRowsB = new System.Windows.Forms.ComboBox();
            this.cbox_numColsB = new System.Windows.Forms.ComboBox();
            this.pnl_A = new System.Windows.Forms.Panel();
            this.lbl_A = new System.Windows.Forms.Label();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.lbl_B = new System.Windows.Forms.Label();
            this.pnl_A.SuspendLayout();
            this.pnl_B.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_multiplication
            // 
            this.lbl_multiplication.AutoSize = true;
            this.lbl_multiplication.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multiplication.ForeColor = System.Drawing.Color.Red;
            this.lbl_multiplication.Location = new System.Drawing.Point(11, 22);
            this.lbl_multiplication.Name = "lbl_multiplication";
            this.lbl_multiplication.Size = new System.Drawing.Size(40, 17);
            this.lbl_multiplication.TabIndex = 0;
            this.lbl_multiplication.Text = "A • B";
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prompt.Location = new System.Drawing.Point(11, 52);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(295, 17);
            this.lbl_prompt.TabIndex = 0;
            this.lbl_prompt.Text = "Please select the dimensions of the matrices.";
            // 
            // lbl_numRowsB
            // 
            this.lbl_numRowsB.AutoSize = true;
            this.lbl_numRowsB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numRowsB.Location = new System.Drawing.Point(10, 42);
            this.lbl_numRowsB.Name = "lbl_numRowsB";
            this.lbl_numRowsB.Size = new System.Drawing.Size(115, 17);
            this.lbl_numRowsB.TabIndex = 0;
            this.lbl_numRowsB.Text = "Number of Rows";
            // 
            // lbl_numColsB
            // 
            this.lbl_numColsB.AutoSize = true;
            this.lbl_numColsB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numColsB.Location = new System.Drawing.Point(10, 75);
            this.lbl_numColsB.Name = "lbl_numColsB";
            this.lbl_numColsB.Size = new System.Drawing.Size(138, 17);
            this.lbl_numColsB.TabIndex = 0;
            this.lbl_numColsB.Text = "Number of Columns";
            // 
            // lbl_numRowsA
            // 
            this.lbl_numRowsA.AutoSize = true;
            this.lbl_numRowsA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numRowsA.Location = new System.Drawing.Point(18, 42);
            this.lbl_numRowsA.Name = "lbl_numRowsA";
            this.lbl_numRowsA.Size = new System.Drawing.Size(115, 17);
            this.lbl_numRowsA.TabIndex = 0;
            this.lbl_numRowsA.Text = "Number of Rows";
            // 
            // lbl_numColsA
            // 
            this.lbl_numColsA.AutoSize = true;
            this.lbl_numColsA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numColsA.Location = new System.Drawing.Point(18, 75);
            this.lbl_numColsA.Name = "lbl_numColsA";
            this.lbl_numColsA.Size = new System.Drawing.Size(138, 17);
            this.lbl_numColsA.TabIndex = 0;
            this.lbl_numColsA.Text = "Number of Columns";
            // 
            // cbox_numRowsA
            // 
            this.cbox_numRowsA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numRowsA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numRowsA.FormattingEnabled = true;
            this.cbox_numRowsA.Items.AddRange(new object[] {
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
            this.cbox_numRowsA.Location = new System.Drawing.Point(160, 39);
            this.cbox_numRowsA.Name = "cbox_numRowsA";
            this.cbox_numRowsA.Size = new System.Drawing.Size(54, 25);
            this.cbox_numRowsA.TabIndex = 1;
            // 
            // cbox_numColsA
            // 
            this.cbox_numColsA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numColsA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numColsA.FormattingEnabled = true;
            this.cbox_numColsA.Items.AddRange(new object[] {
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
            this.cbox_numColsA.Location = new System.Drawing.Point(160, 72);
            this.cbox_numColsA.Name = "cbox_numColsA";
            this.cbox_numColsA.Size = new System.Drawing.Size(54, 25);
            this.cbox_numColsA.TabIndex = 1;
            // 
            // cbox_numRowsB
            // 
            this.cbox_numRowsB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numRowsB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numRowsB.FormattingEnabled = true;
            this.cbox_numRowsB.Items.AddRange(new object[] {
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
            this.cbox_numRowsB.Location = new System.Drawing.Point(152, 39);
            this.cbox_numRowsB.Name = "cbox_numRowsB";
            this.cbox_numRowsB.Size = new System.Drawing.Size(54, 25);
            this.cbox_numRowsB.TabIndex = 1;
            // 
            // cbox_numColsB
            // 
            this.cbox_numColsB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_numColsB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_numColsB.FormattingEnabled = true;
            this.cbox_numColsB.Items.AddRange(new object[] {
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
            this.cbox_numColsB.Location = new System.Drawing.Point(152, 72);
            this.cbox_numColsB.Name = "cbox_numColsB";
            this.cbox_numColsB.Size = new System.Drawing.Size(54, 25);
            this.cbox_numColsB.TabIndex = 1;
            // 
            // pnl_A
            // 
            this.pnl_A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_A.Controls.Add(this.lbl_A);
            this.pnl_A.Controls.Add(this.lbl_numRowsA);
            this.pnl_A.Controls.Add(this.lbl_numColsA);
            this.pnl_A.Controls.Add(this.cbox_numColsA);
            this.pnl_A.Controls.Add(this.cbox_numRowsA);
            this.pnl_A.Location = new System.Drawing.Point(15, 91);
            this.pnl_A.Name = "pnl_A";
            this.pnl_A.Size = new System.Drawing.Size(221, 110);
            this.pnl_A.TabIndex = 2;
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_A.Location = new System.Drawing.Point(77, 4);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(59, 17);
            this.lbl_A.TabIndex = 2;
            this.lbl_A.Text = "Matrix A";
            // 
            // pnl_B
            // 
            this.pnl_B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_B.Controls.Add(this.lbl_B);
            this.pnl_B.Controls.Add(this.lbl_numRowsB);
            this.pnl_B.Controls.Add(this.lbl_numColsB);
            this.pnl_B.Controls.Add(this.cbox_numColsB);
            this.pnl_B.Controls.Add(this.cbox_numRowsB);
            this.pnl_B.Location = new System.Drawing.Point(262, 91);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Size = new System.Drawing.Size(221, 110);
            this.pnl_B.TabIndex = 2;
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_B.Location = new System.Drawing.Point(72, 4);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(57, 17);
            this.lbl_B.TabIndex = 2;
            this.lbl_B.Text = "Matrix B";
            // 
            // form_multiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 230);
            this.Controls.Add(this.pnl_B);
            this.Controls.Add(this.pnl_A);
            this.Controls.Add(this.lbl_prompt);
            this.Controls.Add(this.lbl_multiplication);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "form_multiplication";
            this.Text = "Matrix Multiplication";
            this.pnl_A.ResumeLayout(false);
            this.pnl_A.PerformLayout();
            this.pnl_B.ResumeLayout(false);
            this.pnl_B.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_multiplication;
        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.Label lbl_numRowsB;
        private System.Windows.Forms.Label lbl_numColsB;
        private System.Windows.Forms.Label lbl_numRowsA;
        private System.Windows.Forms.Label lbl_numColsA;
        private System.Windows.Forms.ComboBox cbox_numRowsA;
        private System.Windows.Forms.ComboBox cbox_numColsA;
        private System.Windows.Forms.ComboBox cbox_numRowsB;
        private System.Windows.Forms.ComboBox cbox_numColsB;
        private System.Windows.Forms.Panel pnl_A;
        private System.Windows.Forms.Panel pnl_B;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
    }
}