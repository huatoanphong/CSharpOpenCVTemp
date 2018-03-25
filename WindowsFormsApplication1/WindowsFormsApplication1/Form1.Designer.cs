namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.imgbInput = new Emgu.CV.UI.ImageBox();
            this.pazOutput = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.hbInput = new Emgu.CV.UI.HistogramBox();
            this.hbOutput = new Emgu.CV.UI.HistogramBox();
            this.btnHbInput = new System.Windows.Forms.Button();
            this.btnHbOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(12, 13);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(323, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // imgbInput
            // 
            this.imgbInput.Location = new System.Drawing.Point(12, 42);
            this.imgbInput.Name = "imgbInput";
            this.imgbInput.Size = new System.Drawing.Size(305, 129);
            this.imgbInput.TabIndex = 2;
            this.imgbInput.TabStop = false;
            // 
            // pazOutput
            // 
            this.pazOutput.Location = new System.Drawing.Point(323, 42);
            this.pazOutput.Name = "pazOutput";
            this.pazOutput.Size = new System.Drawing.Size(298, 129);
            this.pazOutput.TabIndex = 4;
            this.pazOutput.TabStop = false;
            // 
            // hbInput
            // 
            this.hbInput.Location = new System.Drawing.Point(12, 209);
            this.hbInput.Name = "hbInput";
            this.hbInput.Size = new System.Drawing.Size(305, 132);
            this.hbInput.TabIndex = 5;
            // 
            // hbOutput
            // 
            this.hbOutput.Location = new System.Drawing.Point(323, 209);
            this.hbOutput.Name = "hbOutput";
            this.hbOutput.Size = new System.Drawing.Size(298, 132);
            this.hbOutput.TabIndex = 6;
            // 
            // btnHbInput
            // 
            this.btnHbInput.Location = new System.Drawing.Point(12, 177);
            this.btnHbInput.Name = "btnHbInput";
            this.btnHbInput.Size = new System.Drawing.Size(75, 23);
            this.btnHbInput.TabIndex = 7;
            this.btnHbInput.Text = "HistoGram";
            this.btnHbInput.UseVisualStyleBackColor = true;
            this.btnHbInput.Click += new System.EventHandler(this.btnHbInput_Click);
            // 
            // btnHbOutput
            // 
            this.btnHbOutput.Location = new System.Drawing.Point(323, 177);
            this.btnHbOutput.Name = "btnHbOutput";
            this.btnHbOutput.Size = new System.Drawing.Size(75, 23);
            this.btnHbOutput.TabIndex = 8;
            this.btnHbOutput.Text = "HistoGram";
            this.btnHbOutput.UseVisualStyleBackColor = true;
            this.btnHbOutput.Click += new System.EventHandler(this.btnHbOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 353);
            this.Controls.Add(this.btnHbOutput);
            this.Controls.Add(this.btnHbInput);
            this.Controls.Add(this.hbOutput);
            this.Controls.Add(this.hbInput);
            this.Controls.Add(this.pazOutput);
            this.Controls.Add(this.imgbInput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnConvert;
        private Emgu.CV.UI.ImageBox imgbInput;
        private Emgu.CV.UI.PanAndZoomPictureBox pazOutput;
        private Emgu.CV.UI.HistogramBox hbInput;
        private Emgu.CV.UI.HistogramBox hbOutput;
        private System.Windows.Forms.Button btnHbInput;
        private System.Windows.Forms.Button btnHbOutput;
    }
}

