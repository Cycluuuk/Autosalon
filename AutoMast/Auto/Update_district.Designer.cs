namespace Auto
{
    partial class Update_district
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
            this.cb_brigade = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(54, 116);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 23;
            this.bt_select.Text = "Выбрать";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // cm_id
            // 
            this.cm_id.FormattingEnabled = true;
            this.cm_id.Location = new System.Drawing.Point(54, 76);
            this.cm_id.Name = "cm_id";
            this.cm_id.Size = new System.Drawing.Size(233, 21);
            this.cm_id.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Сотрудник:";
            // 
            // bt_apply
            // 
            this.bt_apply.Location = new System.Drawing.Point(110, 323);
            this.bt_apply.Name = "bt_apply";
            this.bt_apply.Size = new System.Drawing.Size(117, 34);
            this.bt_apply.TabIndex = 16;
            this.bt_apply.Text = "Сохранить";
            this.bt_apply.UseVisualStyleBackColor = true;
            this.bt_apply.Click += new System.EventHandler(this.bt_apply_Click);
            // 
            // bt_retrun
            // 
            this.bt_retrun.Location = new System.Drawing.Point(110, 363);
            this.bt_retrun.Name = "bt_retrun";
            this.bt_retrun.Size = new System.Drawing.Size(117, 36);
            this.bt_retrun.TabIndex = 15;
            this.bt_retrun.Text = "Назад";
            this.bt_retrun.UseVisualStyleBackColor = true;
            this.bt_retrun.Click += new System.EventHandler(this.bt_retrun_Click);
            // 
            // cb_brigade
            // 
            this.cb_brigade.FormattingEnabled = true;
            this.cb_brigade.Location = new System.Drawing.Point(54, 239);
            this.cb_brigade.Name = "cb_brigade";
            this.cb_brigade.Size = new System.Drawing.Size(233, 21);
            this.cb_brigade.TabIndex = 27;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(54, 175);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(233, 21);
            this.cb_category.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Бригада:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Категория:";
            // 
            // Update_district
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 419);
            this.ControlBox = false;
            this.Controls.Add(this.cb_brigade);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.cm_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_apply);
            this.Controls.Add(this.bt_retrun);
            this.Name = "Update_district";
            this.Text = "Изменить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.ComboBox cm_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_apply;
        private System.Windows.Forms.Button bt_retrun;
        private System.Windows.Forms.ComboBox cb_brigade;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}