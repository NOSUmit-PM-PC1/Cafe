﻿namespace Cafe
{
    partial class FormAdmin
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
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.textBoxNameDish = new System.Windows.Forms.TextBox();
            this.textBoxPriceDish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddDish = new System.Windows.Forms.Button();
            this.buttonDeleteDish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(37, 38);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(264, 344);
            this.listBoxMenu.TabIndex = 0;
            // 
            // textBoxNameDish
            // 
            this.textBoxNameDish.Location = new System.Drawing.Point(422, 114);
            this.textBoxNameDish.Name = "textBoxNameDish";
            this.textBoxNameDish.Size = new System.Drawing.Size(100, 26);
            this.textBoxNameDish.TabIndex = 1;
            // 
            // textBoxPriceDish
            // 
            this.textBoxPriceDish.Location = new System.Drawing.Point(422, 185);
            this.textBoxPriceDish.Name = "textBoxPriceDish";
            this.textBoxPriceDish.Size = new System.Drawing.Size(100, 26);
            this.textBoxPriceDish.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название блюда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена блюда";

            // 
            // buttonAddDish
            // 
            this.buttonAddDish.Location = new System.Drawing.Point(422, 245);
            this.buttonAddDish.Name = "buttonAddDish";
            this.buttonAddDish.Size = new System.Drawing.Size(231, 37);
            this.buttonAddDish.TabIndex = 5;
            this.buttonAddDish.Text = "Добавить блюдо";
            this.buttonAddDish.UseVisualStyleBackColor = true;
            this.buttonAddDish.Click += new System.EventHandler(this.buttonAddDish_Click);
            // 
            // buttonDeleteDish
            // 
            this.buttonDeleteDish.Location = new System.Drawing.Point(422, 303);
            this.buttonDeleteDish.Name = "buttonDeleteDish";
            this.buttonDeleteDish.Size = new System.Drawing.Size(231, 37);
            this.buttonDeleteDish.TabIndex = 7;
            this.buttonDeleteDish.Text = "Удалить блюдо";
            this.buttonDeleteDish.UseVisualStyleBackColor = true;

            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteDish);
            this.Controls.Add(this.buttonAddDish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPriceDish);
            this.Controls.Add(this.textBoxNameDish);
            this.Controls.Add(this.listBoxMenu);
            this.Name = "FormAdmin";
            this.Text = "Форма для администратора";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.TextBox textBoxNameDish;
        private System.Windows.Forms.TextBox textBoxPriceDish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddDish;
        private System.Windows.Forms.Button buttonDeleteDish;
    }
}

