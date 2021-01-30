﻿
namespace SDM_Coffee_Shop.UserControls
{
    partial class GridControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.PBGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Overlock Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(29, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Overlock Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrice.Location = new System.Drawing.Point(189, 284);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 34);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddToCart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddToCart.Location = new System.Drawing.Point(0, 0);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(35, 27);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Order!";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Visible = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // PBGrid
            // 
            this.PBGrid.BackColor = System.Drawing.Color.White;
            this.PBGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBGrid.Location = new System.Drawing.Point(35, 38);
            this.PBGrid.Name = "PBGrid";
            this.PBGrid.Size = new System.Drawing.Size(225, 250);
            this.PBGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBGrid.TabIndex = 4;
            this.PBGrid.TabStop = false;
            this.PBGrid.Click += new System.EventHandler(this.btnInfosmall_Click);
            this.PBGrid.MouseEnter += new System.EventHandler(this.PBGrid_MouseEnter);
            this.PBGrid.MouseLeave += new System.EventHandler(this.buttonHoover_MouseLeave);
            // 
            // GridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::SDM_Coffee_Shop.Properties.Resources.Overlay_blanc;
            this.Controls.Add(this.PBGrid);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "GridControl";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Size = new System.Drawing.Size(295, 327);
            this.MouseLeave += new System.EventHandler(this.buttonHoover_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.PictureBox PBGrid;
    }
}
