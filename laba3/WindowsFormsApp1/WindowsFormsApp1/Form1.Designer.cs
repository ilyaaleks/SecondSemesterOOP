namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Specialist = new System.Windows.Forms.ComboBox();
            this.Kurs = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bal = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dop = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textout = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.adr = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(15, 56);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(144, 22);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(15, 106);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(144, 22);
            this.LastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(15, 171);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(144, 22);
            this.SecondName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime.Location = new System.Drawing.Point(15, 238);
            this.dateTime.MaxDate = new System.DateTime(2019, 3, 6, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 22);
            this.dateTime.TabIndex = 7;
            this.dateTime.Value = new System.DateTime(2019, 3, 6, 0, 0, 0, 0);
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Специальность";
            // 
            // Specialist
            // 
            this.Specialist.FormattingEnabled = true;
            this.Specialist.Items.AddRange(new object[] {
            "ПОИТ",
            "ИСИТ",
            "ПОИБМС",
            "ДЭИВИ"});
            this.Specialist.Location = new System.Drawing.Point(15, 318);
            this.Specialist.Name = "Specialist";
            this.Specialist.Size = new System.Drawing.Size(200, 24);
            this.Specialist.TabIndex = 9;
            // 
            // Kurs
            // 
            this.Kurs.FormattingEnabled = true;
            this.Kurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Kurs.Location = new System.Drawing.Point(15, 392);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(200, 24);
            this.Kurs.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Курс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Средний балл";
            // 
            // Bal
            // 
            this.Bal.Location = new System.Drawing.Point(290, 56);
            this.Bal.Name = "Bal";
            this.Bal.Size = new System.Drawing.Size(144, 22);
            this.Bal.TabIndex = 12;
            this.Bal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender.Location = new System.Drawing.Point(290, 106);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(200, 24);
            this.gender.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Пол";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Группа";
            // 
            // Group
            // 
            this.Group.Location = new System.Drawing.Point(290, 171);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(144, 22);
            this.Group.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Дополнительно";
            // 
            // dop
            // 
            this.dop.Location = new System.Drawing.Point(293, 282);
            this.dop.Multiline = true;
            this.dop.Name = "dop";
            this.dop.Size = new System.Drawing.Size(214, 134);
            this.dop.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 20;
            this.button1.Text = "Чтение информации из xml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 21;
            this.button2.Text = "Сохранение информации в xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textout
            // 
            this.textout.Location = new System.Drawing.Point(547, 148);
            this.textout.Multiline = true;
            this.textout.Name = "textout";
            this.textout.ReadOnly = true;
            this.textout.Size = new System.Drawing.Size(242, 268);
            this.textout.TabIndex = 22;
            this.textout.TextChanged += new System.EventHandler(this.textout_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Адрес";
            // 
            // adr
            // 
            this.adr.Location = new System.Drawing.Point(293, 227);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(144, 22);
            this.adr.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 47);
            this.button3.TabIndex = 25;
            this.button3.Text = "Сохранить объект";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(698, 425);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "nextlaba";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.textout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bal);
            this.Controls.Add(this.Kurs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Specialist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
       
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Specialist;
        private System.Windows.Forms.ComboBox Kurs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Bal;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

