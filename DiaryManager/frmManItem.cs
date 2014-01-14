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
    public partial class frmManItem : Form
    {
        private ManagementItem item;

        public frmManItem(ManagementItem tmp)
        {
            
            item = tmp;
            
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.item.events[0] = this.event0.Text;
            this.item.events[1] = this.event1.Text;
            this.item.events[2] = this.event2.Text;
            this.item.notes = this.notes.Text;
            this.Close();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManItem_Load(object sender, EventArgs e)
        {
            switch (item.itemType)
            {
                case 0:
                    this.title.Text = "饮食计划";
                    this.event0Label.Text = "早餐";
                    this.event1Label.Text = "午餐";
                    this.event2Label.Text = "晚餐";
                    break;
                case 1:
                    this.title.Text = "锻炼计划";
                    this.event0Label.Text = "锻炼地点";
                    this.event1Label.Text = "锻炼项目";
                    this.event2Label.Text = "锻炼时间";
                    break;
                case 2:
                    this.title.Text = "收支记录";
                    this.event0Label.Text = "本日收入";
                    this.event1Label.Text = "本日支出";
                    this.event2Label.Text = "支出项目";
                    break;
            }
            event0.Text = item.events[0];
            event1.Text = item.events[1];
            event2.Text = item.events[2];
            notes.Text = item.notes;
        }
    }
}
