using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Forms;

namespace TracNghiemManager.GUI
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            mainPanel = new TableLayoutPanel();
            informationContainerPanel = new TableLayoutPanel();
            descPanel = new TableLayoutPanel();
            TitlePanel = new TableLayoutPanel();
            lblHeading = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            mainPanel.SuspendLayout();
            descPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(240, 247, 250);
            mainPanel.ColumnCount = 1;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainPanel.Controls.Add(informationContainerPanel, 0, 1);
            mainPanel.Controls.Add(descPanel, 0, 0);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 2;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30.32258F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 69.67742F));
            mainPanel.Size = new Size(1376, 775);
            mainPanel.TabIndex = 0;
            // 
            // informationContainerPanel
            // 
            informationContainerPanel.ColumnCount = 3;
            informationContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0802917F));
            informationContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8394165F));
            informationContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0073F));
            informationContainerPanel.Dock = DockStyle.Fill;
            informationContainerPanel.Location = new Point(3, 237);
            informationContainerPanel.Margin = new Padding(3, 2, 3, 2);
            informationContainerPanel.Name = "informationContainerPanel";
            informationContainerPanel.RowCount = 1;
            informationContainerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            informationContainerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            informationContainerPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 536F));
            informationContainerPanel.Size = new Size(1370, 536);
            informationContainerPanel.TabIndex = 0;
            // 
            // descPanel
            // 
            descPanel.BackColor = Color.White;
            descPanel.ColumnCount = 1;
            descPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            descPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            descPanel.Controls.Add(TitlePanel, 0, 0);
            descPanel.Controls.Add(label6, 0, 1);
            descPanel.Dock = DockStyle.Fill;
            descPanel.Location = new Point(3, 2);
            descPanel.Margin = new Padding(3, 2, 3, 2);
            descPanel.Name = "descPanel";
            descPanel.RowCount = 2;
            descPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 64.06927F));
            descPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35.9307365F));
            descPanel.Size = new Size(1370, 231);
            descPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            TitlePanel.ColumnCount = 2;
            TitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5256424F));
            TitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.4743576F));
            TitlePanel.Controls.Add(lblHeading, 0, 0);
            TitlePanel.Controls.Add(pictureBox4, 1, 0);
            TitlePanel.Dock = DockStyle.Fill;
            TitlePanel.Location = new Point(3, 2);
            TitlePanel.Margin = new Padding(3, 2, 3, 2);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.RowCount = 1;
            TitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TitlePanel.Size = new Size(1364, 144);
            TitlePanel.TabIndex = 2;
            // 
            // lblHeading
            // 
            lblHeading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = Color.SteelBlue;
            lblHeading.Location = new Point(507, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(220, 144);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Lập trình";
            lblHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(733, 2);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(0, 8, 0, 8);
            pictureBox4.Size = new Size(121, 140);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(370, 148);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 4);
            label6.Size = new Size(630, 83);
            label6.TabIndex = 3;
            label6.Text = "Phần mềm quản lý thi trắc nghiệm";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeUserControl";
            Size = new Size(1376, 775);
            mainPanel.ResumeLayout(false);
            descPanel.ResumeLayout(false);
            descPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainPanel;
        private TableLayoutPanel informationContainerPanel;
        private Color pictureBoxColor;
        private TableLayoutPanel descPanel;
        private Label lblHeading;
        private TableLayoutPanel TitlePanel;
        private PictureBox pictureBox4;
        private Label label6;
    }
}
