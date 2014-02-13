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
    public partial class frmManagement : Form
    {
        public frmManagement(Diary curD)
        {
            curDiary = curD;
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addFood_Click(object sender, EventArgs e)
        {
            if (curDiary.management.isExist(0))
            {
                frmItemExist tmp = new frmItemExist();
                DialogResult res = tmp.ShowDialog();
                if (res==DialogResult.OK) curDiary.management.deleteItem(0);
                else return;
            }
            ManagementItem item = new ManagementItem();
            item.setType(0);//0 food
            item.initialEvents();
            frmManItem frm = new frmManItem(item);
            if (frm.ShowDialog()==DialogResult.OK) curDiary.management.addItem(item);
        }

        private void addSport_Click(object sender, EventArgs e)
        {
            if (curDiary.management.isExist(1))
            {
                frmItemExist tmp = new frmItemExist();
                DialogResult res = tmp.ShowDialog();
                if (res==DialogResult.OK) curDiary.management.deleteItem(1);
                else return;
            }
            ManagementItem item = new ManagementItem();
            item.setType(1);//1 sport
            item.initialEvents();
            frmManItem frm = new frmManItem(item);
            
            if (frm.ShowDialog()==DialogResult.OK) curDiary.management.addItem(item);
            
        }

        private void addBill_Click(object sender, EventArgs e)
        {
            if (curDiary.management.isExist(2))
            {
                frmItemExist tmp = new frmItemExist();
                DialogResult res = tmp.ShowDialog();
                if (res == DialogResult.OK) curDiary.management.deleteItem(2);
                else return;
            }
            ManagementItem item = new ManagementItem();
            item.setType(2);//2 bill
            item.initialEvents();
            frmManItem frm = new frmManItem(item);
            if (frm.ShowDialog()==DialogResult.OK)curDiary.management.addItem(item);
        }

    }
}
