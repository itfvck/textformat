namespace 文本格式化
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBoxSrc = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonFormat1 = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.richTextBoxSrc);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(948, 256);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "原文本";
            // 
            // richTextBoxSrc
            // 
            this.richTextBoxSrc.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxSrc.Name = "richTextBoxSrc";
            this.richTextBoxSrc.Size = new System.Drawing.Size(936, 230);
            this.richTextBoxSrc.TabIndex = 0;
            this.richTextBoxSrc.Text = "";
            this.richTextBoxSrc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxSrc_KeyDown);
            this.richTextBoxSrc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxSrc_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "转换后";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(936, 182);
            this.richTextBoxResult.TabIndex = 0;
            this.richTextBoxResult.Text = "";
            this.richTextBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxResult_KeyPress);
            // 
            // buttonFormat1
            // 
            this.buttonFormat1.Location = new System.Drawing.Point(12, 271);
            this.buttonFormat1.Name = "buttonFormat1";
            this.buttonFormat1.Size = new System.Drawing.Size(75, 23);
            this.buttonFormat1.TabIndex = 2;
            this.buttonFormat1.Text = "格式化1";
            this.buttonFormat1.UseVisualStyleBackColor = true;
            this.buttonFormat1.Click += new System.EventHandler(this.buttonFormat1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 517);
            this.Controls.Add(this.buttonFormat1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "文本格式化工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBoxSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonFormat1;
    }
}

