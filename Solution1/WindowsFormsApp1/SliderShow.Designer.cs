
namespace WindowsFormsApp1
{
    partial class SliderShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SliderShow));
            this.lnkChonThuMuc = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picImages = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkChonThuMuc
            // 
            this.lnkChonThuMuc.AutoSize = true;
            this.lnkChonThuMuc.Location = new System.Drawing.Point(12, 22);
            this.lnkChonThuMuc.Name = "lnkChonThuMuc";
            this.lnkChonThuMuc.Size = new System.Drawing.Size(78, 13);
            this.lnkChonThuMuc.TabIndex = 0;
            this.lnkChonThuMuc.TabStop = true;
            this.lnkChonThuMuc.Text = "Chon Thu Muc";
            this.lnkChonThuMuc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChonThuMuc_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 631);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel1_PreviewKeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1216, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(197, 631);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.MouseHover += new System.EventHandler(this.flowLayoutPanel1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picImages);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1213, 628);
            this.panel3.TabIndex = 1;
            // 
            // picImages
            // 
            this.picImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImages.Location = new System.Drawing.Point(0, 0);
            this.picImages.Name = "picImages";
            this.picImages.Size = new System.Drawing.Size(1213, 628);
            this.picImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImages.TabIndex = 0;
            this.picImages.TabStop = false;
            this.picImages.Click += new System.EventHandler(this.picImages_Click);
            this.picImages.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.picImages_PreviewKeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.lnkChonThuMuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 646);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1421, 58);
            this.panel2.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(639, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(54, 51);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(561, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 49);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SliderShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SliderShow";
            this.Text = "SliderShow";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkChonThuMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picImages;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
    }
}