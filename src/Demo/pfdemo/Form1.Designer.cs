
namespace pfdemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.fkhmc = new Sunny.UI.UITextBox();
            this.btnfkhmc = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.cprq = new Sunny.UI.UIDatePicker();
            this.btnskr = new Sunny.UI.UIButton();
            this.skr = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btncprzh = new Sunny.UI.UIButton();
            this.cprzh = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.btnyt = new Sunny.UI.UIButton();
            this.yt = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btnje = new Sunny.UI.UIButton();
            this.je = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.lblmsg = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 306);
            this.pnlBtm.Size = new System.Drawing.Size(798, 55);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(357, 53);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "付款行名称";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fkhmc
            // 
            this.fkhmc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fkhmc.FillColor = System.Drawing.Color.White;
            this.fkhmc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fkhmc.Location = new System.Drawing.Point(464, 50);
            this.fkhmc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fkhmc.Maximum = 2147483647D;
            this.fkhmc.Minimum = -2147483648D;
            this.fkhmc.MinimumSize = new System.Drawing.Size(1, 1);
            this.fkhmc.Name = "fkhmc";
            this.fkhmc.Padding = new System.Windows.Forms.Padding(5);
            this.fkhmc.Size = new System.Drawing.Size(200, 29);
            this.fkhmc.TabIndex = 3;
            this.fkhmc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnfkhmc
            // 
            this.btnfkhmc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfkhmc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnfkhmc.Location = new System.Drawing.Point(698, 47);
            this.btnfkhmc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnfkhmc.Name = "btnfkhmc";
            this.btnfkhmc.Size = new System.Drawing.Size(73, 35);
            this.btnfkhmc.TabIndex = 4;
            this.btnfkhmc.Text = "语音输入";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(15, 53);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "出票日期";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cprq
            // 
            this.cprq.FillColor = System.Drawing.Color.White;
            this.cprq.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cprq.Location = new System.Drawing.Point(111, 50);
            this.cprq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cprq.MaxLength = 10;
            this.cprq.MinimumSize = new System.Drawing.Size(63, 0);
            this.cprq.Name = "cprq";
            this.cprq.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cprq.Size = new System.Drawing.Size(150, 29);
            this.cprq.SymbolDropDown = 61555;
            this.cprq.SymbolNormal = 61555;
            this.cprq.TabIndex = 6;
            this.cprq.Text = "2021-06-23";
            this.cprq.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cprq.Value = new System.DateTime(2021, 6, 23, 9, 48, 39, 207);
            // 
            // btnskr
            // 
            this.btnskr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnskr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnskr.Location = new System.Drawing.Point(268, 111);
            this.btnskr.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnskr.Name = "btnskr";
            this.btnskr.Size = new System.Drawing.Size(73, 35);
            this.btnskr.TabIndex = 9;
            this.btnskr.Text = "语音输入";
            // 
            // skr
            // 
            this.skr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.skr.FillColor = System.Drawing.Color.White;
            this.skr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skr.Location = new System.Drawing.Point(109, 114);
            this.skr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skr.Maximum = 2147483647D;
            this.skr.Minimum = -2147483648D;
            this.skr.MinimumSize = new System.Drawing.Size(1, 1);
            this.skr.Name = "skr";
            this.skr.Padding = new System.Windows.Forms.Padding(5);
            this.skr.Size = new System.Drawing.Size(152, 29);
            this.skr.TabIndex = 8;
            this.skr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(15, 117);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "收款人";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncprzh
            // 
            this.btncprzh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncprzh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncprzh.Location = new System.Drawing.Point(698, 111);
            this.btncprzh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btncprzh.Name = "btncprzh";
            this.btncprzh.Size = new System.Drawing.Size(73, 35);
            this.btncprzh.TabIndex = 12;
            this.btncprzh.Text = "语音输入";
            // 
            // cprzh
            // 
            this.cprzh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cprzh.FillColor = System.Drawing.Color.White;
            this.cprzh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cprzh.Location = new System.Drawing.Point(464, 114);
            this.cprzh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cprzh.Maximum = 2147483647D;
            this.cprzh.Minimum = -2147483648D;
            this.cprzh.MinimumSize = new System.Drawing.Size(1, 1);
            this.cprzh.Name = "cprzh";
            this.cprzh.Padding = new System.Windows.Forms.Padding(5);
            this.cprzh.Size = new System.Drawing.Size(200, 29);
            this.cprzh.TabIndex = 11;
            this.cprzh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(357, 117);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 10;
            this.uiLabel4.Text = "出票人账号";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnyt
            // 
            this.btnyt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnyt.Location = new System.Drawing.Point(698, 179);
            this.btnyt.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnyt.Name = "btnyt";
            this.btnyt.Size = new System.Drawing.Size(73, 35);
            this.btnyt.TabIndex = 18;
            this.btnyt.Text = "语音输入";
            // 
            // yt
            // 
            this.yt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yt.FillColor = System.Drawing.Color.White;
            this.yt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yt.Location = new System.Drawing.Point(464, 182);
            this.yt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yt.Maximum = 2147483647D;
            this.yt.Minimum = -2147483648D;
            this.yt.MinimumSize = new System.Drawing.Size(1, 1);
            this.yt.Name = "yt";
            this.yt.Padding = new System.Windows.Forms.Padding(5);
            this.yt.Size = new System.Drawing.Size(200, 29);
            this.yt.TabIndex = 17;
            this.yt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(357, 185);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 16;
            this.uiLabel5.Text = "用途";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnje
            // 
            this.btnje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnje.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnje.Location = new System.Drawing.Point(268, 179);
            this.btnje.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnje.Name = "btnje";
            this.btnje.Size = new System.Drawing.Size(73, 35);
            this.btnje.TabIndex = 15;
            this.btnje.Text = "语音输入";
            // 
            // je
            // 
            this.je.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.je.FillColor = System.Drawing.Color.White;
            this.je.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.je.Location = new System.Drawing.Point(109, 182);
            this.je.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.je.Maximum = 2147483647D;
            this.je.Minimum = -2147483648D;
            this.je.MinimumSize = new System.Drawing.Size(1, 1);
            this.je.Name = "je";
            this.je.Padding = new System.Windows.Forms.Padding(5);
            this.je.Size = new System.Drawing.Size(152, 29);
            this.je.TabIndex = 14;
            this.je.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel6.Location = new System.Drawing.Point(15, 185);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 13;
            this.uiLabel6.Text = "金额";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblmsg
            // 
            this.lblmsg.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmsg.Location = new System.Drawing.Point(278, 246);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(272, 43);
            this.lblmsg.TabIndex = 25;
            this.lblmsg.Text = "倾听中...";
            this.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnyt);
            this.Controls.Add(this.yt);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.btnje);
            this.Controls.Add(this.je);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.btncprzh);
            this.Controls.Add(this.cprzh);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.btnskr);
            this.Controls.Add(this.skr);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.cprq);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btnfkhmc);
            this.Controls.Add(this.fkhmc);
            this.Controls.Add(this.uiLabel1);
            this.Name = "Form1";
            this.Text = "现金支票";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.fkhmc, 0);
            this.Controls.SetChildIndex(this.btnfkhmc, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.cprq, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.skr, 0);
            this.Controls.SetChildIndex(this.btnskr, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.cprzh, 0);
            this.Controls.SetChildIndex(this.btncprzh, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.je, 0);
            this.Controls.SetChildIndex(this.btnje, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.yt, 0);
            this.Controls.SetChildIndex(this.btnyt, 0);
            this.Controls.SetChildIndex(this.lblmsg, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox fkhmc;
        private Sunny.UI.UIButton btnfkhmc;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatePicker cprq;
        private Sunny.UI.UIButton btnskr;
        private Sunny.UI.UITextBox skr;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btncprzh;
        private Sunny.UI.UITextBox cprzh;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnyt;
        private Sunny.UI.UITextBox yt;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btnje;
        private Sunny.UI.UITextBox je;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel lblmsg;
    }
}

