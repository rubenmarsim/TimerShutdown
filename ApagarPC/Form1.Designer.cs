namespace ApagarPC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxMin = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtBoxHoras = new System.Windows.Forms.TextBox();
            this.txtBoxSecs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnExit.Location = new System.Drawing.Point(1762, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.AutoSize = true;
            this.btnShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnShutdown.Location = new System.Drawing.Point(414, 765);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(181, 41);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.Text = "Apagar PC";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnCancel.Location = new System.Drawing.Point(189, 765);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBoxMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxMin.Location = new System.Drawing.Point(414, 619);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(181, 38);
            this.txtBoxMin.TabIndex = 3;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMin.Location = new System.Drawing.Point(210, 626);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(117, 31);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minutos:";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblSegundos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSegundos.Location = new System.Drawing.Point(183, 687);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(144, 31);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "Segundos:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblHoras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHoras.Location = new System.Drawing.Point(232, 561);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(95, 31);
            this.lblHoras.TabIndex = 6;
            this.lblHoras.Text = "Horas:";
            // 
            // txtBoxHoras
            // 
            this.txtBoxHoras.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBoxHoras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxHoras.Location = new System.Drawing.Point(414, 554);
            this.txtBoxHoras.Name = "txtBoxHoras";
            this.txtBoxHoras.Size = new System.Drawing.Size(181, 38);
            this.txtBoxHoras.TabIndex = 7;
            // 
            // txtBoxSecs
            // 
            this.txtBoxSecs.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBoxSecs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxSecs.Location = new System.Drawing.Point(414, 684);
            this.txtBoxSecs.Name = "txtBoxSecs";
            this.txtBoxSecs.Size = new System.Drawing.Size(181, 38);
            this.txtBoxSecs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::ApagarPC.Properties.Resources.DisneyWallpaperRosa;
            this.ClientSize = new System.Drawing.Size(1843, 1061);
            this.Controls.Add(this.txtBoxSecs);
            this.Controls.Add(this.txtBoxHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtBoxMin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBoxMin;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtBoxHoras;
        private System.Windows.Forms.TextBox txtBoxSecs;
    }
}

