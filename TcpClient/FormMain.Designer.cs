namespace TcpClient {
    partial class FormMain {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkConnet = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxPort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxIp);
            this.panel1.Controls.Add(this.chkConnet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 21);
            this.panel1.TabIndex = 5;
            // 
            // tbxPort
            // 
            this.tbxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPort.Location = new System.Drawing.Point(330, 0);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(180, 21);
            this.tbxPort.TabIndex = 2;
            this.tbxPort.Text = "20000";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkConnet
            // 
            this.chkConnet.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkConnet.Location = new System.Drawing.Point(510, 0);
            this.chkConnet.Name = "chkConnet";
            this.chkConnet.Size = new System.Drawing.Size(74, 21);
            this.chkConnet.TabIndex = 0;
            this.chkConnet.Text = "Connect";
            this.chkConnet.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxSend);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 100);
            this.panel2.TabIndex = 6;
            // 
            // tbxSend
            // 
            this.tbxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSend.Location = new System.Drawing.Point(0, 0);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxSend.Size = new System.Drawing.Size(510, 100);
            this.tbxSend.TabIndex = 4;
            this.tbxSend.WordWrap = false;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(510, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 100);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMessage.Location = new System.Drawing.Point(0, 21);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMessage.Size = new System.Drawing.Size(584, 437);
            this.tbxMessage.TabIndex = 8;
            this.tbxMessage.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 458);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(584, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // tbxIp
            // 
            this.tbxIp.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxIp.Location = new System.Drawing.Point(75, 0);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(180, 21);
            this.tbxIp.TabIndex = 4;
            this.tbxIp.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(255, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormMain";
            this.Text = "TCP Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkConnet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIp;
    }
}

