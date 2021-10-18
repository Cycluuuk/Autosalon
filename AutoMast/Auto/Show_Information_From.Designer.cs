namespace Auto
{
    partial class Show_Information_From
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
            this.dgv_show_info = new System.Windows.Forms.DataGridView();
            this.bt_return = new System.Windows.Forms.Button();
            this.bd_records = new System.Windows.Forms.Button();
            this.bt_car_category = new System.Windows.Forms.Button();
            this.bt_products = new System.Windows.Forms.Button();
            this.bt_staff_info = new System.Windows.Forms.Button();
            this.bt_staff_category = new System.Windows.Forms.Button();
            this.bt_staff_all_info = new System.Windows.Forms.Button();
            this.bt_brigad = new System.Windows.Forms.Button();
            this.bt_workshop = new System.Windows.Forms.Button();
            this.bt_district = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_show_info
            // 
            this.dgv_show_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_info.Location = new System.Drawing.Point(28, 24);
            this.dgv_show_info.Name = "dgv_show_info";
            this.dgv_show_info.RowTemplate.Height = 24;
            this.dgv_show_info.Size = new System.Drawing.Size(1192, 347);
            this.dgv_show_info.TabIndex = 0;
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(1145, 590);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(75, 23);
            this.bt_return.TabIndex = 1;
            this.bt_return.Text = "Назад";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bd_records
            // 
            this.bd_records.Location = new System.Drawing.Point(242, 414);
            this.bd_records.Name = "bd_records";
            this.bd_records.Size = new System.Drawing.Size(171, 39);
            this.bd_records.TabIndex = 2;
            this.bd_records.Text = "Учёт произведённых автомобилей";
            this.bd_records.UseVisualStyleBackColor = true;
            this.bd_records.Click += new System.EventHandler(this.bd_records_Click);
            // 
            // bt_car_category
            // 
            this.bt_car_category.Location = new System.Drawing.Point(242, 539);
            this.bt_car_category.Name = "bt_car_category";
            this.bt_car_category.Size = new System.Drawing.Size(171, 39);
            this.bt_car_category.TabIndex = 3;
            this.bt_car_category.Text = "Категории автомобилей";
            this.bt_car_category.UseVisualStyleBackColor = true;
            this.bt_car_category.Click += new System.EventHandler(this.bt_car_category_Click);
            // 
            // bt_products
            // 
            this.bt_products.Location = new System.Drawing.Point(242, 474);
            this.bt_products.Name = "bt_products";
            this.bt_products.Size = new System.Drawing.Size(171, 39);
            this.bt_products.TabIndex = 4;
            this.bt_products.Text = "Выпускаемые продукты";
            this.bt_products.UseVisualStyleBackColor = true;
            this.bt_products.Click += new System.EventHandler(this.bt_products_Click);
            // 
            // bt_staff_info
            // 
            this.bt_staff_info.Location = new System.Drawing.Point(526, 414);
            this.bt_staff_info.Name = "bt_staff_info";
            this.bt_staff_info.Size = new System.Drawing.Size(171, 39);
            this.bt_staff_info.TabIndex = 5;
            this.bt_staff_info.Text = "Информация о сотрудниках";
            this.bt_staff_info.UseVisualStyleBackColor = true;
            this.bt_staff_info.Click += new System.EventHandler(this.bt_staff_info_Click);
            // 
            // bt_staff_category
            // 
            this.bt_staff_category.Location = new System.Drawing.Point(526, 539);
            this.bt_staff_category.Name = "bt_staff_category";
            this.bt_staff_category.Size = new System.Drawing.Size(171, 39);
            this.bt_staff_category.TabIndex = 6;
            this.bt_staff_category.Text = "Категории сотрудников ";
            this.bt_staff_category.UseVisualStyleBackColor = true;
            this.bt_staff_category.Click += new System.EventHandler(this.bt_staff_category_Click);
            // 
            // bt_staff_all_info
            // 
            this.bt_staff_all_info.Location = new System.Drawing.Point(526, 474);
            this.bt_staff_all_info.Name = "bt_staff_all_info";
            this.bt_staff_all_info.Size = new System.Drawing.Size(171, 39);
            this.bt_staff_all_info.TabIndex = 7;
            this.bt_staff_all_info.Text = "Личная информация сотрудников";
            this.bt_staff_all_info.UseVisualStyleBackColor = true;
            this.bt_staff_all_info.Click += new System.EventHandler(this.bt_staff_all_info_Click);
            // 
            // bt_brigad
            // 
            this.bt_brigad.Location = new System.Drawing.Point(792, 414);
            this.bt_brigad.Name = "bt_brigad";
            this.bt_brigad.Size = new System.Drawing.Size(156, 39);
            this.bt_brigad.TabIndex = 8;
            this.bt_brigad.Text = "Бригады";
            this.bt_brigad.UseVisualStyleBackColor = true;
            this.bt_brigad.Click += new System.EventHandler(this.bt_brigad_Click);
            // 
            // bt_workshop
            // 
            this.bt_workshop.Location = new System.Drawing.Point(792, 474);
            this.bt_workshop.Name = "bt_workshop";
            this.bt_workshop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_workshop.Size = new System.Drawing.Size(156, 39);
            this.bt_workshop.TabIndex = 9;
            this.bt_workshop.Text = "Цеха";
            this.bt_workshop.UseVisualStyleBackColor = true;
            this.bt_workshop.Click += new System.EventHandler(this.bt_workshop_Click);
            // 
            // bt_district
            // 
            this.bt_district.Location = new System.Drawing.Point(792, 539);
            this.bt_district.Name = "bt_district";
            this.bt_district.Size = new System.Drawing.Size(156, 39);
            this.bt_district.TabIndex = 10;
            this.bt_district.Text = "Участки";
            this.bt_district.UseVisualStyleBackColor = true;
            this.bt_district.Click += new System.EventHandler(this.bt_district_Click);
            // 
            // Show_Information_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 646);
            this.ControlBox = false;
            this.Controls.Add(this.bt_district);
            this.Controls.Add(this.bt_workshop);
            this.Controls.Add(this.bt_brigad);
            this.Controls.Add(this.bt_staff_all_info);
            this.Controls.Add(this.bt_staff_category);
            this.Controls.Add(this.bt_staff_info);
            this.Controls.Add(this.bt_products);
            this.Controls.Add(this.bt_car_category);
            this.Controls.Add(this.bd_records);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.dgv_show_info);
            this.Name = "Show_Information_From";
            this.Text = "Информация пердприятия";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_show_info;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bd_records;
        private System.Windows.Forms.Button bt_car_category;
        private System.Windows.Forms.Button bt_products;
        private System.Windows.Forms.Button bt_staff_info;
        private System.Windows.Forms.Button bt_staff_category;
        private System.Windows.Forms.Button bt_staff_all_info;
        private System.Windows.Forms.Button bt_brigad;
        private System.Windows.Forms.Button bt_workshop;
        private System.Windows.Forms.Button bt_district;
    }
}