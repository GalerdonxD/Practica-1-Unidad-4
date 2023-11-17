namespace Practica_1_Unidad_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnAbrir = new Button();
            txtMonto = new TextBox();
            txtCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRetiro = new Button();
            btnDeposito = new Button();
            groupBox3 = new GroupBox();
            btnNuevo = new Button();
            txtSaldo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lstRetiros = new ListBox();
            lstDepositos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(272, 29);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(99, 23);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir cuenta";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(93, 59);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(151, 23);
            txtMonto.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(93, 30);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(151, 23);
            txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRetiro);
            groupBox2.Controls.Add(btnDeposito);
            groupBox2.Location = new Point(11, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 94);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transacciones";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnRetiro
            // 
            btnRetiro.Location = new Point(205, 36);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(111, 23);
            btnRetiro.TabIndex = 1;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(35, 36);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(111, 23);
            btnDeposito.TabIndex = 0;
            btnDeposito.Text = "Depósito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Controls.Add(txtSaldo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lstRetiros);
            groupBox3.Controls.Add(lstDepositos);
            groupBox3.Location = new Point(12, 216);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 218);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(262, 173);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(248, 144);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(122, 23);
            txtSaldo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 126);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 34);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Retiros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 34);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Depósitos";
            // 
            // lstRetiros
            // 
            lstRetiros.FormattingEnabled = true;
            lstRetiros.ItemHeight = 15;
            lstRetiros.Location = new Point(124, 73);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.Size = new Size(97, 139);
            lstRetiros.TabIndex = 1;
            // 
            // lstDepositos
            // 
            lstDepositos.FormattingEnabled = true;
            lstDepositos.ItemHeight = 15;
            lstDepositos.Location = new Point(11, 73);
            lstDepositos.Name = "lstDepositos";
            lstDepositos.Size = new Size(97, 139);
            lstDepositos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(400, 446);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de cuentas de ahorro";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAbrir;
        private TextBox txtMonto;
        private TextBox txtCliente;
        private Button btnRetiro;
        private Button btnDeposito;
        private Button btnNuevo;
        private TextBox txtSaldo;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox lstRetiros;
        private ListBox lstDepositos;
    }
}