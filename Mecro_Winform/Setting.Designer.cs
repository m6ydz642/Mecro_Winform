
namespace Mecro_Winform
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savePoint = new System.Windows.Forms.Button();
            this.saveX_Point = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveY_Point = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.makePointArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(128, 25);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(184, 12);
            this.xlabel.TabIndex = 8;
            this.xlabel.Text = "잠시보류 (원본 form으로 일단씀)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "실시간 Y좌표값";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(128, 48);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(53, 12);
            this.ylabel.TabIndex = 6;
            this.ylabel.Text = "잠시보류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "실시간 X좌표값";
            // 
            // savePoint
            // 
            this.savePoint.Location = new System.Drawing.Point(215, 204);
            this.savePoint.Name = "savePoint";
            this.savePoint.Size = new System.Drawing.Size(97, 23);
            this.savePoint.TabIndex = 9;
            this.savePoint.Text = "좌표찍기 (F2)";
            this.savePoint.UseVisualStyleBackColor = true;
            this.savePoint.Click += new System.EventHandler(this.savePoint_Click);
            // 
            // saveX_Point
            // 
            this.saveX_Point.AutoSize = true;
            this.saveX_Point.Location = new System.Drawing.Point(410, 25);
            this.saveX_Point.Name = "saveX_Point";
            this.saveX_Point.Size = new System.Drawing.Size(38, 12);
            this.saveX_Point.TabIndex = 16;
            this.saveX_Point.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Y좌표 값";
            // 
            // saveY_Point
            // 
            this.saveY_Point.AutoSize = true;
            this.saveY_Point.Location = new System.Drawing.Point(410, 48);
            this.saveY_Point.Name = "saveY_Point";
            this.saveY_Point.Size = new System.Drawing.Size(38, 12);
            this.saveY_Point.TabIndex = 14;
            this.saveY_Point.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "X좌표값";
            // 
            // makePointArea
            // 
            this.makePointArea.Location = new System.Drawing.Point(343, 81);
            this.makePointArea.Name = "makePointArea";
            this.makePointArea.Size = new System.Drawing.Size(105, 23);
            this.makePointArea.TabIndex = 17;
            this.makePointArea.Text = "박스 추가(F3)";
            this.makePointArea.UseVisualStyleBackColor = true;
            this.makePointArea.Click += new System.EventHandler(this.makePointArea_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 239);
            this.Controls.Add(this.makePointArea);
            this.Controls.Add(this.saveX_Point);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveY_Point);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.savePoint);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.label1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_Closing);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePoint;
        private System.Windows.Forms.Label saveX_Point;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label saveY_Point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button makePointArea;
    }
}