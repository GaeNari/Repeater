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
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMacroMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyboardInput
            // 
            this.KeyboardInput.Location = new System.Drawing.Point(183, 77);
            this.KeyboardInput.Name = "KeyboardInput";
            this.KeyboardInput.Size = new System.Drawing.Size(118, 37);
            this.KeyboardInput.TabIndex = 0;
            this.KeyboardInput.Text = "키보드 입력";
            this.KeyboardInput.UseVisualStyleBackColor = true;
            this.KeyboardInput.Click += new System.EventHandler(this.KeyboardInput_Click);
            // 
            // MouseInput
            // 
            this.MouseInput.Location = new System.Drawing.Point(183, 120);
            this.MouseInput.Name = "MouseInput";
            this.MouseInput.Size = new System.Drawing.Size(118, 37);
            this.MouseInput.TabIndex = 1;
            this.MouseInput.Text = "마우스 입력";
            this.MouseInput.UseVisualStyleBackColor = true;
            this.MouseInput.Click += new System.EventHandler(this.MouseInput_Click);
            // 
            // Delay
            // 
            this.Delay.Location = new System.Drawing.Point(183, 163);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(118, 37);
            this.Delay.TabIndex = 2;
            this.Delay.Text = "딜레이";
            this.Delay.UseVisualStyleBackColor = true;
            this.Delay.Click += new System.EventHandler(this.Delay_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(183, 206);
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
            this.Instructions.Location = new System.Drawing.Point(15, 53);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(161, 208);
            this.Instructions.TabIndex = 4;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(202, 280);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(82, 26);
            this.Start.TabIndex = 5;
            this.Start.Text = "시작";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "반복 횟수 :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMacroMenuItem,
            this.불러오기ToolStripMenuItem,
            this.저장ToolStripMenuItem});
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.asdfToolStripMenuItem.Text = "파일(&F)";
            // 
            // NewMacroMenuItem
            // 
            this.NewMacroMenuItem.Name = "NewMacroMenuItem";
            this.NewMacroMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewMacroMenuItem.Text = "새 매크로";
            this.NewMacroMenuItem.Click += new System.EventHandler(this.NewMacroMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // ManualMenuItem
            // 
            this.ManualMenuItem.Name = "ManualMenuItem";
            this.ManualMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ManualMenuItem.Text = "사용법";
            this.ManualMenuItem.Click += new System.EventHandler(this.ManualMenuItem_Click);
            // 
            // Repeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.MouseInput);
            this.Controls.Add(this.KeyboardInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Repeater";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KeyboardInput;
        private System.Windows.Forms.Button MouseInput;
        private System.Windows.Forms.Button Delay;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ListBox Instructions;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMacroMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManualMenuItem;
    }
}

