using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecro_Winform
{
    public partial class Setting : Form
    {
        int dynamicTextBoxCount;

        TextBox dynamicTextBox;
        public Form1 savePointText; // 부모창 선언
        // 부모창에서 객체를 가르켜 넣을거임

        public string savePointGetter
        {
            get;
            set;
        }
        public Setting()
        {
            InitializeComponent();
            dynamicTextBoxCount = 0;
        }

        private void savePoint_Click(object sender, EventArgs e)
        {
            pressF2_Key(); // 마우스 좌표 고정 함수 호출
        }

       
        private void pressF2_Key()
        {

            saveX_Point.Text = Cursor.Position.X.ToString(); // 마우스 좌표 고정
            saveY_Point.Text = Cursor.Position.Y.ToString();

            string value = dynamicTextBox.Name = "dynamicTextBox" + dynamicTextBoxCount;
            // 현재 카운트 되고있는 textbox 순서

            // if (dynamicTextBox.Focused) // 좌표추가할때 현재 포커스 여부만 등록되게해야 함
       
           
           this.dynamicTextBox.Text = saveX_Point.Text + "," + saveY_Point.Text; // 선택한 좌표저장
   
            dynamicTextBox.GotFocus += DynamicTextBox_GotFocus;


            List<TextBox> my = new List<TextBox>();

            string[] list = new string[dynamicTextBoxCount];

            my.Add(dynamicTextBox);
            for (int i = 0; i < dynamicTextBoxCount; i++)
            {
                list[i] = dynamicTextBox.Text;

           
            }
            savePointText.test = my;


        }

        private void DynamicTextBox_GotFocus(object sender, EventArgs e)
        {

            string value2 = dynamicTextBox.Name = "dynamicTextBox" + dynamicTextBoxCount;
                MessageBox.Show("클릭 : " + value2);
        }

    
        private void makePointArea_Click(object sender, EventArgs e) // 좌표 영역 추가 
        {
            int seq = 0;

            // 한꺼번에 추가할때 쓸거
            /*       TextBox[] dynamicTextBox = new TextBox[20];
                   for (int i=0; i< dynamicTextBox.Length; i++)
                   {
                       dynamicTextBox[i] = new TextBox();
                       dynamicTextBox[i].Location = new Point(0, i * 20);
                       dynamicTextBox[i].Size = new Size(100, 10);
                       dynamicTextBox[i].Name = "textbox" + i.ToString();
                       this.Controls.Add(dynamicTextBox[i]);
                   }*/

           dynamicTextBox  = new TextBox();
            Label dynamicLabel = new Label();
            dynamicTextBox.Size = new Size(80, 10); // Size가 받는 getter, setter 타입이 생성자임 
            // x, y 좌표 나눌려고 했었는데 사이즈 딱히 필요없게 됨
     


            dynamicTextBoxCount++; // 동적으로 생성할때마다 한개씩 증가
            dynamicTextBox.Location = new Point(35, 70 + dynamicTextBoxCount * 20); // Y좌표가 한칸당 20씩 늘어남
            dynamicLabel.Location = new Point(12, 70 + dynamicTextBoxCount * 20); // Y좌표가 한칸당 20씩 늘어남
                                                                                  // 35는 x, 70은 y 좌표, 동적생성시 70 + (1 * 20) =  90, 70 + (2 * 20) = 110 해서  20씩 증가하면서 아래로 내려감
            dynamicTextBox.Name = "dynamicTextBox" + dynamicTextBoxCount;
            
            this.Controls.Add(dynamicTextBox);
            dynamicTextBox.Focus(); // 포커스 주기

            dynamicLabel.Name = "label" + dynamicTextBoxCount;
            this.Controls.Add(dynamicLabel);
            
        }

        void Setting_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) // 사용자가 창 닫을시
            {
                // 종료버튼 누를시 저장할거
                savePointGetter = dynamicTextBox.Text; // setter로 전달
                MessageBox.Show("내용이 저장됩니다");

               
   
              

            }
                // Prompt user to save his data

                if (e.CloseReason == CloseReason.WindowsShutDown) // 운영체제 종료할때쓴다는데 이걸왜 ㅋㅋ;;
                {
                MessageBox.Show("종료!!");
                // Autosave and clear up ressources
            }
        }

    /*    private void Setting_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
        
            
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            
        }
*/

        private void Setting_Load(object sender, EventArgs e)
        {

        }
    }
    
}
