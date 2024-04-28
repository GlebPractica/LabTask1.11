namespace Task2
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
            this.BttnFillHastSet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BttnDeleteElement = new System.Windows.Forms.Button();
            this.BttnFillLinkedList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BttnFind = new System.Windows.Forms.Button();
            this.BttnUpdateAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnFillHastSet
            // 
            this.BttnFillHastSet.Location = new System.Drawing.Point(12, 51);
            this.BttnFillHastSet.Name = "BttnFillHastSet";
            this.BttnFillHastSet.Size = new System.Drawing.Size(137, 30);
            this.BttnFillHastSet.TabIndex = 0;
            this.BttnFillHastSet.Text = "Принять и заполнить";
            this.BttnFillHastSet.UseVisualStyleBackColor = true;
            this.BttnFillHastSet.Click += new System.EventHandler(this.BttnFillHastSet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите размер массива";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(134, 128);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HashSet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LinkedList";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(168, 176);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(134, 128);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ввод для удаления из HashSet";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 8;
            // 
            // BttnDeleteElement
            // 
            this.BttnDeleteElement.Location = new System.Drawing.Point(171, 51);
            this.BttnDeleteElement.Name = "BttnDeleteElement";
            this.BttnDeleteElement.Size = new System.Drawing.Size(159, 30);
            this.BttnDeleteElement.TabIndex = 7;
            this.BttnDeleteElement.Text = "Удалить";
            this.BttnDeleteElement.UseVisualStyleBackColor = true;
            this.BttnDeleteElement.Click += new System.EventHandler(this.BttnDeleteElement_Click);
            // 
            // BttnFillLinkedList
            // 
            this.BttnFillLinkedList.Location = new System.Drawing.Point(359, 9);
            this.BttnFillLinkedList.Name = "BttnFillLinkedList";
            this.BttnFillLinkedList.Size = new System.Drawing.Size(104, 36);
            this.BttnFillLinkedList.TabIndex = 10;
            this.BttnFillLinkedList.Text = "Заполнить LinkedList";
            this.BttnFillLinkedList.UseVisualStyleBackColor = true;
            this.BttnFillLinkedList.Click += new System.EventHandler(this.BttnFillLinkedList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введите элемент для поиска";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 12;
            // 
            // BttnFind
            // 
            this.BttnFind.Location = new System.Drawing.Point(313, 142);
            this.BttnFind.Name = "BttnFind";
            this.BttnFind.Size = new System.Drawing.Size(159, 30);
            this.BttnFind.TabIndex = 11;
            this.BttnFind.Text = "Найти";
            this.BttnFind.UseVisualStyleBackColor = true;
            this.BttnFind.Click += new System.EventHandler(this.BttnFind_Click);
            // 
            // BttnUpdateAll
            // 
            this.BttnUpdateAll.Location = new System.Drawing.Point(12, 87);
            this.BttnUpdateAll.Name = "BttnUpdateAll";
            this.BttnUpdateAll.Size = new System.Drawing.Size(218, 30);
            this.BttnUpdateAll.TabIndex = 14;
            this.BttnUpdateAll.Text = "Обновить вывод";
            this.BttnUpdateAll.UseVisualStyleBackColor = true;
            this.BttnUpdateAll.Click += new System.EventHandler(this.BttnUpdateAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BttnUpdateAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BttnFind);
            this.Controls.Add(this.BttnFillLinkedList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BttnDeleteElement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BttnFillHastSet);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnFillHastSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BttnDeleteElement;
        private System.Windows.Forms.Button BttnFillLinkedList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BttnFind;
        private System.Windows.Forms.Button BttnUpdateAll;
    }
}

