namespace HenryAng_Homework1
{
    partial class FrmRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestaurant));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.btnDailyFish = new System.Windows.Forms.Button();
            this.btnTodaySoup = new System.Windows.Forms.Button();
            this.grpBoxFoodItems = new System.Windows.Forms.GroupBox();
            this.picBoxTodaySoup = new System.Windows.Forms.PictureBox();
            this.picBoxChefSpecial = new System.Windows.Forms.PictureBox();
            this.picBoxDailyFish = new System.Windows.Forms.PictureBox();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.grpBoxFoodItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTodaySoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChefSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDailyFish)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(38, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(716, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Countryside Diner ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(648, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(266, 31);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(126, 55);
            this.btnSpecial.TabIndex = 2;
            this.btnSpecial.Text = "Chef\'s Special";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // btnDailyFish
            // 
            this.btnDailyFish.Location = new System.Drawing.Point(497, 31);
            this.btnDailyFish.Name = "btnDailyFish";
            this.btnDailyFish.Size = new System.Drawing.Size(126, 55);
            this.btnDailyFish.TabIndex = 4;
            this.btnDailyFish.Text = "Daily Fish";
            this.btnDailyFish.UseVisualStyleBackColor = true;
            this.btnDailyFish.Click += new System.EventHandler(this.btnDailyDish_Click);
            // 
            // btnTodaySoup
            // 
            this.btnTodaySoup.Location = new System.Drawing.Point(39, 31);
            this.btnTodaySoup.Name = "btnTodaySoup";
            this.btnTodaySoup.Size = new System.Drawing.Size(126, 55);
            this.btnTodaySoup.TabIndex = 1;
            this.btnTodaySoup.Text = "Today\'s Soup";
            this.btnTodaySoup.UseVisualStyleBackColor = true;
            this.btnTodaySoup.Click += new System.EventHandler(this.btnTodaySoup_Click);
            // 
            // grpBoxFoodItems
            // 
            this.grpBoxFoodItems.Controls.Add(this.btnDailyFish);
            this.grpBoxFoodItems.Controls.Add(this.btnTodaySoup);
            this.grpBoxFoodItems.Controls.Add(this.btnSpecial);
            this.grpBoxFoodItems.Location = new System.Drawing.Point(64, 91);
            this.grpBoxFoodItems.Name = "grpBoxFoodItems";
            this.grpBoxFoodItems.Size = new System.Drawing.Size(649, 108);
            this.grpBoxFoodItems.TabIndex = 5;
            this.grpBoxFoodItems.TabStop = false;
            this.grpBoxFoodItems.Text = "Food Choice Items";
            // 
            // picBoxTodaySoup
            // 
            this.picBoxTodaySoup.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTodaySoup.Image")));
            this.picBoxTodaySoup.Location = new System.Drawing.Point(38, 214);
            this.picBoxTodaySoup.Name = "picBoxTodaySoup";
            this.picBoxTodaySoup.Size = new System.Drawing.Size(219, 190);
            this.picBoxTodaySoup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTodaySoup.TabIndex = 6;
            this.picBoxTodaySoup.TabStop = false;
            this.picBoxTodaySoup.Visible = false;
            // 
            // picBoxChefSpecial
            // 
            this.picBoxChefSpecial.Image = ((System.Drawing.Image)(resources.GetObject("picBoxChefSpecial.Image")));
            this.picBoxChefSpecial.Location = new System.Drawing.Point(290, 214);
            this.picBoxChefSpecial.Name = "picBoxChefSpecial";
            this.picBoxChefSpecial.Size = new System.Drawing.Size(219, 191);
            this.picBoxChefSpecial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChefSpecial.TabIndex = 7;
            this.picBoxChefSpecial.TabStop = false;
            this.picBoxChefSpecial.Visible = false;
            // 
            // picBoxDailyFish
            // 
            this.picBoxDailyFish.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDailyFish.Image")));
            this.picBoxDailyFish.Location = new System.Drawing.Point(535, 214);
            this.picBoxDailyFish.Name = "picBoxDailyFish";
            this.picBoxDailyFish.Size = new System.Drawing.Size(219, 191);
            this.picBoxDailyFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDailyFish.TabIndex = 8;
            this.picBoxDailyFish.TabStop = false;
            this.picBoxDailyFish.Visible = false;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.Black;
            this.lblFoodPrice.Location = new System.Drawing.Point(193, 434);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(393, 39);
            this.lblFoodPrice.TabIndex = 9;
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFoodPrice.Visible = false;
            // 
            // FrmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(786, 501);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.picBoxDailyFish);
            this.Controls.Add(this.picBoxChefSpecial);
            this.Controls.Add(this.picBoxTodaySoup);
            this.Controls.Add(this.grpBoxFoodItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmRestaurant";
            this.Text = "Homework 1 for CSC 3220";
            this.grpBoxFoodItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTodaySoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChefSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDailyFish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Button btnDailyFish;
        private System.Windows.Forms.Button btnTodaySoup;
        private System.Windows.Forms.GroupBox grpBoxFoodItems;
        private System.Windows.Forms.PictureBox picBoxTodaySoup;
        private System.Windows.Forms.PictureBox picBoxChefSpecial;
        private System.Windows.Forms.PictureBox picBoxDailyFish;
        private System.Windows.Forms.Label lblFoodPrice;
    }
}

