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
using System.Collections;

namespace Aidana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct OSVERSIONINFOEX
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
            public UInt16 wServicePackMajor;
            public UInt16 wServicePackMinor;
            public UInt16 wSuiteMask;
            public byte wProductType;
            public byte wReserved;

        }
        public enum SystemMetric
        {
            SM_CXSCREEN = 0,  // 0x00
            SM_CYSCREEN = 1,  // 0x01
            SM_CXVSCROLL = 2,  // 0x02
            SM_CYHSCROLL = 3,  // 0x03
            SM_CYCAPTION = 4,  // 0x04
            SM_CXBORDER = 5,  // 0x05
            SM_CYBORDER = 6,  // 0x06
            SM_CXDLGFRAME = 7,  // 0x07
            SM_CXFIXEDFRAME = 7,  // 0x07
            SM_CYDLGFRAME = 8,  // 0x08
            SM_CYFIXEDFRAME = 8,  // 0x08
            SM_CYVTHUMB = 9,  // 0x09
            SM_CXHTHUMB = 10, // 0x0A
            SM_CXICON = 11, // 0x0B
            SM_CYICON = 12, // 0x0C
            SM_CXCURSOR = 13, // 0x0D
            SM_CYCURSOR = 14, // 0x0E
            SM_CYMENU = 15, // 0x0F
            SM_CXFULLSCREEN = 16, // 0x10
            SM_CYFULLSCREEN = 17, // 0x11
            SM_CYKANJIWINDOW = 18, // 0x12
            SM_MOUSEPRESENT = 19, // 0x13
            SM_CYVSCROLL = 20, // 0x14
            SM_CXHSCROLL = 21, // 0x15
            SM_DEBUG = 22, // 0x16
            SM_SWAPBUTTON = 23, // 0x17
            SM_CXMIN = 28, // 0x1C
            SM_CYMIN = 29, // 0x1D
            SM_CXSIZE = 30, // 0x1E
            SM_CYSIZE = 31, // 0x1F
            SM_CXSIZEFRAME = 32, // 0x20
            SM_CXFRAME = 32, // 0x20
            SM_CYSIZEFRAME = 33, // 0x21
            SM_CYFRAME = 33, // 0x21
            SM_CXMINTRACK = 34, // 0x22
            SM_CYMINTRACK = 35, // 0x23
            SM_CXDOUBLECLK = 36, // 0x24
            SM_CYDOUBLECLK = 37, // 0x25
            SM_CXICONSPACING = 38, // 0x26
            SM_CYICONSPACING = 39, // 0x27
            SM_MENUDROPALIGNMENT = 40, // 0x28
            SM_PENWINDOWS = 41, // 0x29
            SM_DBCSENABLED = 42, // 0x2A
            SM_CMOUSEBUTTONS = 43, // 0x2B
            SM_SECURE = 44, // 0x2C
            SM_CXEDGE = 45, // 0x2D
            SM_CYEDGE = 46, // 0x2E
            SM_CXMINSPACING = 47, // 0x2F
            SM_CYMINSPACING = 48, // 0x30
            SM_CXSMICON = 49, // 0x31
            SM_CYSMICON = 50, // 0x32
            SM_CYSMCAPTION = 51, // 0x33
            SM_CXSMSIZE = 52, // 0x34
            SM_CYSMSIZE = 53, // 0x35
            SM_CXMENUSIZE = 54, // 0x36
            SM_CYMENUSIZE = 55, // 0x37
            SM_ARRANGE = 56, // 0x38
            SM_CXMINIMIZED = 57, // 0x39
            SM_CYMINIMIZED = 58, // 0x3A
            SM_CXMAXTRACK = 59, // 0x3B
            SM_CYMAXTRACK = 60, // 0x3C
            SM_CXMAXIMIZED = 61, // 0x3D
            SM_CYMAXIMIZED = 62, // 0x3E
            SM_NETWORK = 63, // 0x3F
            SM_CLEANBOOT = 67, // 0x43
            SM_CXDRAG = 68, // 0x44
            SM_CYDRAG = 69, // 0x45
            SM_SHOWSOUNDS = 70, // 0x46
            SM_CXMENUCHECK = 71, // 0x47
            SM_CYMENUCHECK = 72, // 0x48
            SM_SLOWMACHINE = 73, // 0x49
            SM_MIDEASTENABLED = 74, // 0x4A
            SM_MOUSEWHEELPRESENT = 75, // 0x4B
            SM_XVIRTUALSCREEN = 76, // 0x4C
            SM_YVIRTUALSCREEN = 77, // 0x4D
            SM_CXVIRTUALSCREEN = 78, // 0x4E
            SM_CYVIRTUALSCREEN = 79, // 0x4F
            SM_CMONITORS = 80, // 0x50
            SM_SAMEDISPLAYFORMAT = 81, // 0x51
            SM_IMMENABLED = 82, // 0x52
            SM_CXFOCUSBORDER = 83, // 0x53
            SM_CYFOCUSBORDER = 84, // 0x54
            SM_TABLETPC = 86, // 0x56
            SM_MEDIACENTER = 87, // 0x57
            SM_STARTER = 88, // 0x58
            SM_SERVERR2 = 89, // 0x59
            SM_MOUSEHORIZONTALWHEELPRESENT = 91, // 0x5B
            SM_CXPADDEDBORDER = 92, // 0x5C
            SM_DIGITIZER = 94, // 0x5E
            SM_MAXIMUMTOUCHES = 95, // 0x5F

            SM_REMOTESESSION = 0x1000, // 0x1000
            SM_SHUTTINGDOWN = 0x2000, // 0x2000
            SM_REMOTECONTROL = 0x2001, // 0x2001


            SM_CONVERTIBLESLATEMODE = 0x2003,
            SM_SYSTEMDOCKED = 0x2004,
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct SYSTEMTIME
        {
            [MarshalAs(UnmanagedType.U2)] public short Year;
            [MarshalAs(UnmanagedType.U2)] public short Month;
            [MarshalAs(UnmanagedType.U2)] public short DayOfWeek;
            [MarshalAs(UnmanagedType.U2)] public short Day;
            [MarshalAs(UnmanagedType.U2)] public short Hour;
            [MarshalAs(UnmanagedType.U2)] public short Minute;
            [MarshalAs(UnmanagedType.U2)] public short Second;
            [MarshalAs(UnmanagedType.U2)] public short Milliseconds;

            public SYSTEMTIME(int y, DateTime dt)
            {
                dt = dt.ToUniversalTime();  // SetSystemTime expects the SYSTEMTIME in UTC
                Year = (short)dt.Year;
                Month = (short)dt.Month;
                DayOfWeek = (short)dt.DayOfWeek;
                Day = (short)dt.Day;
                Hour = (short)dt.Hour;
                Minute = (short)dt.Minute;
                Second = (short)dt.Second;
                Milliseconds = (short)dt.Millisecond;
            }
        }


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct TIME_ZONE_INFORMATION
        {
            internal Int32 Bias;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            internal String StandardName;
            internal SYSTEMTIME StandardDate;
            internal Int32 StandardBias;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            internal String DaylightName;
            internal SYSTEMTIME DaylightDate;
            internal Int32 DaylightBias;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetMessageTime();
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetOEMCP();

        [DllImport("Kernel32")]
        static extern unsafe bool GetComputerName(byte* lpBuffer, long* nSize);
        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool GetUserName(System.Text.StringBuilder sb, ref Int32 length);
        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr handle);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hwnd, ref Point lpPoint);
        [DllImport("user32.dll")]
        static extern bool SetSysColors(int cElements, int[] lpaElements,
   int[] lpaRgbValues);

        [DllImport("kernel32.dll")]
        static extern uint GetSystemDirectory([Out] StringBuilder lpBuffer, uint uSize);
        [DllImport("kernel32")]
        static extern bool GetVersionEx(ref OSVERSIONINFOEX osvi);
        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(SystemMetric smIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, StringBuilder pvParam, int fWinIni);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref uint pvParam, int fWinIni);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern int GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation);
        [DllImport("kernel32.dll")]
        static extern void GetLocalTime(out SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        static extern void GetSystemTime(ref SYSTEMTIME lpSystemTime);


        [DllImport("kernel32.dll", SetLastError = true)]
        private extern static uint SetSystemTime(ref SYSTEMTIME systime);
        //   [DllImport("kernel32.dll", SetLastError = true)]
        //public static extern bool SetSystemTime(ref SYSTEMTIME theDateTime);


        [DllImport("user32.dll")]
        static extern uint GetSysColor(int nIndex);
        [DllImport("user32.dll")]
        static extern uint GetDoubleClickTime();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ClipCursor(ref uint lpRect);




        // Объявление API-функции.

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern System.IntPtr GetCommandLine();



        [DllImport("user32", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern int GetKeyNameTextW(uint lParam, StringBuilder lpString,
 int nSize);

        [DllImport("user32.dll")]
        static extern int MessageBeep(int uType);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetKeyboardType(int value);




        [DllImport("user32.dll")]
        static extern bool SwapMouseButton(bool fSwap);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private unsafe void label6_Click(object sender, EventArgs e)
        {

        }

        unsafe private void button1_Click(object sender, EventArgs e)
        {
            byte[] buffor = new byte[512];
            long sizeNameComputer = buffor.Length;
            long* pSize = &sizeNameComputer;
            fixed (byte* pBuffor = buffor)
            {
                GetComputerName(pBuffor, pSize);
            }
            System.Text.Encoding textEnc = new System.Text.ASCIIEncoding();
            label1.Text = "Имя ПК:" + textEnc.GetString(buffor);


            StringBuilder BufferUserName = new StringBuilder(512);
            int sizeUserName = 512;
            GetUserName(BufferUserName, ref sizeUserName);
            label2.Text = "имя пользователя:   " + BufferUserName;

            StringBuilder sbSystemDir = new StringBuilder(256);
            uint sizePathSystemDir = 256;
            GetSystemDirectory(sbSystemDir, sizePathSystemDir);
            label3.Text = "Системная директория" + sbSystemDir;


            OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX();
            osVersionInfo.dwOSVersionInfoSize = (int)(uint)Marshal.SizeOf(osVersionInfo);
            GetVersionEx(ref osVersionInfo);
            label4.Text = "Версия ОС: " + osVersionInfo.dwBuildNumber;


            switch (GetSystemMetrics(SystemMetric.SM_CLEANBOOT))
            {
                case 0:
                    label5.Text = "Тип загрузки: " + "Normal boot";
                    break;
                case 1:
                    label5.Text = "Тип загрузки: " + "fail safe boot";
                    break;
                case 2:
                    label5.Text = "Пип загрузки: " + "fail safe boot with network";
                    break;
            }
            label6.Text = "Разрешение монитора: " + GetSystemMetrics(SystemMetric.SM_CXSCREEN) + "X" + GetSystemMetrics(SystemMetric.SM_CYSCREEN);
            label7.Text = "Ширина Курсора: " + GetSystemMetrics(SystemMetric.SM_CXCURSOR);


            StringBuilder pathWallapper = new StringBuilder(1024);
            const uint SPI_GETDESKWALLPAPER = 0x0073;
            SystemParametersInfo(SPI_GETDESKWALLPAPER, 1024, pathWallapper, 0);
            label8.Text = "Путь к обою рабочего стола: " + pathWallapper;

            const uint SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;
            uint contrast = 0;
            SystemParametersInfo(SPI_GETFONTSMOOTHINGCONTRAST, 0, ref contrast, 0);
            label9.Text = "Контрастность: " + contrast;

            const uint SPI_GETMOUSESPEED = 0x0070;
            uint speed = 0;
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, ref speed, 0);

            label10.Text = "Скoрость мыши: " + speed;


            const int COLOR_WINDOW = 5;
            int color1 = Convert.ToInt32(GetSysColor(COLOR_WINDOW));
            Color color = Color.FromArgb(color1 & 0xFF, (color1 & 0xFF) >> 8, (color1 & 0xFF000) >> 16);
            label11.Text = "COLOR_WINDOW " + "[R=" + color.R + " G= " + color.G + " B= " + color.B + "]";



            const int COLOR_INFOTEXT = 23;
            int color2 = Convert.ToInt32(GetSysColor(COLOR_INFOTEXT));
            Color color3 = Color.FromArgb(color2 & 0xFF, (color2 & 0xFF) >> 8, (color2 & 0xFF000) >> 16);
            label12.Text = "COLOR_INFOTEXT    " + "[R=" + color3.R + " G= " + color3.G + " B= " + color3.B + "]";

            const int COLOR_BACKGROUND = 1;
            int color4 = Convert.ToInt32(GetSysColor(COLOR_BACKGROUND));
            Color color5 = Color.FromArgb(color4 & 0xFF, (color4 & 0xFF) >> 8, (color4 & 0xFF000) >> 16);
            label13.Text = "COLOR_BACKGROUND   " + "[R=" + color5.R + " G= " + color5.G + " B= " + color5.B + "]";


            SYSTEMTIME ltime;
            GetLocalTime(out ltime);
            label14.Text = "Местное время:  Дата: " + ltime.Day + " / " + ltime.Month + " / " + ltime.Year + " /  Время: " + ltime.Hour + ":" + ltime.Minute;


            TIME_ZONE_INFORMATION time1 = new TIME_ZONE_INFORMATION();
            GetTimeZoneInformation(out time1);
            label15.Text = "Информация о часовом поясе:  Дата: " + time1.DaylightName + " / " + " /  Время: " + ltime.Hour + ":" + ltime.Minute + " /  ЧП: " + time1.DaylightBias;


            SYSTEMTIME systemtime = new SYSTEMTIME();
            GetSystemTime(ref systemtime);
            label24.Text = "SystemTime : "+ systemtime.Day.ToString() + "." + systemtime.Month.ToString() + "." + systemtime.Year.ToString() + "    " + systemtime.Hour.ToString() + ":" + systemtime.Minute.ToString() ;





            /*
                        System.IntPtr ptr = GetCommandLine();

                        label23.Text = "GetCommandLine:   " + Marshal.PtrToStringAuto(ptr);

                        label24.Text = "MessageBeep:  " + MessageBeep(-1).ToString();

                        label25.Text = "SwapMouseButton: " + SwapMouseButton(true).ToString();

                        int function = GetKeyboardType(2);
                        label26.Text = "GetKeyboardType:  " + function.ToString();
            */







            /*   this.Cursor = new Cursor(Cursor.Current.Handle);
               Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
               Cursor.Clip = new Rectangle(this.Location, this.Size);*/
            //  label16.Text = "Координаты Курсора: " + Cursor.Clip;
            System.IntPtr ptr = GetCommandLine();

            label16.Text = "GetCommandLine:   " + Marshal.PtrToStringAuto(ptr);
           

            label17.Text = "MessageBeep:  " + MessageBeep(-1).ToString();

            label18.Text = "SwapMouseButton: " + SwapMouseButton(true).ToString();

            int function = GetKeyboardType(2);
            label19.Text = "GetKeyboardType:  " + function.ToString();



           // var doubleClickTime = GetDoubleClickTime();
            //label17.Text = "максимальное вpемя между двумя щелчками мыши: " + doubleClickTime;

           // long getmes = GetMessageTime();
          //  label18.Text = "Время последнего уведомления: " + getmes;
          //  long get = GetOEMCP();
           // label19.Text = "(OEM)для операционной системы: " + get;



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color inColor = Color.FromArgb(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            const int COLOR_INFOTEXT = 23; 
            int[] elements = { COLOR_INFOTEXT };
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(inColor) };
            SetSysColors(elements.Length, elements, colors );


        }


      



        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color inColor = Color.FromArgb(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            const int COLOR_BACKGROUND = 1; ;
            int[] elements = { COLOR_BACKGROUND };
     
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(inColor) };
            SetSysColors(elements.Length, elements, colors);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color inColor = Color.FromArgb(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
            const int COLOR_WINDOW = 5;
            int[] elements = { COLOR_WINDOW };
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(inColor) };
            SetSysColors(elements.Length, elements, colors);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Y = int.Parse(textBox1.Text);
            int M = int.Parse(textBox2.Text);
            int D = int.Parse(textBox12.Text);
            int H = int.Parse(textBox13.Text);
            int m = int.Parse(textBox14.Text);
            int s = int.Parse(textBox15.Text);
            SYSTEMTIME st = new SYSTEMTIME();
            st.Day = (short)D;

            st.Hour = (short)H;

            st.Minute = (short)m;
            st.Month = (short)M;
            st.Second = (short)s;
            st.Year = (short)Y;
            
            SetSystemTime(ref st);


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
