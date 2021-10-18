namespace Auto
{
    partial class Update_product_category
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
            this.bt_select = new System.Windows.Forms.Button();
            this.cm_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_retrun = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(57, 91);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 56;
            this.bt_select.Text = "Выбрать";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // cm_id
            // 
            this.cm_id.FormattingEnabled = true;
            this.cm_id.Location = new System.Drawing.Point(57, 51);
            this.cm_id.Name = "cm_id";
            this.cm_id.Size = new System.Drawing.Size(233, 21);
            this.cm_id.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Категория:";
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(112, 325);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(117, 34);
            this.bt_apply.TabIndex = 53;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_retrun
            // 
            this.bt_retrun.Location = new System.Drawing.Point(112, 365);
            this.bt_retrun.Name = "bt_retrun";
            this.bt_retrun.Size = new System.Drawing.Size(117, 36);
            this.bt_retrun.TabIndex = 52;
            this.bt_retrun.Text = "Назад";
            this.bt_retrun.UseVisualStyleBackColor = true;
            this.bt_retrun.Click += new System.EventHandler(this.bt_retrun_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(57, 165);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(233, 22);
            this.tb_name.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Описание:";
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(57, 231);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(233, 22);
            this.tb_desc.TabIndex = 60;
            // 
            // Update_product_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 437);
            this.ControlBox = false;
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.cm_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_retrun);
            this.Name = "Update_product_category";
            this.Text = "Изменить категорию продуктов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.ComboBox cm_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_retrun;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_desc;
    }
}