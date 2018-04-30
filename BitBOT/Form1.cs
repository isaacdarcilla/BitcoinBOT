using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using MetroFramework.Forms;

namespace BitBOT
{
    public partial class Form1 : MetroForm
    {
        //mouse event constants
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHT_UP = 16;
        //input type constant
        const int INPUT_MOUSE = 0;

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

        Point clickLocation;
        public Form1()
        {
            InitializeComponent();
            this.ArbitraryLocation.Text = clickLocation.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            About click = new About();
            click.ShowDialog();
        }

        private void SetPoint_Click(object sender, EventArgs e)
        {
            Timer.Interval = 5000;
            Timer.Start();
        }

     

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 129 && panel1.Width == 133)
            {
                panel1.Height = 1;
                panel1.Width = 133;
            }
            else
            {

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.SendToBack();
            //StopButton.BringToFront();

            if (RadioSeconds.Checked)
            {
                Timer2.Interval = Convert.ToInt32(Time_TextBox.Text);
            }
            else
            {
                Timer2.Interval = Convert.ToInt32(Time_TextBox.Text) * 10000;
            }
            //Start mine
            Timer2.Start();


            if (panel1.Height == 1 && panel1.Width == 133)
            {
                panel1.Height = 129;
                panel1.Width = 133;
            }
            else
            {

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            clickLocation = Cursor.Position;
            this.ArbitraryLocation.Text = clickLocation.ToString();
            Timer.Stop();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            //set cursor position to memorized location
            Cursor.Position = clickLocation;
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0; //clickLocation.X;
            i.mi.dy = 0; // clickLocation.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }
        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        private void StopButton_Click(object sender, EventArgs e)
        {
            StartButton.BringToFront();
            Timer2.Stop();
        }
    }
}
