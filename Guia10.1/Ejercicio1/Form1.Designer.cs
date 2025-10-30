namespace Ejercicio1
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
            btnRecibir = new Button();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPreparar = new Button();
            lbxVerSectorCarga = new ListBox();
            groupBox3 = new GroupBox();
            lbxListadoAentregar = new ListBox();
            label7 = new Label();
            btnEntregarPaquete = new Button();
            btnIniciarReparto = new Button();
            groupBox4 = new GroupBox();
            tbDireccion2 = new TextBox();
            tbNombre2 = new TextBox();
            tbDNI2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRecibir);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(312, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sector de atencion al cliente ";
            // 
            // btnRecibir
            // 
            btnRecibir.Location = new Point(60, 295);
            btnRecibir.Margin = new Padding(3, 2, 3, 2);
            btnRecibir.Name = "btnRecibir";
            btnRecibir.Size = new Size(158, 54);
            btnRecibir.TabIndex = 6;
            btnRecibir.Text = "Recibir correspondencia";
            btnRecibir.UseVisualStyleBackColor = true;
            btnRecibir.Click += btnRecibir_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(97, 169);
            tbDireccion.Margin = new Padding(3, 2, 3, 2);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(198, 116);
            tbDireccion.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(97, 83);
            tbNombre.Margin = new Padding(3, 2, 3, 2);
            tbNombre.Multiline = true;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(198, 49);
            tbNombre.TabIndex = 4;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(97, 34);
            tbDNI.Margin = new Padding(3, 2, 3, 2);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(198, 23);
            tbDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 171);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPreparar);
            groupBox2.Controls.Add(lbxVerSectorCarga);
            groupBox2.Location = new Point(328, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(318, 364);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paquete en el sector de embarque ";
            // 
            // btnPreparar
            // 
            btnPreparar.Location = new Point(88, 298);
            btnPreparar.Margin = new Padding(3, 2, 3, 2);
            btnPreparar.Name = "btnPreparar";
            btnPreparar.Size = new Size(152, 51);
            btnPreparar.TabIndex = 1;
            btnPreparar.Text = "Preparar camión";
            btnPreparar.UseVisualStyleBackColor = true;
            btnPreparar.Click += btnPreparar_Click;
            // 
            // lbxVerSectorCarga
            // 
            lbxVerSectorCarga.FormattingEnabled = true;
            lbxVerSectorCarga.ItemHeight = 15;
            lbxVerSectorCarga.Location = new Point(18, 26);
            lbxVerSectorCarga.Margin = new Padding(3, 2, 3, 2);
            lbxVerSectorCarga.Name = "lbxVerSectorCarga";
            lbxVerSectorCarga.Size = new Size(282, 259);
            lbxVerSectorCarga.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbxListadoAentregar);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnEntregarPaquete);
            groupBox3.Controls.Add(btnIniciarReparto);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(651, 9);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(340, 364);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tarea de reparto";
            // 
            // lbxListadoAentregar
            // 
            lbxListadoAentregar.FormattingEnabled = true;
            lbxListadoAentregar.ItemHeight = 15;
            lbxListadoAentregar.Location = new Point(13, 271);
            lbxListadoAentregar.Margin = new Padding(3, 2, 3, 2);
            lbxListadoAentregar.Name = "lbxListadoAentregar";
            lbxListadoAentregar.Size = new Size(320, 79);
            lbxListadoAentregar.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 245);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 3;
            label7.Text = "Listado a entregar";
            // 
            // btnEntregarPaquete
            // 
            btnEntregarPaquete.Location = new Point(204, 182);
            btnEntregarPaquete.Margin = new Padding(3, 2, 3, 2);
            btnEntregarPaquete.Name = "btnEntregarPaquete";
            btnEntregarPaquete.Size = new Size(119, 36);
            btnEntregarPaquete.TabIndex = 2;
            btnEntregarPaquete.Text = "Entregar paquete";
            btnEntregarPaquete.UseVisualStyleBackColor = true;
            btnEntregarPaquete.Click += btnEntregarPaquete_Click;
            // 
            // btnIniciarReparto
            // 
            btnIniciarReparto.Location = new Point(39, 182);
            btnIniciarReparto.Margin = new Padding(3, 2, 3, 2);
            btnIniciarReparto.Name = "btnIniciarReparto";
            btnIniciarReparto.Size = new Size(118, 36);
            btnIniciarReparto.TabIndex = 1;
            btnIniciarReparto.Text = "Iniciar Reparto";
            btnIniciarReparto.UseVisualStyleBackColor = true;
            btnIniciarReparto.Click += btnIniciarReparto_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbDireccion2);
            groupBox4.Controls.Add(tbNombre2);
            groupBox4.Controls.Add(tbDNI2);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(13, 26);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(321, 123);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Proximo a entregar";
            // 
            // tbDireccion2
            // 
            tbDireccion2.Location = new Point(114, 88);
            tbDireccion2.Margin = new Padding(3, 2, 3, 2);
            tbDireccion2.Name = "tbDireccion2";
            tbDireccion2.ReadOnly = true;
            tbDireccion2.Size = new Size(178, 23);
            tbDireccion2.TabIndex = 5;
            // 
            // tbNombre2
            // 
            tbNombre2.Location = new Point(114, 51);
            tbNombre2.Margin = new Padding(3, 2, 3, 2);
            tbNombre2.Name = "tbNombre2";
            tbNombre2.ReadOnly = true;
            tbNombre2.Size = new Size(178, 23);
            tbNombre2.TabIndex = 4;
            // 
            // tbDNI2
            // 
            tbDNI2.Location = new Point(114, 15);
            tbDNI2.Margin = new Padding(3, 2, 3, 2);
            tbDNI2.Name = "tbDNI2";
            tbDNI2.ReadOnly = true;
            tbDNI2.Size = new Size(178, 23);
            tbDNI2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 91);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 2;
            label6.Text = "Direccio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 53);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 17);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 0;
            label4.Text = "DNI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 379);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private Button btnRecibir;
        private TextBox tbDireccion;
        private Button btnPreparar;
        private ListBox lbxVerSectorCarga;
        private GroupBox groupBox4;
        private TextBox tbDNI2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbDireccion2;
        private TextBox tbNombre2;
        private ListBox lbxListadoAentregar;
        private Label label7;
        private Button button2;
        private Button btnIniciarReparto;
        private Button btnEntregarPaquete;
    }
}
