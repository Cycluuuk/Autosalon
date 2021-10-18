namespace Auto
{
    partial class Update_workshop
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
            this.cb_districts = new System.Windows.Forms.ComboBox();
            this.cb_head = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_select = new System.Windows.Forms.Button();
            this.cm_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_retrun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_districts
            // 
            this.cb_districts.FormattingEnabled = true;
            this.cb_districts.Location = new System.Drawing.Point(60, 253);
            this.cb_districts.Name = "cb_districts";
            this.cb_districts.Size = new System.Drawing.Size(245, 21);
            this.cb_districts.TabIndex = 73;
            // 
            // cb_head
            // 
            this.cb_head.FormattingEnabled = true;
            this.cb_head.Location = new System.Drawing.Point(60, 200);
            this.cb_head.Name = "cb_head";
            this.cb_head.Size = new System.Drawing.Size(245, 21);
            this.cb_head.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Начальник цеха:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Участки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Название:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(60, 150);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(245, 22);
            this.tb_name.TabIndex = 68;
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(60, 91);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 67;
            this.bt_select.Text = "Выбрать";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // cm_id
            // 
            this.cm_id.FormattingEnabled = true;
            this.cm_id.Location = new System.Drawing.Point(60, 51);
            this.cm_id.Name = "cm_id";
            this.cm_id.Size = new System.Drawing.Size(245, 21);
            this.cm_id.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Цех:";
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(122, 325);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(117, 34);
            this.bt_apply.TabIndex = 64;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_retrun
            // 
            this.bt_retrun.Location = new System.Drawing.Point(122, 365);
            this.bt_retrun.Name = "bt_retrun";
            this.bt_retrun.Size = new System.Drawing.Size(117, 36);
            this.bt_retrun.TabIndex = 63;
            this.bt_retrun.Text = "Назад";
            this.bt_retrun.UseVisualStyleBackColor = true;
            this.bt_retrun.Click += new System.EventHandler(this.bt_retrun_Click);
            // 
            // Update_workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 428);
            this.ControlBox = false;
            this.Controls.Add(this.cb_districts);
            this.Controls.Add(this.cb_head);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.cm_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_retrun);
            this.Name = "Update_workshop";
            this.Text = "Update_workshop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_districts;
        private System.Windows.Forms.ComboBox cb_head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.ComboBox cm_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_retrun;
    }
}