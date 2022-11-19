namespace DuAn.View
{
    partial class CreateStudent
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
            this.txtSex = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddess = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBirtDay = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new DuAn.Component.RJButton();
            this.btnSave = new DuAn.Component.RJButton();
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
            this.CreateForm.Controls.Add(this.txtSex);
            this.CreateForm.Controls.Add(this.cboClass);
            this.CreateForm.Controls.Add(this.label6);
            this.CreateForm.Controls.Add(this.txtAddess);
            this.CreateForm.Controls.Add(this.txtName);
            this.CreateForm.Controls.Add(this.label5);
            this.CreateForm.Controls.Add(this.dtBirtDay);
            this.CreateForm.Controls.Add(this.btnClose);
            this.CreateForm.Controls.Add(this.btnSave);
            this.CreateForm.Controls.Add(this.label4);
            this.CreateForm.Controls.Add(this.label3);
            this.CreateForm.Controls.Add(this.label2);
            this.CreateForm.Controls.Add(this.label1);
            this.CreateForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateForm.ForeColor = System.Drawing.Color.Black;
            this.CreateForm.GradientAngle = 90F;
            this.CreateForm.GradientBottomColor = System.Drawing.Color.MistyRose;
            this.CreateForm.GradientTopColor = System.Drawing.Color.MediumBlue;
            this.CreateForm.Location = new System.Drawing.Point(0, 0);
            this.CreateForm.Name = "CreateForm";
            this.CreateForm.Size = new System.Drawing.Size(544, 688);
            this.CreateForm.TabIndex = 1;
            this.CreateForm.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateForm_Paint);
            this.CreateForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreateForm_MouseDown);
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSex.Location = new System.Drawing.Point(136, 212);
            this.txtSex.Multiline = true;
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(320, 33);
            this.txtSex.TabIndex = 16;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(136, 88);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(165, 23);
            this.cboClass.TabIndex = 15;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Class :";
            // 
            // txtAddess
            // 
            this.txtAddess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddess.Location = new System.Drawing.Point(136, 364);
            this.txtAddess.Multiline = true;
            this.txtAddess.Name = "txtAddess";
            this.txtAddess.Size = new System.Drawing.Size(320, 158);
            this.txtAddess.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(136, 146);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 33);
            this.txtName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address :";
            // 
            // dtBirtDay
            // 
            this.dtBirtDay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBirtDay.Location = new System.Drawing.Point(136, 287);
            this.dtBirtDay.Name = "dtBirtDay";
            this.dtBirtDay.Size = new System.Drawing.Size(320, 33);
            this.dtBirtDay.TabIndex = 9;
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
            this.btnClose.Location = new System.Drawing.Point(322, 602);
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
            this.btnSave.Location = new System.Drawing.Point(87, 602);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "OK";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "BirtDay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Form";
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 688);
            this.Controls.Add(this.CreateForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateStudent";
            this.Text = "CreateStudent";
            this.CreateForm.ResumeLayout(false);
            this.CreateForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.CTPanel CreateForm;
        private Component.RJButton btnClose;
        private Component.RJButton btnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtBirtDay;
        private TextBox txtAddess;
        private TextBox txtName;
        private Label label5;
        private ComboBox cboClass;
        private Label label6;
        private TextBox txtSex;
    }
}