namespace emulateLoginBaidu
{
    partial class frmEmulateLoginBaidu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmulateLoginBaidu));
            this.grpGetBaiduid = new System.Windows.Forms.GroupBox();
            this.grpGetToken = new System.Windows.Forms.GroupBox();
            this.grpEmulateLogin = new System.Windows.Forms.GroupBox();
            this.btnGetBaiduid = new System.Windows.Forms.Button();
            this.lblBaiduMainUrl = new System.Windows.Forms.Label();
            this.txbBaiduMainUrl = new System.Windows.Forms.TextBox();
            this.txbGotBaiduid = new System.Windows.Forms.TextBox();
            this.lblGotBaiduid = new System.Windows.Forms.Label();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.lblExtractedTokenVal = new System.Windows.Forms.Label();
            this.txbExtractedTokenVal = new System.Windows.Forms.TextBox();
            this.btnEmulateLoginBaidu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBaiduUsername = new System.Windows.Forms.TextBox();
            this.txbBaiduPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmulateLoginResult = new System.Windows.Forms.Label();
            this.txbEmulateLoginResult = new System.Windows.Forms.TextBox();
            this.lklEmulateLoginTutorialUrl = new System.Windows.Forms.LinkLabel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.grpGetBaiduid.SuspendLayout();
            this.grpGetToken.SuspendLayout();
            this.grpEmulateLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGetBaiduid
            // 
            this.grpGetBaiduid.Controls.Add(this.lblGotBaiduid);
            this.grpGetBaiduid.Controls.Add(this.txbGotBaiduid);
            this.grpGetBaiduid.Controls.Add(this.txbBaiduMainUrl);
            this.grpGetBaiduid.Controls.Add(this.lblBaiduMainUrl);
            this.grpGetBaiduid.Controls.Add(this.btnGetBaiduid);
            this.grpGetBaiduid.Location = new System.Drawing.Point(25, 13);
            this.grpGetBaiduid.Name = "grpGetBaiduid";
            this.grpGetBaiduid.Size = new System.Drawing.Size(411, 139);
            this.grpGetBaiduid.TabIndex = 0;
            this.grpGetBaiduid.TabStop = false;
            this.grpGetBaiduid.Text = "步骤1：获得cookie BAIDUID";
            // 
            // grpGetToken
            // 
            this.grpGetToken.Controls.Add(this.txbExtractedTokenVal);
            this.grpGetToken.Controls.Add(this.lblExtractedTokenVal);
            this.grpGetToken.Controls.Add(this.btnGetToken);
            this.grpGetToken.Location = new System.Drawing.Point(25, 158);
            this.grpGetToken.Name = "grpGetToken";
            this.grpGetToken.Size = new System.Drawing.Size(411, 98);
            this.grpGetToken.TabIndex = 1;
            this.grpGetToken.TabStop = false;
            this.grpGetToken.Text = "步骤2：获取token值";
            // 
            // grpEmulateLogin
            // 
            this.grpEmulateLogin.Controls.Add(this.txbEmulateLoginResult);
            this.grpEmulateLogin.Controls.Add(this.lblEmulateLoginResult);
            this.grpEmulateLogin.Controls.Add(this.txbBaiduPassword);
            this.grpEmulateLogin.Controls.Add(this.label2);
            this.grpEmulateLogin.Controls.Add(this.txbBaiduUsername);
            this.grpEmulateLogin.Controls.Add(this.label1);
            this.grpEmulateLogin.Controls.Add(this.btnEmulateLoginBaidu);
            this.grpEmulateLogin.Location = new System.Drawing.Point(25, 262);
            this.grpEmulateLogin.Name = "grpEmulateLogin";
            this.grpEmulateLogin.Size = new System.Drawing.Size(411, 208);
            this.grpEmulateLogin.TabIndex = 2;
            this.grpEmulateLogin.TabStop = false;
            this.grpEmulateLogin.Text = "步骤3：模拟登陆百度首页";
            // 
            // btnGetBaiduid
            // 
            this.btnGetBaiduid.Location = new System.Drawing.Point(97, 46);
            this.btnGetBaiduid.Name = "btnGetBaiduid";
            this.btnGetBaiduid.Size = new System.Drawing.Size(200, 26);
            this.btnGetBaiduid.TabIndex = 0;
            this.btnGetBaiduid.Text = "获取cookie BAIDUID";
            this.btnGetBaiduid.UseVisualStyleBackColor = true;
            this.btnGetBaiduid.Click += new System.EventHandler(this.btnGetBaiduid_Click);
            // 
            // lblBaiduMainUrl
            // 
            this.lblBaiduMainUrl.AutoSize = true;
            this.lblBaiduMainUrl.Location = new System.Drawing.Point(60, 23);
            this.lblBaiduMainUrl.Name = "lblBaiduMainUrl";
            this.lblBaiduMainUrl.Size = new System.Drawing.Size(91, 13);
            this.lblBaiduMainUrl.TabIndex = 1;
            this.lblBaiduMainUrl.Text = "百度首页地址：";
            // 
            // txbBaiduMainUrl
            // 
            this.txbBaiduMainUrl.BackColor = System.Drawing.SystemColors.Info;
            this.txbBaiduMainUrl.Location = new System.Drawing.Point(157, 20);
            this.txbBaiduMainUrl.Name = "txbBaiduMainUrl";
            this.txbBaiduMainUrl.ReadOnly = true;
            this.txbBaiduMainUrl.Size = new System.Drawing.Size(248, 20);
            this.txbBaiduMainUrl.TabIndex = 2;
            this.txbBaiduMainUrl.Text = "http://www.baidu.com/";
            this.txbBaiduMainUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbGotBaiduid
            // 
            this.txbGotBaiduid.BackColor = System.Drawing.SystemColors.Info;
            this.txbGotBaiduid.Location = new System.Drawing.Point(6, 97);
            this.txbGotBaiduid.Multiline = true;
            this.txbGotBaiduid.Name = "txbGotBaiduid";
            this.txbGotBaiduid.ReadOnly = true;
            this.txbGotBaiduid.Size = new System.Drawing.Size(399, 36);
            this.txbGotBaiduid.TabIndex = 3;
            // 
            // lblGotBaiduid
            // 
            this.lblGotBaiduid.AutoSize = true;
            this.lblGotBaiduid.Location = new System.Drawing.Point(6, 81);
            this.lblGotBaiduid.Name = "lblGotBaiduid";
            this.lblGotBaiduid.Size = new System.Drawing.Size(147, 13);
            this.lblGotBaiduid.TabIndex = 4;
            this.lblGotBaiduid.Text = "获取到的Cookie BAIDUID：";
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(97, 19);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(200, 26);
            this.btnGetToken.TabIndex = 0;
            this.btnGetToken.Text = "获取token值";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // lblExtractedTokenVal
            // 
            this.lblExtractedTokenVal.AutoSize = true;
            this.lblExtractedTokenVal.Location = new System.Drawing.Point(33, 63);
            this.lblExtractedTokenVal.Name = "lblExtractedTokenVal";
            this.lblExtractedTokenVal.Size = new System.Drawing.Size(118, 13);
            this.lblExtractedTokenVal.TabIndex = 5;
            this.lblExtractedTokenVal.Text = "提取出来的token值：";
            // 
            // txbExtractedTokenVal
            // 
            this.txbExtractedTokenVal.BackColor = System.Drawing.SystemColors.Info;
            this.txbExtractedTokenVal.Location = new System.Drawing.Point(157, 60);
            this.txbExtractedTokenVal.Name = "txbExtractedTokenVal";
            this.txbExtractedTokenVal.ReadOnly = true;
            this.txbExtractedTokenVal.Size = new System.Drawing.Size(248, 20);
            this.txbExtractedTokenVal.TabIndex = 5;
            // 
            // btnEmulateLoginBaidu
            // 
            this.btnEmulateLoginBaidu.Location = new System.Drawing.Point(97, 76);
            this.btnEmulateLoginBaidu.Name = "btnEmulateLoginBaidu";
            this.btnEmulateLoginBaidu.Size = new System.Drawing.Size(200, 26);
            this.btnEmulateLoginBaidu.TabIndex = 6;
            this.btnEmulateLoginBaidu.Text = "模拟登陆百度首页";
            this.btnEmulateLoginBaidu.UseVisualStyleBackColor = true;
            this.btnEmulateLoginBaidu.Click += new System.EventHandler(this.btnEmulateLoginBaidu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "百度用户名：";
            // 
            // txbBaiduUsername
            // 
            this.txbBaiduUsername.BackColor = System.Drawing.SystemColors.Info;
            this.txbBaiduUsername.Location = new System.Drawing.Point(157, 24);
            this.txbBaiduUsername.Name = "txbBaiduUsername";
            this.txbBaiduUsername.Size = new System.Drawing.Size(248, 20);
            this.txbBaiduUsername.TabIndex = 8;
            // 
            // txbBaiduPassword
            // 
            this.txbBaiduPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txbBaiduPassword.Location = new System.Drawing.Point(157, 50);
            this.txbBaiduPassword.Name = "txbBaiduPassword";
            this.txbBaiduPassword.Size = new System.Drawing.Size(248, 20);
            this.txbBaiduPassword.TabIndex = 10;
            this.txbBaiduPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "百度密码：";
            // 
            // lblEmulateLoginResult
            // 
            this.lblEmulateLoginResult.AutoSize = true;
            this.lblEmulateLoginResult.Location = new System.Drawing.Point(3, 156);
            this.lblEmulateLoginResult.Name = "lblEmulateLoginResult";
            this.lblEmulateLoginResult.Size = new System.Drawing.Size(151, 13);
            this.lblEmulateLoginResult.TabIndex = 11;
            this.lblEmulateLoginResult.Text = "模拟登录百度首页的结果：";
            // 
            // txbEmulateLoginResult
            // 
            this.txbEmulateLoginResult.BackColor = System.Drawing.SystemColors.Info;
            this.txbEmulateLoginResult.ForeColor = System.Drawing.Color.Red;
            this.txbEmulateLoginResult.Location = new System.Drawing.Point(157, 117);
            this.txbEmulateLoginResult.Multiline = true;
            this.txbEmulateLoginResult.Name = "txbEmulateLoginResult";
            this.txbEmulateLoginResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbEmulateLoginResult.Size = new System.Drawing.Size(248, 85);
            this.txbEmulateLoginResult.TabIndex = 12;
            // 
            // lklEmulateLoginTutorialUrl
            // 
            this.lklEmulateLoginTutorialUrl.AutoSize = true;
            this.lklEmulateLoginTutorialUrl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklEmulateLoginTutorialUrl.Location = new System.Drawing.Point(21, 550);
            this.lklEmulateLoginTutorialUrl.Name = "lklEmulateLoginTutorialUrl";
            this.lklEmulateLoginTutorialUrl.Size = new System.Drawing.Size(424, 19);
            this.lklEmulateLoginTutorialUrl.TabIndex = 3;
            this.lklEmulateLoginTutorialUrl.TabStop = true;
            this.lklEmulateLoginTutorialUrl.Text = "【教程】模拟登陆网站 之 C#版（内含两种版本的完整的可运行的代码）";
            this.lklEmulateLoginTutorialUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEmulateLoginTutorialUrl_LinkClicked);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(25, 485);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(411, 42);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "全部清空以便重新测试";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmEmulateLoginBaidu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 578);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lklEmulateLoginTutorialUrl);
            this.Controls.Add(this.grpEmulateLogin);
            this.Controls.Add(this.grpGetToken);
            this.Controls.Add(this.grpGetBaiduid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmulateLoginBaidu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模拟登陆百度首页 by Crifan";
            this.Load += new System.EventHandler(this.frmEmulateLoginBaidu_Load);
            this.grpGetBaiduid.ResumeLayout(false);
            this.grpGetBaiduid.PerformLayout();
            this.grpGetToken.ResumeLayout(false);
            this.grpGetToken.PerformLayout();
            this.grpEmulateLogin.ResumeLayout(false);
            this.grpEmulateLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGetBaiduid;
        private System.Windows.Forms.GroupBox grpGetToken;
        private System.Windows.Forms.GroupBox grpEmulateLogin;
        private System.Windows.Forms.TextBox txbBaiduMainUrl;
        private System.Windows.Forms.Label lblBaiduMainUrl;
        private System.Windows.Forms.Button btnGetBaiduid;
        private System.Windows.Forms.Label lblGotBaiduid;
        private System.Windows.Forms.TextBox txbGotBaiduid;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Label lblExtractedTokenVal;
        private System.Windows.Forms.TextBox txbExtractedTokenVal;
        private System.Windows.Forms.Button btnEmulateLoginBaidu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBaiduPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBaiduUsername;
        private System.Windows.Forms.Label lblEmulateLoginResult;
        private System.Windows.Forms.TextBox txbEmulateLoginResult;
        private System.Windows.Forms.LinkLabel lklEmulateLoginTutorialUrl;
        private System.Windows.Forms.Button btnClearAll;
    }
}

