namespace ChatRoom.Service
{
    partial class frmMasin
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
            this.pnlParams = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.grpConn = new System.Windows.Forms.GroupBox();
            this.grpTalkContent = new System.Windows.Forms.GroupBox();
            this.rxtConn = new System.Windows.Forms.RichTextBox();
            this.rxtTalkContent = new System.Windows.Forms.RichTextBox();
            this.pnlParams.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpConn.SuspendLayout();
            this.grpTalkContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParams
            // 
            this.pnlParams.Controls.Add(this.btnEnd);
            this.pnlParams.Controls.Add(this.btnStart);
            this.pnlParams.Controls.Add(this.txtPort);
            this.pnlParams.Controls.Add(this.lblPort);
            this.pnlParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlParams.Location = new System.Drawing.Point(0, 0);
            this.pnlParams.Name = "pnlParams";
            this.pnlParams.Size = new System.Drawing.Size(460, 37);
            this.pnlParams.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpTalkContent);
            this.pnlContent.Controls.Add(this.grpConn);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 37);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(460, 499);
            this.pnlContent.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 9);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 15);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(61, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(89, 25);
            this.txtPort.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(174, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(255, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // grpConn
            // 
            this.grpConn.Controls.Add(this.rxtConn);
            this.grpConn.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpConn.Location = new System.Drawing.Point(0, 0);
            this.grpConn.Name = "grpConn";
            this.grpConn.Size = new System.Drawing.Size(203, 499);
            this.grpConn.TabIndex = 0;
            this.grpConn.TabStop = false;
            this.grpConn.Text = "连接";
            // 
            // grpTalkContent
            // 
            this.grpTalkContent.Controls.Add(this.rxtTalkContent);
            this.grpTalkContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTalkContent.Location = new System.Drawing.Point(203, 0);
            this.grpTalkContent.Name = "grpTalkContent";
            this.grpTalkContent.Size = new System.Drawing.Size(257, 499);
            this.grpTalkContent.TabIndex = 1;
            this.grpTalkContent.TabStop = false;
            this.grpTalkContent.Text = "聊天内容";
            // 
            // rxtConn
            // 
            this.rxtConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxtConn.Location = new System.Drawing.Point(3, 21);
            this.rxtConn.Name = "rxtConn";
            this.rxtConn.Size = new System.Drawing.Size(197, 475);
            this.rxtConn.TabIndex = 0;
            this.rxtConn.Text = "";
            // 
            // rxtTalkContent
            // 
            this.rxtTalkContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rxtTalkContent.Location = new System.Drawing.Point(3, 21);
            this.rxtTalkContent.Name = "rxtTalkContent";
            this.rxtTalkContent.Size = new System.Drawing.Size(251, 475);
            this.rxtTalkContent.TabIndex = 0;
            this.rxtTalkContent.Text = "";
            // 
            // frmMasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 536);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMasin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务端";
            this.pnlParams.ResumeLayout(false);
            this.pnlParams.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.grpConn.ResumeLayout(false);
            this.grpTalkContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlParams;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox grpConn;
        private System.Windows.Forms.GroupBox grpTalkContent;
        private System.Windows.Forms.RichTextBox rxtTalkContent;
        private System.Windows.Forms.RichTextBox rxtConn;
    }
}

