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
            this.listboxCalcBad = new System.Windows.Forms.ListBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btCalc = new System.Windows.Forms.Button();
            this.listboxCalOut = new System.Windows.Forms.ListBox();
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
            // listboxCalcBad
            // 
            this.listboxCalcBad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxCalcBad.FormattingEnabled = true;
            this.listboxCalcBad.ItemHeight = 12;
            this.listboxCalcBad.Location = new System.Drawing.Point(12, 62);
            this.listboxCalcBad.Name = "listboxCalcBad";
            this.listboxCalcBad.Size = new System.Drawing.Size(194, 412);
            this.listboxCalcBad.TabIndex = 3;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(379, 9);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(65, 21);
            this.tb1.TabIndex = 5;
            this.tb1.Text = "1";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(594, 9);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(65, 21);
            this.tb4.TabIndex = 7;
            this.tb4.Text = "11";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(523, 9);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(65, 21);
            this.tb3.TabIndex = 9;
            this.tb3.Text = "1";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(22, 6);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(159, 21);
            this.tbMax.TabIndex = 2;
            this.tbMax.Text = "13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "以内";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(452, 9);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(65, 21);
            this.tb2.TabIndex = 10;
            this.tb2.Text = "1";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(379, 33);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(280, 23);
            this.btCalc.TabIndex = 11;
            this.btCalc.Text = "凑出24";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // listboxCalOut
            // 
            this.listboxCalOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listboxCalOut.FormattingEnabled = true;
            this.listboxCalOut.ItemHeight = 12;
            this.listboxCalOut.Location = new System.Drawing.Point(379, 64);
            this.listboxCalOut.Name = "listboxCalOut";
            this.listboxCalOut.Size = new System.Drawing.Size(280, 412);
            this.listboxCalOut.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 488);
            this.Controls.Add(this.listboxCalOut);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb1);
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
        private System.Windows.Forms.ListBox listboxCalcBad;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.ListBox listboxCalOut;
    }
}

