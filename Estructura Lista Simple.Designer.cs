﻿namespace EstructuradeDatos
{
    partial class Estructura_Lista_Simple
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            this.GbLista = new System.Windows.Forms.GroupBox();
            this.LStLista = new System.Windows.Forms.ListBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbElementoEliminado = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
<<<<<<< HEAD
            this.CbCodigo = new System.Windows.Forms.ComboBox();
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            this.LblCodigoDos = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GbGrupoElemento = new System.Windows.Forms.GroupBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTramite = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
<<<<<<< HEAD
<<<<<<< HEAD
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
=======
            this.CbCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
            this.CbCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            this.GbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.GbElementoEliminado.SuspendLayout();
            this.GbGrupoElemento.SuspendLayout();
<<<<<<< HEAD
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
=======
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 169);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
<<<<<<< HEAD
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            // GbLista
            // 
            this.GbLista.Controls.Add(this.LStLista);
            this.GbLista.Controls.Add(this.DgvLista);
            this.GbLista.Location = new System.Drawing.Point(12, 215);
            this.GbLista.Name = "GbLista";
            this.GbLista.Size = new System.Drawing.Size(615, 216);
            this.GbLista.TabIndex = 23;
            this.GbLista.TabStop = false;
            this.GbLista.Text = "Listado de una Listan y una grilla";
            // 
            // LStLista
            // 
            this.LStLista.FormattingEnabled = true;
            this.LStLista.Location = new System.Drawing.Point(6, 19);
            this.LStLista.Name = "LStLista";
            this.LStLista.Size = new System.Drawing.Size(229, 186);
            this.LStLista.TabIndex = 1;
<<<<<<< HEAD
<<<<<<< HEAD
            this.LStLista.SelectedIndexChanged += new System.EventHandler(this.LStLista_SelectedIndexChanged);
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            // 
            // DgvLista
            // 
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvLista.Location = new System.Drawing.Point(247, 19);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.Size = new System.Drawing.Size(368, 191);
            this.DgvLista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // GbElementoEliminado
            // 
            this.GbElementoEliminado.Controls.Add(this.CbCodigo);
            this.GbElementoEliminado.Controls.Add(this.LblCodigoDos);
            this.GbElementoEliminado.Controls.Add(this.BtnEliminar);
            this.GbElementoEliminado.Location = new System.Drawing.Point(445, 5);
            this.GbElementoEliminado.Name = "GbElementoEliminado";
            this.GbElementoEliminado.Size = new System.Drawing.Size(182, 182);
            this.GbElementoEliminado.TabIndex = 21;
            this.GbElementoEliminado.TabStop = false;
            this.GbElementoEliminado.Text = "Elemento Eliminado";
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // CbCodigo
            // 
            this.CbCodigo.FormattingEnabled = true;
            this.CbCodigo.Location = new System.Drawing.Point(55, 72);
            this.CbCodigo.Name = "CbCodigo";
            this.CbCodigo.Size = new System.Drawing.Size(121, 21);
            this.CbCodigo.TabIndex = 15;
            this.CbCodigo.SelectedIndexChanged += new System.EventHandler(this.CbCodigo_SelectedIndexChanged);
            // 
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            // LblCodigoDos
            // 
            this.LblCodigoDos.AutoSize = true;
            this.LblCodigoDos.Location = new System.Drawing.Point(6, 76);
            this.LblCodigoDos.Name = "LblCodigoDos";
            this.LblCodigoDos.Size = new System.Drawing.Size(40, 13);
            this.LblCodigoDos.TabIndex = 8;
            this.LblCodigoDos.Text = "Codigo";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(22, 141);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(144, 35);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GbGrupoElemento
            // 
            this.GbGrupoElemento.Controls.Add(this.LblCodigo);
            this.GbGrupoElemento.Controls.Add(this.LblNombre);
            this.GbGrupoElemento.Controls.Add(this.LblTramite);
            this.GbGrupoElemento.Controls.Add(this.TxtCodigo);
            this.GbGrupoElemento.Controls.Add(this.TxtNombre);
            this.GbGrupoElemento.Controls.Add(this.TxtTramite);
            this.GbGrupoElemento.Controls.Add(this.BtnAgregar);
            this.GbGrupoElemento.Location = new System.Drawing.Point(218, 5);
            this.GbGrupoElemento.Name = "GbGrupoElemento";
            this.GbGrupoElemento.Size = new System.Drawing.Size(182, 182);
            this.GbGrupoElemento.TabIndex = 22;
            this.GbGrupoElemento.TabStop = false;
            this.GbGrupoElemento.Text = "Nuevo Elemento";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(6, 44);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 1;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(6, 80);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.Location = new System.Drawing.Point(6, 118);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(42, 13);
            this.LblTramite.TabIndex = 3;
            this.LblTramite.Text = "Tramite";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(76, 41);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 4;
<<<<<<< HEAD
<<<<<<< HEAD
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(76, 77);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(76, 115);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(100, 20);
            this.TxtTramite.TabIndex = 6;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(22, 141);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(144, 35);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstructuradeDatos.Properties.Resources.IMG_20230414_WA0017;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
=======
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            // CbCodigo
            // 
            this.CbCodigo.FormattingEnabled = true;
            this.CbCodigo.Location = new System.Drawing.Point(55, 72);
            this.CbCodigo.Name = "CbCodigo";
            this.CbCodigo.Size = new System.Drawing.Size(121, 21);
            this.CbCodigo.TabIndex = 15;
            this.CbCodigo.SelectedIndexChanged += new System.EventHandler(this.CbCodigo_SelectedIndexChanged);
<<<<<<< HEAD
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            // 
            // Estructura_Lista_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GbLista);
            this.Controls.Add(this.GbElementoEliminado);
            this.Controls.Add(this.GbGrupoElemento);
            this.Name = "Estructura_Lista_Simple";
            this.Text = "Estructura_Lista_Simple";
<<<<<<< HEAD
<<<<<<< HEAD
            this.Load += new System.EventHandler(this.Estructura_Lista_Simple_Load);
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            this.GbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.GbElementoEliminado.ResumeLayout(false);
            this.GbElementoEliminado.PerformLayout();
            this.GbGrupoElemento.ResumeLayout(false);
            this.GbGrupoElemento.PerformLayout();
<<<<<<< HEAD
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
=======
>>>>>>> 05e4f30ddeb974a586812c1c3050e622a3be2649
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GbLista;
        private System.Windows.Forms.ListBox LStLista;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox GbElementoEliminado;
        private System.Windows.Forms.Label LblCodigoDos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox GbGrupoElemento;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CbCodigo;
    }
}