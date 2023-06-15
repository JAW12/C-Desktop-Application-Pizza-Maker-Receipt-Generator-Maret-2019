namespace Tugas_Praktikum_Minggu_3
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
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cbVF = new System.Windows.Forms.ComboBox();
            this.cbSauce = new System.Windows.Forms.ComboBox();
            this.cbTopping = new System.Windows.Forms.ComboBox();
            this.cbMeat = new System.Windows.Forms.ComboBox();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblVegFruit = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblMeat = new System.Windows.Forms.Label();
            this.lblBasePizza = new System.Windows.Forms.Label();
            this.gbStok = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.gbOrder.SuspendLayout();
            this.gbStok.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.btnOrder);
            this.gbOrder.Controls.Add(this.cbVF);
            this.gbOrder.Controls.Add(this.cbSauce);
            this.gbOrder.Controls.Add(this.cbTopping);
            this.gbOrder.Controls.Add(this.cbMeat);
            this.gbOrder.Controls.Add(this.cbPizza);
            this.gbOrder.Controls.Add(this.rbLarge);
            this.gbOrder.Controls.Add(this.rbMedium);
            this.gbOrder.Controls.Add(this.rbSmall);
            this.gbOrder.Controls.Add(this.lblSize);
            this.gbOrder.Controls.Add(this.lblVegFruit);
            this.gbOrder.Controls.Add(this.lblSauce);
            this.gbOrder.Controls.Add(this.lblTopping);
            this.gbOrder.Controls.Add(this.lblMeat);
            this.gbOrder.Controls.Add(this.lblBasePizza);
            this.gbOrder.Location = new System.Drawing.Point(9, 10);
            this.gbOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOrder.Size = new System.Drawing.Size(255, 403);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(140, 321);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 43);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cbVF
            // 
            this.cbVF.FormattingEnabled = true;
            this.cbVF.Items.AddRange(new object[] {
            "Tomatoes - 10",
            "Mushroom - 10",
            "Pepper - 10",
            "Pineapple - 10"});
            this.cbVF.Location = new System.Drawing.Point(105, 252);
            this.cbVF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVF.Name = "cbVF";
            this.cbVF.Size = new System.Drawing.Size(138, 21);
            this.cbVF.TabIndex = 2;
            this.cbVF.SelectedIndexChanged += new System.EventHandler(this.cbVF_SelectedIndexChanged);
            // 
            // cbSauce
            // 
            this.cbSauce.FormattingEnabled = true;
            this.cbSauce.Items.AddRange(new object[] {
            "Ketchup - 10",
            "Mustard - 10",
            "BBQ - 10"});
            this.cbSauce.Location = new System.Drawing.Point(105, 197);
            this.cbSauce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSauce.Name = "cbSauce";
            this.cbSauce.Size = new System.Drawing.Size(138, 21);
            this.cbSauce.TabIndex = 2;
            this.cbSauce.SelectedIndexChanged += new System.EventHandler(this.cbSauce_SelectedIndexChanged);
            // 
            // cbTopping
            // 
            this.cbTopping.FormattingEnabled = true;
            this.cbTopping.Items.AddRange(new object[] {
            "Cheese - 10",
            "Marshmellow - 10",
            "Shrimp - 10"});
            this.cbTopping.Location = new System.Drawing.Point(105, 141);
            this.cbTopping.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTopping.Name = "cbTopping";
            this.cbTopping.Size = new System.Drawing.Size(138, 21);
            this.cbTopping.TabIndex = 2;
            this.cbTopping.SelectedIndexChanged += new System.EventHandler(this.cbTopping_SelectedIndexChanged);
            // 
            // cbMeat
            // 
            this.cbMeat.FormattingEnabled = true;
            this.cbMeat.Items.AddRange(new object[] {
            "Beef - 10",
            "Chicken - 10",
            "Fish - 10"});
            this.cbMeat.Location = new System.Drawing.Point(105, 84);
            this.cbMeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMeat.Name = "cbMeat";
            this.cbMeat.Size = new System.Drawing.Size(138, 21);
            this.cbMeat.TabIndex = 2;
            this.cbMeat.SelectedIndexChanged += new System.EventHandler(this.cbMeat_SelectedIndexChanged);
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Items.AddRange(new object[] {
            "Plain Pizza - 10",
            "Black Pizza - 10"});
            this.cbPizza.Location = new System.Drawing.Point(105, 28);
            this.cbPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(138, 21);
            this.cbPizza.TabIndex = 2;
            this.cbPizza.SelectedIndexChanged += new System.EventHandler(this.cbPizza_SelectedIndexChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(49, 359);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 1;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(49, 334);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(49, 310);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(11, 310);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size :";
            // 
            // lblVegFruit
            // 
            this.lblVegFruit.AutoSize = true;
            this.lblVegFruit.Location = new System.Drawing.Point(11, 254);
            this.lblVegFruit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVegFruit.Name = "lblVegFruit";
            this.lblVegFruit.Size = new System.Drawing.Size(91, 13);
            this.lblVegFruit.TabIndex = 0;
            this.lblVegFruit.Text = "Vegetables/Fruit :";
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Location = new System.Drawing.Point(11, 199);
            this.lblSauce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(44, 13);
            this.lblSauce.TabIndex = 0;
            this.lblSauce.Text = "Sauce :";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Location = new System.Drawing.Point(11, 143);
            this.lblTopping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(52, 13);
            this.lblTopping.TabIndex = 0;
            this.lblTopping.Text = "Topping :";
            // 
            // lblMeat
            // 
            this.lblMeat.AutoSize = true;
            this.lblMeat.Location = new System.Drawing.Point(11, 86);
            this.lblMeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeat.Name = "lblMeat";
            this.lblMeat.Size = new System.Drawing.Size(37, 13);
            this.lblMeat.TabIndex = 0;
            this.lblMeat.Text = "Meat :";
            // 
            // lblBasePizza
            // 
            this.lblBasePizza.AutoSize = true;
            this.lblBasePizza.Location = new System.Drawing.Point(11, 30);
            this.lblBasePizza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasePizza.Name = "lblBasePizza";
            this.lblBasePizza.Size = new System.Drawing.Size(65, 13);
            this.lblBasePizza.TabIndex = 0;
            this.lblBasePizza.Text = "Base Pizza :";
            // 
            // gbStok
            // 
            this.gbStok.Controls.Add(this.btnReport);
            this.gbStok.Location = new System.Drawing.Point(9, 430);
            this.gbStok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbStok.Name = "gbStok";
            this.gbStok.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbStok.Size = new System.Drawing.Size(255, 236);
            this.gbStok.TabIndex = 1;
            this.gbStok.TabStop = false;
            this.gbStok.Text = "Stok";
            this.gbStok.Paint += new System.Windows.Forms.PaintEventHandler(this.gbStok_Paint);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(14, 22);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(228, 32);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 761);
            this.Controls.Add(this.gbStok);
            this.Controls.Add(this.gbOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.gbStok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.ComboBox cbVF;
        private System.Windows.Forms.ComboBox cbSauce;
        private System.Windows.Forms.ComboBox cbTopping;
        private System.Windows.Forms.ComboBox cbMeat;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblVegFruit;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblMeat;
        private System.Windows.Forms.Label lblBasePizza;
        private System.Windows.Forms.GroupBox gbStok;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReport;
    }
}

