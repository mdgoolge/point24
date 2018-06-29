namespace Point24App
{
    partial class Form1
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
            this.btCalcBad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.listboxCalcBad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btCalcBad
            // 
            this.btCalcBad.Location = new System.Drawing.Point(12, 33);
            this.btCalcBad.Name = "btCalcBad";
            this.btCalcBad.Size = new System.Drawing.Size(194, 23);
            this.btCalcBad.TabIndex = 0;
            this.btCalcBad.Text = "不能凑出24的数组";
            this.btCalcBad.UseVisualStyleBackColor = true;
            this.btCalcBad.Click += new System.EventHandler(this.btCalcBad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "以内";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(12, 6);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(159, 21);
            this.tbMax.TabIndex = 2;
            this.tbMax.Text = "13";
            // 
            // listboxCalcBad
            // 
            this.listboxCalcBad.FormattingEnabled = true;
            this.listboxCalcBad.ItemHeight = 12;
            this.listboxCalcBad.Location = new System.Drawing.Point(12, 62);
            this.listboxCalcBad.Name = "listboxCalcBad";
            this.listboxCalcBad.Size = new System.Drawing.Size(194, 412);
            this.listboxCalcBad.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 488);
            this.Controls.Add(this.listboxCalcBad);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalcBad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcBad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.ListBox listboxCalcBad;
    }
}

