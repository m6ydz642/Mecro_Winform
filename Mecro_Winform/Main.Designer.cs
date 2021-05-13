
namespace Mecro_Winform
{
    partial class Main
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
            this.stopTimer = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.exeute = new System.Windows.Forms.Button();
            this.timerX_YPostion = new System.Windows.Forms.Timer(this.components);
            this.savePoint = new System.Windows.Forms.Button();
            this.saveX_Point = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveY_Point = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timerMecro = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.준비중입니다ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pointListView = new System.Windows.Forms.ListView();
            this.saveCountView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.savePointView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExcuteSavePoint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "실시간 X좌표값";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(588, 87);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(38, 12);
            this.ylabel.TabIndex = 2;
            this.ylabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "실시간 Y좌표값";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(588, 64);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(38, 12);
            this.xlabel.TabIndex = 4;
            this.xlabel.Text = "label1";
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(205, 115);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(75, 23);
            this.stopTimer.TabIndex = 5;
            this.stopTimer.Text = "중지 (F1)";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(83, 64);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(197, 21);
            this.textBox.TabIndex = 6;
            this.textBox.Text = "텍스트를 입력하세요";
            // 
            // exeute
            // 
            this.exeute.Location = new System.Drawing.Point(83, 115);
            this.exeute.Name = "exeute";
            this.exeute.Size = new System.Drawing.Size(75, 23);
            this.exeute.TabIndex = 7;
            this.exeute.Text = "실행 (F3)";
            this.exeute.UseVisualStyleBackColor = true;
            this.exeute.Click += new System.EventHandler(this.exeute_Click);
            // 
            // timerX_YPostion
            // 
            this.timerX_YPostion.Tick += new System.EventHandler(this.timerX_YPostion_Tick);
            // 
            // savePoint
            // 
            this.savePoint.Location = new System.Drawing.Point(333, 115);
            this.savePoint.Name = "savePoint";
            this.savePoint.Size = new System.Drawing.Size(97, 23);
            this.savePoint.TabIndex = 8;
            this.savePoint.Text = "좌표찍기 (F2)";
            this.savePoint.UseVisualStyleBackColor = true;
            this.savePoint.Click += new System.EventHandler(this.savePoint_Click);
            // 
            // saveX_Point
            // 
            this.saveX_Point.AutoSize = true;
            this.saveX_Point.Location = new System.Drawing.Point(400, 64);
            this.saveX_Point.Name = "saveX_Point";
            this.saveX_Point.Size = new System.Drawing.Size(38, 12);
            this.saveX_Point.TabIndex = 12;
            this.saveX_Point.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y좌표 값";
            // 
            // saveY_Point
            // 
            this.saveY_Point.AutoSize = true;
            this.saveY_Point.Location = new System.Drawing.Point(400, 87);
            this.saveY_Point.Name = "saveY_Point";
            this.saveY_Point.Size = new System.Drawing.Size(38, 12);
            this.saveY_Point.TabIndex = 10;
            this.saveY_Point.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "X좌표값";
            // 
            // timerMecro
            // 
            this.timerMecro.Tick += new System.EventHandler(this.timerMecro_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenuSetting});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // stripmenuSetting
            // 
            this.stripmenuSetting.Name = "stripmenuSetting";
            this.stripmenuSetting.Size = new System.Drawing.Size(180, 22);
            this.stripmenuSetting.Text = "설정";
            this.stripmenuSetting.Click += new System.EventHandler(this.stripmenuSetting_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.준비중입니다ToolStripMenuItem1});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 준비중입니다ToolStripMenuItem1
            // 
            this.준비중입니다ToolStripMenuItem1.Name = "준비중입니다ToolStripMenuItem1";
            this.준비중입니다ToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.준비중입니다ToolStripMenuItem1.Text = "준비중입니다";
            // 
            // pointListView
            // 
            this.pointListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.saveCountView,
            this.savePointView});
            this.pointListView.HideSelection = false;
            this.pointListView.Location = new System.Drawing.Point(333, 144);
            this.pointListView.Name = "pointListView";
            this.pointListView.Size = new System.Drawing.Size(293, 126);
            this.pointListView.TabIndex = 14;
            this.pointListView.UseCompatibleStateImageBehavior = false;
            // 
            // saveCountView
            // 
            this.saveCountView.Text = "순번";
            // 
            // savePointView
            // 
            this.savePointView.Text = "좌표";
            // 
            // ExcuteSavePoint
            // 
            this.ExcuteSavePoint.Location = new System.Drawing.Point(218, 197);
            this.ExcuteSavePoint.Name = "ExcuteSavePoint";
            this.ExcuteSavePoint.Size = new System.Drawing.Size(88, 23);
            this.ExcuteSavePoint.TabIndex = 15;
            this.ExcuteSavePoint.Text = "저장좌표실행";
            this.ExcuteSavePoint.UseVisualStyleBackColor = true;
            this.ExcuteSavePoint.Click += new System.EventHandler(this.ExcuteSavePoint_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 281);
            this.Controls.Add(this.ExcuteSavePoint);
            this.Controls.Add(this.pointListView);
            this.Controls.Add(this.saveX_Point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveY_Point);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.savePoint);
            this.Controls.Add(this.exeute);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Button stopTimer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button exeute;
        private System.Windows.Forms.Timer timerX_YPostion;
        private System.Windows.Forms.Button savePoint;
        private System.Windows.Forms.Label saveX_Point;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label saveY_Point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerMecro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripmenuSetting;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 준비중입니다ToolStripMenuItem1;
        public System.Windows.Forms.ListView pointListView;
        private System.Windows.Forms.ColumnHeader saveCountView;
        private System.Windows.Forms.ColumnHeader savePointView;
        private System.Windows.Forms.Button ExcuteSavePoint;
    }
}

