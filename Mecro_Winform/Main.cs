﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecro_Winform
{
    public partial class Main : Form
    {

        // 마우스 이벤트 dll 
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;      // The left button is down.
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;        // The left button is up.


        int timeMecro;
        int timeX_YPostion;
        string _message;
        string _countMessage;
        string _Regex { get; set; }

        Setting SettingMenu;
        /*        public string[] SaveMainFormNumber
                {
                    get;
                    set;
                }*/
        public string[] ExcutePosition
        {
            get;
            set;


        }


        public delegate void TextEventHandler(string text);
        public event TextEventHandler WriteTextEvent; //Setting 폼에서 전달할 이벤트 핸들러


        public Main()
        {
           InitializeComponent();
           pointListView.View = View.Details; // 디자인에 디테일 뷰 추가
           SettingMenu = new Setting();
            _message = "시간초를 입력해주세요";
            _countMessage = "횟수를 입력해주세요";
             _Regex = "^[0-9]{1,5}$"; // 숫자 0~9까지 1자리부터 5자리까지 ( ^시작 $종료)
           // _Regex = @"\b[0-9]{5}\b"; ; // 숫자 0~9까지 무조건 5자리 (b는 경계자리?)
                                        
            // CheckRegex("");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // 단축키 오버라이드
        {
            // if  (keyData == (Keys.Control | Keys.F))
            if  (keyData == (Keys.F2))
            {
                MessageBox.Show("실시간 좌표가 설정되었습니다");
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
            if (keyData == (Keys.F4))
            {
                ExcueteSavePointMecro();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData); // 부모 호출
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timerX_YPostion.Start();
            timmerbox.Text = _message;
            TextboxiterationsCount.Text = _countMessage;
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
                SettingMenu.MainForm = this; // 자식객체의 Form1 savePointPopup (부모선언) 변수에 Form1(부모) 객체를 넣음 (Setting에서 다시 객체생성을 하지않아도 됨)
                SettingMenu.ShowDialog(); // 설정창 팝업 호출
        }
   
        private void ExcueteSavePointMecro() // 저장된 좌표와 시간초로 타이머 실행 버튼
        {
            string inputtimmer = timmerbox.Text;
            // int iterationsCount = Int32.Parse(TextboxiterationsCount.Text);
            string iterationsText = TextboxiterationsCount.Text;
            int SystemCount = 0;
            if (timmerbox.Text.Equals("") || timmerbox.Text.Equals(_message))
            {
                MessageBox.Show("시간초를 입력해주세요");
                // timmerbox.GotFocus += new EventHandler(timmerbox_Enter);
                timmerbox.Focus(); //     private void timmerbox_Enter(object sender, EventArgs e)를 호출함

            }
            else if(!CheckRegex(inputtimmer))
            {
                MessageBox.Show("시간초를 1~4까지 숫자로 입력해주세요");
            }
            else if (iterationsText.Equals("") || iterationsText.Equals(_countMessage))
            {
                MessageBox.Show("횟수를 입력해주세요");

            }
            else if (!CheckRegex(iterationsText))
            {
                MessageBox.Show("횟수를 1~4까지 입력해주세요");

            }
            else
            {
                MessageBox.Show("매크로를 시작합니다!");
                int iterationsCount = Int32.Parse(iterationsText);

                timerX_YPostion.Stop();// 기존 좌표찍는 타이머는 중단 (콘솔 표시 + 좌표실시간 타이머)

     


                TimeSpan time = TimeSpan.FromSeconds(Int32.Parse(inputtimmer));
                // 문자들어올경우 예외처리 함수로 할것

                bool status = true;
                while (status)
                {
                    for (int i = 0; i < ExcutePosition.Length; i++)
                    {
                        Thread.Sleep(time);
                        Console.WriteLine("저장좌표 SystemCount 시작 : " + SystemCount++);
                        Console.WriteLine("저장좌표 iterationsCount 횟수 : " + iterationsCount);
                        Console.WriteLine("저장좌표 리스트 : " + ExcutePosition[i]);

      
                        string[] X_Y_point = ExcutePosition[i].Split(',');
                        

                        #region 좌표 실행
                        Cursor.Position = new Point(Int32.Parse(X_Y_point[0]), Int32.Parse(X_Y_point[1]));// 지정한 곳으로 커서 보내기
                                                                                                    
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0); // 왼쪽클릭
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0); // 버튼때기
                        #endregion


                        if (i == ExcutePosition.Length)
                        {
                            i = 0;
                        }

                        if (SystemCount >= iterationsCount)
                        {
                            MessageBox.Show("매크로를 자동정지 합니다");
                            status = false;
                            SystemCount = 0;
                        }
                    }
                }
            

            }
        }

        private bool CheckRegex (string text){

            Regex rgx = new Regex(_Regex);
            bool result = rgx.IsMatch(text);
            return result;
        }
        private void ExcuteSavePoint_Click(object sender, EventArgs e) // point listview 에 저장된 좌표 실행
        {
            int length = pointListView.Items.Count;
            ExcutePosition = new string[length];

            if (length > 0)
            {
                    for (int i = 0; i < length; i++) {
                        ExcutePosition[i] = pointListView.Items[i].SubItems[1].Text; // SubItems[1]의 1은 2번째 컬럼 부분임 (순서, 좌표) 중 좌표

                    }
                ExcueteSavePointMecro();
            }
            else
            {
                MessageBox.Show("좌표를 입력해주세요");
                SettingMenu.MainForm = this; // 자식객체의 Form1 savePointPopup (부모선언) 변수에 Form1(부모) 객체를 넣음 (Setting에서 다시 객체생성을 하지않아도 됨)
                SettingMenu.ShowDialog(); // 설정창 팝업 호출
            }

        }

       

        private void ClickTimmerTextBox(object sender, MouseEventArgs e)
        {
            if (timmerbox.Text.Equals("") || timmerbox.Equals(_message))
                timmerbox.Text = "";
        }

        private void timmerbox_Enter(object sender, EventArgs e)
        {
            timmerbox.Text = "";
        }
    }

    public class ThresholdReachedEventArgs : EventArgs // 조만간 값 전달 목적 연습으로 사용할 이벤트 핸들러 
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

}
