
namespace Mecro_Winform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.exeute = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.savePoint = new System.Windows.Forms.Button();
            this.saveX_Point = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveY_Point = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "실시간 X좌표값";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(689, 219);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(38, 12);
            this.ylabel.TabIndex = 2;
            this.ylabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "실시간 Y좌표값";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(689, 196);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(38, 12);
            this.xlabel.TabIndex = 4;
            this.xlabel.Text = "label1";
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(607, 264);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(75, 23);
            this.timer.TabIndex = 5;
            this.timer.Text = "타이머";
            this.timer.UseVisualStyleBackColor = true;
            this.timer.Click += new System.EventHandler(this.timer_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(178, 216);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(197, 21);
            this.textBox.TabIndex = 6;
            this.textBox.Text = "텍스트를 입력하세요";
            // 
            // exeute
            // 
            this.exeute.Location = new System.Drawing.Point(252, 284);
            this.exeute.Name = "exeute";
            this.exeute.Size = new System.Drawing.Size(75, 23);
            this.exeute.TabIndex = 7;
            this.exeute.Text = "실행";
            this.exeute.UseVisualStyleBackColor = true;
            this.exeute.Click += new System.EventHandler(this.exeute_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // savePoint
            // 
            this.savePoint.Location = new System.Drawing.Point(450, 208);
            this.savePoint.Name = "savePoint";
            this.savePoint.Size = new System.Drawing.Size(75, 23);
            this.savePoint.TabIndex = 8;
            this.savePoint.Text = "대상 좌표찍기";
            this.savePoint.UseVisualStyleBackColor = true;
            this.savePoint.Click += new System.EventHandler(this.savePoint_Click);
            // 
            // saveX_Point
            // 
            this.saveX_Point.AutoSize = true;
            this.saveX_Point.Location = new System.Drawing.Point(499, 132);
            this.saveX_Point.Name = "saveX_Point";
            this.saveX_Point.Size = new System.Drawing.Size(38, 12);
            this.saveX_Point.TabIndex = 12;
            this.saveX_Point.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y좌표 값";
            // 
            // saveY_Point
            // 
            this.saveY_Point.AutoSize = true;
            this.saveY_Point.Location = new System.Drawing.Point(499, 155);
            this.saveY_Point.Name = "saveY_Point";
            this.saveY_Point.Size = new System.Drawing.Size(38, 12);
            this.saveY_Point.TabIndex = 10;
            this.saveY_Point.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "X좌표값";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveX_Point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveY_Point);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.savePoint);
            this.Controls.Add(this.exeute);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Button timer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button exeute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button savePoint;
        private System.Windows.Forms.Label saveX_Point;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label saveY_Point;
        private System.Windows.Forms.Label label6;
    }
}

