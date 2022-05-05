
namespace WeatherConcurrencyApp
{
    partial class WeatherPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(257, 16);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(51, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label1";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTemp.Location = new System.Drawing.Point(252, 51);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(56, 29);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "18C";
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.Location = new System.Drawing.Point(212, 134);
            this.lblDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(149, 20);
            this.lblDt.TabIndex = 3;
            this.lblDt.Text = "2021/02/12 12:40";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(123, 122);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(51, 20);
            this.lblHumidity.TabIndex = 4;
            this.lblHumidity.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Humedad:";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(123, 160);
            this.lblPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(51, 20);
            this.lblPressure.TabIndex = 6;
            this.lblPressure.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Presion:";
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(384, 197);
            this.Load += new System.EventHandler(this.WeatherPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblDt;
        public System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label4;
    }
}
