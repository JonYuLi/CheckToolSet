namespace CheckToolSet
{
    partial class CheckToolSetForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMainEdit = new System.Windows.Forms.TextBox();
            this.comboBoxVerifyMode = new System.Windows.Forms.ComboBox();
            this.radioBtnHexMode = new System.Windows.Forms.RadioButton();
            this.radioBtnAsciiMode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMainEdit
            // 
            this.textBoxMainEdit.Location = new System.Drawing.Point(12, 12);
            this.textBoxMainEdit.Multiline = true;
            this.textBoxMainEdit.Name = "textBoxMainEdit";
            this.textBoxMainEdit.Size = new System.Drawing.Size(370, 125);
            this.textBoxMainEdit.TabIndex = 0;
            // 
            // comboBoxVerifyMode
            // 
            this.comboBoxVerifyMode.FormattingEnabled = true;
            this.comboBoxVerifyMode.Items.AddRange(new object[] {
            "累加和",
            "异或和",
            "LRC",
            "CRC"});
            this.comboBoxVerifyMode.Location = new System.Drawing.Point(12, 158);
            this.comboBoxVerifyMode.Name = "comboBoxVerifyMode";
            this.comboBoxVerifyMode.Size = new System.Drawing.Size(118, 20);
            this.comboBoxVerifyMode.TabIndex = 1;
            this.comboBoxVerifyMode.Text = "请选择校验方式";
            // 
            // radioBtnHexMode
            // 
            this.radioBtnHexMode.AutoSize = true;
            this.radioBtnHexMode.Checked = true;
            this.radioBtnHexMode.Location = new System.Drawing.Point(150, 162);
            this.radioBtnHexMode.Name = "radioBtnHexMode";
            this.radioBtnHexMode.Size = new System.Drawing.Size(95, 16);
            this.radioBtnHexMode.TabIndex = 2;
            this.radioBtnHexMode.TabStop = true;
            this.radioBtnHexMode.Text = "十六进制模式";
            this.radioBtnHexMode.UseVisualStyleBackColor = true;
            // 
            // radioBtnAsciiMode
            // 
            this.radioBtnAsciiMode.AutoSize = true;
            this.radioBtnAsciiMode.Location = new System.Drawing.Point(277, 162);
            this.radioBtnAsciiMode.Name = "radioBtnAsciiMode";
            this.radioBtnAsciiMode.Size = new System.Drawing.Size(71, 16);
            this.radioBtnAsciiMode.TabIndex = 2;
            this.radioBtnAsciiMode.Text = "字符模式";
            this.radioBtnAsciiMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "校验结果";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(69, 203);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 21);
            this.textBoxResult.TabIndex = 4;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(203, 201);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "使用帮助";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(307, 201);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(75, 23);
            this.buttonCancle.TabIndex = 5;
            this.buttonCancle.Text = "取消";
            this.buttonCancle.UseVisualStyleBackColor = true;
            // 
            // CheckToolSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 236);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnAsciiMode);
            this.Controls.Add(this.radioBtnHexMode);
            this.Controls.Add(this.comboBoxVerifyMode);
            this.Controls.Add(this.textBoxMainEdit);
            this.MaximizeBox = false;
            this.Name = "CheckToolSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckToolSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMainEdit;
        private System.Windows.Forms.ComboBox comboBoxVerifyMode;
        private System.Windows.Forms.RadioButton radioBtnHexMode;
        private System.Windows.Forms.RadioButton radioBtnAsciiMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonCancle;
    }
}

