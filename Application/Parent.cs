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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void _masterControl_ChangeRequired(object sender, EventArgs e)
        {
            //商品登録画面に切り替える
            _salesControl.Visible = true;
            _masterControl.Visible = false;
        }

        private void _salesControl_ChangeRequired(object sender, EventArgs e)
        {
            //マスタ登録画面に切り替える
            _salesControl.Visible = false;
            _masterControl.Visible = true;
        }
    }
}
