namespace ClassLibrary
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
            this.create_button = new System.Windows.Forms.Button();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.populationtextbox = new System.Windows.Forms.TextBox();
            this.descriptiontextbox = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.clean_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statisticlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.create_button.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_button.ForeColor = System.Drawing.Color.Black;
            this.create_button.Location = new System.Drawing.Point(12, 402);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(195, 33);
            this.create_button.TabIndex = 0;
            this.create_button.Text = " Создать субъект";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(15, 114);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(195, 22);
            this.nametextbox.TabIndex = 1;
            // 
            // populationtextbox
            // 
            this.populationtextbox.Location = new System.Drawing.Point(12, 167);
            this.populationtextbox.Name = "populationtextbox";
            this.populationtextbox.Size = new System.Drawing.Size(195, 22);
            this.populationtextbox.TabIndex = 2;
            // 
            // descriptiontextbox
            // 
            this.descriptiontextbox.Location = new System.Drawing.Point(12, 227);
            this.descriptiontextbox.Multiline = true;
            this.descriptiontextbox.Name = "descriptiontextbox";
            this.descriptiontextbox.Size = new System.Drawing.Size(195, 169);
            this.descriptiontextbox.TabIndex = 3;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(247, 95);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(326, 260);
            this.listbox.TabIndex = 4;
            this.listbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listbox_MouseClick);
            this.listbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_MouseDoubleClick);
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(608, 95);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(424, 301);
            this.infoRichTextBox.TabIndex = 5;
            this.infoRichTextBox.Text = "";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.IndianRed;
            this.delete_button.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(247, 401);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(326, 34);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить субъект";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // find_button
            // 
            this.find_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.find_button.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_button.Location = new System.Drawing.Point(15, 441);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(192, 29);
            this.find_button.TabIndex = 7;
            this.find_button.Text = "Найти по имени";
            this.find_button.UseVisualStyleBackColor = false;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // clean_button
            // 
            this.clean_button.BackColor = System.Drawing.Color.IndianRed;
            this.clean_button.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean_button.Location = new System.Drawing.Point(15, 476);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(192, 46);
            this.clean_button.TabIndex = 8;
            this.clean_button.Text = "Очистить поля ввода";
            this.clean_button.UseVisualStyleBackColor = false;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.back_button.Enabled = false;
            this.back_button.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Location = new System.Drawing.Point(247, 363);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(326, 33);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название субъекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Население:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("durik", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(717, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Информация о субъекте:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Red October", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(300, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Создание государсTва";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listlabel
            // 
            this.listlabel.AutoSize = true;
            this.listlabel.BackColor = System.Drawing.Color.Transparent;
            this.listlabel.Font = new System.Drawing.Font("durik", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listlabel.Location = new System.Drawing.Point(334, 72);
            this.listlabel.Name = "listlabel";
            this.listlabel.Size = new System.Drawing.Size(110, 19);
            this.listlabel.TabIndex = 15;
            this.listlabel.Text = "Все страны:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("durik", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(244, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Статистика:";
            // 
            // statisticlabel
            // 
            this.statisticlabel.AutoSize = true;
            this.statisticlabel.BackColor = System.Drawing.Color.Transparent;
            this.statisticlabel.Font = new System.Drawing.Font("durik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticlabel.Location = new System.Drawing.Point(244, 476);
            this.statisticlabel.Name = "statisticlabel";
            this.statisticlabel.Size = new System.Drawing.Size(0, 13);
            this.statisticlabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::kursovaya.Properties.Resources.video_plug;
            this.ClientSize = new System.Drawing.Size(1066, 603);
            this.Controls.Add(this.statisticlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.descriptiontextbox);
            this.Controls.Add(this.populationtextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.create_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox populationtextbox;
        private System.Windows.Forms.TextBox descriptiontextbox;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label listlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statisticlabel;
    }
}

