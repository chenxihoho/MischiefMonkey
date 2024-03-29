﻿namespace yhAzure.Ladder
{
    partial class frmConfigBase
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
            this.plBottom = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.tcBusinessConfig = new System.Windows.Forms.TabControl();
            this.tpPublicConfig = new System.Windows.Forms.TabPage();
            this.tpPrivateConfig = new System.Windows.Forms.TabPage();
            this.tpAdvanceConfig = new System.Windows.Forms.TabPage();
            this.tpSystemConfig = new System.Windows.Forms.TabPage();
            this.tpSecretConfig = new System.Windows.Forms.TabPage();
            this.plBottom.SuspendLayout();
            this.plMain.SuspendLayout();
            this.tcBusinessConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBottom
            // 
            this.plBottom.Controls.Add(this.btSave);
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(10, 268);
            this.plBottom.Name = "plBottom";
            this.plBottom.Padding = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.plBottom.Size = new System.Drawing.Size(416, 50);
            this.plBottom.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(330, 8);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 40);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "上传配置";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.tcBusinessConfig);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(10, 10);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(416, 258);
            this.plMain.TabIndex = 1;
            // 
            // tcBusinessConfig
            // 
            this.tcBusinessConfig.Controls.Add(this.tpPublicConfig);
            this.tcBusinessConfig.Controls.Add(this.tpPrivateConfig);
            this.tcBusinessConfig.Controls.Add(this.tpAdvanceConfig);
            this.tcBusinessConfig.Controls.Add(this.tpSystemConfig);
            this.tcBusinessConfig.Controls.Add(this.tpSecretConfig);
            this.tcBusinessConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBusinessConfig.Location = new System.Drawing.Point(0, 0);
            this.tcBusinessConfig.Name = "tcBusinessConfig";
            this.tcBusinessConfig.SelectedIndex = 0;
            this.tcBusinessConfig.Size = new System.Drawing.Size(416, 258);
            this.tcBusinessConfig.TabIndex = 0;
            // 
            // tpPublicConfig
            // 
            this.tpPublicConfig.Location = new System.Drawing.Point(4, 22);
            this.tpPublicConfig.Name = "tpPublicConfig";
            this.tpPublicConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpPublicConfig.Size = new System.Drawing.Size(408, 232);
            this.tpPublicConfig.TabIndex = 0;
            this.tpPublicConfig.Text = "共公设置";
            this.tpPublicConfig.UseVisualStyleBackColor = true;
            // 
            // tpPrivateConfig
            // 
            this.tpPrivateConfig.Location = new System.Drawing.Point(4, 22);
            this.tpPrivateConfig.Name = "tpPrivateConfig";
            this.tpPrivateConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrivateConfig.Size = new System.Drawing.Size(408, 232);
            this.tpPrivateConfig.TabIndex = 1;
            this.tpPrivateConfig.Text = "内部设置";
            this.tpPrivateConfig.UseVisualStyleBackColor = true;
            // 
            // tpAdvanceConfig
            // 
            this.tpAdvanceConfig.Location = new System.Drawing.Point(4, 22);
            this.tpAdvanceConfig.Name = "tpAdvanceConfig";
            this.tpAdvanceConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanceConfig.Size = new System.Drawing.Size(408, 232);
            this.tpAdvanceConfig.TabIndex = 2;
            this.tpAdvanceConfig.Text = "高级设置";
            this.tpAdvanceConfig.UseVisualStyleBackColor = true;
            // 
            // tpSystemConfig
            // 
            this.tpSystemConfig.Location = new System.Drawing.Point(4, 22);
            this.tpSystemConfig.Name = "tpSystemConfig";
            this.tpSystemConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpSystemConfig.Size = new System.Drawing.Size(408, 232);
            this.tpSystemConfig.TabIndex = 3;
            this.tpSystemConfig.Text = "系统设置";
            this.tpSystemConfig.UseVisualStyleBackColor = true;
            // 
            // tpSecretConfig
            // 
            this.tpSecretConfig.Location = new System.Drawing.Point(4, 22);
            this.tpSecretConfig.Name = "tpSecretConfig";
            this.tpSecretConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpSecretConfig.Size = new System.Drawing.Size(408, 232);
            this.tpSecretConfig.TabIndex = 4;
            this.tpSecretConfig.Text = "机密设置";
            this.tpSecretConfig.UseVisualStyleBackColor = true;
            // 
            // frmConfigBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 328);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.plBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfigBase";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "云业务设置";
            this.plBottom.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            this.tcBusinessConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel plBottom;
        protected System.Windows.Forms.Panel plMain;
        protected System.Windows.Forms.TabControl tcBusinessConfig;
        protected System.Windows.Forms.TabPage tpPublicConfig;
        protected System.Windows.Forms.TabPage tpPrivateConfig;
        protected System.Windows.Forms.TabPage tpAdvanceConfig;
        protected System.Windows.Forms.TabPage tpSystemConfig;
        protected System.Windows.Forms.TabPage tpSecretConfig;
        protected System.Windows.Forms.Button btSave;
    }
}