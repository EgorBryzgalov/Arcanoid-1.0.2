namespace Arcanoid
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(60, 61);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(166, 71);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(93, 349);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 46);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Location = new System.Drawing.Point(18, 32);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(67, 21);
            this.EasyRadioButton.TabIndex = 3;
            this.EasyRadioButton.TabStop = true;
            this.EasyRadioButton.Text = "Легко";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            this.EasyRadioButton.CheckedChanged += new System.EventHandler(this.OnLevelChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HardRadioButton);
            this.groupBox1.Controls.Add(this.MiddleRadioButton);
            this.groupBox1.Controls.Add(this.EasyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(40, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уровень сложности";
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Location = new System.Drawing.Point(18, 86);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(79, 21);
            this.HardRadioButton.TabIndex = 5;
            this.HardRadioButton.TabStop = true;
            this.HardRadioButton.Text = "Сложно";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            this.HardRadioButton.CheckedChanged += new System.EventHandler(this.OnLevelChanged);
            // 
            // MiddleRadioButton
            // 
            this.MiddleRadioButton.AutoSize = true;
            this.MiddleRadioButton.Location = new System.Drawing.Point(18, 59);
            this.MiddleRadioButton.Name = "MiddleRadioButton";
            this.MiddleRadioButton.Size = new System.Drawing.Size(78, 21);
            this.MiddleRadioButton.TabIndex = 4;
            this.MiddleRadioButton.TabStop = true;
            this.MiddleRadioButton.Text = "Средне";
            this.MiddleRadioButton.UseVisualStyleBackColor = true;
            this.MiddleRadioButton.CheckedChanged += new System.EventHandler(this.OnLevelChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "Arcanoid ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.RadioButton MiddleRadioButton;
    }
}

