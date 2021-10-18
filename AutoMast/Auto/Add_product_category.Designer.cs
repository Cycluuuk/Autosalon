namespace Auto
{
    partial class Add_product_category
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
            this.SuspendLayout();
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(81, 118);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(164, 22);
            this.tb_desc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(81, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(164, 22);
            this.tb_name.TabIndex = 9;
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(97, 228);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(135, 37);
            this.bt_apply.TabIndex = 8;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(97, 271);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(135, 37);
            this.bt_return.TabIndex = 7;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // Add_product_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 320);
            this.ControlBox = false;
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_return);
            this.Name = "Add_product_category";
            this.Text = "Добавить категорию продукта";
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
    }
}