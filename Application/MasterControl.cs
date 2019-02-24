using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationEducation
{
    public partial class MasterControl : UserControl
    {
        public MasterControl()
        {
            InitializeComponent();
        }

        private void ToSaleFormBtn_Click(object sender, EventArgs e)
        {
            var parent = new Parent();
            parent.ChangeForm("Mnt");
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            //https://devlights.hatenablog.com/entry/20070302/p2
            this.MntGritView.DataSource = new BindingSource();

            var dbConnect = new DbConect();

            //設定
            //奇数行を青色にする


        }
    }
}
