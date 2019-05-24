namespace TeaBagMaker
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
            this.CBTea = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CBTea
            // 
            this.CBTea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTea.Font = new System.Drawing.Font("굴림", 14F);
            this.CBTea.FormattingEnabled = true;
            this.CBTea.Location = new System.Drawing.Point(12, 70);
            this.CBTea.Name = "CBTea";
            this.CBTea.Size = new System.Drawing.Size(268, 27);
            this.CBTea.TabIndex = 0;
            this.CBTea.SelectedIndexChanged += new System.EventHandler(this.CBTea_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("굴림", 15F);
            this.btn.Location = new System.Drawing.Point(12, 105);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(268, 43);
            this.btn.TabIndex = 1;
            this.btn.Text = "담그기";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "맛있는 티 끓이기 ^_^";
            // 
            // TimerTB
            // 
            this.TimerTB.Font = new System.Drawing.Font("굴림", 14F);
            this.TimerTB.Location = new System.Drawing.Point(12, 156);
            this.TimerTB.Name = "TimerTB";
            this.TimerTB.ReadOnly = true;
            this.TimerTB.Size = new System.Drawing.Size(268, 29);
            this.TimerTB.TabIndex = 3;
            this.TimerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Tick_Count);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 200);
            this.Controls.Add(this.TimerTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.CBTea);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TeaBagMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTea;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimerTB;
        private System.Windows.Forms.Timer timer1;
    }
}

