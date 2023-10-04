using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TracNghiem_manager
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
            tableLayoutPanel1 = new TableLayoutPanel();
            descPanel = new TableLayoutPanel();
            TitlePanel = new TableLayoutPanel();
            lblHeading = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            mainPanel.SuspendLayout();
            informationContainerPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            descPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel3.SuspendLayout();
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
            informationContainerPanel.Controls.Add(tableLayoutPanel1, 1, 0);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.88889F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Location = new Point(413, 14);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 395F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(543, 508);
            tableLayoutPanel1.TabIndex = 0;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2909279F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4157772F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.2932968F));
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(537, 107);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.3668537F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.63315F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 116);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(537, 389);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.Size = new Size(98, 383);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Location = new Point(107, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.Size = new Size(427, 383);
            tableLayoutPanel5.TabIndex = 1;
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
            informationContainerPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            descPanel.ResumeLayout(false);
            descPanel.PerformLayout();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
    }
}
