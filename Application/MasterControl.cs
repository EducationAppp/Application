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
        public event EventHandler<EventArgs> ChangeRequired = delegate { };

        public MasterControl()
        {
            InitializeComponent();
        }

        private void ToSaleFormBtn_Click(object sender, EventArgs e)
        {
            ChangeRequired(this, EventArgs.Empty);
        }


        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            var itemTable = new DatabaseAcceser().DatabaseConnecter();
            bindingSource.DataSource = itemTable;
            MntGritView.DataSource = bindingSource;




            //設定
            //奇数行を青色にする


        }
    }
}
