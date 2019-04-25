namespace ProjetoAtendimento.Views
{
    partial class Atendimento
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
            this.lbx_Senhas = new System.Windows.Forms.ListBox();
            this.lbx_SenhasGuiche = new System.Windows.Forms.ListBox();
            this.botao_Gerar = new System.Windows.Forms.Button();
            this.botao_Chamar = new System.Windows.Forms.Button();
            this.botao_Adicionar = new System.Windows.Forms.Button();
            this.botao_ListarSenhas = new System.Windows.Forms.Button();
            this.btnListarAtend = new System.Windows.Forms.Button();
            this.lblNumGuiche = new System.Windows.Forms.Label();
            this.lblQtdeGuiche = new System.Windows.Forms.Label();
            this.label_Guiche = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.lbx_Senhas.FormattingEnabled = true;
            this.lbx_Senhas.Location = new System.Drawing.Point(12, 47);
            this.lbx_Senhas.Name = "lbx_Senhas";
            this.lbx_Senhas.Size = new System.Drawing.Size(217, 264);
            this.lbx_Senhas.TabIndex = 0;
            // 
            // lbx_SenhasGuiche
            // 
            this.lbx_SenhasGuiche.FormattingEnabled = true;
            this.lbx_SenhasGuiche.Location = new System.Drawing.Point(439, 47);
            this.lbx_SenhasGuiche.Name = "lbx_SenhasGuiche";
            this.lbx_SenhasGuiche.Size = new System.Drawing.Size(354, 264);
            this.lbx_SenhasGuiche.TabIndex = 1;
            // 
            // botao_Gerar
            // 
            this.botao_Gerar.BackColor = System.Drawing.SystemColors.Control;
            this.botao_Gerar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.botao_Gerar.Location = new System.Drawing.Point(12, 12);
            this.botao_Gerar.Name = "botao_Gerar";
            this.botao_Gerar.Size = new System.Drawing.Size(217, 23);
            this.botao_Gerar.TabIndex = 2;
            this.botao_Gerar.Text = "GERAR";
            this.botao_Gerar.UseVisualStyleBackColor = false;
            this.botao_Gerar.Click += new System.EventHandler(this.botao_gerar_Click);
            // 
            // botao_Chamar
            // 
            this.botao_Chamar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botao_Chamar.Location = new System.Drawing.Point(647, 20);
            this.botao_Chamar.Name = "botao_Chamar";
            this.botao_Chamar.Size = new System.Drawing.Size(106, 23);
            this.botao_Chamar.TabIndex = 3;
            this.botao_Chamar.Text = "CHAMAR";
            this.botao_Chamar.UseVisualStyleBackColor = true;
            this.botao_Chamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // botao_Adicionar
            // 
            this.botao_Adicionar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botao_Adicionar.Location = new System.Drawing.Point(292, 189);
            this.botao_Adicionar.Name = "botao_Adicionar";
            this.botao_Adicionar.Size = new System.Drawing.Size(83, 33);
            this.botao_Adicionar.TabIndex = 4;
            this.botao_Adicionar.Text = "ADICIONAR";
            this.botao_Adicionar.UseVisualStyleBackColor = true;
            this.botao_Adicionar.Click += new System.EventHandler(this.botao_Adicionar_Click);
            // 
            // botao_ListarSenhas
            // 
            this.botao_ListarSenhas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.botao_ListarSenhas.Location = new System.Drawing.Point(39, 317);
            this.botao_ListarSenhas.Name = "botao_ListarSenhas";
            this.botao_ListarSenhas.Size = new System.Drawing.Size(152, 23);
            this.botao_ListarSenhas.TabIndex = 5;
            this.botao_ListarSenhas.Text = "LISTAR SENHAS";
            this.botao_ListarSenhas.UseVisualStyleBackColor = true;
            this.botao_ListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnListarAtend
            // 
            this.btnListarAtend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnListarAtend.Location = new System.Drawing.Point(513, 317);
            this.btnListarAtend.Name = "btnListarAtend";
            this.btnListarAtend.Size = new System.Drawing.Size(206, 23);
            this.btnListarAtend.TabIndex = 6;
            this.btnListarAtend.Text = "LISTAR ATENDIMENTOS";
            this.btnListarAtend.UseVisualStyleBackColor = true;
            this.btnListarAtend.Click += new System.EventHandler(this.btnListarAtend_Click);
            // 
            // lblNumGuiche
            // 
            this.lblNumGuiche.AutoSize = true;
            this.lblNumGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGuiche.Location = new System.Drawing.Point(318, 155);
            this.lblNumGuiche.Name = "lblNumGuiche";
            this.lblNumGuiche.Size = new System.Drawing.Size(30, 31);
            this.lblNumGuiche.TabIndex = 7;
            this.lblNumGuiche.Text = "0";
            // 
            // lblQtdeGuiche
            // 
            this.lblQtdeGuiche.AutoSize = true;
            this.lblQtdeGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiche.Location = new System.Drawing.Point(239, 139);
            this.lblQtdeGuiche.Name = "lblQtdeGuiche";
            this.lblQtdeGuiche.Size = new System.Drawing.Size(194, 16);
            this.lblQtdeGuiche.TabIndex = 8;
            this.lblQtdeGuiche.Text = "QUANTIDADES DE GUICHÊS:";
            this.lblQtdeGuiche.Click += new System.EventHandler(this.lblQtdeGuiche_Click);
            // 
            // label_Guiche
            // 
            this.label_Guiche.AutoSize = true;
            this.label_Guiche.Location = new System.Drawing.Point(474, 22);
            this.label_Guiche.Name = "label_Guiche";
            this.label_Guiche.Size = new System.Drawing.Size(51, 13);
            this.label_Guiche.TabIndex = 9;
            this.label_Guiche.Text = "GUICHÊ:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(531, 22);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(110, 20);
            this.txtGuiche.TabIndex = 10;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 379);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label_Guiche);
            this.Controls.Add(this.lblQtdeGuiche);
            this.Controls.Add(this.lblNumGuiche);
            this.Controls.Add(this.btnListarAtend);
            this.Controls.Add(this.botao_ListarSenhas);
            this.Controls.Add(this.botao_Adicionar);
            this.Controls.Add(this.botao_Chamar);
            this.Controls.Add(this.botao_Gerar);
            this.Controls.Add(this.lbx_SenhasGuiche);
            this.Controls.Add(this.lbx_Senhas);
            this.Name = "Atendimento";
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Senhas;
        private System.Windows.Forms.ListBox lbx_SenhasGuiche;
        private System.Windows.Forms.Button botao_Gerar;
        private System.Windows.Forms.Button botao_Chamar;
        private System.Windows.Forms.Button botao_Adicionar;
        private System.Windows.Forms.Button botao_ListarSenhas;
        private System.Windows.Forms.Button btnListarAtend;
        private System.Windows.Forms.Label lblNumGuiche;
        private System.Windows.Forms.Label lblQtdeGuiche;
        private System.Windows.Forms.Label label_Guiche;
        private System.Windows.Forms.TextBox txtGuiche;
    }
}