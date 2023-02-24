namespace RegisterPizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_pizza_selection = new System.Windows.Forms.Label();
            this.cb_pizza_selection = new System.Windows.Forms.ComboBox();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.rb_large = new System.Windows.Forms.RadioButton();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.gb_dobavki = new System.Windows.Forms.GroupBox();
            this.check_gorchica = new System.Windows.Forms.CheckBox();
            this.check_cubrica = new System.Windows.Forms.CheckBox();
            this.check_mayonese = new System.Windows.Forms.CheckBox();
            this.check_ketchup = new System.Windows.Forms.CheckBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.gb_size.SuspendLayout();
            this.gb_dobavki.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pizza_selection
            // 
            this.lbl_pizza_selection.AutoSize = true;
            this.lbl_pizza_selection.BackColor = System.Drawing.Color.White;
            this.lbl_pizza_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lbl_pizza_selection.ForeColor = System.Drawing.Color.Black;
            this.lbl_pizza_selection.Location = new System.Drawing.Point(51, 54);
            this.lbl_pizza_selection.Name = "lbl_pizza_selection";
            this.lbl_pizza_selection.Size = new System.Drawing.Size(206, 31);
            this.lbl_pizza_selection.TabIndex = 0;
            this.lbl_pizza_selection.Text = "Избор на пица:";
            // 
            // cb_pizza_selection
            // 
            this.cb_pizza_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_pizza_selection.FormattingEnabled = true;
            this.cb_pizza_selection.Items.AddRange(new object[] {
            "Маргарита",
            "Пеперони",
            "Четири сирена",
            "Вегетариана",
            "Прошуто"});
            this.cb_pizza_selection.Location = new System.Drawing.Point(57, 101);
            this.cb_pizza_selection.Name = "cb_pizza_selection";
            this.cb_pizza_selection.Size = new System.Drawing.Size(200, 25);
            this.cb_pizza_selection.TabIndex = 1;
            // 
            // gb_size
            // 
            this.gb_size.BackColor = System.Drawing.Color.White;
            this.gb_size.Controls.Add(this.rb_large);
            this.gb_size.Controls.Add(this.rb_small);
            this.gb_size.Controls.Add(this.rb_medium);
            this.gb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.gb_size.Location = new System.Drawing.Point(364, 88);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(283, 286);
            this.gb_size.TabIndex = 2;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Размер";
            // 
            // rb_large
            // 
            this.rb_large.AutoSize = true;
            this.rb_large.BackColor = System.Drawing.Color.White;
            this.rb_large.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.rb_large.Location = new System.Drawing.Point(28, 208);
            this.rb_large.Name = "rb_large";
            this.rb_large.Size = new System.Drawing.Size(129, 35);
            this.rb_large.TabIndex = 5;
            this.rb_large.TabStop = true;
            this.rb_large.Text = "Голяма";
            this.rb_large.UseVisualStyleBackColor = false;
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.BackColor = System.Drawing.Color.White;
            this.rb_small.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.rb_small.Location = new System.Drawing.Point(28, 63);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(116, 35);
            this.rb_small.TabIndex = 3;
            this.rb_small.TabStop = true;
            this.rb_small.Text = "Малка";
            this.rb_small.UseVisualStyleBackColor = false;
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.BackColor = System.Drawing.Color.White;
            this.rb_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.rb_medium.Location = new System.Drawing.Point(28, 129);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(131, 35);
            this.rb_medium.TabIndex = 4;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Средна";
            this.rb_medium.UseVisualStyleBackColor = false;
            // 
            // gb_dobavki
            // 
            this.gb_dobavki.BackColor = System.Drawing.Color.White;
            this.gb_dobavki.Controls.Add(this.check_gorchica);
            this.gb_dobavki.Controls.Add(this.check_cubrica);
            this.gb_dobavki.Controls.Add(this.check_mayonese);
            this.gb_dobavki.Controls.Add(this.check_ketchup);
            this.gb_dobavki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.gb_dobavki.Location = new System.Drawing.Point(36, 162);
            this.gb_dobavki.Name = "gb_dobavki";
            this.gb_dobavki.Size = new System.Drawing.Size(305, 344);
            this.gb_dobavki.TabIndex = 3;
            this.gb_dobavki.TabStop = false;
            this.gb_dobavki.Text = "Добавки";
            // 
            // check_gorchica
            // 
            this.check_gorchica.AutoSize = true;
            this.check_gorchica.BackColor = System.Drawing.Color.White;
            this.check_gorchica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.check_gorchica.Location = new System.Drawing.Point(65, 244);
            this.check_gorchica.Name = "check_gorchica";
            this.check_gorchica.Size = new System.Drawing.Size(136, 34);
            this.check_gorchica.TabIndex = 7;
            this.check_gorchica.Text = "Горчица";
            this.check_gorchica.UseVisualStyleBackColor = false;
            // 
            // check_cubrica
            // 
            this.check_cubrica.AutoSize = true;
            this.check_cubrica.BackColor = System.Drawing.Color.White;
            this.check_cubrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.check_cubrica.Location = new System.Drawing.Point(62, 178);
            this.check_cubrica.Name = "check_cubrica";
            this.check_cubrica.Size = new System.Drawing.Size(139, 34);
            this.check_cubrica.TabIndex = 6;
            this.check_cubrica.Text = "Чубрица";
            this.check_cubrica.UseVisualStyleBackColor = false;
            this.check_cubrica.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // check_mayonese
            // 
            this.check_mayonese.AutoSize = true;
            this.check_mayonese.BackColor = System.Drawing.Color.White;
            this.check_mayonese.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.check_mayonese.Location = new System.Drawing.Point(62, 110);
            this.check_mayonese.Name = "check_mayonese";
            this.check_mayonese.Size = new System.Drawing.Size(155, 34);
            this.check_mayonese.TabIndex = 5;
            this.check_mayonese.Text = "Майонеза";
            this.check_mayonese.UseVisualStyleBackColor = false;
            // 
            // check_ketchup
            // 
            this.check_ketchup.AutoSize = true;
            this.check_ketchup.BackColor = System.Drawing.Color.White;
            this.check_ketchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.check_ketchup.Location = new System.Drawing.Point(62, 45);
            this.check_ketchup.Name = "check_ketchup";
            this.check_ketchup.Size = new System.Drawing.Size(119, 34);
            this.check_ketchup.TabIndex = 4;
            this.check_ketchup.Text = "Кетчуп";
            this.check_ketchup.UseVisualStyleBackColor = false;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_order.Image")));
            this.btn_order.Location = new System.Drawing.Point(405, 498);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(168, 72);
            this.btn_order.TabIndex = 4;
            this.btn_order.Text = "Поръчай";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 631);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.gb_dobavki);
            this.Controls.Add(this.gb_size);
            this.Controls.Add(this.cb_pizza_selection);
            this.Controls.Add(this.lbl_pizza_selection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Поръчка на пица";
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.gb_dobavki.ResumeLayout(false);
            this.gb_dobavki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pizza_selection;
        private System.Windows.Forms.ComboBox cb_pizza_selection;
        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.RadioButton rb_large;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.GroupBox gb_dobavki;
        private System.Windows.Forms.CheckBox check_gorchica;
        private System.Windows.Forms.CheckBox check_cubrica;
        private System.Windows.Forms.CheckBox check_mayonese;
        private System.Windows.Forms.CheckBox check_ketchup;
        private System.Windows.Forms.Button btn_order;
    }
}

