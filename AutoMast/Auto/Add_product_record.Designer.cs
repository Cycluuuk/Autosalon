namespace Auto
{
    partial class Add_product_record
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.bt_apply = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.cb_workshop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Количество:";
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(56, 217);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(191, 22);
            this.tb_count.TabIndex = 15;
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(77, 285);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(135, 37);
            this.bt_apply.TabIndex = 14;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(77, 328);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(135, 37);
            this.bt_return.TabIndex = 13;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Цех:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Продукт";
            // 
            // cb_product
            // 
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(56, 72);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(191, 21);
            this.cb_product.TabIndex = 19;
            // 
            // cb_workshop
            // 
            this.cb_workshop.FormattingEnabled = true;
            this.cb_workshop.Location = new System.Drawing.Point(56, 146);
            this.cb_workshop.Name = "cb_workshop";
            this.cb_workshop.Size = new System.Drawing.Size(191, 21);
            this.cb_workshop.TabIndex = 20;
            // 
            // Add_product_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 373);
            this.ControlBox = false;
            this.Controls.Add(this.cb_workshop);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_count);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_return);
            this.Name = "Add_product_record";
            this.Text = "Добавить произведённый продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.ComboBox cb_workshop;
    }
}