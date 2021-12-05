
namespace AplicacionPortable
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbReceptor = new System.Windows.Forms.RadioButton();
            this.logMensajes = new System.Windows.Forms.TextBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbAutor.Location = new System.Drawing.Point(50, 27);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(67, 23);
            this.rbAutor.TabIndex = 0;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = true;
            this.rbAutor.CheckedChanged += new System.EventHandler(this.rbAutor_CheckedChanged);
            // 
            // rbReceptor
            // 
            this.rbReceptor.AutoSize = true;
            this.rbReceptor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbReceptor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbReceptor.Location = new System.Drawing.Point(50, 102);
            this.rbReceptor.Name = "rbReceptor";
            this.rbReceptor.Size = new System.Drawing.Size(93, 23);
            this.rbReceptor.TabIndex = 1;
            this.rbReceptor.TabStop = true;
            this.rbReceptor.Text = "Receptor";
            this.rbReceptor.UseVisualStyleBackColor = true;
            this.rbReceptor.CheckedChanged += new System.EventHandler(this.rbReceptor_CheckedChanged);
            // 
            // logMensajes
            // 
            this.logMensajes.BackColor = System.Drawing.Color.Azure;
            this.logMensajes.Location = new System.Drawing.Point(297, 27);
            this.logMensajes.Multiline = true;
            this.logMensajes.Name = "logMensajes";
            this.logMensajes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logMensajes.Size = new System.Drawing.Size(193, 98);
            this.logMensajes.TabIndex = 3;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSelectImg.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectImg.Location = new System.Drawing.Point(167, 61);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(106, 32);
            this.btnSelectImg.TabIndex = 4;
            this.btnSelectImg.Text = "Extraer";
            this.btnSelectImg.UseVisualStyleBackColor = false;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(536, 157);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.logMensajes);
            this.Controls.Add(this.rbReceptor);
            this.Controls.Add(this.rbAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extractor Llave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbReceptor;
        private System.Windows.Forms.TextBox logMensajes;
        private System.Windows.Forms.Button btnSelectImg;
    }
}

