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
    public partial class frmItemExist : Form
    {
        public frmItemExist()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
