namespace BirkaPrint2
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.CodeText = new System.Windows.Forms.TextBox();
            this.SystemText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.FIOText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.DescText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ZayavkaText = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.formlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(125, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Печать";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeText
            // 
            this.CodeText.Location = new System.Drawing.Point(155, 8);
            this.CodeText.Name = "CodeText";
            this.CodeText.Size = new System.Drawing.Size(167, 20);
            this.CodeText.TabIndex = 1;
            // 
            // SystemText
            // 
            this.SystemText.Location = new System.Drawing.Point(155, 40);
            this.SystemText.Name = "SystemText";
            this.SystemText.Size = new System.Drawing.Size(167, 20);
            this.SystemText.TabIndex = 2;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(154, 68);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(167, 20);
            this.NameText.TabIndex = 3;
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(154, 94);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(167, 20);
            this.NumberText.TabIndex = 4;
            // 
            // FIOText
            // 
            this.FIOText.Location = new System.Drawing.Point(154, 120);
            this.FIOText.Name = "FIOText";
            this.FIOText.Size = new System.Drawing.Size(167, 20);
            this.FIOText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Код оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Система управления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Наименование блока";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Серийный номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Фамилия";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Бирка";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(154, 173);
            this.DescText.Multiline = true;
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(167, 103);
            this.DescText.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Неисправность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "№ заявки на ремонт";
            // 
            // ZayavkaText
            // 
            this.ZayavkaText.Location = new System.Drawing.Point(154, 146);
            this.ZayavkaText.Name = "ZayavkaText";
            this.ZayavkaText.Size = new System.Drawing.Size(167, 20);
            this.ZayavkaText.TabIndex = 6;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.ForeColor = System.Drawing.Color.Maroon;
            this.versionLabel.Location = new System.Drawing.Point(3, 299);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 16);
            this.versionLabel.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(317, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 24);
            this.button2.TabIndex = 16;
            this.button2.TabStop = false;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(239, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "по СТП";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // formlabel
            // 
            this.formlabel.AutoSize = true;
            this.formlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formlabel.Location = new System.Drawing.Point(2, 243);
            this.formlabel.Name = "formlabel";
            this.formlabel.Size = new System.Drawing.Size(83, 16);
            this.formlabel.TabIndex = 18;
            this.formlabel.Text = "Форма 4290";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 327);
            this.Controls.Add(this.formlabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.ZayavkaText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIOText);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.SystemText);
            this.Controls.Add(this.CodeText);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать бирок  бр. №621 ОЭТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CodeText;
        private System.Windows.Forms.TextBox SystemText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.TextBox FIOText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox DescText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ZayavkaText;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label formlabel;
    }
}

