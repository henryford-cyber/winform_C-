namespace DuAn.View
{
    partial class CreateClass
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
            this.CreateForm = new DuAn.Component.CTPanel();
            this.btnClose = new DuAn.Component.RJButton();
            this.btnSave = new DuAn.Component.RJButton();
            this.txtTeacher = new Project.Component.RJTextBox();
            this.txtTotal = new Project.Component.RJTextBox();
            this.txtClassName = new Project.Component.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateForm
            // 
            this.CreateForm.BackColor = System.Drawing.Color.Transparent;
            this.CreateForm.BorderRadius = 0;
            this.CreateForm.Controls.Add(this.btnClose);
            this.CreateForm.Controls.Add(this.btnSave);
            this.CreateForm.Controls.Add(this.txtTeacher);
            this.CreateForm.Controls.Add(this.txtTotal);
            this.CreateForm.Controls.Add(this.txtClassName);
            this.CreateForm.Controls.Add(this.label4);
            this.CreateForm.Controls.Add(this.label3);
            this.CreateForm.Controls.Add(this.label2);
            this.CreateForm.Controls.Add(this.label1);
            this.CreateForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateForm.ForeColor = System.Drawing.Color.Black;
            this.CreateForm.GradientAngle = 90F;
            this.CreateForm.GradientBottomColor = System.Drawing.Color.MistyRose;
            this.CreateForm.GradientTopColor = System.Drawing.Color.Teal;
            this.CreateForm.Location = new System.Drawing.Point(0, 0);
            this.CreateForm.Name = "CreateForm";
            this.CreateForm.Size = new System.Drawing.Size(482, 621);
            this.CreateForm.TabIndex = 0;
            this.CreateForm.Paint += new System.Windows.Forms.PaintEventHandler(this.ctPanel1_Paint);
            this.CreateForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctPanel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 40;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(248, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cancel";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 40;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(64, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "OK";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTeacher
            // 
            this.txtTeacher.BackColor = System.Drawing.SystemColors.Window;
            this.txtTeacher.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTeacher.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTeacher.BorderRadius = 10;
            this.txtTeacher.BorderSize = 2;
            this.txtTeacher.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTeacher.ForeColor = System.Drawing.Color.DimGray;
            this.txtTeacher.Location = new System.Drawing.Point(188, 236);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeacher.Multiline = true;
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTeacher.PasswordChar = false;
            this.txtTeacher.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTeacher.PlaceholderText = "";
            this.txtTeacher.Size = new System.Drawing.Size(238, 44);
            this.txtTeacher.TabIndex = 6;
            this.txtTeacher.UnderlinedStyle = false;
            this.txtTeacher._TextChanged += new System.EventHandler(this.txtTeacher__TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotal.BorderRadius = 10;
            this.txtTotal.BorderSize = 2;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotal.Location = new System.Drawing.Point(188, 331);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.Size = new System.Drawing.Size(238, 44);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.UnderlinedStyle = false;
            this.txtTotal._TextChanged += new System.EventHandler(this.txtTotal__TextChanged);
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.SystemColors.Window;
            this.txtClassName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtClassName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtClassName.BorderRadius = 10;
            this.txtClassName.BorderSize = 2;
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClassName.ForeColor = System.Drawing.Color.DimGray;
            this.txtClassName.Location = new System.Drawing.Point(188, 140);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtClassName.PasswordChar = false;
            this.txtClassName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClassName.PlaceholderText = "";
            this.txtClassName.Size = new System.Drawing.Size(238, 44);
            this.txtClassName.TabIndex = 4;
            this.txtClassName.UnderlinedStyle = false;
            this.txtClassName._TextChanged += new System.EventHandler(this.txtClassName__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Student:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 621);
            this.Controls.Add(this.CreateForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateClass";
            this.CreateForm.ResumeLayout(false);
            this.CreateForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.CTPanel CreateForm;
        private Label label1;
        private Component.RJButton btnSave;
        private Project.Component.RJTextBox txtTeacher;
        private Project.Component.RJTextBox txtTotal;
        private Project.Component.RJTextBox txtClassName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Component.RJButton btnClose;
    }
}