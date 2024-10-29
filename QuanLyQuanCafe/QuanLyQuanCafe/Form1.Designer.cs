namespace QuanLyQuanCafe
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
            this.lvMenu = new System.Windows.Forms.ListView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMenu
            // 
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(12, 54);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(719, 258);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(749, 54);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(131, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(613, 397);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(118, 23);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Thanh Toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 16;
            this.lbCart.Items.AddRange(new object[] {
            "Các đồ uống đã đặt trong giỏ hàng"});
            this.lbCart.Location = new System.Drawing.Point(12, 308);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(719, 84);
            this.lbCart.TabIndex = 3;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(383, 400);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(84, 16);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Tổng số tiền:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(749, 106);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(131, 27);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Thêm vào giỏ hàng";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Quán Cafe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lvMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCart;
    }
}

