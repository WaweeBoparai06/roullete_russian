namespace roullete_russian
{
    partial class maingame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load_button = new System.Windows.Forms.Button();
            this.spin_button = new System.Windows.Forms.Button();
            this.shot_button = new System.Windows.Forms.Button();
            this.rety_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(121, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Russian Roullete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 217);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // load_button
            // 
            this.load_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_button.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.ForeColor = System.Drawing.Color.Lime;
            this.load_button.Location = new System.Drawing.Point(28, 326);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(104, 37);
            this.load_button.TabIndex = 3;
            this.load_button.Text = "load";
            this.load_button.UseVisualStyleBackColor = false;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // spin_button
            // 
            this.spin_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spin_button.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_button.ForeColor = System.Drawing.Color.Lime;
            this.spin_button.Location = new System.Drawing.Point(168, 326);
            this.spin_button.Name = "spin_button";
            this.spin_button.Size = new System.Drawing.Size(104, 37);
            this.spin_button.TabIndex = 4;
            this.spin_button.Text = "spin";
            this.spin_button.UseVisualStyleBackColor = false;
            this.spin_button.Click += new System.EventHandler(this.spin_button_Click);
            // 
            // shot_button
            // 
            this.shot_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shot_button.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shot_button.ForeColor = System.Drawing.Color.Lime;
            this.shot_button.Location = new System.Drawing.Point(325, 326);
            this.shot_button.Name = "shot_button";
            this.shot_button.Size = new System.Drawing.Size(104, 37);
            this.shot_button.TabIndex = 5;
            this.shot_button.Text = "shoot";
            this.shot_button.UseVisualStyleBackColor = false;
            this.shot_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // rety_button
            // 
            this.rety_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rety_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rety_button.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rety_button.ForeColor = System.Drawing.Color.Lime;
            this.rety_button.Location = new System.Drawing.Point(481, 326);
            this.rety_button.Name = "rety_button";
            this.rety_button.Size = new System.Drawing.Size(104, 37);
            this.rety_button.TabIndex = 6;
            this.rety_button.Text = "Retry";
            this.rety_button.UseVisualStyleBackColor = false;
            this.rety_button.Click += new System.EventHandler(this.rety_button_Click);
            // 
            // maingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::roullete_russian.Properties.Resources.Russian_roulette_2500016b;
            this.ClientSize = new System.Drawing.Size(618, 385);
            this.Controls.Add(this.rety_button);
            this.Controls.Add(this.shot_button);
            this.Controls.Add(this.spin_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "maingame";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button spin_button;
        private System.Windows.Forms.Button shot_button;
        private System.Windows.Forms.Button rety_button;
    }
}