namespace Trabajo2
{
    partial class AgregarAsignatura
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAsignatura = new System.Windows.Forms.Button();
            this.btnActualizarAsignatura = new System.Windows.Forms.Button();
            this.txCreditos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txAsignatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 136);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 19);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnEliminarAsignatura);
            this.groupBox1.Controls.Add(this.btnActualizarAsignatura);
            this.groupBox1.Controls.Add(this.txCreditos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txAsignatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignatura";
            // 
            // btnEliminarAsignatura
            // 
            this.btnEliminarAsignatura.Location = new System.Drawing.Point(7, 184);
            this.btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            this.btnEliminarAsignatura.Size = new System.Drawing.Size(68, 19);
            this.btnEliminarAsignatura.TabIndex = 10;
            this.btnEliminarAsignatura.Text = "Eliminar";
            this.btnEliminarAsignatura.UseVisualStyleBackColor = true;
            this.btnEliminarAsignatura.Click += new System.EventHandler(this.btnEliminarAsignatura_Click);
            // 
            // btnActualizarAsignatura
            // 
            this.btnActualizarAsignatura.Location = new System.Drawing.Point(7, 136);
            this.btnActualizarAsignatura.Name = "btnActualizarAsignatura";
            this.btnActualizarAsignatura.Size = new System.Drawing.Size(68, 19);
            this.btnActualizarAsignatura.TabIndex = 9;
            this.btnActualizarAsignatura.Text = "Actualizar";
            this.btnActualizarAsignatura.UseVisualStyleBackColor = true;
            this.btnActualizarAsignatura.Click += new System.EventHandler(this.btnActualizarAsignatura_Click);
            // 
            // txCreditos
            // 
            this.txCreditos.Location = new System.Drawing.Point(56, 80);
            this.txCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.txCreditos.Name = "txCreditos";
            this.txCreditos.Size = new System.Drawing.Size(72, 20);
            this.txCreditos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creditos: ";
            // 
            // txAsignatura
            // 
            this.txAsignatura.Location = new System.Drawing.Point(106, 46);
            this.txAsignatura.Margin = new System.Windows.Forms.Padding(2);
            this.txAsignatura.Name = "txAsignatura";
            this.txAsignatura.Size = new System.Drawing.Size(118, 20);
            this.txAsignatura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Asignatura: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAsignaturas);
            this.groupBox2.Location = new System.Drawing.Point(333, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(304, 274);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignatura";
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Location = new System.Drawing.Point(4, 18);
            this.dgvAsignaturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.RowHeadersWidth = 51;
            this.dgvAsignaturas.Size = new System.Drawing.Size(295, 244);
            this.dgvAsignaturas.TabIndex = 0;
            this.dgvAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaturas_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(130, 184);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(56, 19);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // AgregarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarAsignatura";
            this.Text = "AgregarAsignatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.TextBox txAsignatura;
        private System.Windows.Forms.TextBox txCreditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarAsignatura;
        private System.Windows.Forms.Button btnActualizarAsignatura;
        private System.Windows.Forms.Button btnListar;
    }
}