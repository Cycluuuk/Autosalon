namespace Auto
{
    partial class Update_empl_category
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
            this.rb_engineer = new System.Windows.Forms.RadioButton();
            this.rb_worker = new System.Windows.Forms.RadioButton();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.cm_id = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_engineer
            // 
            this.rb_engineer.AutoSize = true;
            this.rb_engineer.Location = new System.Drawing.Point(52, 283);
            this.rb_engineer.Name = "rb_engineer";
            this.rb_engineer.Size = new System.Drawing.Size(75, 17);
            this.rb_engineer.TabIndex = 17;
            this.rb_engineer.TabStop = true;
            this.rb_engineer.Text = "Инженер";
            this.rb_engineer.UseVisualStyleBackColor = true;
            // 
            // rb_worker
            // 
            this.rb_worker.AutoSize = true;
            this.rb_worker.Location = new System.Drawing.Point(52, 260);
            this.rb_worker.Name = "rb_worker";
            this.rb_worker.Size = new System.Drawing.Size(71, 17);
            this.rb_worker.TabIndex = 16;
            this.rb_worker.TabStop = true;
            this.rb_worker.Text = "Рабочий";
            this.rb_worker.UseVisualStyleBackColor = true;
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(48, 197);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(229, 22);
            this.tb_desc.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Специализация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(48, 131);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(229, 22);
            this.tb_name.TabIndex = 11;
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(97, 327);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(135, 37);
            this.bt_apply.TabIndex = 10;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(97, 370);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(135, 37);
            this.bt_return.TabIndex = 9;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(48, 77);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 20;
            this.bt_select.Text = "Выбрать";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // cm_id
            // 
            this.cm_id.FormattingEnabled = true;
            this.cm_id.Location = new System.Drawing.Point(48, 37);
            this.cm_id.Name = "cm_id";
            this.cm_id.Size = new System.Drawing.Size(233, 21);
            this.cm_id.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Категория:";
            // 
            // Update_empl_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 423);
            this.ControlBox = false;
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.cm_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_engineer);
            this.Controls.Add(this.rb_worker);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_return);
            this.Name = "Update_empl_category";
            this.Text = "Изменить категорию сотрудников";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_engineer;
        private System.Windows.Forms.RadioButton rb_worker;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.ComboBox cm_id;
        private System.Windows.Forms.Label label4;
    }
}