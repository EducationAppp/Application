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
        private SalesControl _salesForm;
        private MasterControl _MentenanceForm;

        public Parent()
        {
            InitializeComponent();

            _salesForm = new SalesControl();
            _MentenanceForm = new MasterControl();

            //ParentパネルにSalesControl.cs,MasterControl.csを追加
            this.ParentPanel.Controls.Add(_salesForm);
            this.ParentPanel.Controls.Add(_MentenanceForm);

            //メンテナンス画面のみ表示
            _salesForm.Visible = false;
            _MentenanceForm.Visible = true;
        }

        public void ChangeForm(String status) {

            //商品登録画面に切り替える
            if (status == "Mnt")
            {
                _salesForm.Visible = true;
                _MentenanceForm.Visible = false;
                return;
            }

            //マスタ登録画面に切り替える
            if (status == "Sales")
            {
                _salesForm.Visible = false;
                _MentenanceForm.Visible = true;
                return;
            }

        }

    }
}
