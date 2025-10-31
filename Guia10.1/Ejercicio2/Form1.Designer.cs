namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnRegistrarReclamo = new Button();
            tbMotivo = new TextBox();
            tbNombre = new TextBox();
            Motivo = new Label();
            Nombre = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCrearOrden = new Button();
            lbVerReclamos = new ListBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnEjecutarOrden = new Button();
            lbVerOrdenesAEjecutar = new ListBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarReclamo);
            groupBox1.Controls.Add(tbMotivo);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(Motivo);
            groupBox1.Controls.Add(Nombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 372);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recepcion de reclamos ";
            // 
            // btnRegistrarReclamo
            // 
            btnRegistrarReclamo.Location = new Point(34, 289);
            btnRegistrarReclamo.Name = "btnRegistrarReclamo";
            btnRegistrarReclamo.Size = new Size(178, 53);
            btnRegistrarReclamo.TabIndex = 4;
            btnRegistrarReclamo.Text = "Registrar reclamo";
            btnRegistrarReclamo.UseVisualStyleBackColor = true;
            btnRegistrarReclamo.Click += btnRegistrarReclamo_Click;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(112, 131);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(127, 119);
            tbMotivo.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(112, 83);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(127, 23);
            tbNombre.TabIndex = 1;
            // 
            // Motivo
            // 
            Motivo.AutoSize = true;
            Motivo.Location = new Point(36, 134);
            Motivo.Name = "Motivo";
            Motivo.Size = new Size(45, 15);
            Motivo.TabIndex = 2;
            Motivo.Text = "Motivo";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(34, 91);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 52);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del reclamo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearOrden);
            groupBox2.Controls.Add(lbVerReclamos);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(315, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 372);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Planificar Trabajo";
            // 
            // btnCrearOrden
            // 
            btnCrearOrden.Location = new Point(43, 289);
            btnCrearOrden.Name = "btnCrearOrden";
            btnCrearOrden.Size = new Size(199, 53);
            btnCrearOrden.TabIndex = 2;
            btnCrearOrden.Text = "Crear Orden De Trabajo";
            btnCrearOrden.UseVisualStyleBackColor = true;
            btnCrearOrden.Click += btnCrearOrden_Click;
            // 
            // lbVerReclamos
            // 
            lbVerReclamos.FormattingEnabled = true;
            lbVerReclamos.ItemHeight = 15;
            lbVerReclamos.Location = new Point(6, 83);
            lbVerReclamos.Name = "lbVerReclamos";
            lbVerReclamos.Size = new Size(256, 169);
            lbVerReclamos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Lista de reclamos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEjecutarOrden);
            groupBox3.Controls.Add(lbVerOrdenesAEjecutar);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(589, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 372);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de trabajos ";
            // 
            // btnEjecutarOrden
            // 
            btnEjecutarOrden.Location = new Point(35, 289);
            btnEjecutarOrden.Name = "btnEjecutarOrden";
            btnEjecutarOrden.Size = new Size(220, 53);
            btnEjecutarOrden.TabIndex = 2;
            btnEjecutarOrden.Text = "Ejecutar orden de trabajo";
            btnEjecutarOrden.UseVisualStyleBackColor = true;
            btnEjecutarOrden.Click += btnEjecutarOrden_Click;
            // 
            // lbVerOrdenesAEjecutar
            // 
            lbVerOrdenesAEjecutar.FormattingEnabled = true;
            lbVerOrdenesAEjecutar.ItemHeight = 15;
            lbVerOrdenesAEjecutar.Location = new Point(19, 83);
            lbVerOrdenesAEjecutar.Name = "lbVerOrdenesAEjecutar";
            lbVerOrdenesAEjecutar.Size = new Size(271, 169);
            lbVerOrdenesAEjecutar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 52);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 0;
            label3.Text = "Travajos ejecutados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 397);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnRegistrarReclamo;
        private TextBox tbMotivo;
        private TextBox tbNombre;
        private Label Motivo;
        private Label Nombre;
        private Label label1;
        private Button btnCrearOrden;
        private ListBox lbVerReclamos;
        private Label label2;
        private Button btnEjecutarOrden;
        private ListBox lbVerOrdenesAEjecutar;
        private Label label3;
    }
}
