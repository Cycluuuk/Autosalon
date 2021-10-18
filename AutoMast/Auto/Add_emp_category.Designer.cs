namespace Auto
{
    partial class Add_emp_category
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
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_apply = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.rb_worker = new System.Windows.Forms.RadioButton();
            this.rb_engineer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(92, 366);
            this.bt_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(180, 46);
            this.bt_return.TabIndex = 0;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(92, 313);
            this.bt_apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(180, 46);
            this.bt_apply.TabIndex = 1;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(75, 47);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(217, 22);
            this.tb_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Специализация:";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(75, 128);
            this.tb_desc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(217, 22);
            this.tb_desc.TabIndex = 6;
            // 
            // rb_worker
            // 
            this.rb_worker.AutoSize = true;
            this.rb_worker.Location = new System.Drawing.Point(75, 206);
            this.rb_worker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_worker.Name = "rb_worker";
            this.rb_worker.Size = new System.Drawing.Size(86, 21);
            this.rb_worker.TabIndex = 7;
            this.rb_worker.TabStop = true;
            this.rb_worker.Text = "Рабочий";
            this.rb_worker.UseVisualStyleBackColor = true;
            // 
            // rb_engineer
            // 
            this.rb_engineer.AutoSize = true;
            this.rb_engineer.Location = new System.Drawing.Point(75, 234);
            this.rb_engineer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_engineer.Name = "rb_engineer";
            this.rb_engineer.Size = new System.Drawing.Size(88, 21);
            this.rb_engineer.TabIndex = 8;
            this.rb_engineer.TabStop = true;
            this.rb_engineer.Text = "Инженер";
            this.rb_engineer.UseVisualStyleBackColor = true;
            // 
            // Add_emp_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 439);
            this.ControlBox = false;
            this.Controls.Add(this.rb_engineer);
            this.Controls.Add(this.rb_worker);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_return);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_emp_category";
            this.Text = "Добавить категорию сотрудника";
            this.Load += new System.EventHandler(this.Add_emp_category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.RadioButton rb_worker;
        private System.Windows.Forms.RadioButton rb_engineer;
    }
}