namespace Ejercicio3
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
            btnAtender = new Button();
            lbPedidosEntrantes = new ListBox();
            label3 = new Label();
            tbDireccion = new TextBox();
            tbTelefono = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAsignar = new Button();
            lbOcupados = new ListBox();
            label6 = new Label();
            lbDisponibles = new ListBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            nupNumeroVehiculo = new NumericUpDown();
            label4 = new Label();
            btnLiberar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupNumeroVehiculo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAtender);
            groupBox1.Controls.Add(lbPedidosEntrantes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 514);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recibir pedido taxi";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(66, 434);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(125, 57);
            btnAtender.TabIndex = 6;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lbPedidosEntrantes
            // 
            lbPedidosEntrantes.FormattingEnabled = true;
            lbPedidosEntrantes.Location = new Point(6, 261);
            lbPedidosEntrantes.Name = "lbPedidosEntrantes";
            lbPedidosEntrantes.Size = new Size(238, 164);
            lbPedidosEntrantes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 235);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Pedidos entrantes";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(88, 122);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(125, 92);
            tbDireccion.TabIndex = 3;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(88, 68);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(125, 27);
            tbTelefono.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 129);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 71);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Telefono";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAsignar);
            groupBox2.Controls.Add(lbOcupados);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lbDisponibles);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(322, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 514);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Central de taxis";
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(51, 434);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(144, 57);
            btnAsignar.TabIndex = 4;
            btnAsignar.Text = "Asignar coche a cliente";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lbOcupados
            // 
            lbOcupados.FormattingEnabled = true;
            lbOcupados.Location = new Point(19, 301);
            lbOcupados.Name = "lbOcupados";
            lbOcupados.Size = new Size(214, 124);
            lbOcupados.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 278);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 2;
            label6.Text = "Vehiculos ocupados";
            // 
            // lbDisponibles
            // 
            lbDisponibles.FormattingEnabled = true;
            lbDisponibles.Location = new Point(19, 111);
            lbDisponibles.Name = "lbDisponibles";
            lbDisponibles.Size = new Size(214, 144);
            lbDisponibles.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 75);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 0;
            label5.Text = "Vehiculos disponibles";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nupNumeroVehiculo);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnLiberar);
            groupBox3.Location = new Point(612, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 514);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones del chofer";
            // 
            // nupNumeroVehiculo
            // 
            nupNumeroVehiculo.Location = new Point(153, 66);
            nupNumeroVehiculo.Name = "nupNumeroVehiculo";
            nupNumeroVehiculo.Size = new Size(150, 27);
            nupNumeroVehiculo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 68);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 1;
            label4.Text = "Numero de vehiculo ";
            // 
            // btnLiberar
            // 
            btnLiberar.Location = new Point(89, 434);
            btnLiberar.Name = "btnLiberar";
            btnLiberar.Size = new Size(140, 57);
            btnLiberar.TabIndex = 0;
            btnLiberar.Text = "Liberar coche";
            btnLiberar.UseVisualStyleBackColor = true;
            btnLiberar.Click += btnLiberar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 538);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupNumeroVehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAtender;
        private ListBox lbPedidosEntrantes;
        private Label label3;
        private TextBox tbDireccion;
        private TextBox tbTelefono;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private NumericUpDown nupNumeroVehiculo;
        private Label label4;
        private Button btnLiberar;
        private Button btnAsignar;
        private ListBox lbOcupados;
        private Label label6;
        private ListBox lbDisponibles;
        private Label label5;
    }
}
