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

        public string savePointGetter
        {
            get;
            set;
        }
        
         public string[] savetest { // 저장할 배열
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
            dynamicTextBox.Text = saveX_Point.Text + "," + saveY_Point.Text; // 선택한 좌표저장
           
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
            dynamicTextBox.Name = "textbox" + dynamicTextBoxCount;
            
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
                savePointGetter = dynamicTextBox.Text;
               for (int i = 1; i < dynamicTextBoxCount; i++)
                {
                    MessageBox.Show("save message : " + savetest[i]);
                }
                
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
