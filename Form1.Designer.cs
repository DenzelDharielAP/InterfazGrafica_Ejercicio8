namespace InterfazGrafica_Ejercicio8
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMensaje = new TextBox();
            txtIsr = new TextBox();
            txtSfs = new TextBox();
            txtAfp = new TextBox();
            txtSueldo = new TextBox();
            btnEvaluar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 24);
            label1.TabIndex = 0;
            label1.Text = "IMPUESTO SOBRE LA RENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "AFP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 82);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(92, 163);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 3;
            label4.Text = "SFS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 242);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Mensaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(91, 200);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 5;
            label6.Text = "ISR";
            // 
            // txtMensaje
            // 
            txtMensaje.Enabled = false;
            txtMensaje.Location = new Point(149, 241);
            txtMensaje.Margin = new Padding(2, 2, 2, 2);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(106, 23);
            txtMensaje.TabIndex = 6;
            // 
            // txtIsr
            // 
            txtIsr.Enabled = false;
            txtIsr.Location = new Point(150, 200);
            txtIsr.Margin = new Padding(2, 2, 2, 2);
            txtIsr.Name = "txtIsr";
            txtIsr.Size = new Size(106, 23);
            txtIsr.TabIndex = 7;
            // 
            // txtSfs
            // 
            txtSfs.Enabled = false;
            txtSfs.Location = new Point(149, 161);
            txtSfs.Margin = new Padding(2, 2, 2, 2);
            txtSfs.Name = "txtSfs";
            txtSfs.Size = new Size(106, 23);
            txtSfs.TabIndex = 8;
            // 
            // txtAfp
            // 
            txtAfp.Enabled = false;
            txtAfp.Location = new Point(149, 122);
            txtAfp.Margin = new Padding(2, 2, 2, 2);
            txtAfp.Name = "txtAfp";
            txtAfp.Size = new Size(106, 23);
            txtAfp.TabIndex = 9;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(149, 82);
            txtSueldo.Margin = new Padding(2, 2, 2, 2);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(106, 23);
            txtSueldo.TabIndex = 10;
            // 
            // btnEvaluar
            // 
            btnEvaluar.BackColor = Color.RoyalBlue;
            btnEvaluar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvaluar.ForeColor = Color.White;
            btnEvaluar.Location = new Point(339, 108);
            btnEvaluar.Margin = new Padding(2, 2, 2, 2);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(103, 28);
            btnEvaluar.TabIndex = 11;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = false;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.RoyalBlue;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(476, 108);
            btnLimpiar.Margin = new Padding(2, 2, 2, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.RoyalBlue;
            btnCerrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(414, 173);
            btnCerrar.Margin = new Padding(2, 2, 2, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 29);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(641, 307);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEvaluar);
            Controls.Add(txtSueldo);
            Controls.Add(txtAfp);
            Controls.Add(txtSfs);
            Controls.Add(txtIsr);
            Controls.Add(txtMensaje);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMensaje;
        private TextBox txtIsr;
        private TextBox txtSfs;
        private TextBox txtAfp;
        private TextBox txtSueldo;
        private Button btnEvaluar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}