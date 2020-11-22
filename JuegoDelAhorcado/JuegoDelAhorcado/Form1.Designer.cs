namespace JuegoDelAhorcado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.labelN_intentos = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.labelPalabraAdivinar = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.labelErroneas = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.flpTeclado = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPalabras = new System.Windows.Forms.FlowLayoutPanel();
            this.flpErroneas = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGanado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pLogin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.pPalabra = new System.Windows.Forms.Panel();
            this.lblpalabraInsertada = new System.Windows.Forms.Label();
            this.btnaniadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPalabra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLogin.SuspendLayout();
            this.pPalabra.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDificultad
            // 
            this.cbDificultad.BackColor = System.Drawing.Color.Indigo;
            this.cbDificultad.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDificultad.ForeColor = System.Drawing.Color.White;
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Items.AddRange(new object[] {
            "Nivel Básico",
            "Nivel Medio",
            "Nivel Avanzado"});
            this.cbDificultad.Location = new System.Drawing.Point(38, 20);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(228, 33);
            this.cbDificultad.TabIndex = 0;
            this.cbDificultad.Text = "Seleccionar Dificultad";
            this.cbDificultad.SelectedIndexChanged += new System.EventHandler(this.cbDificultad_SelectedIndexChanged);
            // 
            // labelN_intentos
            // 
            this.labelN_intentos.AutoSize = true;
            this.labelN_intentos.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN_intentos.Location = new System.Drawing.Point(807, 20);
            this.labelN_intentos.Name = "labelN_intentos";
            this.labelN_intentos.Size = new System.Drawing.Size(243, 29);
            this.labelN_intentos.TabIndex = 1;
            this.labelN_intentos.Text = "Nº Intentos Restantes:";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(1056, 20);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(27, 29);
            this.lblIntentos.TabIndex = 2;
            this.lblIntentos.Text = "7";
            // 
            // labelPalabraAdivinar
            // 
            this.labelPalabraAdivinar.AutoSize = true;
            this.labelPalabraAdivinar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalabraAdivinar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelPalabraAdivinar.Location = new System.Drawing.Point(86, 253);
            this.labelPalabraAdivinar.Name = "labelPalabraAdivinar";
            this.labelPalabraAdivinar.Size = new System.Drawing.Size(199, 31);
            this.labelPalabraAdivinar.TabIndex = 3;
            this.labelPalabraAdivinar.Text = "Adivinar Palabra:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(38, 156);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(150, 74);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelErroneas
            // 
            this.labelErroneas.AutoSize = true;
            this.labelErroneas.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroneas.ForeColor = System.Drawing.Color.LightCoral;
            this.labelErroneas.Location = new System.Drawing.Point(447, 20);
            this.labelErroneas.Name = "labelErroneas";
            this.labelErroneas.Size = new System.Drawing.Size(169, 29);
            this.labelErroneas.TabIndex = 5;
            this.labelErroneas.Text = "Letras Erróneas";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(959, 413);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(150, 84);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Modo Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // flpTeclado
            // 
            this.flpTeclado.Location = new System.Drawing.Point(82, 430);
            this.flpTeclado.Name = "flpTeclado";
            this.flpTeclado.Size = new System.Drawing.Size(727, 213);
            this.flpTeclado.TabIndex = 8;
            // 
            // flpPalabras
            // 
            this.flpPalabras.AutoSize = true;
            this.flpPalabras.BackColor = System.Drawing.Color.Beige;
            this.flpPalabras.Cursor = System.Windows.Forms.Cursors.Default;
            this.flpPalabras.Location = new System.Drawing.Point(82, 287);
            this.flpPalabras.Name = "flpPalabras";
            this.flpPalabras.Size = new System.Drawing.Size(724, 137);
            this.flpPalabras.TabIndex = 9;
            this.flpPalabras.WrapContents = false;
            // 
            // flpErroneas
            // 
            this.flpErroneas.BackColor = System.Drawing.Color.Beige;
            this.flpErroneas.Location = new System.Drawing.Point(298, 55);
            this.flpErroneas.Name = "flpErroneas";
            this.flpErroneas.Size = new System.Drawing.Size(459, 98);
            this.flpErroneas.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(812, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblGanado
            // 
            this.lblGanado.AutoSize = true;
            this.lblGanado.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanado.ForeColor = System.Drawing.Color.Purple;
            this.lblGanado.Location = new System.Drawing.Point(349, 156);
            this.lblGanado.Name = "lblGanado";
            this.lblGanado.Size = new System.Drawing.Size(326, 72);
            this.lblGanado.TabIndex = 18;
            this.lblGanado.Text = "YOU WIN!!!";
            this.lblGanado.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(973, 523);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 72);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.LightBlue;
            this.pLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogin.Controls.Add(this.lblAdmin);
            this.pLogin.Controls.Add(this.btnIngresar);
            this.pLogin.Controls.Add(this.lblConfirmacion);
            this.pLogin.Controls.Add(this.lblPassword);
            this.pLogin.Controls.Add(this.lblLogin);
            this.pLogin.Controls.Add(this.txbPassword);
            this.pLogin.Controls.Add(this.txbUsuario);
            this.pLogin.Location = new System.Drawing.Point(390, 84);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(453, 268);
            this.pLogin.TabIndex = 20;
            this.pLogin.Visible = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(55, 13);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(330, 25);
            this.lblAdmin.TabIndex = 6;
            this.lblAdmin.Text = "Introduce Login de Administrador";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(200, 201);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 41);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Login";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.ForeColor = System.Drawing.Color.Maroon;
            this.lblConfirmacion.Location = new System.Drawing.Point(192, 169);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(124, 20);
            this.lblConfirmacion.TabIndex = 4;
            this.lblConfirmacion.Text = "Login Incorrecto";
            this.lblConfirmacion.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(75, 131);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(110, 83);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Usuario";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(195, 130);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(125, 26);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(195, 83);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(125, 26);
            this.txbUsuario.TabIndex = 0;
            // 
            // pPalabra
            // 
            this.pPalabra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pPalabra.Controls.Add(this.lblpalabraInsertada);
            this.pPalabra.Controls.Add(this.btnaniadir);
            this.pPalabra.Controls.Add(this.label1);
            this.pPalabra.Controls.Add(this.txbPalabra);
            this.pPalabra.Location = new System.Drawing.Point(849, 84);
            this.pPalabra.Name = "pPalabra";
            this.pPalabra.Size = new System.Drawing.Size(260, 268);
            this.pPalabra.TabIndex = 21;
            this.pPalabra.Visible = false;
            // 
            // lblpalabraInsertada
            // 
            this.lblpalabraInsertada.AutoSize = true;
            this.lblpalabraInsertada.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpalabraInsertada.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpalabraInsertada.Location = new System.Drawing.Point(57, 156);
            this.lblpalabraInsertada.Name = "lblpalabraInsertada";
            this.lblpalabraInsertada.Size = new System.Drawing.Size(160, 24);
            this.lblpalabraInsertada.TabIndex = 8;
            this.lblpalabraInsertada.Text = "Palabra Insertada";
            // 
            // btnaniadir
            // 
            this.btnaniadir.Location = new System.Drawing.Point(79, 203);
            this.btnaniadir.Name = "btnaniadir";
            this.btnaniadir.Size = new System.Drawing.Size(99, 41);
            this.btnaniadir.TabIndex = 7;
            this.btnaniadir.Text = "Añadir";
            this.btnaniadir.UseVisualStyleBackColor = true;
            this.btnaniadir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Introduce Palabra nueva\r\n a añadir:";
            // 
            // txbPalabra
            // 
            this.txbPalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalabra.Location = new System.Drawing.Point(61, 106);
            this.txbPalabra.Name = "txbPalabra";
            this.txbPalabra.Size = new System.Drawing.Size(140, 30);
            this.txbPalabra.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1154, 665);
            this.Controls.Add(this.pPalabra);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblGanado);
            this.Controls.Add(this.flpErroneas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpPalabras);
            this.Controls.Add(this.flpTeclado);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.labelErroneas);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.labelPalabraAdivinar);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.labelN_intentos);
            this.Controls.Add(this.cbDificultad);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Juego del Ahorcado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.pPalabra.ResumeLayout(false);
            this.pPalabra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.Label labelN_intentos;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label labelPalabraAdivinar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label labelErroneas;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.FlowLayoutPanel flpTeclado;
        private System.Windows.Forms.FlowLayoutPanel flpPalabras;
        private System.Windows.Forms.FlowLayoutPanel flpErroneas;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGanado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel pPalabra;
        private System.Windows.Forms.TextBox txbPalabra;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnaniadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpalabraInsertada;
    }
}

