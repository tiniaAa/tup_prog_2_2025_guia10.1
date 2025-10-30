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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            btnRecibir = new Button();
            lbxVerSectorCarga = new ListBox();
            btnPreparar = new Button();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbDNI2 = new TextBox();
            tbNombre2 = new TextBox();
            tbDireccion2 = new TextBox();
            btnIniciarReparto = new Button();
            button2 = new Button();
            label7 = new Label();
            lbxListadoAentregar = new ListBox();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 486);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sector de atencion al cliente ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPreparar);
            groupBox2.Controls.Add(lbxVerSectorCarga);
            groupBox2.Location = new Point(375, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 486);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paquete en el sector de embarque ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbxListadoAentregar);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(btnIniciarReparto);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(744, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 486);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tarea de reparto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 228);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(111, 45);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(226, 27);
            tbDNI.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(111, 111);
            tbNombre.Multiline = true;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(226, 64);
            tbNombre.TabIndex = 4;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(111, 225);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(226, 153);
            tbDireccion.TabIndex = 5;
            // 
            // btnRecibir
            // 
            btnRecibir.Location = new Point(68, 393);
            btnRecibir.Name = "btnRecibir";
            btnRecibir.Size = new Size(180, 72);
            btnRecibir.TabIndex = 6;
            btnRecibir.Text = "Recibir correspondencia";
            btnRecibir.UseVisualStyleBackColor = true;
            btnRecibir.Click += btnRecibir_Click;
            // 
            // lbxVerSectorCarga
            // 
            lbxVerSectorCarga.FormattingEnabled = true;
            lbxVerSectorCarga.Location = new Point(20, 34);
            lbxVerSectorCarga.Name = "lbxVerSectorCarga";
            lbxVerSectorCarga.Size = new Size(322, 344);
            lbxVerSectorCarga.TabIndex = 0;
            // 
            // btnPreparar
            // 
            btnPreparar.Location = new Point(100, 397);
            btnPreparar.Name = "btnPreparar";
            btnPreparar.Size = new Size(174, 68);
            btnPreparar.TabIndex = 1;
            btnPreparar.Text = "Preparar camión";
            btnPreparar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbDireccion2);
            groupBox4.Controls.Add(tbNombre2);
            groupBox4.Controls.Add(tbDNI2);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(15, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(367, 164);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Proximo a entregar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 23);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 0;
            label4.Text = "DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 71);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 121);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Direccio";
            // 
            // tbDNI2
            // 
            tbDNI2.Location = new Point(130, 20);
            tbDNI2.Name = "tbDNI2";
            tbDNI2.Size = new Size(203, 27);
            tbDNI2.TabIndex = 3;
            // 
            // tbNombre2
            // 
            tbNombre2.Location = new Point(130, 68);
            tbNombre2.Name = "tbNombre2";
            tbNombre2.Size = new Size(203, 27);
            tbNombre2.TabIndex = 4;
            // 
            // tbDireccion2
            // 
            tbDireccion2.Location = new Point(130, 118);
            tbDireccion2.Name = "tbDireccion2";
            tbDireccion2.Size = new Size(203, 27);
            tbDireccion2.TabIndex = 5;
            // 
            // btnIniciarReparto
            // 
            btnIniciarReparto.Location = new Point(45, 243);
            btnIniciarReparto.Name = "btnIniciarReparto";
            btnIniciarReparto.Size = new Size(135, 48);
            btnIniciarReparto.TabIndex = 1;
            btnIniciarReparto.Text = "Iniciar Reparto";
            btnIniciarReparto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(233, 243);
            button2.Name = "button2";
            button2.Size = new Size(136, 48);
            button2.TabIndex = 2;
            button2.Text = "Entregar paquete";
            button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 316);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 3;
            label7.Text = "Listado a entregar";
            // 
            // lbxListadoAentregar
            // 
            lbxListadoAentregar.FormattingEnabled = true;
            lbxListadoAentregar.Location = new Point(15, 361);
            lbxListadoAentregar.Name = "lbxListadoAentregar";
            lbxListadoAentregar.Size = new Size(365, 104);
            lbxListadoAentregar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 505);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
    }
}
