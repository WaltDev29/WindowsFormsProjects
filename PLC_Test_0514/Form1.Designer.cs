namespace PLC_Test_0514
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnMvBackward = new System.Windows.Forms.Button();
            this.btnMvForward = new System.Windows.Forms.Button();
            this.lblSens = new System.Windows.Forms.Label();
            this.btnReadSens = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConnect.Location = new System.Drawing.Point(79, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 51);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnMvBackward
            // 
            this.btnMvBackward.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMvBackward.Location = new System.Drawing.Point(79, 217);
            this.btnMvBackward.Name = "btnMvBackward";
            this.btnMvBackward.Size = new System.Drawing.Size(117, 51);
            this.btnMvBackward.TabIndex = 1;
            this.btnMvBackward.Text = "후진";
            this.btnMvBackward.UseVisualStyleBackColor = true;
            this.btnMvBackward.Click += new System.EventHandler(this.btnMvBackward_Click);
            // 
            // btnMvForward
            // 
            this.btnMvForward.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMvForward.Location = new System.Drawing.Point(79, 135);
            this.btnMvForward.Name = "btnMvForward";
            this.btnMvForward.Size = new System.Drawing.Size(117, 51);
            this.btnMvForward.TabIndex = 2;
            this.btnMvForward.Text = "전진";
            this.btnMvForward.UseVisualStyleBackColor = true;
            this.btnMvForward.Click += new System.EventHandler(this.btnMvForward_Click);
            // 
            // lblSens
            // 
            this.lblSens.AutoSize = true;
            this.lblSens.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSens.Location = new System.Drawing.Point(145, 368);
            this.lblSens.Name = "lblSens";
            this.lblSens.Size = new System.Drawing.Size(0, 20);
            this.lblSens.TabIndex = 3;
            // 
            // btnReadSens
            // 
            this.btnReadSens.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReadSens.Location = new System.Drawing.Point(79, 300);
            this.btnReadSens.Name = "btnReadSens";
            this.btnReadSens.Size = new System.Drawing.Size(117, 46);
            this.btnReadSens.TabIndex = 4;
            this.btnReadSens.Text = "센서 읽기";
            this.btnReadSens.UseVisualStyleBackColor = true;
            this.btnReadSens.Click += new System.EventHandler(this.btnReadSensor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.btnReadSens);
            this.Controls.Add(this.lblSens);
            this.Controls.Add(this.btnMvForward);
            this.Controls.Add(this.btnMvBackward);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnMvBackward;
        private System.Windows.Forms.Button btnMvForward;
        private System.Windows.Forms.Label lblSens;
        private System.Windows.Forms.Button btnReadSens;
        private System.Windows.Forms.Timer timer1;
    }
}

