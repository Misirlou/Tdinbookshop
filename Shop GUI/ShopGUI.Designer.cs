namespace Shop_GUI
{
    partial class ShopGUI
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
            this.Orders = new System.Windows.Forms.ListBox();
            this.Stock = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Orders
            // 
            this.Orders.FormattingEnabled = true;
            this.Orders.Location = new System.Drawing.Point(13, 13);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(118, 186);
            this.Orders.TabIndex = 0;
            // 
            // Stock
            // 
            this.Stock.FormattingEnabled = true;
            this.Stock.Location = new System.Drawing.Point(138, 13);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(127, 186);
            this.Stock.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 157);
            this.textBox1.TabIndex = 3;
            // 
            // ShopGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 280);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Orders);
            this.Name = "ShopGUI";
            this.Text = "Shop GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Orders;
        private System.Windows.Forms.ListBox Stock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

