namespace GURPSCalculator
{
    partial class GURPScalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GURPScalc));
            label1 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SpeedText = new TextBox();
            AnswerBox = new TextBox();
            WeightText = new TextBox();
            CaliberText = new TextBox();
            DamPointButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            radioButton5 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 18);
            label1.TabIndex = 8;
            label1.Text = "Caliber - mm | Speed - m/s | Weight - kg";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Verdana", 15.75F);
            radioButton4.Location = new Point(203, 145);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(131, 29);
            radioButton4.TabIndex = 6;
            radioButton4.Text = "Steel Rod";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Verdana", 15.75F);
            radioButton3.Location = new Point(203, 110);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(478, 29);
            radioButton3.TabIndex = 4;
            radioButton3.Text = "Depleted uranium (DU) core or penetrator";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Verdana", 15.75F);
            radioButton2.Location = new Point(203, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(391, 29);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Tungsten or tungsten carbide core";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Verdana", 15.75F);
            radioButton1.Location = new Point(203, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(562, 29);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Steel cap, reinforced core, or semi-armor piercing";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // SpeedText
            // 
            SpeedText.Font = new Font("Verdana", 18F);
            SpeedText.ForeColor = SystemColors.WindowFrame;
            SpeedText.Location = new Point(12, 83);
            SpeedText.Name = "SpeedText";
            SpeedText.Size = new Size(146, 37);
            SpeedText.TabIndex = 1;
            SpeedText.Text = "Speed";
            SpeedText.TextAlign = HorizontalAlignment.Center;
            SpeedText.Click += SpeedText_Click;
            SpeedText.KeyPress += SpeedText_KeyPress;
            SpeedText.Leave += SpeedText_Leave;
            // 
            // AnswerBox
            // 
            AnswerBox.Enabled = false;
            AnswerBox.Font = new Font("Verdana", 18F);
            AnswerBox.ForeColor = Color.Black;
            AnswerBox.Location = new Point(12, 199);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(146, 37);
            AnswerBox.TabIndex = 1;
            AnswerBox.Text = "Answer";
            AnswerBox.TextAlign = HorizontalAlignment.Center;
            AnswerBox.Click += WeightText_Click;
            AnswerBox.Leave += WeightText_Leave;
            // 
            // WeightText
            // 
            WeightText.Font = new Font("Verdana", 18F);
            WeightText.ForeColor = SystemColors.WindowFrame;
            WeightText.Location = new Point(12, 126);
            WeightText.Name = "WeightText";
            WeightText.Size = new Size(146, 37);
            WeightText.TabIndex = 1;
            WeightText.Text = "Weight";
            WeightText.TextAlign = HorizontalAlignment.Center;
            WeightText.Click += WeightText_Click;
            WeightText.KeyPress += WeightText_KeyPress;
            WeightText.Leave += WeightText_Leave;
            // 
            // CaliberText
            // 
            CaliberText.Font = new Font("Verdana", 18F);
            CaliberText.ForeColor = SystemColors.WindowFrame;
            CaliberText.Location = new Point(12, 40);
            CaliberText.Name = "CaliberText";
            CaliberText.Size = new Size(146, 37);
            CaliberText.TabIndex = 1;
            CaliberText.Text = "Caliber";
            CaliberText.TextAlign = HorizontalAlignment.Center;
            CaliberText.Click += CaliberText_Click;
            CaliberText.KeyPress += CaliberText_KeyPress;
            CaliberText.Leave += CaliberText_Leave;
            // 
            // DamPointButton
            // 
            DamPointButton.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DamPointButton.Location = new Point(192, 183);
            DamPointButton.Name = "DamPointButton";
            DamPointButton.Size = new Size(142, 67);
            DamPointButton.TabIndex = 0;
            DamPointButton.Text = "Calculate";
            DamPointButton.UseVisualStyleBackColor = true;
            DamPointButton.Click += DamPointButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Verdana", 15.75F);
            radioButton5.Location = new Point(351, 145);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(87, 29);
            radioButton5.TabIndex = 6;
            radioButton5.Text = "APDS";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // GURPScalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 288);
            Controls.Add(label1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(DamPointButton);
            Controls.Add(radioButton3);
            Controls.Add(CaliberText);
            Controls.Add(radioButton2);
            Controls.Add(WeightText);
            Controls.Add(radioButton1);
            Controls.Add(AnswerBox);
            Controls.Add(SpeedText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GURPScalc";
            Text = "GURPS Calculator @Made by FoxRedBlack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DamPointButton;
        private TextBox SpeedText;
        private TextBox WeightText;
        private TextBox CaliberText;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private TextBox AnswerBox;
        private RadioButton radioButton5;
    }
}
