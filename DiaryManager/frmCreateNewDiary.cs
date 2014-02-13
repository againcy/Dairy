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
    public partial class frmCreatNew : Form
    {
       /* private string curTitle;
        private string curWeather;
        private DateTime curDate;*/
        private Diary tmp;
        public frmCreatNew(Diary newDiary)
        {
            tmp = newDiary;
            /*
            this.curDate = newDiary.date;
            this.curTitle = newDiary.title;
            this.curWeather = newDiary.weather;*/
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            
            this.tmp.weather = weatherBox.Text;
            this.tmp.title = titleBox.Text;
            this.tmp.date = dateTimePicker1.Value;
            
            this.Close();
        }

        private void creatNew_Load(object sender, EventArgs e)
        {

        }
    }
}
