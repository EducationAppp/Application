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
    public partial class SalesControl : UserControl
    {
        public event EventHandler<EventArgs> ChangeRequired = delegate { };

        public SalesControl()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeRequired(this, EventArgs.Empty);
        }
    }
}
