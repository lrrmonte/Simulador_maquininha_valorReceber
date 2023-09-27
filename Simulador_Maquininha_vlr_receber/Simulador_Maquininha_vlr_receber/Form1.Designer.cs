namespace Simulador_Maquininha_vlr_receber
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_vlr_venda = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_pmt_cliente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_vlr_taxa = new System.Windows.Forms.Label();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_vlr_receber = new System.Windows.Forms.TextBox();
            this.tb_prazo = new System.Windows.Forms.TextBox();
            this.tb_taxa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador maquininha de cartão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "valor a receber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o valor que deseja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o prazo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digite a taxa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor que deve ser a venda para";
            // 
            // lb_vlr_venda
            // 
            this.lb_vlr_venda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_vlr_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlr_venda.Location = new System.Drawing.Point(395, 167);
            this.lb_vlr_venda.Name = "lb_vlr_venda";
            this.lb_vlr_venda.Size = new System.Drawing.Size(137, 24);
            this.lb_vlr_venda.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(410, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Parcela cliente";
            // 
            // lb_pmt_cliente
            // 
            this.lb_pmt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_pmt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pmt_cliente.Location = new System.Drawing.Point(395, 271);
            this.lb_pmt_cliente.Name = "lb_pmt_cliente";
            this.lb_pmt_cliente.Size = new System.Drawing.Size(143, 23);
            this.lb_pmt_cliente.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(440, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Taxa R$";
            // 
            // lb_vlr_taxa
            // 
            this.lb_vlr_taxa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_vlr_taxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlr_taxa.Location = new System.Drawing.Point(395, 370);
            this.lb_vlr_taxa.Name = "lb_vlr_taxa";
            this.lb_vlr_taxa.Size = new System.Drawing.Size(143, 24);
            this.lb_vlr_taxa.TabIndex = 10;
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calcular.Location = new System.Drawing.Point(645, 155);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(93, 44);
            this.bt_Calcular.TabIndex = 11;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(645, 251);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(93, 43);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(645, 350);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(93, 44);
            this.bt_Sair.TabIndex = 13;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // label12
            // 
            this.label12.Image = global::Simulador_Maquininha_vlr_receber.Properties.Resources.maquininhaCartao;
            this.label12.Location = new System.Drawing.Point(660, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 91);
            this.label12.TabIndex = 14;
            // 
            // tb_vlr_receber
            // 
            this.tb_vlr_receber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vlr_receber.Location = new System.Drawing.Point(111, 167);
            this.tb_vlr_receber.Name = "tb_vlr_receber";
            this.tb_vlr_receber.Size = new System.Drawing.Size(139, 24);
            this.tb_vlr_receber.TabIndex = 15;
            // 
            // tb_prazo
            // 
            this.tb_prazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prazo.Location = new System.Drawing.Point(111, 270);
            this.tb_prazo.Name = "tb_prazo";
            this.tb_prazo.Size = new System.Drawing.Size(139, 24);
            this.tb_prazo.TabIndex = 16;
            // 
            // tb_taxa
            // 
            this.tb_taxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_taxa.Location = new System.Drawing.Point(111, 370);
            this.tb_taxa.Name = "tb_taxa";
            this.tb_taxa.Size = new System.Drawing.Size(139, 24);
            this.tb_taxa.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(120, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "receber da venda";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(361, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 18);
            this.label14.TabIndex = 19;
            this.label14.Text = "obtenção do valor informado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_taxa);
            this.Controls.Add(this.tb_prazo);
            this.Controls.Add(this.tb_vlr_receber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.lb_vlr_taxa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_pmt_cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_vlr_venda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador maquininha valor a receber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_vlr_venda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_pmt_cliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_vlr_taxa;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_vlr_receber;
        private System.Windows.Forms.TextBox tb_prazo;
        private System.Windows.Forms.TextBox tb_taxa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

