
namespace GetDirectoryFileList
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
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_copyAll = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(10, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(41, 12);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "目录：";
            // 
            // textBox_content
            // 
            this.textBox_content.Location = new System.Drawing.Point(55, 10);
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(300, 21);
            this.textBox_content.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 400);
            this.listBox1.TabIndex = 2;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(369, 9);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 3;
            this.btn_browse.Text = "浏览";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btn_copyAll
            // 
            this.btn_copyAll.Location = new System.Drawing.Point(462, 369);
            this.btn_copyAll.Name = "btn_copyAll";
            this.btn_copyAll.Size = new System.Drawing.Size(75, 23);
            this.btn_copyAll.TabIndex = 4;
            this.btn_copyAll.Text = "复制所有";
            this.btn_copyAll.UseVisualStyleBackColor = true;
            this.btn_copyAll.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(462, 414);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "生成文件";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(462, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "相对路径";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_copyAll);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_content);
            this.Controls.Add(this.label_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_content;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_copyAll;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

