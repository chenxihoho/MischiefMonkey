﻿namespace MischiefMonkey
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.plLog = new System.Windows.Forms.Panel();
            this.edLog = new System.Windows.Forms.TextBox();
            this.plTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSearchBankPassword = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.nudStartPos = new System.Windows.Forms.NumericUpDown();
            this.lbStartPos = new System.Windows.Forms.Label();
            this.plLog.SuspendLayout();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPos)).BeginInit();
            this.SuspendLayout();
            // 
            // plLog
            // 
            this.plLog.Controls.Add(this.edLog);
            this.plLog.Location = new System.Drawing.Point(12, 65);
            this.plLog.Name = "plLog";
            this.plLog.Padding = new System.Windows.Forms.Padding(10);
            this.plLog.Size = new System.Drawing.Size(529, 277);
            this.plLog.TabIndex = 7;
            // 
            // edLog
            // 
            this.edLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.edLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edLog.ForeColor = System.Drawing.Color.Lime;
            this.edLog.Location = new System.Drawing.Point(10, 10);
            this.edLog.Margin = new System.Windows.Forms.Padding(4);
            this.edLog.Multiline = true;
            this.edLog.Name = "edLog";
            this.edLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edLog.Size = new System.Drawing.Size(509, 257);
            this.edLog.TabIndex = 1;
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.plTop.Controls.Add(this.lbStartPos);
            this.plTop.Controls.Add(this.nudStartPos);
            this.plTop.Controls.Add(this.pictureBox1);
            this.plTop.Controls.Add(this.btSearchBankPassword);
            this.plTop.Controls.Add(this.tbKeyword);
            this.plTop.Controls.Add(this.btSearch);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(541, 59);
            this.plTop.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MischiefMonkey.Properties.Resources._4143a7fa7f4a923f5019b14addf10839;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btSearchBankPassword
            // 
            this.btSearchBankPassword.Location = new System.Drawing.Point(425, 8);
            this.btSearchBankPassword.Name = "btSearchBankPassword";
            this.btSearchBankPassword.Size = new System.Drawing.Size(101, 44);
            this.btSearchBankPassword.TabIndex = 8;
            this.btSearchBankPassword.Text = "遍历银行卡密码";
            this.btSearchBankPassword.UseVisualStyleBackColor = true;
            this.btSearchBankPassword.Click += new System.EventHandler(this.btSearchBankPassword_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbKeyword.Location = new System.Drawing.Point(68, 12);
            this.tbKeyword.Multiline = true;
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(192, 35);
            this.tbKeyword.TabIndex = 0;
            this.tbKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeyword_KeyDown);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(337, 8);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(82, 44);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "开始搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // nudStartPos
            // 
            this.nudStartPos.Location = new System.Drawing.Point(269, 28);
            this.nudStartPos.Name = "nudStartPos";
            this.nudStartPos.Size = new System.Drawing.Size(41, 21);
            this.nudStartPos.TabIndex = 10;
            // 
            // lbStartPos
            // 
            this.lbStartPos.AutoSize = true;
            this.lbStartPos.Location = new System.Drawing.Point(266, 10);
            this.lbStartPos.Name = "lbStartPos";
            this.lbStartPos.Size = new System.Drawing.Size(65, 12);
            this.lbStartPos.TabIndex = 11;
            this.lbStartPos.Text = "译码起始位";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(541, 354);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.plLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "无限猴子";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.plLog.ResumeLayout(false);
            this.plLog.PerformLayout();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLog;
        private System.Windows.Forms.TextBox edLog;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btSearchBankPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbStartPos;
        private System.Windows.Forms.NumericUpDown nudStartPos;
    }
}

