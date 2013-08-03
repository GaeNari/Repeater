namespace Repeater
{
    partial class MouseInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pos_X = new System.Windows.Forms.TextBox();
            this.pos_Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.MoveRadioButton = new System.Windows.Forms.RadioButton();
            this.LeftClickRadioButton = new System.Windows.Forms.RadioButton();
            this.RightClickRadioButton = new System.Windows.Forms.RadioButton();
            this.LeftDownRadioButton = new System.Windows.Forms.RadioButton();
            this.LeftUpRadioButton = new System.Windows.Forms.RadioButton();
            this.RightDownRadioButton = new System.Windows.Forms.RadioButton();
            this.RightUpRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // pos_X
            // 
            this.pos_X.Location = new System.Drawing.Point(81, 68);
            this.pos_X.Name = "pos_X";
            this.pos_X.Size = new System.Drawing.Size(52, 21);
            this.pos_X.TabIndex = 2;
            this.pos_X.TabStop = false;
            // 
            // pos_Y
            // 
            this.pos_Y.Location = new System.Drawing.Point(162, 68);
            this.pos_Y.Name = "pos_Y";
            this.pos_Y.Size = new System.Drawing.Size(58, 21);
            this.pos_Y.TabIndex = 3;
            this.pos_Y.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "q를 누르면 현재 마우스의 위치로 X,Y가 설정됩니다";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "포커스를 TextBox 외의 부분에 두고 사용하십시오";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(58, 249);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(145, 249);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 9;
            this.Cancle.Text = "취소";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // MoveRadioButton
            // 
            this.MoveRadioButton.AutoSize = true;
            this.MoveRadioButton.Location = new System.Drawing.Point(41, 129);
            this.MoveRadioButton.Name = "MoveRadioButton";
            this.MoveRadioButton.Size = new System.Drawing.Size(47, 16);
            this.MoveRadioButton.TabIndex = 10;
            this.MoveRadioButton.TabStop = true;
            this.MoveRadioButton.Text = "이동";
            this.MoveRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeftClickRadioButton
            // 
            this.LeftClickRadioButton.AutoSize = true;
            this.LeftClickRadioButton.Location = new System.Drawing.Point(41, 151);
            this.LeftClickRadioButton.Name = "LeftClickRadioButton";
            this.LeftClickRadioButton.Size = new System.Drawing.Size(75, 16);
            this.LeftClickRadioButton.TabIndex = 11;
            this.LeftClickRadioButton.TabStop = true;
            this.LeftClickRadioButton.Text = "왼쪽 클릭";
            this.LeftClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // RightClickRadioButton
            // 
            this.RightClickRadioButton.AutoSize = true;
            this.RightClickRadioButton.Location = new System.Drawing.Point(41, 173);
            this.RightClickRadioButton.Name = "RightClickRadioButton";
            this.RightClickRadioButton.Size = new System.Drawing.Size(87, 16);
            this.RightClickRadioButton.TabIndex = 12;
            this.RightClickRadioButton.TabStop = true;
            this.RightClickRadioButton.Text = "오른쪽 클릭";
            this.RightClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeftDownRadioButton
            // 
            this.LeftDownRadioButton.AutoSize = true;
            this.LeftDownRadioButton.Location = new System.Drawing.Point(141, 129);
            this.LeftDownRadioButton.Name = "LeftDownRadioButton";
            this.LeftDownRadioButton.Size = new System.Drawing.Size(87, 16);
            this.LeftDownRadioButton.TabIndex = 13;
            this.LeftDownRadioButton.TabStop = true;
            this.LeftDownRadioButton.Text = "왼쪽 누르기";
            this.LeftDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeftUpRadioButton
            // 
            this.LeftUpRadioButton.AutoSize = true;
            this.LeftUpRadioButton.Location = new System.Drawing.Point(141, 151);
            this.LeftUpRadioButton.Name = "LeftUpRadioButton";
            this.LeftUpRadioButton.Size = new System.Drawing.Size(75, 16);
            this.LeftUpRadioButton.TabIndex = 14;
            this.LeftUpRadioButton.TabStop = true;
            this.LeftUpRadioButton.Text = "왼쪽 떼기";
            this.LeftUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // RightDownRadioButton
            // 
            this.RightDownRadioButton.AutoSize = true;
            this.RightDownRadioButton.Location = new System.Drawing.Point(141, 174);
            this.RightDownRadioButton.Name = "RightDownRadioButton";
            this.RightDownRadioButton.Size = new System.Drawing.Size(99, 16);
            this.RightDownRadioButton.TabIndex = 15;
            this.RightDownRadioButton.TabStop = true;
            this.RightDownRadioButton.Text = "오른쪽 누르기";
            this.RightDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // RightUpRadioButton
            // 
            this.RightUpRadioButton.AutoSize = true;
            this.RightUpRadioButton.Location = new System.Drawing.Point(141, 196);
            this.RightUpRadioButton.Name = "RightUpRadioButton";
            this.RightUpRadioButton.Size = new System.Drawing.Size(87, 16);
            this.RightUpRadioButton.TabIndex = 16;
            this.RightUpRadioButton.TabStop = true;
            this.RightUpRadioButton.Text = "오른쪽 떼기";
            this.RightUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // MouseInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 284);
            this.Controls.Add(this.RightUpRadioButton);
            this.Controls.Add(this.RightDownRadioButton);
            this.Controls.Add(this.LeftUpRadioButton);
            this.Controls.Add(this.LeftDownRadioButton);
            this.Controls.Add(this.RightClickRadioButton);
            this.Controls.Add(this.LeftClickRadioButton);
            this.Controls.Add(this.MoveRadioButton);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pos_Y);
            this.Controls.Add(this.pos_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "MouseInputForm";
            this.Text = "MouseInputForm";
            this.Load += new System.EventHandler(this.MouseInputForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MouseInputForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pos_X;
        private System.Windows.Forms.TextBox pos_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.RadioButton MoveRadioButton;
        private System.Windows.Forms.RadioButton LeftClickRadioButton;
        private System.Windows.Forms.RadioButton RightClickRadioButton;
        private System.Windows.Forms.RadioButton LeftDownRadioButton;
        private System.Windows.Forms.RadioButton LeftUpRadioButton;
        private System.Windows.Forms.RadioButton RightDownRadioButton;
        private System.Windows.Forms.RadioButton RightUpRadioButton;
    }
}