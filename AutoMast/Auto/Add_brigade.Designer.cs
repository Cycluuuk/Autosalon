namespace Auto
{
    partial class Add_brigade
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
            this.bt_retrun = new System.Windows.Forms.Button();
            this.bt_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_head = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_retrun
            // 
            this.bt_retrun.Location = new System.Drawing.Point(103, 325);
            this.bt_retrun.Name = "bt_retrun";
            this.bt_retrun.Size = new System.Drawing.Size(117, 36);
            this.bt_retrun.TabIndex = 0;
            this.bt_retrun.Text = "Назад";
            this.bt_retrun.UseVisualStyleBackColor = true;
            this.bt_retrun.Click += new System.EventHandler(this.bt_retrun_Click);
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(103, 285);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(117, 34);
            this.bt_apply.TabIndex = 1;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Бригадир:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(48, 95);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(233, 22);
            this.tb_name.TabIndex = 4;
            // 
            // cb_head
            // 
            this.cb_head.FormattingEnabled = true;
            this.cb_head.Location = new System.Drawing.Point(48, 185);
            this.cb_head.Name = "cb_head";
            this.cb_head.Size = new System.Drawing.Size(233, 21);
            this.cb_head.TabIndex = 5;
            // 
            // Add_brigade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 373);
            this.ControlBox = false;
            this.Controls.Add(this.cb_head);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_retrun);
            this.Name = "Add_brigade";
            this.Text = "Добавить бригаду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_retrun;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_head;
    }
}