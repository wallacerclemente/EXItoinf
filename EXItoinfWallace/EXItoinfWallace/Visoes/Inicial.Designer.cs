namespace EXItoinfWallace.Visoes
{
    partial class Inicial
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
            this.dgvEtiquetas = new System.Windows.Forms.DataGridView();
            this.btSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btValidar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbChaveIntegracao = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCodigoEtiqueta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEtiquetas
            // 
            this.dgvEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtiquetas.Location = new System.Drawing.Point(12, 230);
            this.dgvEtiquetas.Name = "dgvEtiquetas";
            this.dgvEtiquetas.Size = new System.Drawing.Size(738, 181);
            this.dgvEtiquetas.TabIndex = 56;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(684, 417);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 55;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btValidar);
            this.panel1.Controls.Add(this.btApagar);
            this.panel1.Controls.Add(this.btEditar);
            this.panel1.Controls.Add(this.btInserir);
            this.panel1.Location = new System.Drawing.Point(262, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 77);
            this.panel1.TabIndex = 54;
            // 
            // btValidar
            // 
            this.btValidar.Location = new System.Drawing.Point(76, 42);
            this.btValidar.Name = "btValidar";
            this.btValidar.Size = new System.Drawing.Size(100, 23);
            this.btValidar.TabIndex = 3;
            this.btValidar.Text = "&Validar Correios";
            this.btValidar.UseVisualStyleBackColor = true;
            this.btValidar.Click += new System.EventHandler(this.btValidar_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(168, 13);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 2;
            this.btApagar.Text = "&Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(87, 13);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "&Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(6, 13);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "&Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Chave de integração";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nome do cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = " Código da etiqueta";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(18, 145);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 20);
            this.tbStatus.TabIndex = 45;
            // 
            // tbChaveIntegracao
            // 
            this.tbChaveIntegracao.Location = new System.Drawing.Point(529, 106);
            this.tbChaveIntegracao.Name = "tbChaveIntegracao";
            this.tbChaveIntegracao.Size = new System.Drawing.Size(209, 20);
            this.tbChaveIntegracao.TabIndex = 44;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(423, 106);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(100, 20);
            this.tbCEP.TabIndex = 43;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(249, 106);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(168, 20);
            this.tbCidade.TabIndex = 42;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(15, 106);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(228, 20);
            this.tbBairro.TabIndex = 41;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(15, 67);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(735, 20);
            this.tbEndereco.TabIndex = 40;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(124, 28);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(626, 20);
            this.tbNome.TabIndex = 39;
            // 
            // tbCodigoEtiqueta
            // 
            this.tbCodigoEtiqueta.Location = new System.Drawing.Point(15, 28);
            this.tbCodigoEtiqueta.Name = "tbCodigoEtiqueta";
            this.tbCodigoEtiqueta.Size = new System.Drawing.Size(103, 20);
            this.tbCodigoEtiqueta.TabIndex = 38;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.dgvEtiquetas);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbChaveIntegracao);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigoEtiqueta);
            this.Name = "Inicial";
            this.Text = "Inicial";
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.Enter += new System.EventHandler(this.Inicial_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEtiquetas;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btValidar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbChaveIntegracao;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCodigoEtiqueta;
    }
}