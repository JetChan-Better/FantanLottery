namespace FantanLottery
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPage_betRecord = new System.Windows.Forms.TabPage();
            this.rtbx_betRecord = new System.Windows.Forms.RichTextBox();
            this.tbPage_userMgr = new System.Windows.Forms.TabPage();
            this.btnStopGather = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPage_betRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.btnStopGather);
            this.splitContainer1.Size = new System.Drawing.Size(1145, 730);
            this.splitContainer1.SplitterDistance = 944;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPage_betRecord);
            this.tabControl1.Controls.Add(this.tbPage_userMgr);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPage_betRecord
            // 
            this.tbPage_betRecord.Controls.Add(this.rtbx_betRecord);
            this.tbPage_betRecord.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.tbPage_betRecord.Location = new System.Drawing.Point(4, 34);
            this.tbPage_betRecord.Name = "tbPage_betRecord";
            this.tbPage_betRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_betRecord.Size = new System.Drawing.Size(936, 692);
            this.tbPage_betRecord.TabIndex = 0;
            this.tbPage_betRecord.Text = "下注记录";
            this.tbPage_betRecord.UseVisualStyleBackColor = true;
            // 
            // rtbx_betRecord
            // 
            this.rtbx_betRecord.AcceptsTab = true;
            this.rtbx_betRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbx_betRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbx_betRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbx_betRecord.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbx_betRecord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbx_betRecord.Location = new System.Drawing.Point(3, 3);
            this.rtbx_betRecord.Name = "rtbx_betRecord";
            this.rtbx_betRecord.ReadOnly = true;
            this.rtbx_betRecord.Size = new System.Drawing.Size(930, 686);
            this.rtbx_betRecord.TabIndex = 0;
            this.rtbx_betRecord.Text = "";
            // 
            // tbPage_userMgr
            // 
            this.tbPage_userMgr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPage_userMgr.Location = new System.Drawing.Point(4, 34);
            this.tbPage_userMgr.Name = "tbPage_userMgr";
            this.tbPage_userMgr.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_userMgr.Size = new System.Drawing.Size(936, 692);
            this.tbPage_userMgr.TabIndex = 1;
            this.tbPage_userMgr.Text = "用户管理";
            this.tbPage_userMgr.UseVisualStyleBackColor = true;
            // 
            // btnStopGather
            // 
            this.btnStopGather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopGather.Location = new System.Drawing.Point(110, 695);
            this.btnStopGather.Name = "btnStopGather";
            this.btnStopGather.Size = new System.Drawing.Size(75, 23);
            this.btnStopGather.TabIndex = 0;
            this.btnStopGather.Text = "停止采集";
            this.btnStopGather.UseVisualStyleBackColor = true;
            this.btnStopGather.Click += new System.EventHandler(this.btnStopGather_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 730);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "番摊自动下注机器";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPage_betRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPage_betRecord;
        private System.Windows.Forms.TabPage tbPage_userMgr;
        private System.Windows.Forms.RichTextBox rtbx_betRecord;
        private System.Windows.Forms.Button btnStopGather;
    }
}

