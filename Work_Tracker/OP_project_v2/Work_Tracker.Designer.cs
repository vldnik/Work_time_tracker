namespace OP_project_v2
{
    partial class Work_Tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work_Tracker));
            this.StartTimeButton = new System.Windows.Forms.Button();
            this.ScreensPathTextBox = new System.Windows.Forms.TextBox();
            this.Waylabel = new System.Windows.Forms.Label();
            this.ChooseWaybutton = new System.Windows.Forms.Button();
            this.ScreenTimelabel = new System.Windows.Forms.Label();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ProgslistBox = new System.Windows.Forms.ListBox();
            this.AllTimelabel = new System.Windows.Forms.Label();
            this.AllTimelistBox = new System.Windows.Forms.ListBox();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.ProgsOnlabel = new System.Windows.Forms.Label();
            this.NameMilestoneBox = new System.Windows.Forms.TextBox();
            this.NameMilestoneLabel = new System.Windows.Forms.Label();
            this.buttonCreateMilestone = new System.Windows.Forms.Button();
            this.buttonDoneMilestone = new System.Windows.Forms.Button();
            this.MilestonesLabel = new System.Windows.Forms.Label();
            this.MilestoneListBox = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // StartTimeButton
            // 
            this.StartTimeButton.Location = new System.Drawing.Point(17, 231);
            this.StartTimeButton.Name = "StartTimeButton";
            this.StartTimeButton.Size = new System.Drawing.Size(285, 71);
            this.StartTimeButton.TabIndex = 0;
            this.StartTimeButton.Text = "Запустить таймер";
            this.StartTimeButton.UseVisualStyleBackColor = true;
            this.StartTimeButton.Click += new System.EventHandler(this.TimerStartButtonClick);
            // 
            // ScreensPathTextBox
            // 
            this.ScreensPathTextBox.Location = new System.Drawing.Point(378, 33);
            this.ScreensPathTextBox.Name = "ScreensPathTextBox";
            this.ScreensPathTextBox.Size = new System.Drawing.Size(307, 31);
            this.ScreensPathTextBox.TabIndex = 1;
            // 
            // Waylabel
            // 
            this.Waylabel.AutoSize = true;
            this.Waylabel.Location = new System.Drawing.Point(12, 33);
            this.Waylabel.Name = "Waylabel";
            this.Waylabel.Size = new System.Drawing.Size(355, 25);
            this.Waylabel.TabIndex = 2;
            this.Waylabel.Text = "Путь для сохранения скриншотов:";
            this.Waylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChooseWaybutton
            // 
            this.ChooseWaybutton.Location = new System.Drawing.Point(400, 231);
            this.ChooseWaybutton.Name = "ChooseWaybutton";
            this.ChooseWaybutton.Size = new System.Drawing.Size(285, 71);
            this.ChooseWaybutton.TabIndex = 3;
            this.ChooseWaybutton.Text = "Выбрать путь сохранения скриншотов";
            this.ChooseWaybutton.UseVisualStyleBackColor = true;
            this.ChooseWaybutton.Click += new System.EventHandler(this.SelectFolderButtonClick);
            // 
            // ScreenTimelabel
            // 
            this.ScreenTimelabel.AutoSize = true;
            this.ScreenTimelabel.Location = new System.Drawing.Point(12, 102);
            this.ScreenTimelabel.Name = "ScreenTimelabel";
            this.ScreenTimelabel.Size = new System.Drawing.Size(360, 25);
            this.ScreenTimelabel.TabIndex = 4;
            this.ScreenTimelabel.Text = "Интервал скриншотов (в минутах):";
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(378, 102);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(307, 31);
            this.IntervalTextBox.TabIndex = 5;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Work Time Tracker ";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // ProgslistBox
            // 
            this.ProgslistBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProgslistBox.FormattingEnabled = true;
            this.ProgslistBox.ItemHeight = 25;
            this.ProgslistBox.Location = new System.Drawing.Point(17, 377);
            this.ProgslistBox.Name = "ProgslistBox";
            this.ProgslistBox.Size = new System.Drawing.Size(668, 404);
            this.ProgslistBox.TabIndex = 6;
            this.ProgslistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AllTimelabel
            // 
            this.AllTimelabel.AutoSize = true;
            this.AllTimelabel.Location = new System.Drawing.Point(749, 33);
            this.AllTimelabel.Name = "AllTimelabel";
            this.AllTimelabel.Size = new System.Drawing.Size(233, 25);
            this.AllTimelabel.TabIndex = 8;
            this.AllTimelabel.Text = "Общее время работы:";
            this.AllTimelabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // AllTimelistBox
            // 
            this.AllTimelistBox.FormattingEnabled = true;
            this.AllTimelistBox.ItemHeight = 25;
            this.AllTimelistBox.Location = new System.Drawing.Point(1002, 29);
            this.AllTimelistBox.Name = "AllTimelistBox";
            this.AllTimelistBox.Size = new System.Drawing.Size(417, 29);
            this.AllTimelistBox.TabIndex = 9;
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(1134, 79);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(285, 71);
            this.buttonEnd.TabIndex = 10;
            this.buttonEnd.Text = "Конец работы";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProgsOnlabel
            // 
            this.ProgsOnlabel.AutoSize = true;
            this.ProgsOnlabel.Location = new System.Drawing.Point(12, 334);
            this.ProgsOnlabel.Name = "ProgsOnlabel";
            this.ProgsOnlabel.Size = new System.Drawing.Size(238, 25);
            this.ProgsOnlabel.TabIndex = 11;
            this.ProgsOnlabel.Text = "Открытые программы:";
            // 
            // NameMilestoneBox
            // 
            this.NameMilestoneBox.Location = new System.Drawing.Point(754, 179);
            this.NameMilestoneBox.Name = "NameMilestoneBox";
            this.NameMilestoneBox.Size = new System.Drawing.Size(665, 31);
            this.NameMilestoneBox.TabIndex = 13;
            this.NameMilestoneBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameMilestoneLabel
            // 
            this.NameMilestoneLabel.AutoSize = true;
            this.NameMilestoneLabel.Location = new System.Drawing.Point(749, 139);
            this.NameMilestoneLabel.Name = "NameMilestoneLabel";
            this.NameMilestoneLabel.Size = new System.Drawing.Size(178, 25);
            this.NameMilestoneLabel.TabIndex = 14;
            this.NameMilestoneLabel.Text = "Название этапа:";
            // 
            // buttonCreateMilestone
            // 
            this.buttonCreateMilestone.Location = new System.Drawing.Point(754, 231);
            this.buttonCreateMilestone.Name = "buttonCreateMilestone";
            this.buttonCreateMilestone.Size = new System.Drawing.Size(285, 71);
            this.buttonCreateMilestone.TabIndex = 15;
            this.buttonCreateMilestone.Text = "Создать этап";
            this.buttonCreateMilestone.UseVisualStyleBackColor = true;
            this.buttonCreateMilestone.Click += new System.EventHandler(this.buttonCreateMilestone_Click);
            // 
            // buttonDoneMilestone
            // 
            this.buttonDoneMilestone.Location = new System.Drawing.Point(1134, 231);
            this.buttonDoneMilestone.Name = "buttonDoneMilestone";
            this.buttonDoneMilestone.Size = new System.Drawing.Size(285, 71);
            this.buttonDoneMilestone.TabIndex = 16;
            this.buttonDoneMilestone.Text = "Выполнить этап";
            this.buttonDoneMilestone.UseVisualStyleBackColor = true;
            this.buttonDoneMilestone.Click += new System.EventHandler(this.buttonDoneMilestone_Click);
            // 
            // MilestonesLabel
            // 
            this.MilestonesLabel.AutoSize = true;
            this.MilestonesLabel.Location = new System.Drawing.Point(749, 334);
            this.MilestonesLabel.Name = "MilestonesLabel";
            this.MilestonesLabel.Size = new System.Drawing.Size(82, 25);
            this.MilestonesLabel.TabIndex = 17;
            this.MilestonesLabel.Text = "Этапы:";
            // 
            // MilestoneListBox
            // 
            this.MilestoneListBox.Location = new System.Drawing.Point(754, 377);
            this.MilestoneListBox.Name = "MilestoneListBox";
            this.MilestoneListBox.Size = new System.Drawing.Size(665, 404);
            this.MilestoneListBox.TabIndex = 18;
            this.MilestoneListBox.UseCompatibleStateImageBehavior = false;
            this.MilestoneListBox.View = System.Windows.Forms.View.List;
            // 
            // Work_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 802);
            this.Controls.Add(this.MilestoneListBox);
            this.Controls.Add(this.MilestonesLabel);
            this.Controls.Add(this.buttonDoneMilestone);
            this.Controls.Add(this.buttonCreateMilestone);
            this.Controls.Add(this.NameMilestoneLabel);
            this.Controls.Add(this.NameMilestoneBox);
            this.Controls.Add(this.ProgsOnlabel);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.AllTimelistBox);
            this.Controls.Add(this.AllTimelabel);
            this.Controls.Add(this.ProgslistBox);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.ScreenTimelabel);
            this.Controls.Add(this.ChooseWaybutton);
            this.Controls.Add(this.Waylabel);
            this.Controls.Add(this.ScreensPathTextBox);
            this.Controls.Add(this.StartTimeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Work_Tracker";
            this.Text = "Work Time Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartTimeButton;
        private System.Windows.Forms.TextBox ScreensPathTextBox;
        private System.Windows.Forms.Label Waylabel;
        private System.Windows.Forms.Button ChooseWaybutton;
        private System.Windows.Forms.Label ScreenTimelabel;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ListBox ProgslistBox;
        private System.Windows.Forms.Label AllTimelabel;
        private System.Windows.Forms.ListBox AllTimelistBox;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label ProgsOnlabel;
        private System.Windows.Forms.TextBox NameMilestoneBox;
        private System.Windows.Forms.Label NameMilestoneLabel;
        private System.Windows.Forms.Button buttonCreateMilestone;
        private System.Windows.Forms.Button buttonDoneMilestone;
        private System.Windows.Forms.Label MilestonesLabel;
        private System.Windows.Forms.ListView MilestoneListBox;
    }
}

