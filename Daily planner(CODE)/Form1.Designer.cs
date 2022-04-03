
namespace Daily_planner
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
            this.components = new System.ComponentModel.Container();
            this.PlanBox = new System.Windows.Forms.TextBox();
            this.CreateB = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.PlanList = new System.Windows.Forms.ListBox();
            this.planlabel = new System.Windows.Forms.Label();
            this.CloseB = new System.Windows.Forms.Button();
            this.AcceptB = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.WatchBox = new System.Windows.Forms.TextBox();
            this.WatchB = new System.Windows.Forms.Button();
            this.WatchClose = new System.Windows.Forms.Button();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // PlanBox
            // 
            this.PlanBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlanBox.Location = new System.Drawing.Point(191, 6);
            this.PlanBox.Multiline = true;
            this.PlanBox.Name = "PlanBox";
            this.PlanBox.Size = new System.Drawing.Size(349, 637);
            this.PlanBox.TabIndex = 0;
            this.PlanBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreateB
            // 
            this.CreateB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateB.Location = new System.Drawing.Point(191, 362);
            this.CreateB.Name = "CreateB";
            this.CreateB.Size = new System.Drawing.Size(90, 36);
            this.CreateB.TabIndex = 1;
            this.CreateB.Text = "Создать";
            this.CreateB.UseVisualStyleBackColor = false;
            this.CreateB.Click += new System.EventHandler(this.CreateB_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteB.Location = new System.Drawing.Point(383, 362);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(90, 36);
            this.DeleteB.TabIndex = 2;
            this.DeleteB.Text = "Удалить";
            this.DeleteB.UseVisualStyleBackColor = false;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.monthCalendar1.Location = new System.Drawing.Point(15, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // PlanList
            // 
            this.PlanList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlanList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlanList.FormattingEnabled = true;
            this.PlanList.Location = new System.Drawing.Point(191, 66);
            this.PlanList.Name = "PlanList";
            this.PlanList.Size = new System.Drawing.Size(281, 290);
            this.PlanList.TabIndex = 4;
            // 
            // planlabel
            // 
            this.planlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.planlabel.AutoSize = true;
            this.planlabel.BackColor = System.Drawing.Color.Transparent;
            this.planlabel.Location = new System.Drawing.Point(191, 50);
            this.planlabel.Name = "planlabel";
            this.planlabel.Size = new System.Drawing.Size(115, 13);
            this.planlabel.TabIndex = 5;
            this.planlabel.Text = "Список напоминаний";
            this.planlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CloseB
            // 
            this.CloseB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CloseB.Location = new System.Drawing.Point(546, 619);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(75, 23);
            this.CloseB.TabIndex = 6;
            this.CloseB.Text = "Закрыть";
            this.CloseB.UseVisualStyleBackColor = false;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // AcceptB
            // 
            this.AcceptB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AcceptB.Location = new System.Drawing.Point(546, 590);
            this.AcceptB.Name = "AcceptB";
            this.AcceptB.Size = new System.Drawing.Size(75, 23);
            this.AcceptB.TabIndex = 7;
            this.AcceptB.Text = "Принять";
            this.AcceptB.UseVisualStyleBackColor = false;
            this.AcceptB.Click += new System.EventHandler(this.AcceptB_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CreateNewButton.Location = new System.Drawing.Point(546, 561);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(75, 23);
            this.CreateNewButton.TabIndex = 8;
            this.CreateNewButton.Text = "Создать";
            this.CreateNewButton.UseVisualStyleBackColor = false;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(547, 532);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NoteBox.Location = new System.Drawing.Point(25, 256);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(134, 25);
            this.NoteBox.TabIndex = 10;
            this.NoteBox.TextChanged += new System.EventHandler(this.NoteBox_TextChanged);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoteLabel.Location = new System.Drawing.Point(5, 240);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(174, 13);
            this.NoteLabel.TabIndex = 11;
            this.NoteLabel.Text = "Название заметки(16 символов)";
            // 
            // WatchBox
            // 
            this.WatchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WatchBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WatchBox.Location = new System.Drawing.Point(15, 26);
            this.WatchBox.Multiline = true;
            this.WatchBox.Name = "WatchBox";
            this.WatchBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WatchBox.Size = new System.Drawing.Size(606, 255);
            this.WatchBox.TabIndex = 12;
            this.WatchBox.TextChanged += new System.EventHandler(this.WatchBox_TextChanged);
            // 
            // WatchB
            // 
            this.WatchB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WatchB.Location = new System.Drawing.Point(287, 362);
            this.WatchB.Name = "WatchB";
            this.WatchB.Size = new System.Drawing.Size(90, 36);
            this.WatchB.TabIndex = 13;
            this.WatchB.Text = "Посмотреть";
            this.WatchB.UseVisualStyleBackColor = true;
            this.WatchB.Click += new System.EventHandler(this.WatchB_Click);
            // 
            // WatchClose
            // 
            this.WatchClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WatchClose.Location = new System.Drawing.Point(546, 287);
            this.WatchClose.Name = "WatchClose";
            this.WatchClose.Size = new System.Drawing.Size(75, 23);
            this.WatchClose.TabIndex = 14;
            this.WatchClose.Text = "Закрыть";
            this.WatchClose.UseVisualStyleBackColor = true;
            this.WatchClose.Click += new System.EventHandler(this.WatchClose_Click);
            // 
            // DataBox
            // 
            this.DataBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DataBox.Location = new System.Drawing.Point(12, 349);
            this.DataBox.Multiline = true;
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(142, 20);
            this.DataBox.TabIndex = 15;
            this.DataBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataLabel.Location = new System.Drawing.Point(4, 320);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(163, 26);
            this.DataLabel.TabIndex = 16;
            this.DataLabel.Text = "  Введите дату напоминания\r\nФормата (15.08.2021 15:48:03)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daily_planner.Properties.Resources._1234231231231;
            this.ClientSize = new System.Drawing.Size(633, 649);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.WatchClose);
            this.Controls.Add(this.WatchB);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.AcceptB);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.planlabel);
            this.Controls.Add(this.PlanList);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.CreateB);
            this.Controls.Add(this.PlanBox);
            this.Controls.Add(this.WatchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyPlanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlanBox;
        private System.Windows.Forms.Button CreateB;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox PlanList;
        private System.Windows.Forms.Label planlabel;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.Button AcceptB;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.TextBox WatchBox;
        private System.Windows.Forms.Button WatchB;
        private System.Windows.Forms.Button WatchClose;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

