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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btnHor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHor.Location = new System.Drawing.Point(3, 23);
            this.btnHor.Name = "btnHor";
            this.btnHor.Size = new System.Drawing.Size(159, 67);
            this.btnHor.TabIndex = 3;
            this.btnHor.Text = "Horarios";
            this.btnHor.UseVisualStyleBackColor = true;
            this.btnHor.Click += new System.EventHandler(this.btnHor_Click);
            // 
            // btnProy
            // 
            this.btnProy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProy.Location = new System.Drawing.Point(3, 116);
            this.btnProy.Name = "btnProy";
            this.btnProy.Size = new System.Drawing.Size(159, 67);
            this.btnProy.TabIndex = 4;
            this.btnProy.Text = "Proyección";
            this.btnProy.UseVisualStyleBackColor = true;
            this.btnProy.Click += new System.EventHandler(this.btnProy_Click);
            // 
            // btnProf
            // 
            this.btnProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.Location = new System.Drawing.Point(3, 209);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(159, 67);
            this.btnProf.TabIndex = 5;
            this.btnProf.Text = "Profesores";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // btnMat
            // 
            this.btnMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMat.Location = new System.Drawing.Point(3, 302);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(159, 67);
            this.btnMat.TabIndex = 6;
            this.btnMat.Text = "Materias";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // btnAvi
            // 
            this.btnAvi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvi.Location = new System.Drawing.Point(3, 395);
            this.btnAvi.Name = "btnAvi";
            this.btnAvi.Size = new System.Drawing.Size(159, 67);
            this.btnAvi.TabIndex = 7;
            this.btnAvi.Text = "Avisos";
            this.btnAvi.UseVisualStyleBackColor = true;
            this.btnAvi.Click += new System.EventHandler(this.btnAvi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnHor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProy, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAvi, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnProf, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnMat, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 488);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(185, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 488);
            this.panel1.TabIndex = 10;
            // 
            // lblResp
            // 
            this.lblResp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(0, 0);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(785, 488);
            this.lblResp.TabIndex = 9;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayuda";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResp;
    }
}