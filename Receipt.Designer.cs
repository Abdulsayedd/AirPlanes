namespace AirPlanes
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.HomePage = new System.Windows.Forms.Button();
            this.Ticket_ID = new System.Windows.Forms.Label();
            this.Ticket_From = new System.Windows.Forms.Label();
            this.Ticket_To = new System.Windows.Forms.Label();
            this.Ticket_Price = new System.Windows.Forms.Label();
            this.Ticket_From_Time = new System.Windows.Forms.Label();
            this.Ticket_To_Time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.Color.Transparent;
            this.HomePage.BackgroundImage = global::AirPlanes.Properties.Resources.Home11;
            this.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomePage.FlatAppearance.BorderSize = 0;
            this.HomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePage.Location = new System.Drawing.Point(2, 4);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(28, 27);
            this.HomePage.TabIndex = 11;
            this.HomePage.UseVisualStyleBackColor = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // Ticket_ID
            // 
            this.Ticket_ID.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_ID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ticket_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Ticket_ID.Location = new System.Drawing.Point(216, 368);
            this.Ticket_ID.Name = "Ticket_ID";
            this.Ticket_ID.Size = new System.Drawing.Size(72, 30);
            this.Ticket_ID.TabIndex = 12;
            this.Ticket_ID.Text = "label1";
            this.Ticket_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ticket_From
            // 
            this.Ticket_From.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_From.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_From.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ticket_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Ticket_From.Location = new System.Drawing.Point(67, 447);
            this.Ticket_From.Name = "Ticket_From";
            this.Ticket_From.Size = new System.Drawing.Size(72, 30);
            this.Ticket_From.TabIndex = 12;
            this.Ticket_From.Text = "label1";
            this.Ticket_From.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ticket_To
            // 
            this.Ticket_To.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_To.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_To.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ticket_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Ticket_To.Location = new System.Drawing.Point(367, 447);
            this.Ticket_To.Name = "Ticket_To";
            this.Ticket_To.Size = new System.Drawing.Size(72, 30);
            this.Ticket_To.TabIndex = 12;
            this.Ticket_To.Text = "label1";
            this.Ticket_To.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ticket_Price
            // 
            this.Ticket_Price.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_Price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ticket_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Ticket_Price.Location = new System.Drawing.Point(214, 562);
            this.Ticket_Price.Name = "Ticket_Price";
            this.Ticket_Price.Size = new System.Drawing.Size(72, 30);
            this.Ticket_Price.TabIndex = 12;
            this.Ticket_Price.Text = "label1";
            this.Ticket_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ticket_From_Time
            // 
            this.Ticket_From_Time.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_From_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_From_Time.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ticket_From_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Ticket_From_Time.Location = new System.Drawing.Point(73, 477);
            this.Ticket_From_Time.Name = "Ticket_From_Time";
            this.Ticket_From_Time.Size = new System.Drawing.Size(50, 20);
            this.Ticket_From_Time.TabIndex = 12;
            this.Ticket_From_Time.Text = "label1";
            this.Ticket_From_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ticket_To_Time
            // 
            this.Ticket_To_Time.BackColor = System.Drawing.Color.Transparent;
            this.Ticket_To_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket_To_Time.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ticket_To_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.Ticket_To_Time.Location = new System.Drawing.Point(374, 477);
            this.Ticket_To_Time.Name = "Ticket_To_Time";
            this.Ticket_To_Time.Size = new System.Drawing.Size(50, 20);
            this.Ticket_To_Time.TabIndex = 12;
            this.Ticket_To_Time.Text = "label1";
            this.Ticket_To_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(160, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 182);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirPlanes.Properties.Resources.Receipt1;
            this.ClientSize = new System.Drawing.Size(499, 651);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ticket_Price);
            this.Controls.Add(this.Ticket_To_Time);
            this.Controls.Add(this.Ticket_From_Time);
            this.Controls.Add(this.Ticket_To);
            this.Controls.Add(this.Ticket_From);
            this.Controls.Add(this.Ticket_ID);
            this.Controls.Add(this.HomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button HomePage;
        private Label Ticket_ID;
        private Label Ticket_From;
        private Label Ticket_To;
        private Label Ticket_Price;
        private Label Ticket_From_Time;
        private Label Ticket_To_Time;
        private PictureBox pictureBox1;
    }
}