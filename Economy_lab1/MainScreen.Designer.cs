namespace EPZ_lab1
{
    partial class MainScreen
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
            this.calculate_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rowsNumber = new System.Windows.Forms.TextBox();
            this.listBox_projectTypes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result_laborIntensity = new System.Windows.Forms.Label();
            this.result_stuff = new System.Windows.Forms.Label();
            this.result_duration = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate_button.Location = new System.Drawing.Point(158, 229);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(127, 29);
            this.calculate_button.TabIndex = 0;
            this.calculate_button.Text = "Розрахувати";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип проекту:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "KLOC";
            // 
            // textBox_rowsNumber
            // 
            this.textBox_rowsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_rowsNumber.Location = new System.Drawing.Point(212, 32);
            this.textBox_rowsNumber.Name = "textBox_rowsNumber";
            this.textBox_rowsNumber.Size = new System.Drawing.Size(104, 26);
            this.textBox_rowsNumber.TabIndex = 3;
            // 
            // listBox_projectTypes
            // 
            this.listBox_projectTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_projectTypes.FormattingEnabled = true;
            this.listBox_projectTypes.ItemHeight = 20;
            this.listBox_projectTypes.Items.AddRange(new object[] {
            "Розповсюджений",
            "Напівнезалежний",
            "Вбудований"});
            this.listBox_projectTypes.Location = new System.Drawing.Point(9, 32);
            this.listBox_projectTypes.Name = "listBox_projectTypes";
            this.listBox_projectTypes.Size = new System.Drawing.Size(157, 24);
            this.listBox_projectTypes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Трудомісткість:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(293, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тривалість(місяці):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(160, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Персоналу:";
            // 
            // result_laborIntensity
            // 
            this.result_laborIntensity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result_laborIntensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_laborIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_laborIntensity.Location = new System.Drawing.Point(5, 140);
            this.result_laborIntensity.Name = "result_laborIntensity";
            this.result_laborIntensity.Size = new System.Drawing.Size(100, 23);
            this.result_laborIntensity.TabIndex = 8;
            // 
            // result_stuff
            // 
            this.result_stuff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result_stuff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_stuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_stuff.Location = new System.Drawing.Point(164, 140);
            this.result_stuff.Name = "result_stuff";
            this.result_stuff.Size = new System.Drawing.Size(100, 23);
            this.result_stuff.TabIndex = 9;
            // 
            // result_duration
            // 
            this.result_duration.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_duration.Location = new System.Drawing.Point(297, 140);
            this.result_duration.Name = "result_duration";
            this.result_duration.Size = new System.Drawing.Size(100, 23);
            this.result_duration.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(119, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Результат:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.result_duration);
            this.Controls.Add(this.result_stuff);
            this.Controls.Add(this.result_laborIntensity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_projectTypes);
            this.Controls.Add(this.textBox_rowsNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_button);
            this.Name = "MainScreen";
            this.Text = "COCOMO Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rowsNumber;
        private System.Windows.Forms.ListBox listBox_projectTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result_laborIntensity;
        private System.Windows.Forms.Label result_stuff;
        private System.Windows.Forms.Label result_duration;
        private System.Windows.Forms.Label label9;
    }
}

