
namespace prakticheskaia1._2_byNeshik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTotalTime = new System.Windows.Forms.Button();
            this.buttonShowChampion = new System.Windows.Forms.Button();
            this.textBoxSwimming1 = new System.Windows.Forms.TextBox();
            this.textBoxBike1 = new System.Windows.Forms.TextBox();
            this.textBoxRunning1 = new System.Windows.Forms.TextBox();
            this.textBoxTotalTime1 = new System.Windows.Forms.TextBox();
            this.textBoxTotalTime2 = new System.Windows.Forms.TextBox();
            this.textBoxRunning2 = new System.Windows.Forms.TextBox();
            this.textBoxBike2 = new System.Windows.Forms.TextBox();
            this.textBoxSwimming2 = new System.Windows.Forms.TextBox();
            this.textBoxTotalTime3 = new System.Windows.Forms.TextBox();
            this.textBoxRunning3 = new System.Windows.Forms.TextBox();
            this.textBoxBike3 = new System.Windows.Forms.TextBox();
            this.textBoxSwimming3 = new System.Windows.Forms.TextBox();
            this.textBoxChampionName = new System.Windows.Forms.TextBox();
            this.textBoxSportsman3 = new System.Windows.Forms.TextBox();
            this.textBoxSportsman2 = new System.Windows.Forms.TextBox();
            this.textBoxSportsman1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Соревнование по триатлону";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Плавает(м\\мин)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(37, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Скорость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(37, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Общее время(мин)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(37, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Бег(км\\ч)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(37, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Велосипед(км\\ч)";
            // 
            // buttonTotalTime
            // 
            this.buttonTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTotalTime.Location = new System.Drawing.Point(70, 422);
            this.buttonTotalTime.Name = "buttonTotalTime";
            this.buttonTotalTime.Size = new System.Drawing.Size(116, 33);
            this.buttonTotalTime.TabIndex = 9;
            this.buttonTotalTime.Text = "Показать";
            this.buttonTotalTime.UseVisualStyleBackColor = true;
            this.buttonTotalTime.Click += new System.EventHandler(this.buttonTotalTime_Click);
            // 
            // buttonShowChampion
            // 
            this.buttonShowChampion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowChampion.Location = new System.Drawing.Point(256, 510);
            this.buttonShowChampion.Name = "buttonShowChampion";
            this.buttonShowChampion.Size = new System.Drawing.Size(116, 33);
            this.buttonShowChampion.TabIndex = 10;
            this.buttonShowChampion.Text = "Чемпион";
            this.buttonShowChampion.UseVisualStyleBackColor = true;
            this.buttonShowChampion.Click += new System.EventHandler(this.buttonShowChampion_Click);
            // 
            // textBoxSwimming1
            // 
            this.textBoxSwimming1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSwimming1.Location = new System.Drawing.Point(367, 168);
            this.textBoxSwimming1.Name = "textBoxSwimming1";
            this.textBoxSwimming1.Size = new System.Drawing.Size(81, 31);
            this.textBoxSwimming1.TabIndex = 11;
            // 
            // textBoxBike1
            // 
            this.textBoxBike1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBike1.Location = new System.Drawing.Point(367, 235);
            this.textBoxBike1.Name = "textBoxBike1";
            this.textBoxBike1.Size = new System.Drawing.Size(81, 31);
            this.textBoxBike1.TabIndex = 12;
            // 
            // textBoxRunning1
            // 
            this.textBoxRunning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRunning1.Location = new System.Drawing.Point(367, 303);
            this.textBoxRunning1.Name = "textBoxRunning1";
            this.textBoxRunning1.Size = new System.Drawing.Size(81, 31);
            this.textBoxRunning1.TabIndex = 13;
            // 
            // textBoxTotalTime1
            // 
            this.textBoxTotalTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalTime1.Location = new System.Drawing.Point(367, 371);
            this.textBoxTotalTime1.Name = "textBoxTotalTime1";
            this.textBoxTotalTime1.Size = new System.Drawing.Size(81, 31);
            this.textBoxTotalTime1.TabIndex = 14;
            // 
            // textBoxTotalTime2
            // 
            this.textBoxTotalTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalTime2.Location = new System.Drawing.Point(539, 371);
            this.textBoxTotalTime2.Name = "textBoxTotalTime2";
            this.textBoxTotalTime2.Size = new System.Drawing.Size(81, 31);
            this.textBoxTotalTime2.TabIndex = 18;
            // 
            // textBoxRunning2
            // 
            this.textBoxRunning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRunning2.Location = new System.Drawing.Point(539, 303);
            this.textBoxRunning2.Name = "textBoxRunning2";
            this.textBoxRunning2.Size = new System.Drawing.Size(81, 31);
            this.textBoxRunning2.TabIndex = 17;
            // 
            // textBoxBike2
            // 
            this.textBoxBike2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBike2.Location = new System.Drawing.Point(539, 235);
            this.textBoxBike2.Name = "textBoxBike2";
            this.textBoxBike2.Size = new System.Drawing.Size(81, 31);
            this.textBoxBike2.TabIndex = 16;
            // 
            // textBoxSwimming2
            // 
            this.textBoxSwimming2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSwimming2.Location = new System.Drawing.Point(539, 168);
            this.textBoxSwimming2.Name = "textBoxSwimming2";
            this.textBoxSwimming2.Size = new System.Drawing.Size(81, 31);
            this.textBoxSwimming2.TabIndex = 15;
            // 
            // textBoxTotalTime3
            // 
            this.textBoxTotalTime3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalTime3.Location = new System.Drawing.Point(699, 371);
            this.textBoxTotalTime3.Name = "textBoxTotalTime3";
            this.textBoxTotalTime3.Size = new System.Drawing.Size(81, 31);
            this.textBoxTotalTime3.TabIndex = 22;
            // 
            // textBoxRunning3
            // 
            this.textBoxRunning3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRunning3.Location = new System.Drawing.Point(699, 303);
            this.textBoxRunning3.Name = "textBoxRunning3";
            this.textBoxRunning3.Size = new System.Drawing.Size(81, 31);
            this.textBoxRunning3.TabIndex = 21;
            // 
            // textBoxBike3
            // 
            this.textBoxBike3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBike3.Location = new System.Drawing.Point(699, 235);
            this.textBoxBike3.Name = "textBoxBike3";
            this.textBoxBike3.Size = new System.Drawing.Size(81, 31);
            this.textBoxBike3.TabIndex = 20;
            // 
            // textBoxSwimming3
            // 
            this.textBoxSwimming3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSwimming3.Location = new System.Drawing.Point(699, 168);
            this.textBoxSwimming3.Name = "textBoxSwimming3";
            this.textBoxSwimming3.Size = new System.Drawing.Size(81, 31);
            this.textBoxSwimming3.TabIndex = 19;
            // 
            // textBoxChampionName
            // 
            this.textBoxChampionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChampionName.Location = new System.Drawing.Point(378, 512);
            this.textBoxChampionName.Name = "textBoxChampionName";
            this.textBoxChampionName.Size = new System.Drawing.Size(257, 31);
            this.textBoxChampionName.TabIndex = 23;
            // 
            // textBoxSportsman3
            // 
            this.textBoxSportsman3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSportsman3.Location = new System.Drawing.Point(666, 75);
            this.textBoxSportsman3.Name = "textBoxSportsman3";
            this.textBoxSportsman3.Size = new System.Drawing.Size(154, 31);
            this.textBoxSportsman3.TabIndex = 26;
            // 
            // textBoxSportsman2
            // 
            this.textBoxSportsman2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSportsman2.Location = new System.Drawing.Point(506, 75);
            this.textBoxSportsman2.Name = "textBoxSportsman2";
            this.textBoxSportsman2.Size = new System.Drawing.Size(154, 31);
            this.textBoxSportsman2.TabIndex = 25;
            // 
            // textBoxSportsman1
            // 
            this.textBoxSportsman1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSportsman1.Location = new System.Drawing.Point(334, 75);
            this.textBoxSportsman1.Name = "textBoxSportsman1";
            this.textBoxSportsman1.Size = new System.Drawing.Size(166, 31);
            this.textBoxSportsman1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(175, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Спортсмены:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSportsman3);
            this.Controls.Add(this.textBoxSportsman2);
            this.Controls.Add(this.textBoxSportsman1);
            this.Controls.Add(this.textBoxChampionName);
            this.Controls.Add(this.textBoxTotalTime3);
            this.Controls.Add(this.textBoxRunning3);
            this.Controls.Add(this.textBoxBike3);
            this.Controls.Add(this.textBoxSwimming3);
            this.Controls.Add(this.textBoxTotalTime2);
            this.Controls.Add(this.textBoxRunning2);
            this.Controls.Add(this.textBoxBike2);
            this.Controls.Add(this.textBoxSwimming2);
            this.Controls.Add(this.textBoxTotalTime1);
            this.Controls.Add(this.textBoxRunning1);
            this.Controls.Add(this.textBoxBike1);
            this.Controls.Add(this.textBoxSwimming1);
            this.Controls.Add(this.buttonShowChampion);
            this.Controls.Add(this.buttonTotalTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTotalTime;
        private System.Windows.Forms.Button buttonShowChampion;
        private System.Windows.Forms.TextBox textBoxSwimming1;
        private System.Windows.Forms.TextBox textBoxBike1;
        private System.Windows.Forms.TextBox textBoxRunning1;
        private System.Windows.Forms.TextBox textBoxTotalTime1;
        private System.Windows.Forms.TextBox textBoxTotalTime2;
        private System.Windows.Forms.TextBox textBoxRunning2;
        private System.Windows.Forms.TextBox textBoxBike2;
        private System.Windows.Forms.TextBox textBoxSwimming2;
        private System.Windows.Forms.TextBox textBoxTotalTime3;
        private System.Windows.Forms.TextBox textBoxRunning3;
        private System.Windows.Forms.TextBox textBoxBike3;
        private System.Windows.Forms.TextBox textBoxSwimming3;
        private System.Windows.Forms.TextBox textBoxChampionName;
        private System.Windows.Forms.TextBox textBoxSportsman3;
        private System.Windows.Forms.TextBox textBoxSportsman2;
        private System.Windows.Forms.TextBox textBoxSportsman1;
        private System.Windows.Forms.Label label3;
    }
}

