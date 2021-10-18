namespace Auto
{
    partial class Update_brigade
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_retrun = new System.Windows.Forms.Button();
            this.cm_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_head
            // 
            this.cb_head.FormattingEnabled = true;
            this.cb_head.Location = new System.Drawing.Point(57, 272);
            this.cb_head.Name = "cb_head";
            this.cb_head.Size = new System.Drawing.Size(233, 21);
            this.cb_head.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(57, 214);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(233, 22);
            this.tb_name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Бригадир:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название:";
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(112, 336);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(117, 34);
            this.bt_apply.TabIndex = 7;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_retrun
            // 
            this.bt_retrun.Location = new System.Drawing.Point(112, 376);
            this.bt_retrun.Name = "bt_retrun";
            this.bt_retrun.Size = new System.Drawing.Size(117, 36);
            this.bt_retrun.TabIndex = 6;
            this.bt_retrun.Text = "Назад";
            this.bt_retrun.UseVisualStyleBackColor = true;
            this.bt_retrun.Click += new System.EventHandler(this.bt_retrun_Click);
            // 
            // cm_id
            // 
            this.cm_id.FormattingEnabled = true;
            this.cm_id.Location = new System.Drawing.Point(57, 62);
            this.cm_id.Name = "cm_id";
            this.cm_id.Size = new System.Drawing.Size(233, 21);
            this.cm_id.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Бригада:";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(57, 102);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 14;
            this.bt_select.Text = "Выбрать";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // Update_brigade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 444);
            this.ControlBox = false;
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.cm_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_head);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_retrun);
            this.Name = "Update_brigade";
            this.Text = "Изменить бригаду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_head;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_retrun;
        private System.Windows.Forms.ComboBox cm_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_select;
    }
}