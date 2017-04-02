namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.country_combobox = new System.Windows.Forms.ComboBox();
            this.cities_listbox = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.add_city_butt = new System.Windows.Forms.TextBox();
            this.population = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.major_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.population)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.area)).BeginInit();
            this.SuspendLayout();
            // 
            // country_combobox
            // 
            this.country_combobox.FormattingEnabled = true;
            this.country_combobox.Location = new System.Drawing.Point(12, 14);
            this.country_combobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.country_combobox.Name = "country_combobox";
            this.country_combobox.Size = new System.Drawing.Size(149, 24);
            this.country_combobox.TabIndex = 0;
            this.country_combobox.Text = "Select country";
            this.country_combobox.SelectedIndexChanged += new System.EventHandler(this.country_combobox_SelectedIndexChanged);
            // 
            // cities_listbox
            // 
            this.cities_listbox.FormattingEnabled = true;
            this.cities_listbox.ItemHeight = 16;
            this.cities_listbox.Location = new System.Drawing.Point(12, 54);
            this.cities_listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cities_listbox.Name = "cities_listbox";
            this.cities_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cities_listbox.Size = new System.Drawing.Size(149, 116);
            this.cities_listbox.TabIndex = 1;
            this.cities_listbox.SelectedIndexChanged += new System.EventHandler(this.cities_listbox_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Enabled = false;
            this.add_button.Font = new System.Drawing.Font("HP Simplified", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(167, 93);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(118, 35);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("HP Simplified", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(167, 54);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 35);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // add_city_butt
            // 
            this.add_city_butt.Location = new System.Drawing.Point(167, 14);
            this.add_city_butt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_city_butt.Name = "add_city_butt";
            this.add_city_butt.Size = new System.Drawing.Size(118, 22);
            this.add_city_butt.TabIndex = 4;
            this.add_city_butt.Text = "Enter city name here...";
            this.add_city_butt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_city_butt_MouseClick);
            // 
            // population
            // 
            this.population.Location = new System.Drawing.Point(85, 37);
            this.population.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.population.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(120, 22);
            this.population.TabIndex = 5;
            this.population.ValueChanged += new System.EventHandler(this.population_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.major_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.area);
            this.groupBox1.Controls.Add(this.population);
            this.groupBox1.Location = new System.Drawing.Point(293, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(210, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Major";
            // 
            // major_textbox
            // 
            this.major_textbox.Location = new System.Drawing.Point(85, 115);
            this.major_textbox.Name = "major_textbox";
            this.major_textbox.Size = new System.Drawing.Size(119, 22);
            this.major_textbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Population";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(85, 77);
            this.area.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(120, 22);
            this.area.TabIndex = 6;
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("HP Simplified", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(167, 132);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(118, 35);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 176);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_city_butt);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.cities_listbox);
            this.Controls.Add(this.country_combobox);
            this.Font = new System.Drawing.Font("HP Simplified", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.population)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox country_combobox;
        private System.Windows.Forms.ListBox cities_listbox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox add_city_butt;
        private System.Windows.Forms.NumericUpDown population;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox major_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
    }
}

