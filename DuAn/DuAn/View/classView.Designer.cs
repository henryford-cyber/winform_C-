namespace DuAn.View
{
    partial class classView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classView));
            this.btnReadfile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new Project.Component.RJTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotal2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotal1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvLophoc = new System.Windows.Forms.DataGridView();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeroomTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLophoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadfile
            // 
            this.btnReadfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReadfile.BackColor = System.Drawing.Color.DimGray;
            this.btnReadfile.FlatAppearance.BorderSize = 0;
            this.btnReadfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReadfile.ForeColor = System.Drawing.Color.White;
            this.btnReadfile.Image = ((System.Drawing.Image)(resources.GetObject("btnReadfile.Image")));
            this.btnReadfile.Location = new System.Drawing.Point(931, 386);
            this.btnReadfile.Name = "btnReadfile";
            this.btnReadfile.Size = new System.Drawing.Size(191, 53);
            this.btnReadfile.TabIndex = 5;
            this.btnReadfile.Text = "Read File";
            this.btnReadfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReadfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReadfile.UseVisualStyleBackColor = false;
            this.btnReadfile.Click += new System.EventHandler(this.btnReadfile_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(931, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Edit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.BackColor = System.Drawing.Color.DimGray;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(931, 483);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(191, 53);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(931, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(931, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "  Search";
            this.txtSearch.Size = new System.Drawing.Size(907, 57);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotal2,
            this.lblTotal1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotal2
            // 
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(66, 17);
            this.lblTotal2.Text = "Total class :";
            // 
            // lblTotal1
            // 
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(13, 17);
            this.lblTotal1.Text = "0";
            // 
            // dgvLophoc
            // 
            this.dgvLophoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLophoc.AutoGenerateColumns = false;
            this.dgvLophoc.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvLophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classNameDataGridViewTextBoxColumn,
            this.homeroomTeacherDataGridViewTextBoxColumn,
            this.totalStudentDataGridViewTextBoxColumn});
            this.dgvLophoc.DataSource = this.classBindingSource;
            this.dgvLophoc.Location = new System.Drawing.Point(12, 101);
            this.dgvLophoc.Name = "dgvLophoc";
            this.dgvLophoc.RowTemplate.Height = 25;
            this.dgvLophoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLophoc.Size = new System.Drawing.Size(908, 435);
            this.dgvLophoc.TabIndex = 11;
            this.dgvLophoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLophoc_CellContentClick);
            this.dgvLophoc.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvLophoc_DataError);
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "className";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "Class Name";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // homeroomTeacherDataGridViewTextBoxColumn
            // 
            this.homeroomTeacherDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.homeroomTeacherDataGridViewTextBoxColumn.DataPropertyName = "homeroomTeacher";
            this.homeroomTeacherDataGridViewTextBoxColumn.HeaderText = "Homeroom Teacher";
            this.homeroomTeacherDataGridViewTextBoxColumn.Name = "homeroomTeacherDataGridViewTextBoxColumn";
            // 
            // totalStudentDataGridViewTextBoxColumn
            // 
            this.totalStudentDataGridViewTextBoxColumn.DataPropertyName = "totalStudent";
            this.totalStudentDataGridViewTextBoxColumn.HeaderText = "Total Student";
            this.totalStudentDataGridViewTextBoxColumn.Name = "totalStudentDataGridViewTextBoxColumn";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(DuAn.Model.Class);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(931, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 53);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // classView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvLophoc);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReadfile);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Name = "classView";
            this.Text = "classView";
            this.Load += new System.EventHandler(this.classView_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLophoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnReadfile;
        private Button button4;
        private Button btnExport;
        private Button btnDelete;
        private Button button1;
        private Project.Component.RJTextBox txtSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotal2;
        private ToolStripStatusLabel lblTotal1;
        private DataGridView dgvLophoc;
        private BindingSource classBindingSource;
        private DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn homeroomTeacherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalStudentDataGridViewTextBoxColumn;
        private Button btnSearch;
    }
}