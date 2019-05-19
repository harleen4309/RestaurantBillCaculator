namespace A1HarleenKaur
{
    partial class RestaurantBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantBillForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.lblMainCourses = new System.Windows.Forms.Label();
            this.lblAppetizers = new System.Windows.Forms.Label();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.cmbMainCourses = new System.Windows.Forms.ComboBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.cmbBeverages = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStdInfo = new System.Windows.Forms.Label();
            this.listBoxSelection = new System.Windows.Forms.ListBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBoxSubTotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesserts);
            this.groupBox1.Controls.Add(this.lblMainCourses);
            this.groupBox1.Controls.Add(this.lblAppetizers);
            this.groupBox1.Controls.Add(this.lblBeverages);
            this.groupBox1.Controls.Add(this.cmbMainCourses);
            this.groupBox1.Controls.Add(this.cmbAppetizers);
            this.groupBox1.Controls.Add(this.cmbBeverages);
            this.groupBox1.Controls.Add(this.cmbDesserts);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Items";
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Location = new System.Drawing.Point(26, 177);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(57, 14);
            this.lblDesserts.TabIndex = 6;
            this.lblDesserts.Text = "Desserts:";
            // 
            // lblMainCourses
            // 
            this.lblMainCourses.AutoSize = true;
            this.lblMainCourses.Location = new System.Drawing.Point(26, 132);
            this.lblMainCourses.Name = "lblMainCourses";
            this.lblMainCourses.Size = new System.Drawing.Size(87, 14);
            this.lblMainCourses.TabIndex = 5;
            this.lblMainCourses.Text = "Main Courses:";
            // 
            // lblAppetizers
            // 
            this.lblAppetizers.AutoSize = true;
            this.lblAppetizers.Location = new System.Drawing.Point(26, 86);
            this.lblAppetizers.Name = "lblAppetizers";
            this.lblAppetizers.Size = new System.Drawing.Size(71, 14);
            this.lblAppetizers.TabIndex = 4;
            this.lblAppetizers.Text = "Appetizers:";
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Location = new System.Drawing.Point(26, 36);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(69, 14);
            this.lblBeverages.TabIndex = 3;
            this.lblBeverages.Text = "Beverages:";
            // 
            // cmbMainCourses
            // 
            this.cmbMainCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainCourses.FormattingEnabled = true;
            this.cmbMainCourses.Location = new System.Drawing.Point(175, 127);
            this.cmbMainCourses.Name = "cmbMainCourses";
            this.cmbMainCourses.Size = new System.Drawing.Size(140, 22);
            this.cmbMainCourses.TabIndex = 2;
            this.cmbMainCourses.SelectedIndexChanged += new System.EventHandler(this.CmbMainCourses_SelectedIndexChanged);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Location = new System.Drawing.Point(175, 77);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(140, 22);
            this.cmbAppetizers.TabIndex = 1;
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.CmbAppetizers_SelectedIndexChanged);
            // 
            // cmbBeverages
            // 
            this.cmbBeverages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeverages.FormattingEnabled = true;
            this.cmbBeverages.Location = new System.Drawing.Point(175, 27);
            this.cmbBeverages.Name = "cmbBeverages";
            this.cmbBeverages.Size = new System.Drawing.Size(140, 22);
            this.cmbBeverages.TabIndex = 0;
            this.cmbBeverages.SelectedIndexChanged += new System.EventHandler(this.CmbBeverages_SelectedIndexChanged);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Location = new System.Drawing.Point(175, 177);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(140, 22);
            this.cmbDesserts.TabIndex = 2;
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.CmbDesserts_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStdInfo);
            this.groupBox2.Location = new System.Drawing.Point(14, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // lblStdInfo
            // 
            this.lblStdInfo.AutoSize = true;
            this.lblStdInfo.Location = new System.Drawing.Point(62, 47);
            this.lblStdInfo.Name = "lblStdInfo";
            this.lblStdInfo.Size = new System.Drawing.Size(0, 14);
            this.lblStdInfo.TabIndex = 0;
            // 
            // listBoxSelection
            // 
            this.listBoxSelection.FormattingEnabled = true;
            this.listBoxSelection.ItemHeight = 14;
            this.listBoxSelection.Location = new System.Drawing.Point(476, 12);
            this.listBoxSelection.Name = "listBoxSelection";
            this.listBoxSelection.Size = new System.Drawing.Size(154, 214);
            this.listBoxSelection.TabIndex = 3;
            
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(450, 277);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(63, 14);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(450, 311);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(75, 14);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax @ 13%:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(450, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 14);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtBoxSubTotal
            // 
            this.txtBoxSubTotal.Location = new System.Drawing.Point(571, 274);
            this.txtBoxSubTotal.Name = "txtBoxSubTotal";
            this.txtBoxSubTotal.ReadOnly = true;
            this.txtBoxSubTotal.Size = new System.Drawing.Size(116, 20);
            this.txtBoxSubTotal.TabIndex = 7;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(571, 308);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.ReadOnly = true;
            this.txtBoxTax.Size = new System.Drawing.Size(116, 20);
            this.txtBoxTax.TabIndex = 8;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(571, 340);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(116, 20);
            this.txtBoxTotal.TabIndex = 9;
            // 
            // btnClearBill
            // 
            this.btnClearBill.Location = new System.Drawing.Point(498, 366);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(87, 25);
            this.btnClearBill.TabIndex = 10;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = true;
            this.btnClearBill.Click += new System.EventHandler(this.BtnClearBill_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(481, 232);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(143, 25);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "Delete Selected Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // RestaurantBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnClearBill);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxTax);
            this.Controls.Add(this.txtBoxSubTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.listBoxSelection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RestaurantBillForm";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMainCourses;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.ComboBox cmbBeverages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.Label lblDesserts;
        private System.Windows.Forms.Label lblMainCourses;
        private System.Windows.Forms.Label lblAppetizers;
        private System.Windows.Forms.Label lblBeverages;
        private System.Windows.Forms.ListBox listBoxSelection;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBoxSubTotal;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.Label lblStdInfo;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}

