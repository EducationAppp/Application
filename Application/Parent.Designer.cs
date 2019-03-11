namespace ApplicationEducation
{
    partial class Parent
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ParentPanel = new System.Windows.Forms.Panel();
            this._salesControl = new ApplicationEducation.SalesControl();
            this._masterControl = new ApplicationEducation.MasterControl();
            this.ParentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentPanel
            // 
            this.ParentPanel.Controls.Add(this._salesControl);
            this.ParentPanel.Controls.Add(this._masterControl);
            this.ParentPanel.Location = new System.Drawing.Point(0, 0);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(1500, 800);
            this.ParentPanel.TabIndex = 0;
            // 
            // _salesControl
            // 
            this._salesControl.Location = new System.Drawing.Point(0, 0);
            this._salesControl.Name = "_salesControl";
            this._salesControl.Size = new System.Drawing.Size(1500, 800);
            this._salesControl.TabIndex = 1;
            this._salesControl.Visible = false;
            this._salesControl.ChangeRequired += new System.EventHandler<System.EventArgs>(this._salesControl_ChangeRequired);
            // 
            // _masterControl
            // 
            this._masterControl.Location = new System.Drawing.Point(0, 0);
            this._masterControl.Name = "_masterControl";
            this._masterControl.Size = new System.Drawing.Size(1500, 800);
            this._masterControl.TabIndex = 0;
            this._masterControl.ChangeRequired += new System.EventHandler<System.EventArgs>(this._masterControl_ChangeRequired);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 796);
            this.Controls.Add(this.ParentPanel);
            this.Name = "Parent";
            this.ParentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ParentPanel;
        private SalesControl _salesControl;
        private MasterControl _masterControl;
    }
}
