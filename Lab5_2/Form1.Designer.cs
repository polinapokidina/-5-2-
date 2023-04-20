namespace Lab5_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSecondumer = new System.Windows.Forms.Timer(this.components);
            this.resetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeNow = new System.Windows.Forms.TextBox();
            this.timerTimeNow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMinutes
            // 
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinutes.Location = new System.Drawing.Point(16, 54);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(55, 20);
            this.txtMinutes.TabIndex = 0;
            this.txtMinutes.Text = "0";
            // 
            // txtSeconds
            // 
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeconds.Location = new System.Drawing.Point(145, 54);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(55, 20);
            this.txtSeconds.TabIndex = 1;
            this.txtSeconds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "мин.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "сек.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(145, 93);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSecondumer
            // 
            this.tmrSecondumer.Interval = 1000;
            this.tmrSecondumer.Tick += new System.EventHandler(this.tmrSecondumer_Tick);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(16, 93);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Сброс";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текущее время";
            // 
            // txtTimeNow
            // 
            this.txtTimeNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeNow.Location = new System.Drawing.Point(97, 11);
            this.txtTimeNow.Name = "txtTimeNow";
            this.txtTimeNow.Size = new System.Drawing.Size(100, 20);
            this.txtTimeNow.TabIndex = 7;
            // 
            // timerTimeNow
            // 
            this.timerTimeNow.Interval = 1000;
            this.timerTimeNow.Tick += new System.EventHandler(this.timerTimeNow_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 130);
            this.Controls.Add(this.txtTimeNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Name = "Form1";
            this.Text = "Секундомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSecondumer;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeNow;
        private System.Windows.Forms.Timer timerTimeNow;
    }
}

