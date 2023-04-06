namespace lr17
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.result1TextBox = new System.Windows.Forms.TextBox();
            this.array1TextBox = new System.Windows.Forms.TextBox();
            this.array2TextBox = new System.Windows.Forms.TextBox();
            this.result2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(31, 233);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(113, 34);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Порахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(31, 193);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(113, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати елементи до масивів";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // result1TextBox
            // 
            this.result1TextBox.Location = new System.Drawing.Point(31, 141);
            this.result1TextBox.Name = "result1TextBox";
            this.result1TextBox.Size = new System.Drawing.Size(350, 20);
            this.result1TextBox.TabIndex = 2;
            // 
            // array1TextBox
            // 
            this.array1TextBox.Location = new System.Drawing.Point(82, 70);
            this.array1TextBox.Name = "array1TextBox";
            this.array1TextBox.Size = new System.Drawing.Size(97, 20);
            this.array1TextBox.TabIndex = 3;
            // 
            // array2TextBox
            // 
            this.array2TextBox.Location = new System.Drawing.Point(82, 96);
            this.array2TextBox.Name = "array2TextBox";
            this.array2TextBox.Size = new System.Drawing.Size(97, 20);
            this.array2TextBox.TabIndex = 4;
            // 
            // result2TextBox
            // 
            this.result2TextBox.Location = new System.Drawing.Point(31, 167);
            this.result2TextBox.Name = "result2TextBox";
            this.result2TextBox.Size = new System.Drawing.Size(350, 20);
            this.result2TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Andarray";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Оnаrrау";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введіть у поля Andarray та Onarray по одному елемету та натисніть кнопку \'\'Додати" +
    " елементи до масивів\'\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Квадратні корені елементів масиву Andarray";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Логарифми елементів масиву Onarray";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result2TextBox);
            this.Controls.Add(this.array2TextBox);
            this.Controls.Add(this.array1TextBox);
            this.Controls.Add(this.result1TextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox result1TextBox;
        private System.Windows.Forms.TextBox array1TextBox;
        private System.Windows.Forms.TextBox array2TextBox;
        private System.Windows.Forms.TextBox result2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

