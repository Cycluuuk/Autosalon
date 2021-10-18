namespace Auto
{
    partial class Add_Information_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.bt_add_staff = new System.Windows.Forms.Button();
            this.bt_add_staff_category = new System.Windows.Forms.Button();
            this.bt_add_brigade = new System.Windows.Forms.Button();
            this.bt_add_district = new System.Windows.Forms.Button();
            this.bt_add_prod_category = new System.Windows.Forms.Button();
            this.bt_add_prod = new System.Windows.Forms.Button();
            this.bt_add_prod_record = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_change_staff = new System.Windows.Forms.Button();
            this.bt_change_staff_personal = new System.Windows.Forms.Button();
            this.bt_change_staff_category = new System.Windows.Forms.Button();
            this.bt_change_brigade = new System.Windows.Forms.Button();
            this.bt_change_district = new System.Windows.Forms.Button();
            this.bt_change_prod_category = new System.Windows.Forms.Button();
            this.bt_change_prod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изменение данных:";
            // 
            // bt_add_staff
            // 
            this.bt_add_staff.Location = new System.Drawing.Point(73, 90);
            this.bt_add_staff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_staff.Name = "bt_add_staff";
            this.bt_add_staff.Size = new System.Drawing.Size(225, 53);
            this.bt_add_staff.TabIndex = 2;
            this.bt_add_staff.Text = "Добавить сотрудника";
            this.bt_add_staff.UseVisualStyleBackColor = true;
            this.bt_add_staff.Click += new System.EventHandler(this.bt_add_staff_Click);
            // 
            // bt_add_staff_category
            // 
            this.bt_add_staff_category.Location = new System.Drawing.Point(73, 169);
            this.bt_add_staff_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_staff_category.Name = "bt_add_staff_category";
            this.bt_add_staff_category.Size = new System.Drawing.Size(225, 52);
            this.bt_add_staff_category.TabIndex = 3;
            this.bt_add_staff_category.Text = "Добавить категорию сотрудника";
            this.bt_add_staff_category.UseVisualStyleBackColor = true;
            this.bt_add_staff_category.Click += new System.EventHandler(this.bt_add_staff_category_Click);
            // 
            // bt_add_brigade
            // 
            this.bt_add_brigade.Location = new System.Drawing.Point(359, 90);
            this.bt_add_brigade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_brigade.Name = "bt_add_brigade";
            this.bt_add_brigade.Size = new System.Drawing.Size(225, 53);
            this.bt_add_brigade.TabIndex = 4;
            this.bt_add_brigade.Text = "Добавить бригаду";
            this.bt_add_brigade.UseVisualStyleBackColor = true;
            this.bt_add_brigade.Click += new System.EventHandler(this.bt_add_brigade_Click);
            // 
            // bt_add_district
            // 
            this.bt_add_district.Location = new System.Drawing.Point(359, 169);
            this.bt_add_district.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_district.Name = "bt_add_district";
            this.bt_add_district.Size = new System.Drawing.Size(225, 52);
            this.bt_add_district.TabIndex = 5;
            this.bt_add_district.Text = "Добавить участок";
            this.bt_add_district.UseVisualStyleBackColor = true;
            this.bt_add_district.Click += new System.EventHandler(this.bt_add_district_Click);
            // 
            // bt_add_prod_category
            // 
            this.bt_add_prod_category.Location = new System.Drawing.Point(633, 90);
            this.bt_add_prod_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_prod_category.Name = "bt_add_prod_category";
            this.bt_add_prod_category.Size = new System.Drawing.Size(225, 53);
            this.bt_add_prod_category.TabIndex = 7;
            this.bt_add_prod_category.Text = "Добавить категорию продукта";
            this.bt_add_prod_category.UseVisualStyleBackColor = true;
            this.bt_add_prod_category.Click += new System.EventHandler(this.bt_add_prod_category_Click);
            // 
            // bt_add_prod
            // 
            this.bt_add_prod.Location = new System.Drawing.Point(633, 169);
            this.bt_add_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_prod.Name = "bt_add_prod";
            this.bt_add_prod.Size = new System.Drawing.Size(225, 52);
            this.bt_add_prod.TabIndex = 8;
            this.bt_add_prod.Text = "Добавить продукт";
            this.bt_add_prod.UseVisualStyleBackColor = true;
            this.bt_add_prod.Click += new System.EventHandler(this.bt_add_prod_Click);
            // 
            // bt_add_prod_record
            // 
            this.bt_add_prod_record.Location = new System.Drawing.Point(912, 90);
            this.bt_add_prod_record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_prod_record.Name = "bt_add_prod_record";
            this.bt_add_prod_record.Size = new System.Drawing.Size(248, 130);
            this.bt_add_prod_record.TabIndex = 9;
            this.bt_add_prod_record.Text = "Добавить произведённый продукт";
            this.bt_add_prod_record.UseVisualStyleBackColor = true;
            this.bt_add_prod_record.Click += new System.EventHandler(this.bt_add_prod_record_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(1040, 676);
            this.bt_return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(120, 41);
            this.bt_return.TabIndex = 10;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_change_staff
            // 
            this.bt_change_staff.Location = new System.Drawing.Point(359, 465);
            this.bt_change_staff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_staff.Name = "bt_change_staff";
            this.bt_change_staff.Size = new System.Drawing.Size(225, 47);
            this.bt_change_staff.TabIndex = 11;
            this.bt_change_staff.Text = "Изменить участок";
            this.bt_change_staff.UseVisualStyleBackColor = true;
            this.bt_change_staff.Click += new System.EventHandler(this.bt_change_staff_Click);
            // 
            // bt_change_staff_personal
            // 
            this.bt_change_staff_personal.Location = new System.Drawing.Point(73, 460);
            this.bt_change_staff_personal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_staff_personal.Name = "bt_change_staff_personal";
            this.bt_change_staff_personal.Size = new System.Drawing.Size(225, 50);
            this.bt_change_staff_personal.TabIndex = 12;
            this.bt_change_staff_personal.Text = "Изменить личные данные сотрудника";
            this.bt_change_staff_personal.UseVisualStyleBackColor = true;
            this.bt_change_staff_personal.Click += new System.EventHandler(this.bt_change_staff_personal_Click);
            // 
            // bt_change_staff_category
            // 
            this.bt_change_staff_category.Location = new System.Drawing.Point(73, 540);
            this.bt_change_staff_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_staff_category.Name = "bt_change_staff_category";
            this.bt_change_staff_category.Size = new System.Drawing.Size(225, 52);
            this.bt_change_staff_category.TabIndex = 13;
            this.bt_change_staff_category.Text = "Изменить категорию сотрудников";
            this.bt_change_staff_category.UseVisualStyleBackColor = true;
            this.bt_change_staff_category.Click += new System.EventHandler(this.bt_change_staff_category_Click);
            // 
            // bt_change_brigade
            // 
            this.bt_change_brigade.Location = new System.Drawing.Point(359, 388);
            this.bt_change_brigade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_brigade.Name = "bt_change_brigade";
            this.bt_change_brigade.Size = new System.Drawing.Size(225, 47);
            this.bt_change_brigade.TabIndex = 14;
            this.bt_change_brigade.Text = "Изменить бригаду";
            this.bt_change_brigade.UseVisualStyleBackColor = true;
            this.bt_change_brigade.Click += new System.EventHandler(this.bt_change_brigade_Click);
            // 
            // bt_change_district
            // 
            this.bt_change_district.Location = new System.Drawing.Point(73, 388);
            this.bt_change_district.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_district.Name = "bt_change_district";
            this.bt_change_district.Size = new System.Drawing.Size(225, 50);
            this.bt_change_district.TabIndex = 15;
            this.bt_change_district.Text = "Изменить данные сотрудника";
            this.bt_change_district.UseVisualStyleBackColor = true;
            this.bt_change_district.Click += new System.EventHandler(this.bt_change_district_Click);
            // 
            // bt_change_prod_category
            // 
            this.bt_change_prod_category.Location = new System.Drawing.Point(633, 388);
            this.bt_change_prod_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_prod_category.Name = "bt_change_prod_category";
            this.bt_change_prod_category.Size = new System.Drawing.Size(225, 47);
            this.bt_change_prod_category.TabIndex = 17;
            this.bt_change_prod_category.Text = "Изменть категорию продукта";
            this.bt_change_prod_category.UseVisualStyleBackColor = true;
            this.bt_change_prod_category.Click += new System.EventHandler(this.button16_Click);
            // 
            // bt_change_prod
            // 
            this.bt_change_prod.Location = new System.Drawing.Point(633, 460);
            this.bt_change_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_prod.Name = "bt_change_prod";
            this.bt_change_prod.Size = new System.Drawing.Size(225, 52);
            this.bt_change_prod.TabIndex = 18;
            this.bt_change_prod.Text = "Изменить продукт";
            this.bt_change_prod.UseVisualStyleBackColor = true;
            this.bt_change_prod.Click += new System.EventHandler(this.bt_change_prod_Click);
            // 
            // Add_Information_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 751);
            this.ControlBox = false;
            this.Controls.Add(this.bt_change_prod);
            this.Controls.Add(this.bt_change_prod_category);
            this.Controls.Add(this.bt_change_district);
            this.Controls.Add(this.bt_change_brigade);
            this.Controls.Add(this.bt_change_staff_category);
            this.Controls.Add(this.bt_change_staff_personal);
            this.Controls.Add(this.bt_change_staff);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.bt_add_prod_record);
            this.Controls.Add(this.bt_add_prod);
            this.Controls.Add(this.bt_add_prod_category);
            this.Controls.Add(this.bt_add_district);
            this.Controls.Add(this.bt_add_brigade);
            this.Controls.Add(this.bt_add_staff_category);
            this.Controls.Add(this.bt_add_staff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Add_Information_Form";
            this.Text = "Изменение данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_add_staff;
        private System.Windows.Forms.Button bt_add_staff_category;
        private System.Windows.Forms.Button bt_add_brigade;
        private System.Windows.Forms.Button bt_add_district;
        private System.Windows.Forms.Button bt_add_prod_category;
        private System.Windows.Forms.Button bt_add_prod;
        private System.Windows.Forms.Button bt_add_prod_record;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_change_staff;
        private System.Windows.Forms.Button bt_change_staff_personal;
        private System.Windows.Forms.Button bt_change_staff_category;
        private System.Windows.Forms.Button bt_change_brigade;
        private System.Windows.Forms.Button bt_change_district;
        private System.Windows.Forms.Button bt_change_prod_category;
        private System.Windows.Forms.Button bt_change_prod;
    }
}