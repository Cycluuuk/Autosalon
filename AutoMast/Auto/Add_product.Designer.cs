namespace Auto
{
    partial class Add_product
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
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(49, 114);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(218, 22);
            this.tb_desc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(49, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(218, 22);
            this.tb_name.TabIndex = 9;
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(85, 267);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(135, 37);
            this.bt_apply.TabIndex = 8;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(85, 310);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(135, 37);
            this.bt_return.TabIndex = 7;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Категория продукта:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(49, 185);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(218, 21);
            this.cb_category.TabIndex = 14;
            // 
            // Add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 375);
            this.ControlBox = false;
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_return);
            this.Name = "Add_product";
            this.Text = "Add_product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_category;
    }
}