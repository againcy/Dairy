using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiaryManager
{
    public partial class Form1 : Form
    {
        private bool setFontIcons(bool isBold, bool isItalic, bool isUnderline, int fontNameIndex, int fontSizeIndex)
        {
            toolStripComboBox_size.SelectedIndex = fontSizeIndex;
            toolStripComboBox_style.SelectedIndex = fontNameIndex;
            toolStripButton_bold.Checked = isBold;
            toolStripButton_Italic.Checked = isItalic;
            toolStripButton_underline.Checked = isUnderline;
            return false;
        }

        private bool setFontIcons(Font font)
        {
            int fontNameIndex = 0,fontSizeIndex = 0;
            foreach (string t in toolStripComboBox_style.Items)
            {
                if (t == font.FontFamily.Name)
                    break;
                fontNameIndex++;
            }
            foreach (string t in toolStripComboBox_size.Items)
            {
                if (t == font.Size.ToString())
                    break;
                fontSizeIndex++;
            }
            return setFontIcons(font.Bold, font.Italic, font.Underline, fontNameIndex, fontSizeIndex);
                    
        }

        private Font myGetSelectionFont()
        {
            Font t = this.workspace.SelectionFont;
            if (t == null)
                return defaultFont;
            else return t;
        }

        private Font getFont(string fontString, float fontsize, FontStyle fs)
        {
            Font ret = null;
            try
            {
                ret = new Font(fontString, fontsize, fs);
            }
            catch (Exception)
            {
                //MessageBox.Show("请使用另一种字体");
                try
                {
                    ret = new Font(fontString, fontsize, FontStyle.Italic | fs);

                }
                catch (Exception)
                {
                    //try
                    //{
                        ret = new Font(fontString, fontsize, FontStyle.Bold | fs);
                    //}
                    //catch (Exception)
                    //{
                    //    return null;
                    //}
                }
            }
            return ret;
        }
    }
}
