namespace Ayubo_Drive
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnRent = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.Yellow;
            this.btnRent.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(39, 90);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(132, 60);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "Rent Calculation ";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.Yellow;
            this.btnDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.Location = new System.Drawing.Point(191, 200);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(132, 60);
            this.btnDay.TabIndex = 1;
            this.btnDay.Text = "Day Tour";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.Yellow;
            this.btnLong.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLong.Location = new System.Drawing.Point(367, 328);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(132, 60);
            this.btnLong.TabIndex = 2;
            this.btnLong.Text = "Long Tour";
            this.btnLong.UseVisualStyleBackColor = false;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Fuchsia;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(25, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(545, 486);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnRent);
            this.Name = "Form2";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnExit;
    }
}