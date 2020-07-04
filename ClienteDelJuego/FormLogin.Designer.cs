namespace ClienteDelJuego
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelIniciarSesionTit = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(41, 22);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(390, 60);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            // 
            // labelIniciarSesionTit
            // 
            this.labelIniciarSesionTit.AutoSize = true;
            this.labelIniciarSesionTit.BackColor = System.Drawing.Color.Transparent;
            this.labelIniciarSesionTit.Font = new System.Drawing.Font("Pacifico", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesionTit.Location = new System.Drawing.Point(107, 85);
            this.labelIniciarSesionTit.Name = "labelIniciarSesionTit";
            this.labelIniciarSesionTit.Size = new System.Drawing.Size(73, 41);
            this.labelIniciarSesionTit.TabIndex = 2;
            this.labelIniciarSesionTit.Text = "Login";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.AllowDrop = true;
            this.buttonIngresar.AutoSize = true;
            this.buttonIngresar.BackColor = System.Drawing.Color.Transparent;
            this.buttonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonIngresar.Font = new System.Drawing.Font("Pacifico", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonIngresar.Location = new System.Drawing.Point(112, 254);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(249, 53);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Iniciar Sesión";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            this.buttonIngresar.MouseEnter += new System.EventHandler(this.buttonIngresar_MouseEnter);
            this.buttonIngresar.MouseLeave += new System.EventHandler(this.buttonIngresar_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(462, 336);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 114;
            this.lineShape2.X2 = 362;
            this.lineShape2.Y1 = 223;
            this.lineShape2.Y2 = 223;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 114;
            this.lineShape1.X2 = 362;
            this.lineShape1.Y1 = 162;
            this.lineShape1.Y2 = 162;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.Azure;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsuario.Location = new System.Drawing.Point(112, 136);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(251, 20);
            this.textBoxUsuario.TabIndex = 7;
            this.textBoxUsuario.Text = "usuario";
            this.textBoxUsuario.Enter += new System.EventHandler(this.textBoxUsuario_Enter);
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            this.textBoxUsuario.Leave += new System.EventHandler(this.textBoxUsuario_Leave);
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BackColor = System.Drawing.Color.Azure;
            this.textBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContrasena.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.ForeColor = System.Drawing.Color.Black;
            this.textBoxContrasena.Location = new System.Drawing.Point(114, 195);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(249, 20);
            this.textBoxContrasena.TabIndex = 8;
            this.textBoxContrasena.Text = "contraseña";
            this.textBoxContrasena.Enter += new System.EventHandler(this.textBoxContrasena_Enter);
            this.textBoxContrasena.Leave += new System.EventHandler(this.textBoxContrasena_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::ClienteDelJuego.Properties.Resources.z9yxq28d5rey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 336);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelIniciarSesionTit);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Masters!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label labelIniciarSesionTit;
        private System.Windows.Forms.Button buttonIngresar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
    }
}

