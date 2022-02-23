namespace GazClientApp
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetDetails = new System.Windows.Forms.Button();
            this.ErrorList = new System.Windows.Forms.ListBox();
            this.AccNoText = new System.Windows.Forms.TextBox();
            this.ConsumText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FIOtext = new System.Windows.Forms.TextBox();
            this.SummText = new System.Windows.Forms.TextBox();
            this.GAZText = new System.Windows.Forms.TextBox();
            this.PenaltyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetDetails
            // 
            this.GetDetails.Location = new System.Drawing.Point(299, 271);
            this.GetDetails.Name = "GetDetails";
            this.GetDetails.Size = new System.Drawing.Size(75, 23);
            this.GetDetails.TabIndex = 0;
            this.GetDetails.Text = "Запрос";
            this.GetDetails.UseVisualStyleBackColor = true;
            this.GetDetails.Click += new System.EventHandler(this.GetDetails_Click);
            // 
            // ErrorList
            // 
            this.ErrorList.FormattingEnabled = true;
            this.ErrorList.Location = new System.Drawing.Point(12, 117);
            this.ErrorList.Name = "ErrorList";
            this.ErrorList.Size = new System.Drawing.Size(362, 95);
            this.ErrorList.TabIndex = 6;
            // 
            // AccNoText
            // 
            this.AccNoText.Location = new System.Drawing.Point(274, 245);
            this.AccNoText.Name = "AccNoText";
            this.AccNoText.Size = new System.Drawing.Size(100, 20);
            this.AccNoText.TabIndex = 7;
            // 
            // ConsumText
            // 
            this.ConsumText.Location = new System.Drawing.Point(274, 219);
            this.ConsumText.Name = "ConsumText";
            this.ConsumText.Size = new System.Drawing.Size(100, 20);
            this.ConsumText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Номер счета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Показания счетчика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ФИО абонента:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Сумма к оплате:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Расход ГАЗа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Сумма по пене:";
            // 
            // FIOtext
            // 
            this.FIOtext.Location = new System.Drawing.Point(138, 12);
            this.FIOtext.Name = "FIOtext";
            this.FIOtext.Size = new System.Drawing.Size(236, 20);
            this.FIOtext.TabIndex = 15;
            // 
            // SummText
            // 
            this.SummText.Location = new System.Drawing.Point(138, 38);
            this.SummText.Name = "SummText";
            this.SummText.Size = new System.Drawing.Size(236, 20);
            this.SummText.TabIndex = 16;
            // 
            // GAZText
            // 
            this.GAZText.Location = new System.Drawing.Point(138, 64);
            this.GAZText.Name = "GAZText";
            this.GAZText.Size = new System.Drawing.Size(236, 20);
            this.GAZText.TabIndex = 17;
            // 
            // PenaltyText
            // 
            this.PenaltyText.Location = new System.Drawing.Point(138, 90);
            this.PenaltyText.Name = "PenaltyText";
            this.PenaltyText.Size = new System.Drawing.Size(236, 20);
            this.PenaltyText.TabIndex = 18;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 343);
            this.Controls.Add(this.PenaltyText);
            this.Controls.Add(this.GAZText);
            this.Controls.Add(this.SummText);
            this.Controls.Add(this.FIOtext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConsumText);
            this.Controls.Add(this.AccNoText);
            this.Controls.Add(this.ErrorList);
            this.Controls.Add(this.GetDetails);
            this.Name = "MainFrm";
            this.Text = "ГазПРОМ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetDetails;
        private System.Windows.Forms.ListBox ErrorList;
        private System.Windows.Forms.TextBox AccNoText;
        private System.Windows.Forms.TextBox ConsumText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FIOtext;
        private System.Windows.Forms.TextBox SummText;
        private System.Windows.Forms.TextBox GAZText;
        private System.Windows.Forms.TextBox PenaltyText;
    }
}

