using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Diagnostics;
namespace OP_project_v2
{
    public partial class Work_Tracker : Form
    {
        public Work_Tracker()
        {
            InitializeComponent();
            // делаем невидимой нашу иконку в трее
            notifyIcon.Visible = false;
            // добавляем Эвент или событие по 2му клику мышки, 
            //вызывая функцию  notifyIcon1_MouseDoubleClick
            notifyIcon.MouseDoubleClick += new MouseEventHandler(NotifyIcon_MouseDoubleClick);
            // добавляем событие на изменение окна
            this.Resize += new EventHandler(this.Form1_Resize);
        }
        string screenshotPath;
        int interval = 1;
        string programName;
        float scale;
        int width;
        int height;
        TimeSpan time;
        public void ScreenSaver(object sender, EventArgs e)
        {
            programName = GetActiveWindowTitle();
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            scale = getScalingFactor();
            width = Convert.ToInt32(resolution.Width * scale);
            height = Convert.ToInt32(resolution.Height * scale);
            var bounds = Screen.GetBounds(new Point(0, 0));
            var bmp = new Bitmap(width, height);
            using (var g = Graphics.FromImage(bmp))
                g.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            bmp.Save(ScreensPathTextBox.Text + string.Format("{0} {1:dd.MM.yyyy-HH.mm.ss}.png", programName, DateTime.Now), ImageFormat.Png);
        }
        //GetWindowTitle
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        Stopwatch swatch = new Stopwatch();
        public void TimerStartButtonClick(object sender, EventArgs e)
        {
            if (IntervalTextBox.Text != "")
            {
                interval = int.Parse(IntervalTextBox.Text);
            }
            Timer screentime = new Timer(TimeSpan.FromMinutes(interval).TotalMilliseconds);
            screentime.AutoReset = true;
            screentime.Elapsed += new ElapsedEventHandler(ScreenSaver);
            screentime.Start();
            swatch.Start();
            Timer t = new Timer(1000); // 1 sec = 1000, 60 sec = 60000
            t.AutoReset = true;
            t.Elapsed += new ElapsedEventHandler(ListOfPrograms);
            t.Start();
            WindowState = FormWindowState.Minimized;
        }
        private void ListOfPrograms(object sender, ElapsedEventArgs e)
        {
            List<string> itemsToAdd = new List<string>();
            programName = GetActiveWindowTitle();
            itemsToAdd.Add(programName);
            Action<string> updateList = (programName) =>
            {
                if (string.IsNullOrEmpty(programName)) return;
                if (!ProgslistBox.Items.Contains(programName))
                {
                    ProgslistBox.Items.Add(programName);
                }
            };
            if (InvokeRequired)
                Invoke(updateList, programName);
            else
                updateList(programName);  
        }
        private void SelectFolderButtonClick(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)  
            {
                string screenshotPath = folderBrowserDialog1.SelectedPath;
                ScreensPathTextBox.Text = screenshotPath + '\\';
            }
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon.Visible = false;
            // возвращаем отображение окна в панели
            this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon.Visible = true;
            }
        }
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,
        }
        private float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);
            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;
            return ScreenScalingFactor; // 1.25 = 125%
        }
        private void Form1_Load(object sender, EventArgs e){}
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void button3_Click(object sender, EventArgs e)
        {
            swatch.Stop();
            AllTimelistBox.Items.Add(swatch.Elapsed.ToString("hh\\:mm\\:ss"));
            ScreenSaver(sender, e);
        }
        string milestone;
        private void buttonCreateMilestone_Click(object sender, EventArgs e)
        {
            milestone = NameMilestoneBox.Text;
            MilestoneListBox.Items.Add(milestone);
        }
        private void buttonDoneMilestone_Click(object sender, EventArgs e)
        {
            if (MilestoneListBox.SelectedItems.Count > 0)
            {
                MilestoneListBox.SelectedItems[0].BackColor = Color.LightGreen;
            }
        }
    }
}