namespace s_a_3_client
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.Location = new System.Drawing.Point(200, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "邮件发送系统";
            // 
            // addressLabel
            // 
            this.addressLabel.Location = new System.Drawing.Point(20, 40);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(74, 23);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "邮件地址";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(100, 35);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 21);
            this.address.TabIndex = 0;
            // 
            // contentLabel
            // 
            this.contentLabel.Location = new System.Drawing.Point(20, 80);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(74, 23);
            this.contentLabel.TabIndex = 0;
            this.contentLabel.Text = "邮件内容";
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(100, 75);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(200, 21);
            this.content.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(400, 100);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 100);
            this.resultLabel.TabIndex = 0;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(100, 150);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.Text = "发送";
            this.send.TabIndex = 0;
            this.send.Click += new System.EventHandler(this.send_click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(200, 150);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.Text = "检查邮件地址";
            this.check.TabIndex = 0;
            this.check.Click += new System.EventHandler(this.check_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 277);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.content);
            this.Controls.Add(this.send);
            this.Controls.Add(this.check);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label resultLabel;

        #endregion
    }
}

