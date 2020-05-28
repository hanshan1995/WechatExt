namespace WechatExt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Txt_Status = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "启动方式一：直接在程序内启动，关闭程序后无法使用";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "启动方式二：通过服务的方式启动（需管理员权限），程序关闭后服务仍可用";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "直接启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 61);
            this.button3.TabIndex = 5;
            this.button3.Text = "停止服务";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(46, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 61);
            this.button4.TabIndex = 6;
            this.button4.Text = "运行服务";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(392, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 61);
            this.button5.TabIndex = 7;
            this.button5.Text = "卸载服务";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Txt_Status
            // 
            this.Txt_Status.AutoSize = true;
            this.Txt_Status.Location = new System.Drawing.Point(47, 313);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Size = new System.Drawing.Size(80, 18);
            this.Txt_Status.TabIndex = 8;
            this.Txt_Status.Text = "服务状态";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(565, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 61);
            this.button6.TabIndex = 9;
            this.button6.Text = "开机自启";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Txt_Status;
        private System.Windows.Forms.Button button6;
    }
}

