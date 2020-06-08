namespace RssReader
{
    partial class Form1
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.dtgvInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewWeb = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbbNewsType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(92, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(696, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtSummary
            // 
            this.txtSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummary.Location = new System.Drawing.Point(92, 67);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(696, 29);
            this.txtSummary.TabIndex = 2;
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLink.Location = new System.Drawing.Point(92, 197);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(696, 20);
            this.txtLink.TabIndex = 3;
            // 
            // dtgvInfo
            // 
            this.dtgvInfo.AllowUserToAddRows = false;
            this.dtgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInfo.Location = new System.Drawing.Point(12, 252);
            this.dtgvInfo.Name = "dtgvInfo";
            this.dtgvInfo.ReadOnly = true;
            this.dtgvInfo.RowHeadersVisible = false;
            this.dtgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInfo.Size = new System.Drawing.Size(776, 186);
            this.dtgvInfo.TabIndex = 4;
            this.dtgvInfo.SelectionChanged += new System.EventHandler(this.dtgvInfo_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Summary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Link:";
            // 
            // btnViewWeb
            // 
            this.btnViewWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewWeb.Location = new System.Drawing.Point(295, 223);
            this.btnViewWeb.Name = "btnViewWeb";
            this.btnViewWeb.Size = new System.Drawing.Size(112, 23);
            this.btnViewWeb.TabIndex = 8;
            this.btnViewWeb.Text = "Xem trên web";
            this.btnViewWeb.UseVisualStyleBackColor = true;
            this.btnViewWeb.Click += new System.EventHandler(this.btnViewWeb_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(713, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbbNewsType
            // 
            this.cbbNewsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNewsType.FormattingEnabled = true;
            this.cbbNewsType.Location = new System.Drawing.Point(12, 225);
            this.cbbNewsType.Name = "cbbNewsType";
            this.cbbNewsType.Size = new System.Drawing.Size(159, 21);
            this.cbbNewsType.TabIndex = 11;
            this.cbbNewsType.SelectedIndexChanged += new System.EventHandler(this.cbbNewsType_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReport,
            this.tsmiPersonalInfo,
            this.tsmiLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiReport
            // 
            this.tsmiReport.Name = "tsmiReport";
            this.tsmiReport.Size = new System.Drawing.Size(61, 20);
            this.tsmiReport.Text = "Báo cáo";
            this.tsmiReport.Click += new System.EventHandler(this.tsmiReport_Click);
            // 
            // tsmiPersonalInfo
            // 
            this.tsmiPersonalInfo.Name = "tsmiPersonalInfo";
            this.tsmiPersonalInfo.Size = new System.Drawing.Size(115, 20);
            this.tsmiPersonalInfo.Text = "Thông tin cá nhân";
            this.tsmiPersonalInfo.Click += new System.EventHandler(this.tsmiPersonalInfo_Click);
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(73, 20);
            this.tsmiLogOut.Text = "Đăng xuất";
            this.tsmiLogOut.Click += new System.EventHandler(this.tsmiLogOut_Click);
            // 
            // rtbDetail
            // 
            this.rtbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDetail.Location = new System.Drawing.Point(92, 102);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.ReadOnly = true;
            this.rtbDetail.Size = new System.Drawing.Size(696, 89);
            this.rtbDetail.TabIndex = 13;
            this.rtbDetail.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Detail:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trạng thái: Không";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDetail);
            this.Controls.Add(this.cbbNewsType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnViewWeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvInfo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Rss Reader";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.DataGridView dtgvInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewWeb;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbbNewsType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.RichTextBox rtbDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

