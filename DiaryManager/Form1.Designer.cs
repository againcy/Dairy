namespace DiaryManager
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox_style = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_size = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.获取最新日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传当前日记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workspace = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_bold,
            this.toolStripButton_Italic,
            this.toolStripButton_underline,
            this.toolStripComboBox_style,
            this.toolStripComboBox_size});
            this.toolStrip.Location = new System.Drawing.Point(0, 44);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(2200, 40);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripButton_bold
            // 
            this.toolStripButton_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_bold.Image = global::DiaryManager.Properties.Resources.buttonBold;
            this.toolStripButton_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_bold.Name = "toolStripButton_bold";
            this.toolStripButton_bold.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton_bold.Text = "toolStripButton_bold";
            this.toolStripButton_bold.Click += new System.EventHandler(this.toolStripButton_bold_Click);
            // 
            // toolStripButton_Italic
            // 
            this.toolStripButton_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Italic.Image = global::DiaryManager.Properties.Resources.buttonItalic;
            this.toolStripButton_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Italic.Name = "toolStripButton_Italic";
            this.toolStripButton_Italic.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton_Italic.Text = "toolStripButton_Italic";
            this.toolStripButton_Italic.Click += new System.EventHandler(this.toolStripButton_Italic_Click);
            // 
            // toolStripButton_underline
            // 
            this.toolStripButton_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_underline.Image = global::DiaryManager.Properties.Resources.buttonUnderline;
            this.toolStripButton_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_underline.Name = "toolStripButton_underline";
            this.toolStripButton_underline.Size = new System.Drawing.Size(23, 37);
            this.toolStripButton_underline.Text = "toolStripButton_underline";
            this.toolStripButton_underline.Click += new System.EventHandler(this.toolStripButton_underline_Click);
            // 
            // toolStripComboBox_style
            // 
            this.toolStripComboBox_style.Name = "toolStripComboBox_style";
            this.toolStripComboBox_style.Size = new System.Drawing.Size(238, 40);
            this.toolStripComboBox_style.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_style_SelectedIndexChanged);
            this.toolStripComboBox_style.Click += new System.EventHandler(this.toolStripComboBox_style_Click);
            // 
            // toolStripComboBox_size
            // 
            this.toolStripComboBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.toolStripComboBox_size.Name = "toolStripComboBox_size";
            this.toolStripComboBox_size.Size = new System.Drawing.Size(146, 40);
            this.toolStripComboBox_size.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_size_SelectedIndexChanged);
            this.toolStripComboBox_size.Click += new System.EventHandler(this.toolStripComboBox_size_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.未登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2200, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建日记ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.读取日记ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建日记ToolStripMenuItem
            // 
            this.新建日记ToolStripMenuItem.Name = "新建日记ToolStripMenuItem";
            this.新建日记ToolStripMenuItem.Size = new System.Drawing.Size(190, 36);
            this.新建日记ToolStripMenuItem.Text = "新建日记";
            this.新建日记ToolStripMenuItem.Click += new System.EventHandler(this.新建日记ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(190, 36);
            this.保存ToolStripMenuItem.Text = "保存日记";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 读取日记ToolStripMenuItem
            // 
            this.读取日记ToolStripMenuItem.Name = "读取日记ToolStripMenuItem";
            this.读取日记ToolStripMenuItem.Size = new System.Drawing.Size(190, 36);
            this.读取日记ToolStripMenuItem.Text = "读取日记";
            this.读取日记ToolStripMenuItem.Click += new System.EventHandler(this.读取日记ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 未登录ToolStripMenuItem
            // 
            this.未登录ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.未登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.获取最新日记ToolStripMenuItem,
            this.上传当前日记ToolStripMenuItem});
            this.未登录ToolStripMenuItem.Name = "未登录ToolStripMenuItem";
            this.未登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.未登录ToolStripMenuItem.Text = "（未登录）";
            this.未登录ToolStripMenuItem.Click += new System.EventHandler(this.未登录ToolStripMenuItem_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.登录ToolStripMenuItem.Text = "登录(&L)...";
            this.登录ToolStripMenuItem.Visible = false;
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(273, 6);
            // 
            // 获取最新日记ToolStripMenuItem
            // 
            this.获取最新日记ToolStripMenuItem.Name = "获取最新日记ToolStripMenuItem";
            this.获取最新日记ToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.获取最新日记ToolStripMenuItem.Text = "获取最新日记(&N)";
            this.获取最新日记ToolStripMenuItem.Click += new System.EventHandler(this.获取最新日记ToolStripMenuItem_Click);
            // 
            // 上传当前日记ToolStripMenuItem
            // 
            this.上传当前日记ToolStripMenuItem.Name = "上传当前日记ToolStripMenuItem";
            this.上传当前日记ToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.上传当前日记ToolStripMenuItem.Text = "上传当前日记(&U)";
            this.上传当前日记ToolStripMenuItem.Click += new System.EventHandler(this.上传当前日记ToolStripMenuItem_Click);
            // 
            // workspace
            // 
            this.workspace.Location = new System.Drawing.Point(302, 242);
            this.workspace.Margin = new System.Windows.Forms.Padding(6);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(1372, 1110);
            this.workspace.TabIndex = 2;
            this.workspace.Text = "";
            this.workspace.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(0, 242);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 916);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1802, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加新的管理项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(1733, 242);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(397, 916);
            this.listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2200, 1368);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.workspace);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox workspace;
        private System.Windows.Forms.ToolStripMenuItem 新建日记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_size;
        private System.Windows.Forms.ToolStripButton toolStripButton_bold;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Italic;
        private System.Windows.Forms.ToolStripButton toolStripButton_underline;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_style;
        private System.Windows.Forms.ToolStripMenuItem 未登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 获取最新日记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传当前日记ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 读取日记ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

