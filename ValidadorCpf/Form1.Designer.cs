namespace ValidadorCpf
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCnpj = new System.Windows.Forms.Button();
            this.txtNumeroDigitado = new System.Windows.Forms.TextBox();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblTexto3 = new System.Windows.Forms.Label();
            this.btnCpf = new System.Windows.Forms.Button();
            this.btnPis = new System.Windows.Forms.Button();
            this.lblTexto4 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCnpj
            // 
            this.btnCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.btnCnpj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCnpj.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCnpj.Location = new System.Drawing.Point(20, 189);
            this.btnCnpj.Name = "btnCnpj";
            this.btnCnpj.Size = new System.Drawing.Size(86, 35);
            this.btnCnpj.TabIndex = 0;
            this.btnCnpj.Text = "CNPJ";
            this.btnCnpj.UseVisualStyleBackColor = false;
            this.btnCnpj.Click += new System.EventHandler(this.btnCnpj_Click);
            // 
            // txtNumeroDigitado
            // 
            this.txtNumeroDigitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.txtNumeroDigitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDigitado.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtNumeroDigitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtNumeroDigitado.Location = new System.Drawing.Point(20, 118);
            this.txtNumeroDigitado.Multiline = true;
            this.txtNumeroDigitado.Name = "txtNumeroDigitado";
            this.txtNumeroDigitado.Size = new System.Drawing.Size(280, 28);
            this.txtNumeroDigitado.TabIndex = 1;
            this.txtNumeroDigitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroDigitado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDigitado_KeyPress);
            // 
            // lblTexto2
            // 
            this.lblTexto2.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTexto2.ForeColor = System.Drawing.Color.LightGray;
            this.lblTexto2.Location = new System.Drawing.Point(20, 95);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(280, 18);
            this.lblTexto2.TabIndex = 2;
            this.lblTexto2.Text = "Digite o número abaixo";
            this.lblTexto2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTexto1
            // 
            this.lblTexto1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto1.ForeColor = System.Drawing.Color.LightGray;
            this.lblTexto1.Location = new System.Drawing.Point(20, 50);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(280, 29);
            this.lblTexto1.TabIndex = 2;
            this.lblTexto1.Text = "Validador de Documentos";
            this.lblTexto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(20, 250);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(280, 45);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblTexto3
            // 
            this.lblTexto3.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTexto3.ForeColor = System.Drawing.Color.LightGray;
            this.lblTexto3.Location = new System.Drawing.Point(20, 166);
            this.lblTexto3.Name = "lblTexto3";
            this.lblTexto3.Size = new System.Drawing.Size(280, 18);
            this.lblTexto3.TabIndex = 2;
            this.lblTexto3.Text = "Selecione o tipo para validar";
            this.lblTexto3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCpf
            // 
            this.btnCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.btnCpf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCpf.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCpf.Location = new System.Drawing.Point(117, 189);
            this.btnCpf.Name = "btnCpf";
            this.btnCpf.Size = new System.Drawing.Size(86, 35);
            this.btnCpf.TabIndex = 0;
            this.btnCpf.Text = "CPF";
            this.btnCpf.UseVisualStyleBackColor = false;
            this.btnCpf.Click += new System.EventHandler(this.btnCpf_Click);
            // 
            // btnPis
            // 
            this.btnPis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.btnPis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPis.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnPis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnPis.Location = new System.Drawing.Point(214, 189);
            this.btnPis.Name = "btnPis";
            this.btnPis.Size = new System.Drawing.Size(86, 35);
            this.btnPis.TabIndex = 0;
            this.btnPis.Text = "PIS";
            this.btnPis.UseVisualStyleBackColor = false;
            this.btnPis.Click += new System.EventHandler(this.btnPis_Click);
            // 
            // lblTexto4
            // 
            this.lblTexto4.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblTexto4.ForeColor = System.Drawing.Color.LightGray;
            this.lblTexto4.Location = new System.Drawing.Point(20, 320);
            this.lblTexto4.Name = "lblTexto4";
            this.lblTexto4.Size = new System.Drawing.Size(280, 18);
            this.lblTexto4.TabIndex = 2;
            this.lblTexto4.Text = "Resultado";
            this.lblTexto4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.btnFechar);
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(320, 35);
            this.pnlBarraTitulo.TabIndex = 6;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(170, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 35);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.Text = "🗕";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(220, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 35);
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.Text = "🗖";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseEnter += new System.EventHandler(this.btnMaximizar_MouseEnter);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(270, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 35);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "✖";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(20, 343);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(280, 40);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(320, 425);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.lblTexto4);
            this.Controls.Add(this.lblTexto3);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.txtNumeroDigitado);
            this.Controls.Add(this.btnPis);
            this.Controls.Add(this.btnCpf);
            this.Controls.Add(this.btnCnpj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta de Validação";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCnpj;
        private System.Windows.Forms.TextBox txtNumeroDigitado;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblTexto3;
        private System.Windows.Forms.Button btnCpf;
        private System.Windows.Forms.Button btnPis;
        private System.Windows.Forms.Label lblTexto4;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Label lblResultado;
    }
}

