namespace image_game
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.rbBooks = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbImages ) ).BeginInit();
            this.SuspendLayout();
            // 
            // pbImages
            // 
            this.pbImages.Image = global::image_game.Properties.Resources.Pen;
            this.pbImages.Location = new System.Drawing.Point( 410, 94 );
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size( 454, 324 );
            this.pbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImages.TabIndex = 0;
            this.pbImages.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font( "Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblImage.ForeColor = System.Drawing.Color.Red;
            this.lblImage.Location = new System.Drawing.Point( 612, 432 );
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size( 63, 34 );
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "Pen";
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Font = new System.Drawing.Font( "Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbPen.ForeColor = System.Drawing.Color.Blue;
            this.rbPen.Location = new System.Drawing.Point( 318, 535 );
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size( 66, 39 );
            this.rbPen.TabIndex = 6;
            this.rbPen.TabStop = true;
            this.rbPen.Tag = "Pen";
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            this.rbPen.CheckedChanged += new System.EventHandler( this.rbPen_CheckedChanged );
            // 
            // rbBooks
            // 
            this.rbBooks.AutoSize = true;
            this.rbBooks.Font = new System.Drawing.Font( "Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbBooks.ForeColor = System.Drawing.Color.Blue;
            this.rbBooks.Location = new System.Drawing.Point( 516, 535 );
            this.rbBooks.Name = "rbBooks";
            this.rbBooks.Size = new System.Drawing.Size( 87, 39 );
            this.rbBooks.TabIndex = 7;
            this.rbBooks.TabStop = true;
            this.rbBooks.Tag = "Books";
            this.rbBooks.Text = "Books";
            this.rbBooks.UseVisualStyleBackColor = true;
            this.rbBooks.CheckedChanged += new System.EventHandler( this.rbBooks_CheckedChanged );
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font( "Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbBoy.ForeColor = System.Drawing.Color.Blue;
            this.rbBoy.Location = new System.Drawing.Point( 714, 535 );
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size( 68, 39 );
            this.rbBoy.TabIndex = 8;
            this.rbBoy.TabStop = true;
            this.rbBoy.Tag = "Boy";
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler( this.rbBoy_CheckedChanged );
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font( "Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbGirl.ForeColor = System.Drawing.Color.Blue;
            this.rbGirl.Location = new System.Drawing.Point( 912, 535 );
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size( 69, 39 );
            this.rbGirl.TabIndex = 9;
            this.rbGirl.TabStop = true;
            this.rbGirl.Tag = "Girl";
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler( this.rbGirl_CheckedChanged );
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1294, 632 );
            this.Controls.Add( this.rbGirl );
            this.Controls.Add( this.rbBoy );
            this.Controls.Add( this.rbBooks );
            this.Controls.Add( this.rbPen );
            this.Controls.Add( this.lblImage );
            this.Controls.Add( this.pbImages );
            this.Name = "Form1";
            this.Text = "Image Game";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pbImages ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbBooks;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.RadioButton rbGirl;
    }
}

