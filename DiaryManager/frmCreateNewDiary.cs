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
    public partial class creatNew : Form
    {
        private Label lb_title;
        private Label lb_weather;
        private Label lb_date;
        public creatNew(Label title,Label weather,Label date)
        {
            this.lb_date = date;
            this.lb_title = title;
            this.lb_weather = weather;
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
            this.lb_weather.Text = weatherBox.Text;
            this.lb_title.Text = titleBox.Text;
            this.lb_date.Text = dateTimePicker1.Text;
            
            this.Close();
        }
    }
}
