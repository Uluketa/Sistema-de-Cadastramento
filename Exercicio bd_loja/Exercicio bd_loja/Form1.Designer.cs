namespace Exercicio_bd_loja
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
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlistarforcedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarforcedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(152, 298);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(677, 20);
            this.txtbairro.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 29);
            this.label13.TabIndex = 58;
            this.label13.Text = "Bairro:";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(601, 408);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(178, 39);
            this.btn_excluir.TabIndex = 57;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(342, 406);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(188, 41);
            this.btnatualizar.TabIndex = 56;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnatualizar_MouseClick);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(96, 406);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(174, 43);
            this.btncadastrar.TabIndex = 55;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(729, 337);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 20);
            this.txtestado.TabIndex = 54;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(152, 337);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(457, 20);
            this.txtcidade.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(617, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 29);
            this.label12.TabIndex = 52;
            this.label12.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "Cidade:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(474, 248);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(355, 20);
            this.txtcomplemento.TabIndex = 50;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(128, 247);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(190, 20);
            this.txtcep.TabIndex = 49;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(657, 203);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(172, 20);
            this.txtnum.TabIndex = 48;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(182, 203);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(395, 20);
            this.txtendereco.TabIndex = 47;
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(577, 160);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(251, 20);
            this.txtcelular.TabIndex = 46;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(174, 159);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(285, 20);
            this.txttelefone.TabIndex = 45;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Location = new System.Drawing.Point(144, 115);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(685, 20);
            this.txtcnpj.TabIndex = 44;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(678, 23);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(151, 20);
            this.txtcodigo.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(334, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "Complem.:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(139, 67);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(690, 20);
            this.txtemail.TabIndex = 41;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(157, 23);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(413, 20);
            this.txtnome.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(582, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 39;
            this.label9.Text = "Num:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome:";
            // 
            // dgvlistarforcedores
            // 
            this.dgvlistarforcedores.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvlistarforcedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarforcedores.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvlistarforcedores.Location = new System.Drawing.Point(35, 468);
            this.dgvlistarforcedores.Name = "dgvlistarforcedores";
            this.dgvlistarforcedores.Size = new System.Drawing.Size(816, 174);
            this.dgvlistarforcedores.TabIndex = 60;
            this.dgvlistarforcedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvlistarfornecedores);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 666);
            this.Controls.Add(this.dgvlistarforcedores);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtcnpj);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarforcedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvlistarforcedores;
    }
}

