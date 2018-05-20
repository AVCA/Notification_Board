namespace Notification_Board
{
    partial class GUI_Tv
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
            this.panel_barra_superior = new System.Windows.Forms.Panel();
            this.panel_Horarios = new System.Windows.Forms.Panel();
            this.dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.lbl_Horarios = new System.Windows.Forms.Label();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.tbl_l_panel_Contenido = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Avisos = new System.Windows.Forms.Panel();
            this.panel_titulo_Avisos = new System.Windows.Forms.Panel();
            this.lbl_Avisos = new System.Windows.Forms.Label();
            this.panel_pbxImage = new System.Windows.Forms.Panel();
            this.pbxImagen2 = new System.Windows.Forms.PictureBox();
            this.pbxImagen1 = new System.Windows.Forms.PictureBox();
            this.HourTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_Horarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            this.tbl_l_panel_Contenido.SuspendLayout();
            this.panel_Avisos.SuspendLayout();
            this.panel_titulo_Avisos.SuspendLayout();
            this.panel_pbxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_barra_superior
            // 
            this.panel_barra_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_barra_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_barra_superior.Name = "panel_barra_superior";
            this.panel_barra_superior.Size = new System.Drawing.Size(926, 39);
            this.panel_barra_superior.TabIndex = 0;
            // 
            // panel_Horarios
            // 
            this.panel_Horarios.Controls.Add(this.dgv_Horarios);
            this.panel_Horarios.Controls.Add(this.lbl_Horarios);
            this.panel_Horarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Horarios.Location = new System.Drawing.Point(3, 3);
            this.panel_Horarios.Name = "panel_Horarios";
            this.panel_Horarios.Size = new System.Drawing.Size(443, 512);
            this.panel_Horarios.TabIndex = 1;
            // 
            // dgv_Horarios
            // 
            this.dgv_Horarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Horarios.Location = new System.Drawing.Point(0, 24);
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.Size = new System.Drawing.Size(443, 488);
            this.dgv_Horarios.TabIndex = 0;
            // 
            // lbl_Horarios
            // 
            this.lbl_Horarios.AutoSize = true;
            this.lbl_Horarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Horarios.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horarios.Location = new System.Drawing.Point(0, 0);
            this.lbl_Horarios.Name = "lbl_Horarios";
            this.lbl_Horarios.Size = new System.Drawing.Size(88, 24);
            this.lbl_Horarios.TabIndex = 0;
            this.lbl_Horarios.Text = "Horarios:";
            // 
            // ImageTimer
            // 
            this.ImageTimer.Tick += new System.EventHandler(this.ImageTimer_Tick);
            // 
            // tbl_l_panel_Contenido
            // 
            this.tbl_l_panel_Contenido.ColumnCount = 3;
            this.tbl_l_panel_Contenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48812F));
            this.tbl_l_panel_Contenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.915767F));
            this.tbl_l_panel_Contenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.59611F));
            this.tbl_l_panel_Contenido.Controls.Add(this.panel_Horarios, 0, 0);
            this.tbl_l_panel_Contenido.Controls.Add(this.panel_Avisos, 2, 0);
            this.tbl_l_panel_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_l_panel_Contenido.Location = new System.Drawing.Point(0, 39);
            this.tbl_l_panel_Contenido.Name = "tbl_l_panel_Contenido";
            this.tbl_l_panel_Contenido.RowCount = 1;
            this.tbl_l_panel_Contenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_l_panel_Contenido.Size = new System.Drawing.Size(926, 518);
            this.tbl_l_panel_Contenido.TabIndex = 4;
            // 
            // panel_Avisos
            // 
            this.panel_Avisos.Controls.Add(this.panel_titulo_Avisos);
            this.panel_Avisos.Controls.Add(this.panel_pbxImage);
            this.panel_Avisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Avisos.Location = new System.Drawing.Point(479, 3);
            this.panel_Avisos.Name = "panel_Avisos";
            this.panel_Avisos.Size = new System.Drawing.Size(444, 512);
            this.panel_Avisos.TabIndex = 4;
            // 
            // panel_titulo_Avisos
            // 
            this.panel_titulo_Avisos.Controls.Add(this.lbl_Avisos);
            this.panel_titulo_Avisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo_Avisos.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo_Avisos.Name = "panel_titulo_Avisos";
            this.panel_titulo_Avisos.Size = new System.Drawing.Size(444, 24);
            this.panel_titulo_Avisos.TabIndex = 4;
            // 
            // lbl_Avisos
            // 
            this.lbl_Avisos.AutoSize = true;
            this.lbl_Avisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Avisos.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Avisos.Location = new System.Drawing.Point(0, 0);
            this.lbl_Avisos.Name = "lbl_Avisos";
            this.lbl_Avisos.Size = new System.Drawing.Size(67, 24);
            this.lbl_Avisos.TabIndex = 2;
            this.lbl_Avisos.Text = "Avisos:";
            // 
            // panel_pbxImage
            // 
            this.panel_pbxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel_pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_pbxImage.Controls.Add(this.pbxImagen2);
            this.panel_pbxImage.Controls.Add(this.pbxImagen1);
            this.panel_pbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pbxImage.Location = new System.Drawing.Point(0, 0);
            this.panel_pbxImage.Name = "panel_pbxImage";
            this.panel_pbxImage.Size = new System.Drawing.Size(444, 512);
            this.panel_pbxImage.TabIndex = 3;
            // 
            // pbxImagen2
            // 
            this.pbxImagen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImagen2.Location = new System.Drawing.Point(0, 0);
            this.pbxImagen2.Name = "pbxImagen2";
            this.pbxImagen2.Size = new System.Drawing.Size(444, 512);
            this.pbxImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen2.TabIndex = 1;
            this.pbxImagen2.TabStop = false;
            // 
            // pbxImagen1
            // 
            this.pbxImagen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImagen1.Location = new System.Drawing.Point(0, 0);
            this.pbxImagen1.Name = "pbxImagen1";
            this.pbxImagen1.Size = new System.Drawing.Size(444, 512);
            this.pbxImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen1.TabIndex = 0;
            this.pbxImagen1.TabStop = false;
            // 
            // HourTimer
            // 
            this.HourTimer.Tick += new System.EventHandler(this.HourTimer_Tick);
            // 
            // GUI_Tv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 557);
            this.Controls.Add(this.tbl_l_panel_Contenido);
            this.Controls.Add(this.panel_barra_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Tv";
            this.Text = "p";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tv_Load);
            this.panel_Horarios.ResumeLayout(false);
            this.panel_Horarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).EndInit();
            this.tbl_l_panel_Contenido.ResumeLayout(false);
            this.panel_Avisos.ResumeLayout(false);
            this.panel_titulo_Avisos.ResumeLayout(false);
            this.panel_titulo_Avisos.PerformLayout();
            this.panel_pbxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra_superior;
        private System.Windows.Forms.Panel panel_Horarios;
        private System.Windows.Forms.Label lbl_Horarios;
        private System.Windows.Forms.DataGridView dgv_Horarios;
        private System.Windows.Forms.Timer ImageTimer;
        private System.Windows.Forms.TableLayoutPanel tbl_l_panel_Contenido;
        private System.Windows.Forms.Timer HourTimer;
        private System.Windows.Forms.Panel panel_Avisos;
        private System.Windows.Forms.Panel panel_pbxImage;
        private System.Windows.Forms.PictureBox pbxImagen2;
        private System.Windows.Forms.PictureBox pbxImagen1;
        private System.Windows.Forms.Panel panel_titulo_Avisos;
        private System.Windows.Forms.Label lbl_Avisos;
    }
}