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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // 단축키 오버라이드
        {
            // if  (keyData == (Keys.Control | Keys.F))
            if  (keyData == (Keys.F2))
            {
                MessageBox.Show("좌표가 설정되었습니다");
                pressF2_Key(); // 마우스 좌표 고정 호출
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData); // 부모 호출
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer_Click(object sender, EventArgs e) // 자동실행
        {


            // this.textBox.Focus();
           

        }

        private void exeute_Click(object sender, EventArgs e) // 실행
        {
            Cursor.Position = new Point(Int32.Parse(saveX_Point.Text), Int32.Parse(saveY_Point.Text));// 지정한 곳으로 커서 보내기
                        // string으로 변환함   
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // 왼쪽클릭
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // 버튼때기
            SendKeys.Send(textBox.Text); // 텍스트박스 속의 메시지 전송
            timer1.Start(); // 실행시 타이머 시작, 좌표 실시간으로 움직이게 할꺼 
        }

        private void timer1_Tick(object sender, EventArgs e) // 타이머 작동
        {
            ylabel.Text = Cursor.Position.X.ToString(); // 마우스 좌표 표시
            xlabel.Text = Cursor.Position.Y.ToString();
            
            
            time++; // 작동하면서 ++처리함 
            // 타이머가 일정시간 이상 되었을때 다른 버튼클릭같은 이벤트 하면 됨
            Console.WriteLine("timmer : " + time);

            if (time >= 20) // 약 7초 정도
            {
                Console.WriteLine(time + " 재시작");
                time = 0;
                /*********************************************************/
                // 좌표에 저장된 값 다시 가져오기
                Cursor.Position = new Point(Int32.Parse(saveX_Point.Text), Int32.Parse(saveY_Point.Text));// 지정한 곳으로 커서 보내기
                                                                                                          // string으로 변환함   
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // 왼쪽클릭
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // 버튼때기
                /*********************************************************/
                for (int i=0; i<textBox.Text.Length; i++)  // 텍스트 길이만큼 삭제
                    SendKeys.Send("{BKSP}"); // backspace
         
                
                SendKeys.Send(textBox.Text); // 텍스트박스 속의 메시지 전송
            }
        }

        private void savePoint_Click(object sender, EventArgs e)
        {
            pressF2_Key(); // 마우스 좌표 고정 함수 호출

        }

        private void pressF2_Key()
        {
           
            saveX_Point.Text = Cursor.Position.X.ToString(); // 마우스 좌표 고정
            saveY_Point.Text = Cursor.Position.Y.ToString();
           
        }
    }
}
