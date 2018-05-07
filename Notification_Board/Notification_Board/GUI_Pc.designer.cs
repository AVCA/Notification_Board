namespace Notification_Board
{
    partial class GUI_Pc
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Pc));
            this.panel_Barra = new System.Windows.Forms.Panel();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_botones = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.pb_Inicio = new System.Windows.Forms.PictureBox();
            this.panel_Inicio = new System.Windows.Forms.Panel();
            this.btn_Iniciar_Proyeccion = new System.Windows.Forms.Button();
            this.pc_Iniciar_Proyeccion = new System.Windows.Forms.PictureBox();
            this.panel_Iniciar_Proyeccion = new System.Windows.Forms.Panel();
            this.pc_Salones = new System.Windows.Forms.PictureBox();
            this.btn_Salones = new System.Windows.Forms.Button();
            this.panel_Salones = new System.Windows.Forms.Panel();
            this.btn_Informacion = new System.Windows.Forms.Button();
            this.pc_Informacion = new System.Windows.Forms.PictureBox();
            this.panel_Informacion = new System.Windows.Forms.Panel();
            this.panel_Avisos = new System.Windows.Forms.Panel();
            this.pc_Avisos = new System.Windows.Forms.PictureBox();
            this.btn_Avisos = new System.Windows.Forms.Button();
            this.pc_Imparte = new System.Windows.Forms.PictureBox();
            this.panel_Imparte = new System.Windows.Forms.Panel();
            this.btn_Imparte = new System.Windows.Forms.Button();
            this.btn_Materias = new System.Windows.Forms.Button();
            this.pc_Materias = new System.Windows.Forms.PictureBox();
            this.panel_Materias = new System.Windows.Forms.Panel();
            this.btn_Profesores = new System.Windows.Forms.Button();
            this.pc_Profesores = new System.Windows.Forms.PictureBox();
            this.panel_Profesores = new System.Windows.Forms.Panel();
            this.btn_Horarios = new System.Windows.Forms.Button();
            this.pc_Horarios = new System.Windows.Forms.PictureBox();
            this.panel_Horarios = new System.Windows.Forms.Panel();
            this.panel_Asistencia = new System.Windows.Forms.Panel();
            this.pc_Asistencia = new System.Windows.Forms.PictureBox();
            this.btn_Asistencia = new System.Windows.Forms.Button();
            this.panel_Subinterfaz = new System.Windows.Forms.Panel();
            this.panel_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Iniciar_Proyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Salones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Informacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Avisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Imparte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Profesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Horarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Asistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Barra
            // 
            this.panel_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Barra.Controls.Add(this.btn_Restaurar);
            this.panel_Barra.Controls.Add(this.btn_Minimizar);
            this.panel_Barra.Controls.Add(this.btn_Maximizar);
            this.panel_Barra.Controls.Add(this.btn_Cerrar);
            this.panel_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Barra.Location = new System.Drawing.Point(0, 0);
            this.panel_Barra.Name = "panel_Barra";
            this.panel_Barra.Size = new System.Drawing.Size(1300, 38);
            this.panel_Barra.TabIndex = 0;
            this.panel_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restaurar.Image")));
            this.btn_Restaurar.Location = new System.Drawing.Point(1221, 6);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restaurar.TabIndex = 3;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1180, 6);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(25, 25);
            this.btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimizar.TabIndex = 2;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.Image")));
            this.btn_Maximizar.Location = new System.Drawing.Point(1221, 6);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(25, 25);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Maximizar.TabIndex = 1;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1262, 6);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel_Menu.Controls.Add(this.panel_botones);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 38);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(220, 612);
            this.panel_Menu.TabIndex = 1;
            // 
            // panel_botones
            // 
            this.panel_botones.ColumnCount = 3;
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.570829F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.24533F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.18384F));
            this.panel_botones.Controls.Add(this.btn_Inicio, 2, 1);
            this.panel_botones.Controls.Add(this.pb_Inicio, 1, 1);
            this.panel_botones.Controls.Add(this.panel_Inicio, 0, 1);
            this.panel_botones.Controls.Add(this.btn_Iniciar_Proyeccion, 2, 3);
            this.panel_botones.Controls.Add(this.pc_Iniciar_Proyeccion, 1, 3);
            this.panel_botones.Controls.Add(this.panel_Iniciar_Proyeccion, 0, 3);
            this.panel_botones.Controls.Add(this.pc_Salones, 1, 5);
            this.panel_botones.Controls.Add(this.btn_Salones, 2, 5);
            this.panel_botones.Controls.Add(this.panel_Salones, 0, 5);
            this.panel_botones.Controls.Add(this.btn_Informacion, 2, 19);
            this.panel_botones.Controls.Add(this.pc_Informacion, 1, 19);
            this.panel_botones.Controls.Add(this.panel_Informacion, 0, 19);
            this.panel_botones.Controls.Add(this.panel_Avisos, 0, 17);
            this.panel_botones.Controls.Add(this.pc_Avisos, 1, 17);
            this.panel_botones.Controls.Add(this.btn_Avisos, 2, 17);
            this.panel_botones.Controls.Add(this.pc_Imparte, 1, 15);
            this.panel_botones.Controls.Add(this.panel_Imparte, 0, 15);
            this.panel_botones.Controls.Add(this.btn_Imparte, 2, 15);
            this.panel_botones.Controls.Add(this.btn_Materias, 2, 13);
            this.panel_botones.Controls.Add(this.pc_Materias, 1, 13);
            this.panel_botones.Controls.Add(this.panel_Materias, 0, 13);
            this.panel_botones.Controls.Add(this.btn_Profesores, 2, 11);
            this.panel_botones.Controls.Add(this.pc_Profesores, 1, 11);
            this.panel_botones.Controls.Add(this.panel_Profesores, 0, 11);
            this.panel_botones.Controls.Add(this.btn_Horarios, 2, 9);
            this.panel_botones.Controls.Add(this.pc_Horarios, 1, 9);
            this.panel_botones.Controls.Add(this.panel_Horarios, 0, 9);
            this.panel_botones.Controls.Add(this.panel_Asistencia, 0, 7);
            this.panel_botones.Controls.Add(this.pc_Asistencia, 1, 7);
            this.panel_botones.Controls.Add(this.btn_Asistencia, 2, 7);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_botones.Location = new System.Drawing.Point(0, 0);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.RowCount = 21;
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.panel_botones.Size = new System.Drawing.Size(220, 612);
            this.panel_botones.TabIndex = 0;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Location = new System.Drawing.Point(63, 38);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Inicio.Size = new System.Drawing.Size(154, 29);
            this.btn_Inicio.TabIndex = 1;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = false;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // pb_Inicio
            // 
            this.pb_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Inicio.Image = global::Notification_Board.Properties.Resources.Inicio;
            this.pb_Inicio.Location = new System.Drawing.Point(15, 38);
            this.pb_Inicio.Name = "pb_Inicio";
            this.pb_Inicio.Size = new System.Drawing.Size(42, 29);
            this.pb_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inicio.TabIndex = 0;
            this.pb_Inicio.TabStop = false;
            // 
            // panel_Inicio
            // 
            this.panel_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Inicio.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Inicio.Location = new System.Drawing.Point(3, 38);
            this.panel_Inicio.Name = "panel_Inicio";
            this.panel_Inicio.Size = new System.Drawing.Size(6, 29);
            this.panel_Inicio.TabIndex = 34;
            // 
            // btn_Iniciar_Proyeccion
            // 
            this.btn_Iniciar_Proyeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Iniciar_Proyeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Iniciar_Proyeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Iniciar_Proyeccion.FlatAppearance.BorderSize = 0;
            this.btn_Iniciar_Proyeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Iniciar_Proyeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar_Proyeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar_Proyeccion.ForeColor = System.Drawing.Color.White;
            this.btn_Iniciar_Proyeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Iniciar_Proyeccion.Location = new System.Drawing.Point(63, 93);
            this.btn_Iniciar_Proyeccion.Name = "btn_Iniciar_Proyeccion";
            this.btn_Iniciar_Proyeccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Iniciar_Proyeccion.Size = new System.Drawing.Size(154, 29);
            this.btn_Iniciar_Proyeccion.TabIndex = 2;
            this.btn_Iniciar_Proyeccion.Text = "Iniciar proyección";
            this.btn_Iniciar_Proyeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Iniciar_Proyeccion.UseVisualStyleBackColor = false;
            this.btn_Iniciar_Proyeccion.Click += new System.EventHandler(this.btn_GUI_Tv_Click);
            // 
            // pc_Iniciar_Proyeccion
            // 
            this.pc_Iniciar_Proyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Iniciar_Proyeccion.Image = global::Notification_Board.Properties.Resources.proyeccion;
            this.pc_Iniciar_Proyeccion.Location = new System.Drawing.Point(15, 93);
            this.pc_Iniciar_Proyeccion.Name = "pc_Iniciar_Proyeccion";
            this.pc_Iniciar_Proyeccion.Size = new System.Drawing.Size(42, 29);
            this.pc_Iniciar_Proyeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Iniciar_Proyeccion.TabIndex = 25;
            this.pc_Iniciar_Proyeccion.TabStop = false;
            // 
            // panel_Iniciar_Proyeccion
            // 
            this.panel_Iniciar_Proyeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Iniciar_Proyeccion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Iniciar_Proyeccion.Location = new System.Drawing.Point(3, 93);
            this.panel_Iniciar_Proyeccion.Name = "panel_Iniciar_Proyeccion";
            this.panel_Iniciar_Proyeccion.Size = new System.Drawing.Size(6, 29);
            this.panel_Iniciar_Proyeccion.TabIndex = 32;
            // 
            // pc_Salones
            // 
            this.pc_Salones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_Salones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Salones.Image = global::Notification_Board.Properties.Resources.Horario;
            this.pc_Salones.Location = new System.Drawing.Point(15, 148);
            this.pc_Salones.Name = "pc_Salones";
            this.pc_Salones.Size = new System.Drawing.Size(42, 29);
            this.pc_Salones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Salones.TabIndex = 37;
            this.pc_Salones.TabStop = false;
            // 
            // btn_Salones
            // 
            this.btn_Salones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Salones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Salones.FlatAppearance.BorderSize = 0;
            this.btn_Salones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Salones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salones.ForeColor = System.Drawing.Color.White;
            this.btn_Salones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salones.Location = new System.Drawing.Point(63, 148);
            this.btn_Salones.Name = "btn_Salones";
            this.btn_Salones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Salones.Size = new System.Drawing.Size(154, 29);
            this.btn_Salones.TabIndex = 38;
            this.btn_Salones.Text = "Consultar salones disponibles";
            this.btn_Salones.UseVisualStyleBackColor = false;
            this.btn_Salones.Click += new System.EventHandler(this.btn_Salones_Click);
            // 
            // panel_Salones
            // 
            this.panel_Salones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Salones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Salones.Location = new System.Drawing.Point(3, 148);
            this.panel_Salones.Name = "panel_Salones";
            this.panel_Salones.Size = new System.Drawing.Size(6, 29);
            this.panel_Salones.TabIndex = 33;
            // 
            // btn_Informacion
            // 
            this.btn_Informacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Informacion.FlatAppearance.BorderSize = 0;
            this.btn_Informacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Informacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Informacion.ForeColor = System.Drawing.Color.White;
            this.btn_Informacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Informacion.Location = new System.Drawing.Point(63, 533);
            this.btn_Informacion.Name = "btn_Informacion";
            this.btn_Informacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Informacion.Size = new System.Drawing.Size(154, 29);
            this.btn_Informacion.TabIndex = 8;
            this.btn_Informacion.Text = "Ayuda";
            this.btn_Informacion.UseVisualStyleBackColor = false;
            this.btn_Informacion.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // pc_Informacion
            // 
            this.pc_Informacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Informacion.Image = global::Notification_Board.Properties.Resources.Ayuda;
            this.pc_Informacion.Location = new System.Drawing.Point(15, 533);
            this.pc_Informacion.Name = "pc_Informacion";
            this.pc_Informacion.Size = new System.Drawing.Size(42, 29);
            this.pc_Informacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Informacion.TabIndex = 31;
            this.pc_Informacion.TabStop = false;
            // 
            // panel_Informacion
            // 
            this.panel_Informacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Informacion.Location = new System.Drawing.Point(3, 533);
            this.panel_Informacion.Name = "panel_Informacion";
            this.panel_Informacion.Size = new System.Drawing.Size(6, 29);
            this.panel_Informacion.TabIndex = 36;
            // 
            // panel_Avisos
            // 
            this.panel_Avisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Avisos.Location = new System.Drawing.Point(3, 478);
            this.panel_Avisos.Name = "panel_Avisos";
            this.panel_Avisos.Size = new System.Drawing.Size(6, 29);
            this.panel_Avisos.TabIndex = 34;
            // 
            // pc_Avisos
            // 
            this.pc_Avisos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Avisos.Image = global::Notification_Board.Properties.Resources.Avisos;
            this.pc_Avisos.Location = new System.Drawing.Point(15, 478);
            this.pc_Avisos.Name = "pc_Avisos";
            this.pc_Avisos.Size = new System.Drawing.Size(42, 29);
            this.pc_Avisos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Avisos.TabIndex = 30;
            this.pc_Avisos.TabStop = false;
            // 
            // btn_Avisos
            // 
            this.btn_Avisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Avisos.FlatAppearance.BorderSize = 0;
            this.btn_Avisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Avisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Avisos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Avisos.ForeColor = System.Drawing.Color.White;
            this.btn_Avisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Avisos.Location = new System.Drawing.Point(63, 478);
            this.btn_Avisos.Name = "btn_Avisos";
            this.btn_Avisos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Avisos.Size = new System.Drawing.Size(154, 29);
            this.btn_Avisos.TabIndex = 7;
            this.btn_Avisos.Text = "Avisos";
            this.btn_Avisos.UseVisualStyleBackColor = false;
            this.btn_Avisos.Click += new System.EventHandler(this.btn_Avisos_Click);
            // 
            // pc_Imparte
            // 
            this.pc_Imparte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Imparte.Image = global::Notification_Board.Properties.Resources.Materia;
            this.pc_Imparte.Location = new System.Drawing.Point(15, 423);
            this.pc_Imparte.Name = "pc_Imparte";
            this.pc_Imparte.Size = new System.Drawing.Size(42, 29);
            this.pc_Imparte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Imparte.TabIndex = 29;
            this.pc_Imparte.TabStop = false;
            // 
            // panel_Imparte
            // 
            this.panel_Imparte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Imparte.Location = new System.Drawing.Point(3, 423);
            this.panel_Imparte.Name = "panel_Imparte";
            this.panel_Imparte.Size = new System.Drawing.Size(6, 29);
            this.panel_Imparte.TabIndex = 34;
            // 
            // btn_Imparte
            // 
            this.btn_Imparte.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_Imparte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Imparte.FlatAppearance.BorderSize = 0;
            this.btn_Imparte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Imparte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imparte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imparte.ForeColor = System.Drawing.Color.White;
            this.btn_Imparte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Imparte.Location = new System.Drawing.Point(63, 423);
            this.btn_Imparte.Name = "btn_Imparte";
            this.btn_Imparte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Imparte.Size = new System.Drawing.Size(154, 29);
            this.btn_Imparte.TabIndex = 6;
            this.btn_Imparte.Text = "Impartido";
            this.btn_Imparte.UseVisualStyleBackColor = false;
            this.btn_Imparte.Click += new System.EventHandler(this.btn_Imparte_Click);
            // 
            // btn_Materias
            // 
            this.btn_Materias.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_Materias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Materias.FlatAppearance.BorderSize = 0;
            this.btn_Materias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Materias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Materias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Materias.ForeColor = System.Drawing.Color.White;
            this.btn_Materias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Materias.Location = new System.Drawing.Point(63, 368);
            this.btn_Materias.Name = "btn_Materias";
            this.btn_Materias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Materias.Size = new System.Drawing.Size(154, 29);
            this.btn_Materias.TabIndex = 5;
            this.btn_Materias.Text = "Materias";
            this.btn_Materias.UseVisualStyleBackColor = false;
            this.btn_Materias.Click += new System.EventHandler(this.btn_Materias_Click);
            // 
            // pc_Materias
            // 
            this.pc_Materias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Materias.Image = ((System.Drawing.Image)(resources.GetObject("pc_Materias.Image")));
            this.pc_Materias.Location = new System.Drawing.Point(15, 368);
            this.pc_Materias.Name = "pc_Materias";
            this.pc_Materias.Size = new System.Drawing.Size(42, 29);
            this.pc_Materias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Materias.TabIndex = 28;
            this.pc_Materias.TabStop = false;
            // 
            // panel_Materias
            // 
            this.panel_Materias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Materias.Location = new System.Drawing.Point(3, 368);
            this.panel_Materias.Name = "panel_Materias";
            this.panel_Materias.Size = new System.Drawing.Size(6, 29);
            this.panel_Materias.TabIndex = 34;
            // 
            // btn_Profesores
            // 
            this.btn_Profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Profesores.FlatAppearance.BorderSize = 0;
            this.btn_Profesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profesores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profesores.ForeColor = System.Drawing.Color.White;
            this.btn_Profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profesores.Location = new System.Drawing.Point(63, 313);
            this.btn_Profesores.Name = "btn_Profesores";
            this.btn_Profesores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Profesores.Size = new System.Drawing.Size(154, 29);
            this.btn_Profesores.TabIndex = 4;
            this.btn_Profesores.Text = "Profesores";
            this.btn_Profesores.UseVisualStyleBackColor = false;
            this.btn_Profesores.Click += new System.EventHandler(this.btn_Profesor_Click);
            // 
            // pc_Profesores
            // 
            this.pc_Profesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Profesores.Image = ((System.Drawing.Image)(resources.GetObject("pc_Profesores.Image")));
            this.pc_Profesores.Location = new System.Drawing.Point(15, 313);
            this.pc_Profesores.Name = "pc_Profesores";
            this.pc_Profesores.Size = new System.Drawing.Size(42, 29);
            this.pc_Profesores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Profesores.TabIndex = 27;
            this.pc_Profesores.TabStop = false;
            // 
            // panel_Profesores
            // 
            this.panel_Profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Profesores.Location = new System.Drawing.Point(3, 313);
            this.panel_Profesores.Name = "panel_Profesores";
            this.panel_Profesores.Size = new System.Drawing.Size(6, 29);
            this.panel_Profesores.TabIndex = 35;
            // 
            // btn_Horarios
            // 
            this.btn_Horarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Horarios.FlatAppearance.BorderSize = 0;
            this.btn_Horarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Horarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Horarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Horarios.ForeColor = System.Drawing.Color.White;
            this.btn_Horarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Horarios.Location = new System.Drawing.Point(63, 258);
            this.btn_Horarios.Name = "btn_Horarios";
            this.btn_Horarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Horarios.Size = new System.Drawing.Size(154, 29);
            this.btn_Horarios.TabIndex = 3;
            this.btn_Horarios.Text = "Horarios";
            this.btn_Horarios.UseVisualStyleBackColor = false;
            this.btn_Horarios.Click += new System.EventHandler(this.btn_Horarios_Click);
            // 
            // pc_Horarios
            // 
            this.pc_Horarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Horarios.Image = global::Notification_Board.Properties.Resources.Horario;
            this.pc_Horarios.Location = new System.Drawing.Point(15, 258);
            this.pc_Horarios.Name = "pc_Horarios";
            this.pc_Horarios.Size = new System.Drawing.Size(42, 29);
            this.pc_Horarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Horarios.TabIndex = 26;
            this.pc_Horarios.TabStop = false;
            // 
            // panel_Horarios
            // 
            this.panel_Horarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Horarios.Location = new System.Drawing.Point(3, 258);
            this.panel_Horarios.Name = "panel_Horarios";
            this.panel_Horarios.Size = new System.Drawing.Size(6, 29);
            this.panel_Horarios.TabIndex = 34;
            // 
            // panel_Asistencia
            // 
            this.panel_Asistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(0)))));
            this.panel_Asistencia.Location = new System.Drawing.Point(3, 203);
            this.panel_Asistencia.Name = "panel_Asistencia";
            this.panel_Asistencia.Size = new System.Drawing.Size(6, 29);
            this.panel_Asistencia.TabIndex = 39;
            // 
            // pc_Asistencia
            // 
            this.pc_Asistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pc_Asistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pc_Asistencia.Image = global::Notification_Board.Properties.Resources.Horario;
            this.pc_Asistencia.Location = new System.Drawing.Point(15, 203);
            this.pc_Asistencia.Name = "pc_Asistencia";
            this.pc_Asistencia.Size = new System.Drawing.Size(42, 29);
            this.pc_Asistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Asistencia.TabIndex = 40;
            this.pc_Asistencia.TabStop = false;
            // 
            // btn_Asistencia
            // 
            this.btn_Asistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Asistencia.FlatAppearance.BorderSize = 0;
            this.btn_Asistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btn_Asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Asistencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Asistencia.ForeColor = System.Drawing.Color.White;
            this.btn_Asistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Asistencia.Location = new System.Drawing.Point(63, 203);
            this.btn_Asistencia.Name = "btn_Asistencia";
            this.btn_Asistencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Asistencia.Size = new System.Drawing.Size(154, 29);
            this.btn_Asistencia.TabIndex = 41;
            this.btn_Asistencia.Text = "Asistencias";
            this.btn_Asistencia.UseVisualStyleBackColor = false;
            this.btn_Asistencia.Click += new System.EventHandler(this.btn_Asistencia_Click);
            // 
            // panel_Subinterfaz
            // 
            this.panel_Subinterfaz.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Subinterfaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Subinterfaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Subinterfaz.Location = new System.Drawing.Point(220, 38);
            this.panel_Subinterfaz.Name = "panel_Subinterfaz";
            this.panel_Subinterfaz.Size = new System.Drawing.Size(1080, 612);
            this.panel_Subinterfaz.TabIndex = 4;
            // 
            // GUI_Pc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_Subinterfaz);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Pc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_Pc_Load);
            this.panel_Barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Iniciar_Proyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Salones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Informacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Avisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Imparte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Profesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Horarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Asistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Barra;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.PictureBox btn_Maximizar;
        private System.Windows.Forms.Button btn_Iniciar_Proyeccion;
        private System.Windows.Forms.Button btn_Informacion;
        private System.Windows.Forms.Button btn_Avisos;
        private System.Windows.Forms.Button btn_Profesores;
        private System.Windows.Forms.Button btn_Materias;
        private System.Windows.Forms.TableLayoutPanel panel_botones;
        private System.Windows.Forms.Button btn_Horarios;
        private System.Windows.Forms.PictureBox pb_Inicio;
        private System.Windows.Forms.Panel panel_Materias;
        private System.Windows.Forms.Panel panel_Imparte;
        private System.Windows.Forms.Panel panel_Avisos;
        private System.Windows.Forms.Panel panel_Inicio;
        private System.Windows.Forms.Panel panel_Horarios;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_Imparte;
        private System.Windows.Forms.PictureBox pc_Iniciar_Proyeccion;
        private System.Windows.Forms.PictureBox pc_Horarios;
        private System.Windows.Forms.PictureBox pc_Profesores;
        private System.Windows.Forms.PictureBox pc_Materias;
        private System.Windows.Forms.PictureBox pc_Imparte;
        private System.Windows.Forms.PictureBox pc_Avisos;
        private System.Windows.Forms.PictureBox pc_Informacion;
        private System.Windows.Forms.Panel panel_Iniciar_Proyeccion;
        private System.Windows.Forms.Panel panel_Salones;
        private System.Windows.Forms.Panel panel_Profesores;
        private System.Windows.Forms.Panel panel_Informacion;
        private System.Windows.Forms.PictureBox pc_Salones;
        private System.Windows.Forms.Button btn_Salones;
        private System.Windows.Forms.Panel panel_Asistencia;
        private System.Windows.Forms.PictureBox pc_Asistencia;
        private System.Windows.Forms.Button btn_Asistencia;
        private System.Windows.Forms.Panel panel_Subinterfaz;
    }
}

