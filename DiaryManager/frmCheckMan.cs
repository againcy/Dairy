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
    public partial class frmCheckMan : Form
    {
        private Diary curDiary;
        public frmCheckMan(Diary tmp)
        {
            curDiary = tmp;
            InitializeComponent();
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            ManagementItem item = curDiary.management.checkItem(0);
            if (item == null)
            {
                MessageBox.Show("您未添加该管理项！\n请添加后查看！");
            }
            else
            {
                frmManItem frm = new frmManItem(item);
                frm.Show();
            }
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            ManagementItem item = curDiary.management.checkItem(1);
            if (item == null)
            {
                MessageBox.Show("您未添加该管理项！\n请添加后查看！");
            }
            else
            {
                frmManItem frm = new frmManItem(item);
                frm.Show();
            }
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            ManagementItem item = curDiary.management.checkItem(2);
            if (item == null)
            {
                MessageBox.Show("您未添加该管理项！\n请添加后查看！");
            }
            else
            {
                frmManItem frm = new frmManItem(item);
                frm.Show();
            }
        }

        private void deleteFood_Click(object sender, EventArgs e)
        {
            bool tmp = curDiary.management.deleteItem(0);
            if (!tmp) MessageBox.Show("您未添加该管理项！\n请添加后再执行此操作！");
        }

        private void deleteSport_Click(object sender, EventArgs e)
        {
            bool tmp = curDiary.management.deleteItem(1);
            if (!tmp) MessageBox.Show("您未添加该管理项！\n请添加后再执行此操作！");
        }

        private void deleteBill_Click(object sender, EventArgs e)
        {
            bool tmp = curDiary.management.deleteItem(2);
            if (!tmp) MessageBox.Show("您未添加该管理项！\n请添加后再执行此操作！");
        }

    }
}
