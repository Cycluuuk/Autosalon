namespace Auto
{
    partial class Main_From
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_show_data = new System.Windows.Forms.Button();
            this.bt_change_data = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_show_data
            // 
            this.bt_show_data.Location = new System.Drawing.Point(108, 59);
            this.bt_show_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_show_data.Name = "bt_show_data";
            this.bt_show_data.Size = new System.Drawing.Size(104, 57);
            this.bt_show_data.TabIndex = 3;
            this.bt_show_data.Text = "Просмотр данных";
            this.bt_show_data.UseVisualStyleBackColor = true;
            this.bt_show_data.Click += new System.EventHandler(this.bt_show_data_Click);
            // 
            // bt_change_data
            // 
            this.bt_change_data.Location = new System.Drawing.Point(267, 59);
            this.bt_change_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_change_data.Name = "bt_change_data";
            this.bt_change_data.Size = new System.Drawing.Size(103, 57);
            this.bt_change_data.TabIndex = 4;
            this.bt_change_data.Text = "Изменение данных";
            this.bt_change_data.UseVisualStyleBackColor = true;
            this.bt_change_data.Click += new System.EventHandler(this.bt_change_data_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(180, 149);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(125, 57);
            this.bt_exit.TabIndex = 5;
            this.bt_exit.Text = "Выход";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 255);
            this.ControlBox = false;
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_change_data);
            this.Controls.Add(this.bt_show_data);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_From";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Main_From_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_show_data;
        private System.Windows.Forms.Button bt_change_data;
        private System.Windows.Forms.Button bt_exit;
    }
}

