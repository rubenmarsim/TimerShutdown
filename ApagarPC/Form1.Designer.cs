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
            this.btnExit.Location = new System.Drawing.Point(725, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(39, 365);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.Text = "Apagar PC";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxMin
            // 
            this.txtBoxMin.Location = new System.Drawing.Point(112, 270);
            this.txtBoxMin.Name = "txtBoxMin";
            this.txtBoxMin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMin.TabIndex = 3;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(50, 270);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(44, 13);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(39, 314);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "Segundos";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(59, 227);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 6;
            this.lblHoras.Text = "Horas";
            // 
            // txtBoxHoras
            // 
            this.txtBoxHoras.Location = new System.Drawing.Point(112, 227);
            this.txtBoxHoras.Name = "txtBoxHoras";
            this.txtBoxHoras.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHoras.TabIndex = 7;
            // 
            // txtBoxSecs
            // 
            this.txtBoxSecs.Location = new System.Drawing.Point(112, 314);
            this.txtBoxSecs.Name = "txtBoxSecs";
            this.txtBoxSecs.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSecs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApagarPC.Properties.Resources.DisneyWallpaperRosa;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

