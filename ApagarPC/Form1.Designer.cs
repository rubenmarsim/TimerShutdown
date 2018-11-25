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
            this.btnCancionBB = new System.Windows.Forms.Button();
            this.btnDisketera = new System.Windows.Forms.Button();
            this.dateTimePkrHours = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.btnExit.TabIndex = 6;
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
            this.btnShutdown.TabIndex = 4;
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
            this.btnCancel.TabIndex = 5;
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
            this.txtBoxMin.TabIndex = 1;
            this.txtBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMin_KeyPress);
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
            this.lblMin.TabIndex = 8;
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
            this.lblSegundos.TabIndex = 9;
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
            this.lblHoras.TabIndex = 7;
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
            this.txtBoxHoras.TabIndex = 0;
            this.txtBoxHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHoras_KeyPress);
            // 
            // txtBoxSecs
            // 
            this.txtBoxSecs.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtBoxSecs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxSecs.Location = new System.Drawing.Point(414, 684);
            this.txtBoxSecs.Name = "txtBoxSecs";
            this.txtBoxSecs.Size = new System.Drawing.Size(181, 38);
            this.txtBoxSecs.TabIndex = 2;
            this.txtBoxSecs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSecs_KeyPress);
            // 
            // btnCancionBB
            // 
            this.btnCancionBB.BackColor = System.Drawing.Color.Transparent;
            this.btnCancionBB.FlatAppearance.BorderSize = 0;
            this.btnCancionBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancionBB.Location = new System.Drawing.Point(1333, 541);
            this.btnCancionBB.Name = "btnCancionBB";
            this.btnCancionBB.Size = new System.Drawing.Size(10, 11);
            this.btnCancionBB.TabIndex = 10;
            this.btnCancionBB.UseVisualStyleBackColor = false;
            this.btnCancionBB.Click += new System.EventHandler(this.btnCancionBB_Click);
            // 
            // btnDisketera
            // 
            this.btnDisketera.BackColor = System.Drawing.Color.Transparent;
            this.btnDisketera.FlatAppearance.BorderSize = 0;
            this.btnDisketera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisketera.Location = new System.Drawing.Point(1344, 168);
            this.btnDisketera.Name = "btnDisketera";
            this.btnDisketera.Size = new System.Drawing.Size(10, 11);
            this.btnDisketera.TabIndex = 11;
            this.btnDisketera.UseVisualStyleBackColor = false;
            this.btnDisketera.Click += new System.EventHandler(this.btnDisketera_Click);
            // 
            // dateTimePkrHours
            // 
            this.dateTimePkrHours.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePkrHours.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePkrHours.Location = new System.Drawing.Point(414, 479);
            this.dateTimePkrHours.MinDate = new System.DateTime(2018, 11, 25, 0, 0, 0, 0);
            this.dateTimePkrHours.Name = "dateTimePkrHours";
            this.dateTimePkrHours.Size = new System.Drawing.Size(181, 20);
            this.dateTimePkrHours.TabIndex = 12;
            this.dateTimePkrHours.Value = new System.DateTime(2018, 11, 25, 13, 21, 32, 0);
            this.dateTimePkrHours.Leave += new System.EventHandler(this.dateTimePkrHours_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(215, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tiempo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(71, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 25, 13, 21, 44, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::ApagarPC.Properties.Resources.DisneyWallpaperRosa;
            this.ClientSize = new System.Drawing.Size(1843, 1061);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePkrHours);
            this.Controls.Add(this.btnDisketera);
            this.Controls.Add(this.btnCancionBB);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnCancionBB;
        private System.Windows.Forms.Button btnDisketera;
        private System.Windows.Forms.DateTimePicker dateTimePkrHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

