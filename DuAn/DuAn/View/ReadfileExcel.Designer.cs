namespace DuAn.View
{
    partial class ReadfileExcel
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
            this.txtPath = new Project.Component.RJTextBox();
            this.btnChoose = new DuAn.Component.RJButton();
            this.ctPanel1 = new DuAn.Component.CTPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ctPanel2 = new DuAn.Component.CTPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctPanel1.SuspendLayout();
            this.ctPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtPath.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPath.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPath.BorderRadius = 20;
            this.txtPath.BorderSize = 2;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPath.ForeColor = System.Drawing.Color.DimGray;
            this.txtPath.Location = new System.Drawing.Point(174, 14);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPath.PasswordChar = false;
            this.txtPath.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPath.PlaceholderText = "";
            this.txtPath.Size = new System.Drawing.Size(570, 40);
            this.txtPath.TabIndex = 0;
            this.txtPath.UnderlinedStyle = false;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChoose.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnChoose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChoose.BorderRadius = 20;
            this.btnChoose.BorderSize = 0;
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(17, 14);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(150, 40);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose FIle";
            this.btnChoose.TextColor = System.Drawing.Color.White;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ctPanel1
            // 
            this.ctPanel1.BackColor = System.Drawing.Color.White;
            this.ctPanel1.BorderRadius = 30;
            this.ctPanel1.Controls.Add(this.label1);
            this.ctPanel1.ForeColor = System.Drawing.Color.Black;
            this.ctPanel1.GradientAngle = 90F;
            this.ctPanel1.GradientBottomColor = System.Drawing.Color.Gray;
            this.ctPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.ctPanel1.Location = new System.Drawing.Point(12, 12);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(759, 69);
            this.ctPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(258, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Read File Excel";
            // 
            // ctPanel2
            // 
            this.ctPanel2.BackColor = System.Drawing.Color.White;
            this.ctPanel2.BorderRadius = 30;
            this.ctPanel2.Controls.Add(this.dataGridView1);
            this.ctPanel2.Controls.Add(this.btnChoose);
            this.ctPanel2.Controls.Add(this.txtPath);
            this.ctPanel2.ForeColor = System.Drawing.Color.Black;
            this.ctPanel2.GradientAngle = 90F;
            this.ctPanel2.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.ctPanel2.GradientTopColor = System.Drawing.Color.White;
            this.ctPanel2.Location = new System.Drawing.Point(12, 87);
            this.ctPanel2.Name = "ctPanel2";
            this.ctPanel2.Size = new System.Drawing.Size(760, 448);
            this.ctPanel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(727, 357);
            this.dataGridView1.TabIndex = 2;
            // 
            // ReadfileExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 547);
            this.Controls.Add(this.ctPanel2);
            this.Controls.Add(this.ctPanel1);
            this.Name = "ReadfileExcel";
            this.Text = "ReadfileExcel";
            this.ctPanel1.ResumeLayout(false);
            this.ctPanel1.PerformLayout();
            this.ctPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Project.Component.RJTextBox txtPath;
        private Component.RJButton btnChoose;
        private Component.CTPanel ctPanel1;
        private Label label1;
        private Component.CTPanel ctPanel2;
        private DataGridView dataGridView1;
    }
}