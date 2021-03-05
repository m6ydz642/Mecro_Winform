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

            TextBox dynamicTextBox = new TextBox();
            dynamicTextBoxCount++; // 동적으로 생성할때마다 한개씩 증가
                dynamicTextBox.Location = new Point(35, 70 + dynamicTextBoxCount * 20); // Y좌표가 한칸당 20씩 늘어남
  
                dynamicTextBox.Name = "textbox" + dynamicTextBoxCount;
                this.Controls.Add(dynamicTextBox);
            }

        }
    
}
