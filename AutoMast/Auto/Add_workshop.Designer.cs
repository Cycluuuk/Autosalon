namespace Auto
{
    partial class Add_workshop
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
            this.cb_head = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.cb_districts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_head
            // 
            this.cb_head.FormattingEnabled = true;
            this.cb_head.Location = new System.Drawing.Point(58, 124);
            this.cb_head.Name = "cb_head";
            this.cb_head.Size = new System.Drawing.Size(245, 21);
            this.cb_head.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Начальник цеха:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Участки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(58, 63);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(245, 22);
            this.tb_name.TabIndex = 10;
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(121, 322);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(119, 40);
            this.bt_apply.TabIndex = 9;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(121, 368);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(119, 41);
            this.bt_return.TabIndex = 8;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // cb_districts
            // 
            this.cb_districts.FormattingEnabled = true;
            this.cb_districts.Location = new System.Drawing.Point(58, 194);
            this.cb_districts.Name = "cb_districts";
            this.cb_districts.Size = new System.Drawing.Size(245, 21);
            this.cb_districts.TabIndex = 16;
            // 
            // Add_workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 430);
            this.ControlBox = false;
            this.Controls.Add(this.cb_districts);
            this.Controls.Add(this.cb_head);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_return);
            this.Name = "Add_workshop";
            this.Text = "Добавить цех";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_head;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.ComboBox cb_districts;
    }
}