
namespace WindowsFormsApp1
{
    partial class imagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imagesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCheDo = new System.Windows.Forms.ComboBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lnkChonFile = new System.Windows.Forms.LinkLabel();
            this.lnkChonThuMuc = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 610);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnkChonThuMuc);
            this.panel2.Controls.Add(this.lnkChonFile);
            this.panel2.Controls.Add(this.btnLeft);
            this.panel2.Controls.Add(this.btnRight);
            this.panel2.Controls.Add(this.cmbCheDo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 50);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1147, 610);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chế độ:";
            // 
            // cmbCheDo
            // 
            this.cmbCheDo.FormattingEnabled = true;
            this.cmbCheDo.Items.AddRange(new object[] {
            "AutoSize",
            "Stretch",
            "Zoom",
            "Center"});
            this.cmbCheDo.Location = new System.Drawing.Point(63, 15);
            this.cmbCheDo.Name = "cmbCheDo";
            this.cmbCheDo.Size = new System.Drawing.Size(121, 21);
            this.cmbCheDo.TabIndex = 1;
            this.cmbCheDo.SelectedIndexChanged += new System.EventHandler(this.cmbCheDo_SelectedIndexChanged);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(210, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(302, 15);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 21);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lnkChonFile
            // 
            this.lnkChonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkChonFile.AutoSize = true;
            this.lnkChonFile.Location = new System.Drawing.Point(1070, 19);
            this.lnkChonFile.Name = "lnkChonFile";
            this.lnkChonFile.Size = new System.Drawing.Size(49, 13);
            this.lnkChonFile.TabIndex = 4;
            this.lnkChonFile.TabStop = true;
            this.lnkChonFile.Text = "ChonFIle";
            this.lnkChonFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChonFile_LinkClicked);
            // 
            // lnkChonThuMuc
            // 
            this.lnkChonThuMuc.AutoSize = true;
            this.lnkChonThuMuc.Location = new System.Drawing.Point(975, 19);
            this.lnkChonThuMuc.Name = "lnkChonThuMuc";
            this.lnkChonThuMuc.Size = new System.Drawing.Size(78, 13);
            this.lnkChonThuMuc.TabIndex = 5;
            this.lnkChonThuMuc.TabStop = true;
            this.lnkChonThuMuc.Text = "Chon Thu Muc";
            this.lnkChonThuMuc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChonThuMuc_LinkClicked);
            // 
            // imagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "imagesForm";
            this.Text = "imagesForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCheDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.LinkLabel lnkChonFile;
        private System.Windows.Forms.LinkLabel lnkChonThuMuc;
    }
}