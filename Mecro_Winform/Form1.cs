using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecro_Winform
{
    public partial class Form1 : Form
    {

        // 마우스 이벤트 dll 
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;      // The left button is down.
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;        // The left button is up.


        int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // 타이머 시작하게해서 좌표 실시간으로 움직이게 할꺼
      

        }

        private void timer_Click(object sender, EventArgs e) // 자동실행
        {

         
            // this.textBox.Focus();
           

        }

        private void exeute_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Int32.Parse(saveX_Point.Text), Int32.Parse(saveY_Point.Text));// 지정한 곳으로 커서 보내기
                        // string으로 변환함   
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // 왼쪽클릭
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // 버튼때기
            SendKeys.Send(textBox.Text);
        }

        private void timer1_Tick(object sender, EventArgs e) // 타이머 작동
        {
            ylabel.Text = Cursor.Position.X.ToString(); // 마우스 좌표 표시
            xlabel.Text = Cursor.Position.Y.ToString();
            
            
            time++; // 작동하면서 ++처리함 
            // 타이머가 일정시간 이상 되었을때 다른 버튼클릭같은 이벤트 하면 됨
            Console.WriteLine("timmer : " + time);
        }

        private void savePoint_Click(object sender, EventArgs e)
        {
            saveX_Point.Text = Cursor.Position.X.ToString(); // 마우스 좌표 고정
            saveY_Point.Text = Cursor.Position.Y.ToString();
       
        }
    }
}
