namespace Day9
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
            this.button1 = new System.Windows.Forms.Button();
            this.digitalClock1 = new Day9.DigitalClock();
            this.colorMixer1 = new Day9.ColorMixer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // digitalClock1
            // 
            this.digitalClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClock1.Location = new System.Drawing.Point(149, 124);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(306, 178);
            this.digitalClock1.TabIndex = 2;
            this.digitalClock1.Text = "digitalClock1";
            // 
            // colorMixer1
            // 
            this.colorMixer1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colorMixer1.Location = new System.Drawing.Point(461, 24);
            this.colorMixer1.Name = "colorMixer1";
            this.colorMixer1.Size = new System.Drawing.Size(317, 254);
            this.colorMixer1.TabIndex = 0;
            this.colorMixer1.ColorChanged += new System.EventHandler(this.colorMixer1_ColorChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorMixer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorMixer colorMixer1;
        private System.Windows.Forms.Button button1;
        private DigitalClock digitalClock1;
    }
}