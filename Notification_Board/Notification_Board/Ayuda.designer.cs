namespace Notification_Board
{
    partial class Ayuda
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
            this.btnHor = new System.Windows.Forms.Button();
            this.btnProy = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnMat = new System.Windows.Forms.Button();
            this.btnAvi = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ayuda";
            // 
            // btnHor
            // 
            this.btnHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHor.Location = new System.Drawing.Point(106, 61);
            this.btnHor.Name = "btnHor";
            this.btnHor.Size = new System.Drawing.Size(146, 70);
            this.btnHor.TabIndex = 3;
            this.btnHor.Text = "Horarios";
            this.btnHor.UseVisualStyleBackColor = true;
            this.btnHor.Click += new System.EventHandler(this.btnHor_Click);
            // 
            // btnProy
            // 
            this.btnProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProy.Location = new System.Drawing.Point(106, 148);
            this.btnProy.Name = "btnProy";
            this.btnProy.Size = new System.Drawing.Size(146, 70);
            this.btnProy.TabIndex = 4;
            this.btnProy.Text = "Proyección";
            this.btnProy.UseVisualStyleBackColor = true;
            this.btnProy.Click += new System.EventHandler(this.btnProy_Click);
            // 
            // btnProf
            // 
            this.btnProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.Location = new System.Drawing.Point(106, 235);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(146, 70);
            this.btnProf.TabIndex = 5;
            this.btnProf.Text = "Profesores";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // btnMat
            // 
            this.btnMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMat.Location = new System.Drawing.Point(106, 324);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(146, 70);
            this.btnMat.TabIndex = 6;
            this.btnMat.Text = "Materias";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // btnAvi
            // 
            this.btnAvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvi.Location = new System.Drawing.Point(106, 410);
            this.btnAvi.Name = "btnAvi";
            this.btnAvi.Size = new System.Drawing.Size(146, 70);
            this.btnAvi.TabIndex = 7;
            this.btnAvi.Text = "Avisos";
            this.btnAvi.UseVisualStyleBackColor = true;
            this.btnAvi.Click += new System.EventHandler(this.btnAvi_Click);
            // 
            // lblResp
            // 
            this.lblResp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(314, 61);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(614, 419);
            this.lblResp.TabIndex = 8;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 530);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.btnAvi);
            this.Controls.Add(this.btnMat);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnProy);
            this.Controls.Add(this.btnHor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayuda";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHor;
        private System.Windows.Forms.Button btnProy;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Button btnMat;
        private System.Windows.Forms.Button btnAvi;
        private System.Windows.Forms.Label lblResp;
    }
}