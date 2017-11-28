using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;


namespace KeyLocker
{
    public partial class Hook : Form
    {

        private Settings settings;
        public Hook()
        {
            InitializeComponent();
        }

        public Hook(Form form) : this()
        {
            this.settings = form as Settings;
        }


        // ... { GLOBAL HOOK }
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);
        

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_MOUSE_LL = 14;
        const int WH_KEYBOARD_LL = 13; // Номер глобального LowLevel-хука на клавиатуру

        const int WM_KEYDOWN = 0x100; // Сообщения нажатия клавиши
        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;
        const int WM_MOUSEMOVE = 0x0200;
        const int WM_MOUSEWHEEL = 0x020A;
        const int WM_RBUTTONDOWN = 0x0204;
        const int WM_RBUTTONUP = 0x0205;

        const int VK_ESC = 0x1B;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr khook= IntPtr.Zero;
        private static IntPtr mhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            khook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
            mhook = SetWindowsHookEx(WH_MOUSE_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(khook);
            UnhookWindowsHookEx(mhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && (wParam == (IntPtr)WM_KEYDOWN ||
                wParam == (IntPtr)WM_LBUTTONDOWN ||
                wParam == (IntPtr)WM_LBUTTONUP ||
                wParam == (IntPtr)WM_MOUSEMOVE ||
                wParam == (IntPtr)WM_MOUSEWHEEL ||
                wParam == (IntPtr)WM_RBUTTONDOWN ||
                wParam == (IntPtr)WM_RBUTTONUP))
            {

                int vkCode = Marshal.ReadInt32(lParam);
                switch(vkCode)
                {
                    case VK_ESC:
                        UnHook();
                        break;
                }
                return (IntPtr)1;
            }
            else
                return CallNextHookEx(khook, code, (int)wParam, lParam);
        }

        private void Hook_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UnHook();
            this.notifyIcon1.Visible = false;
        }

        private void Hook_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
            this.ShowInTaskbar = false;
            
            this.Visible = false;
            
            this.notifyIcon1.Visible = true;

            notifyIcon1.ContextMenuStrip = notifyMenuStrip;

            SetHook();
        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnHook();

            settings.Visible = true;
            settings.WindowState = FormWindowState.Normal;
            settings.Show();

            this.notifyIcon1.Visible = true;
            this.Visible = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void 실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetHook();
        }
    }

}
