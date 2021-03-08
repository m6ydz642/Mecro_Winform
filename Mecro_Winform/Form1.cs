using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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


        int timeMecro;
        int timeX_YPostion;

    public List<TextBox> test
        {
            get;
            set;
        } 
        
        public Form1()
        {
            InitializeComponent();
           pointListView.View = View.Details; // 디자인에 디테일 뷰 추가

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

            if (keyData == (Keys.F3))
            {
                MessageBox.Show("매크로가 시작되었습니다");
                pressF3_Key(); // 마우스 좌표 고정 호출
                return true;
            }

            if (keyData == (Keys.F1))
            {
                timerMecro.Stop(); // 매크로는 중지하고 좌표설정 타이머는 작동
                timerX_YPostion.Start();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData); // 부모 호출
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timerX_YPostion.Start();
         
        }

        private void stopTimer_Click(object sender, EventArgs e) // 매크로 중지
        {


            timerMecro.Stop(); // 매크로는 중지하고 좌표설정 타이머는 작동
            timerX_YPostion.Start();
            MessageBox.Show("매크로가 중단되었습니다");
            
        }

        private void exeute_Click(object sender, EventArgs e) // 실행
        {
            pressF3_Key();
        }

        private void timerX_YPostion_Tick(object sender, EventArgs e) // 좌표 실시간 타이머 작동
        {
            xlabel.Text = Cursor.Position.X.ToString(); // 마우스 좌표 표시
            ylabel.Text = Cursor.Position.Y.ToString();
            timeX_YPostion++;
            Console.WriteLine("timerX_YPostion : " + timeX_YPostion);


        }

        private void savePoint_Click(object sender, EventArgs e)
        {
            pressF2_Key(); // 마우스 좌표 고정 함수 호출

        }

        private void pressF3_Key()
        {
            timerX_YPostion.Stop(); // 좌표 표시하던 타이머는 멈춤 

            // 해당 좌표로 마우스 이동
            getMousePointAction();

            timerMecro.Start(); // 실행시 타이머 시작, 좌표 실시간으로 움직이게 할꺼 
            
                Thread.Sleep(300);
                SendKeys.Send(textBox.Text); // 텍스트박스 속의 메시지 전송
            
        }
        private void pressF2_Key()
        {
           
            saveX_Point.Text = Cursor.Position.X.ToString(); // 마우스 좌표 고정
            saveY_Point.Text = Cursor.Position.Y.ToString();
           
        }

        private void timerMecro_Tick(object sender, EventArgs e) // 매크로 시작 타이머
        {
            

            timeMecro++; // 매크로가 작동하면서 ++처리함 
            // 타이머가 일정시간 이상 되었을때 다른 버튼클릭같은 이벤트 하면 됨
            Console.WriteLine("timeMecro : " + timeMecro);
          
            if (timeMecro >= 20) // 약 7초 정도
            {
                Console.WriteLine(timeMecro + " 재시작");
                timeMecro = 0;
                /*********************************************************/
                getMousePointAction();
                /*********************************************************/
                for (int i = textBox.Text.Length; i >= 0; i--)
                {                                           // 텍스트 길이만큼 삭제
                    SendKeys.SendWait("{BKSP}"); // backspace
                    // 회사컴퓨터에서는 send가 안되서 sendwait로 함 (키보드 키 전송 보안문제같음)
                    Thread.Sleep(100); 
                }


                SendKeys.Send(textBox.Text); // 텍스트박스 속의 메시지 전송
            }
        }

        private void getMousePointAction()
        {
            // 좌표에 저장된 값 다시 가져오기
            Cursor.Position = new Point(Int32.Parse(saveX_Point.Text), Int32.Parse(saveY_Point.Text));// 지정한 곳으로 커서 보내기
                                                                                                      // string으로 변환함   
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // 왼쪽클릭
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // 버튼때기
        }

        private void stripmenuSetting_Click(object sender, EventArgs e) // 파일 -> 설정
        {
            Setting settingMenu = new Setting();
            settingMenu.savePointText = this; // 자식객체의 savePointText변수에 Form1(부모) 객체를 넣음
            settingMenu.ShowDialog(); // 설정 팝업 호출
            settingMenu.ShowDialog(); // 설정 호출
        }
    }
}
