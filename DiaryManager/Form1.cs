using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiaryManager
{
    public partial class Form1 : Form
    {
        //构造函数在这里！
        public Form1()
        {
            InitializeComponent();
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox_size_Click(object sender, EventArgs e)
        {

        }
        


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //窗体加载时的初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)      //窗体打开时加载系统安装字体名称并输入到ComboBox控件中去  
            {
                this.toolStripComboBox_style.Items.Add(font.Name);           //加载  
            }
            this.toolStripComboBox_style.SelectedItem = "宋体";              //默认显示的字体  

            this.toolStripComboBox_size.SelectedIndex = 10;               //默认的字号为10  
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        //加粗
        private void toolStripButton_bold_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.workspace.SelectionFont;
            if (oldFont.Bold)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            this.workspace.SelectionFont = newFont;
            this.workspace.Focus();
        }

        //斜体
        private void toolStripButton_Italic_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.workspace.SelectionFont;
            if (oldFont.Italic)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            this.workspace.SelectionFont = newFont;
            this.workspace.Focus();
        }

        //下划线
        private void toolStripButton_underline_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.workspace.SelectionFont;
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            this.workspace.SelectionFont = newFont;
            this.workspace.Focus();
        }

        //更改字号
        private void toolStripComboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sizeString = ((ToolStripComboBox)sender).SelectedItem.ToString();
            float curSize = float.Parse(sizeString);
            Font oldFont = this.workspace.SelectionFont;
            this.workspace.SelectionFont = new Font(oldFont.FontFamily, curSize, oldFont.Style);
            this.workspace.Focus();
        }

        //更改字体
        private void toolStripComboBox_style_SelectedIndexChanged(object sender, EventArgs e)
        {
            string styleString = ((ToolStripComboBox)sender).SelectedItem.ToString();

            Font oldFont = this.workspace.SelectionFont;
            //try
            //{
                this.workspace.SelectionFont = new Font(styleString, oldFont.Size, oldFont.Style);
            //}
           // catch (Exception )
            //{
            //    MessageBox.Show("请使用另一种字体");
           // }
            this.workspace.Focus();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox_style_Click(object sender, EventArgs e)
        {

        }


        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
