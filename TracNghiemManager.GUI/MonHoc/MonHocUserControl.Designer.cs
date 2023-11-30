﻿using System.Drawing;
using System.Windows.Forms;

namespace TracNghiemManager.GUI.MonHoc
{
    partial class MonHocUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocUserControl));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.headingPanel = new System.Windows.Forms.TableLayoutPanel();
			this.containerBtnPanel = new System.Windows.Forms.TableLayoutPanel();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnXuatFile = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.containerTimKiemPanel = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.headingPanel.SuspendLayout();
			this.containerBtnPanel.SuspendLayout();
			this.containerTimKiemPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
			this.mainPanel.ColumnCount = 1;
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.mainPanel.Controls.Add(this.headingPanel, 0, 0);
			this.mainPanel.Controls.Add(this.dataGridView1, 0, 1);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.RowCount = 2;
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.87899F));
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.12101F));
			this.mainPanel.Size = new System.Drawing.Size(1573, 826);
			this.mainPanel.TabIndex = 0;
			// 
			// headingPanel
			// 
			this.headingPanel.BackColor = System.Drawing.Color.White;
			this.headingPanel.ColumnCount = 1;
			this.headingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.headingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.headingPanel.Controls.Add(this.containerBtnPanel, 0, 0);
			this.headingPanel.Controls.Add(this.containerTimKiemPanel, 0, 1);
			this.headingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.headingPanel.Location = new System.Drawing.Point(11, 9);
			this.headingPanel.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.headingPanel.Name = "headingPanel";
			this.headingPanel.RowCount = 2;
			this.headingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.23404F));
			this.headingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.76596F));
			this.headingPanel.Size = new System.Drawing.Size(1551, 187);
			this.headingPanel.TabIndex = 0;
			// 
			// containerBtnPanel
			// 
			this.containerBtnPanel.ColumnCount = 4;
			this.containerBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
			this.containerBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
			this.containerBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
			this.containerBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
			this.containerBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.containerBtnPanel.Controls.Add(this.btnLamMoi, 3, 0);
			this.containerBtnPanel.Controls.Add(this.btnXuatFile, 2, 0);
			this.containerBtnPanel.Controls.Add(this.btnSua, 1, 0);
			this.containerBtnPanel.Controls.Add(this.btnThem, 0, 0);
			this.containerBtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.containerBtnPanel.Location = new System.Drawing.Point(0, 0);
			this.containerBtnPanel.Margin = new System.Windows.Forms.Padding(0);
			this.containerBtnPanel.Name = "containerBtnPanel";
			this.containerBtnPanel.RowCount = 1;
			this.containerBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this.containerBtnPanel.Size = new System.Drawing.Size(1551, 125);
			this.containerBtnPanel.TabIndex = 0;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.BackColor = System.Drawing.Color.White;
			this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLamMoi.FlatAppearance.BorderSize = 0;
			this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnLamMoi.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
			this.btnLamMoi.Location = new System.Drawing.Point(1127, 0);
			this.btnLamMoi.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(421, 128);
			this.btnLamMoi.TabIndex = 5;
			this.btnLamMoi.Text = "LÀM MỚI";
			this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnLamMoi.UseVisualStyleBackColor = false;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnXuatFile
			// 
			this.btnXuatFile.BackColor = System.Drawing.Color.White;
			this.btnXuatFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnXuatFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnXuatFile.FlatAppearance.BorderSize = 0;
			this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXuatFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnXuatFile.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
			this.btnXuatFile.Location = new System.Drawing.Point(704, 0);
			this.btnXuatFile.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.btnXuatFile.Name = "btnXuatFile";
			this.btnXuatFile.Size = new System.Drawing.Size(420, 128);
			this.btnXuatFile.TabIndex = 3;
			this.btnXuatFile.Text = "XUẤT FILE";
			this.btnXuatFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnXuatFile.UseVisualStyleBackColor = false;
			this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.White;
			this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSua.FlatAppearance.BorderSize = 0;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnSua.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
			this.btnSua.Location = new System.Drawing.Point(352, 0);
			this.btnSua.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(349, 128);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "SỬA";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.White;
			this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnThem.ForeColor = System.Drawing.Color.SteelBlue;
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.Location = new System.Drawing.Point(0, 0);
			this.btnThem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(349, 128);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "THÊM";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// containerTimKiemPanel
			// 
			this.containerTimKiemPanel.ColumnCount = 2;
			this.containerTimKiemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.94598F));
			this.containerTimKiemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.05401F));
			this.containerTimKiemPanel.Controls.Add(this.textBoxTimKiem, 0, 0);
			this.containerTimKiemPanel.Controls.Add(this.btnTimKiem, 1, 0);
			this.containerTimKiemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.containerTimKiemPanel.Location = new System.Drawing.Point(0, 131);
			this.containerTimKiemPanel.Margin = new System.Windows.Forms.Padding(0, 6, 23, 6);
			this.containerTimKiemPanel.Name = "containerTimKiemPanel";
			this.containerTimKiemPanel.RowCount = 1;
			this.containerTimKiemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.containerTimKiemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.containerTimKiemPanel.Size = new System.Drawing.Size(1528, 50);
			this.containerTimKiemPanel.TabIndex = 1;
			// 
			// textBoxTimKiem
			// 
			this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.textBoxTimKiem.Location = new System.Drawing.Point(20, 1);
			this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(20, 1, 29, 0);
			this.textBoxTimKiem.Name = "textBoxTimKiem";
			this.textBoxTimKiem.Size = new System.Drawing.Size(1232, 43);
			this.textBoxTimKiem.TabIndex = 0;
			this.textBoxTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimKiem_KeyPress);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.Color.White;
			this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnTimKiem.Location = new System.Drawing.Point(1282, 0);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(246, 50);
			this.btnTimKiem.TabIndex = 1;
			this.btnTimKiem.Text = " TÌM KIẾM";
			this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 50;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(11, 221);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(11, 16, 11, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(1551, 589);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.Color.SteelBlue;
			this.button2.Location = new System.Drawing.Point(5, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.button2.Size = new System.Drawing.Size(173, 155);
			this.button2.TabIndex = 2;
			this.button2.Text = "THÊM";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// MonHocUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MonHocUserControl";
			this.Size = new System.Drawing.Size(1573, 826);
			this.mainPanel.ResumeLayout(false);
			this.headingPanel.ResumeLayout(false);
			this.containerBtnPanel.ResumeLayout(false);
			this.containerTimKiemPanel.ResumeLayout(false);
			this.containerTimKiemPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainPanel;
        private Button button2;
        private TableLayoutPanel headingPanel;
        private TableLayoutPanel containerBtnPanel;
        private Button btnThem;
        private Button btnXuatFile;
        private Button btnSua;
        private Button btnLamMoi;
        private TableLayoutPanel containerTimKiemPanel;
        private TextBox textBoxTimKiem;
        private Button btnTimKiem;
        private DataGridView dataGridView1;
    }
}
