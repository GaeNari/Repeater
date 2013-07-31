namespace Repeater
{
    partial class Repeater
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyboardInput = new System.Windows.Forms.Button();
            this.MouseInput = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // KeyboardInput
            // 
            this.KeyboardInput.Location = new System.Drawing.Point(182, 95);
            this.KeyboardInput.Name = "KeyboardInput";
            this.KeyboardInput.Size = new System.Drawing.Size(118, 37);
            this.KeyboardInput.TabIndex = 0;
            this.KeyboardInput.Text = "키보드 입력";
            this.KeyboardInput.UseVisualStyleBackColor = true;
            this.KeyboardInput.Click += new System.EventHandler(this.KeyboardInput_Click);
            // 
            // MouseInput
            // 
            this.MouseInput.Location = new System.Drawing.Point(182, 138);
            this.MouseInput.Name = "MouseInput";
            this.MouseInput.Size = new System.Drawing.Size(118, 37);
            this.MouseInput.TabIndex = 1;
            this.MouseInput.Text = "마우스 입력";
            this.MouseInput.UseVisualStyleBackColor = true;
            this.MouseInput.Click += new System.EventHandler(this.MouseInput_Click);
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(182, 181);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(118, 37);
            this.Delay.TabIndex = 2;
            this.Delay.Text = "딜레이";
            this.Delay.UseVisualStyleBackColor = true;
            this.Delay.Click += new System.EventHandler(this.Delay_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(182, 224);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 37);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Instructions
            // 
            this.Instructions.FormattingEnabled = true;
            this.Instructions.ItemHeight = 12;
            this.Instructions.Location = new System.Drawing.Point(12, 75);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(161, 208);
            this.Instructions.TabIndex = 4;
            // 
            // Repeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 360);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.MouseInput);
            this.Controls.Add(this.KeyboardInput);
            this.Name = "Repeater";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KeyboardInput;
        private System.Windows.Forms.Button MouseInput;
        private System.Windows.Forms.Button Delay;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox Instructions;
    }
}

