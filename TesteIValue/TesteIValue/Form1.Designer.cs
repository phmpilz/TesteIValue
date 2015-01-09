namespace TesteIValue
{
    partial class formVerbosPreposicoes
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
            this.btnBaixarTextoATextoB = new System.Windows.Forms.Button();
            this.btnContarPreposicoesTextoA = new System.Windows.Forms.Button();
            this.grbAcoes = new System.Windows.Forms.GroupBox();
            this.btnContarVerbosTextoB = new System.Windows.Forms.Button();
            this.btnContarVerbosTextoA = new System.Windows.Forms.Button();
            this.btnContarPreposicoesTextoB = new System.Windows.Forms.Button();
            this.grbTextoATextoB = new System.Windows.Forms.GroupBox();
            this.lblLetrasFoo = new System.Windows.Forms.Label();
            this.lblLabelLetrasFoo = new System.Windows.Forms.Label();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.lblTextoA = new System.Windows.Forms.Label();
            this.grbPreposicoes = new System.Windows.Forms.GroupBox();
            this.lblPreposicoesTextoB = new System.Windows.Forms.Label();
            this.lblLabelPreposicoesTextoB = new System.Windows.Forms.Label();
            this.lblPreposicoesTextoA = new System.Windows.Forms.Label();
            this.lblLabelPreposicoesTextoA = new System.Windows.Forms.Label();
            this.grbVerbos = new System.Windows.Forms.GroupBox();
            this.lblEmPrimeiraPessoaTextoB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmPrimeiraPessoaTextoA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVerbosTextoB = new System.Windows.Forms.Label();
            this.lblLabelVerbosTextoB = new System.Windows.Forms.Label();
            this.lblVerbosTextoA = new System.Windows.Forms.Label();
            this.lblLabelVerbosTextoA = new System.Windows.Forms.Label();
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.grbAcoes.SuspendLayout();
            this.grbTextoATextoB.SuspendLayout();
            this.grbPreposicoes.SuspendLayout();
            this.grbVerbos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaixarTextoATextoB
            // 
            this.btnBaixarTextoATextoB.Location = new System.Drawing.Point(6, 19);
            this.btnBaixarTextoATextoB.Name = "btnBaixarTextoATextoB";
            this.btnBaixarTextoATextoB.Size = new System.Drawing.Size(141, 43);
            this.btnBaixarTextoATextoB.TabIndex = 0;
            this.btnBaixarTextoATextoB.Text = "&Baixar Texto A e Texto B";
            this.btnBaixarTextoATextoB.UseVisualStyleBackColor = true;
            this.btnBaixarTextoATextoB.Click += new System.EventHandler(this.btnBaixarTextoATextoB_Click);
            // 
            // btnContarPreposicoesTextoA
            // 
            this.btnContarPreposicoesTextoA.Enabled = false;
            this.btnContarPreposicoesTextoA.Location = new System.Drawing.Point(153, 19);
            this.btnContarPreposicoesTextoA.Name = "btnContarPreposicoesTextoA";
            this.btnContarPreposicoesTextoA.Size = new System.Drawing.Size(133, 43);
            this.btnContarPreposicoesTextoA.TabIndex = 1;
            this.btnContarPreposicoesTextoA.Text = "&Contar Preposições Texto A";
            this.btnContarPreposicoesTextoA.UseVisualStyleBackColor = true;
            this.btnContarPreposicoesTextoA.Click += new System.EventHandler(this.btnContarPreposicoesTextoA_Click);
            // 
            // grbAcoes
            // 
            this.grbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAcoes.Controls.Add(this.btnContarVerbosTextoB);
            this.grbAcoes.Controls.Add(this.btnContarVerbosTextoA);
            this.grbAcoes.Controls.Add(this.btnContarPreposicoesTextoB);
            this.grbAcoes.Controls.Add(this.btnContarPreposicoesTextoA);
            this.grbAcoes.Controls.Add(this.btnBaixarTextoATextoB);
            this.grbAcoes.Location = new System.Drawing.Point(13, 13);
            this.grbAcoes.Name = "grbAcoes";
            this.grbAcoes.Size = new System.Drawing.Size(683, 68);
            this.grbAcoes.TabIndex = 2;
            this.grbAcoes.TabStop = false;
            this.grbAcoes.Text = "Ações";
            // 
            // btnContarVerbosTextoB
            // 
            this.btnContarVerbosTextoB.Enabled = false;
            this.btnContarVerbosTextoB.Location = new System.Drawing.Point(556, 19);
            this.btnContarVerbosTextoB.Name = "btnContarVerbosTextoB";
            this.btnContarVerbosTextoB.Size = new System.Drawing.Size(121, 43);
            this.btnContarVerbosTextoB.TabIndex = 4;
            this.btnContarVerbosTextoB.Text = "Contar V&erbos Texto B";
            this.btnContarVerbosTextoB.UseVisualStyleBackColor = true;
            this.btnContarVerbosTextoB.Click += new System.EventHandler(this.btnContarVerbosTextoB_Click);
            // 
            // btnContarVerbosTextoA
            // 
            this.btnContarVerbosTextoA.Enabled = false;
            this.btnContarVerbosTextoA.Location = new System.Drawing.Point(431, 19);
            this.btnContarVerbosTextoA.Name = "btnContarVerbosTextoA";
            this.btnContarVerbosTextoA.Size = new System.Drawing.Size(119, 43);
            this.btnContarVerbosTextoA.TabIndex = 3;
            this.btnContarVerbosTextoA.Text = "Contar &Verbos Texto A";
            this.btnContarVerbosTextoA.UseVisualStyleBackColor = true;
            this.btnContarVerbosTextoA.Click += new System.EventHandler(this.btnContarVerbosTextoA_Click);
            // 
            // btnContarPreposicoesTextoB
            // 
            this.btnContarPreposicoesTextoB.Enabled = false;
            this.btnContarPreposicoesTextoB.Location = new System.Drawing.Point(292, 19);
            this.btnContarPreposicoesTextoB.Name = "btnContarPreposicoesTextoB";
            this.btnContarPreposicoesTextoB.Size = new System.Drawing.Size(133, 43);
            this.btnContarPreposicoesTextoB.TabIndex = 2;
            this.btnContarPreposicoesTextoB.Text = "C&ontar Preposições Texto B";
            this.btnContarPreposicoesTextoB.UseVisualStyleBackColor = true;
            this.btnContarPreposicoesTextoB.Click += new System.EventHandler(this.btnContarPreposicoesTextoB_Click);
            // 
            // grbTextoATextoB
            // 
            this.grbTextoATextoB.Controls.Add(this.lblLetrasFoo);
            this.grbTextoATextoB.Controls.Add(this.lblLabelLetrasFoo);
            this.grbTextoATextoB.Controls.Add(this.txtTextoB);
            this.grbTextoATextoB.Controls.Add(this.txtTextoA);
            this.grbTextoATextoB.Controls.Add(this.lblTextoB);
            this.grbTextoATextoB.Controls.Add(this.lblTextoA);
            this.grbTextoATextoB.Location = new System.Drawing.Point(13, 88);
            this.grbTextoATextoB.Name = "grbTextoATextoB";
            this.grbTextoATextoB.Size = new System.Drawing.Size(683, 207);
            this.grbTextoATextoB.TabIndex = 3;
            this.grbTextoATextoB.TabStop = false;
            this.grbTextoATextoB.Text = "Texto A e Texto B";
            // 
            // lblLetrasFoo
            // 
            this.lblLetrasFoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasFoo.Location = new System.Drawing.Point(605, 29);
            this.lblLetrasFoo.Name = "lblLetrasFoo";
            this.lblLetrasFoo.Size = new System.Drawing.Size(72, 72);
            this.lblLetrasFoo.TabIndex = 5;
            // 
            // lblLabelLetrasFoo
            // 
            this.lblLabelLetrasFoo.AutoSize = true;
            this.lblLabelLetrasFoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelLetrasFoo.Location = new System.Drawing.Point(602, 16);
            this.lblLabelLetrasFoo.Name = "lblLabelLetrasFoo";
            this.lblLabelLetrasFoo.Size = new System.Drawing.Size(75, 13);
            this.lblLabelLetrasFoo.TabIndex = 4;
            this.lblLabelLetrasFoo.Text = "Letras Foo: ";
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoB.Location = new System.Drawing.Point(6, 115);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(59, 13);
            this.lblTextoB.TabIndex = 1;
            this.lblTextoB.Text = "Texto B: ";
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoA.Location = new System.Drawing.Point(6, 16);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(59, 13);
            this.lblTextoA.TabIndex = 0;
            this.lblTextoA.Text = "Texto A: ";
            // 
            // grbPreposicoes
            // 
            this.grbPreposicoes.Controls.Add(this.lblPreposicoesTextoB);
            this.grbPreposicoes.Controls.Add(this.lblLabelPreposicoesTextoB);
            this.grbPreposicoes.Controls.Add(this.lblPreposicoesTextoA);
            this.grbPreposicoes.Controls.Add(this.lblLabelPreposicoesTextoA);
            this.grbPreposicoes.Location = new System.Drawing.Point(12, 301);
            this.grbPreposicoes.Name = "grbPreposicoes";
            this.grbPreposicoes.Size = new System.Drawing.Size(684, 82);
            this.grbPreposicoes.TabIndex = 4;
            this.grbPreposicoes.TabStop = false;
            this.grbPreposicoes.Text = "Preposições";
            // 
            // lblPreposicoesTextoB
            // 
            this.lblPreposicoesTextoB.AutoSize = true;
            this.lblPreposicoesTextoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreposicoesTextoB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPreposicoesTextoB.Location = new System.Drawing.Point(555, 16);
            this.lblPreposicoesTextoB.Name = "lblPreposicoesTextoB";
            this.lblPreposicoesTextoB.Size = new System.Drawing.Size(89, 63);
            this.lblPreposicoesTextoB.TabIndex = 4;
            this.lblPreposicoesTextoB.Text = "00";
            // 
            // lblLabelPreposicoesTextoB
            // 
            this.lblLabelPreposicoesTextoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelPreposicoesTextoB.Location = new System.Drawing.Point(366, 16);
            this.lblLabelPreposicoesTextoB.Name = "lblLabelPreposicoesTextoB";
            this.lblLabelPreposicoesTextoB.Size = new System.Drawing.Size(183, 63);
            this.lblLabelPreposicoesTextoB.TabIndex = 3;
            this.lblLabelPreposicoesTextoB.Text = "Preposições Texto B: ";
            this.lblLabelPreposicoesTextoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreposicoesTextoA
            // 
            this.lblPreposicoesTextoA.AutoSize = true;
            this.lblPreposicoesTextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreposicoesTextoA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPreposicoesTextoA.Location = new System.Drawing.Point(238, 16);
            this.lblPreposicoesTextoA.Name = "lblPreposicoesTextoA";
            this.lblPreposicoesTextoA.Size = new System.Drawing.Size(89, 63);
            this.lblPreposicoesTextoA.TabIndex = 2;
            this.lblPreposicoesTextoA.Text = "00";
            // 
            // lblLabelPreposicoesTextoA
            // 
            this.lblLabelPreposicoesTextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelPreposicoesTextoA.Location = new System.Drawing.Point(49, 16);
            this.lblLabelPreposicoesTextoA.Name = "lblLabelPreposicoesTextoA";
            this.lblLabelPreposicoesTextoA.Size = new System.Drawing.Size(183, 63);
            this.lblLabelPreposicoesTextoA.TabIndex = 1;
            this.lblLabelPreposicoesTextoA.Text = "Preposições Texto A: ";
            this.lblLabelPreposicoesTextoA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbVerbos
            // 
            this.grbVerbos.Controls.Add(this.lblEmPrimeiraPessoaTextoB);
            this.grbVerbos.Controls.Add(this.label2);
            this.grbVerbos.Controls.Add(this.lblEmPrimeiraPessoaTextoA);
            this.grbVerbos.Controls.Add(this.label4);
            this.grbVerbos.Controls.Add(this.lblVerbosTextoB);
            this.grbVerbos.Controls.Add(this.lblLabelVerbosTextoB);
            this.grbVerbos.Controls.Add(this.lblVerbosTextoA);
            this.grbVerbos.Controls.Add(this.lblLabelVerbosTextoA);
            this.grbVerbos.Location = new System.Drawing.Point(12, 389);
            this.grbVerbos.Name = "grbVerbos";
            this.grbVerbos.Size = new System.Drawing.Size(684, 138);
            this.grbVerbos.TabIndex = 5;
            this.grbVerbos.TabStop = false;
            this.grbVerbos.Text = "Verbos";
            // 
            // lblEmPrimeiraPessoaTextoB
            // 
            this.lblEmPrimeiraPessoaTextoB.AutoSize = true;
            this.lblEmPrimeiraPessoaTextoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmPrimeiraPessoaTextoB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEmPrimeiraPessoaTextoB.Location = new System.Drawing.Point(563, 78);
            this.lblEmPrimeiraPessoaTextoB.Name = "lblEmPrimeiraPessoaTextoB";
            this.lblEmPrimeiraPessoaTextoB.Size = new System.Drawing.Size(77, 54);
            this.lblEmPrimeiraPessoaTextoB.TabIndex = 8;
            this.lblEmPrimeiraPessoaTextoB.Text = "00";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "... Em primeira pessoa Texto B: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmPrimeiraPessoaTextoA
            // 
            this.lblEmPrimeiraPessoaTextoA.AutoSize = true;
            this.lblEmPrimeiraPessoaTextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmPrimeiraPessoaTextoA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEmPrimeiraPessoaTextoA.Location = new System.Drawing.Point(243, 78);
            this.lblEmPrimeiraPessoaTextoA.Name = "lblEmPrimeiraPessoaTextoA";
            this.lblEmPrimeiraPessoaTextoA.Size = new System.Drawing.Size(77, 54);
            this.lblEmPrimeiraPessoaTextoA.TabIndex = 6;
            this.lblEmPrimeiraPessoaTextoA.Text = "00";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 54);
            this.label4.TabIndex = 5;
            this.label4.Text = "... Em Primeira Pessoa Texto A: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerbosTextoB
            // 
            this.lblVerbosTextoB.AutoSize = true;
            this.lblVerbosTextoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbosTextoB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblVerbosTextoB.Location = new System.Drawing.Point(555, 16);
            this.lblVerbosTextoB.Name = "lblVerbosTextoB";
            this.lblVerbosTextoB.Size = new System.Drawing.Size(89, 63);
            this.lblVerbosTextoB.TabIndex = 4;
            this.lblVerbosTextoB.Text = "00";
            // 
            // lblLabelVerbosTextoB
            // 
            this.lblLabelVerbosTextoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelVerbosTextoB.Location = new System.Drawing.Point(366, 16);
            this.lblLabelVerbosTextoB.Name = "lblLabelVerbosTextoB";
            this.lblLabelVerbosTextoB.Size = new System.Drawing.Size(183, 63);
            this.lblLabelVerbosTextoB.TabIndex = 3;
            this.lblLabelVerbosTextoB.Text = "Verbos Texto B: ";
            this.lblLabelVerbosTextoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerbosTextoA
            // 
            this.lblVerbosTextoA.AutoSize = true;
            this.lblVerbosTextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbosTextoA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblVerbosTextoA.Location = new System.Drawing.Point(238, 16);
            this.lblVerbosTextoA.Name = "lblVerbosTextoA";
            this.lblVerbosTextoA.Size = new System.Drawing.Size(89, 63);
            this.lblVerbosTextoA.TabIndex = 2;
            this.lblVerbosTextoA.Text = "00";
            // 
            // lblLabelVerbosTextoA
            // 
            this.lblLabelVerbosTextoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelVerbosTextoA.Location = new System.Drawing.Point(49, 16);
            this.lblLabelVerbosTextoA.Name = "lblLabelVerbosTextoA";
            this.lblLabelVerbosTextoA.Size = new System.Drawing.Size(183, 63);
            this.lblLabelVerbosTextoA.TabIndex = 1;
            this.lblLabelVerbosTextoA.Text = "Verbos Texto A: ";
            this.lblLabelVerbosTextoA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(71, 112);
            this.txtTextoB.Multiline = true;
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.ReadOnly = true;
            this.txtTextoB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoB.Size = new System.Drawing.Size(525, 90);
            this.txtTextoB.TabIndex = 3;
            // 
            // txtTextoA
            // 
            this.txtTextoA.Location = new System.Drawing.Point(71, 16);
            this.txtTextoA.Multiline = true;
            this.txtTextoA.Name = "txtTextoA";
            this.txtTextoA.ReadOnly = true;
            this.txtTextoA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoA.Size = new System.Drawing.Size(525, 90);
            this.txtTextoA.TabIndex = 2;
            // 
            // formVerbosPreposicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 538);
            this.Controls.Add(this.grbVerbos);
            this.Controls.Add(this.grbPreposicoes);
            this.Controls.Add(this.grbTextoATextoB);
            this.Controls.Add(this.grbAcoes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(724, 576);
            this.Name = "formVerbosPreposicoes";
            this.Text = "Form que Calcula Verbos e Preposições de IValuesh";
            this.Load += new System.EventHandler(this.formVerbosPreposicoes_Load);
            this.grbAcoes.ResumeLayout(false);
            this.grbTextoATextoB.ResumeLayout(false);
            this.grbTextoATextoB.PerformLayout();
            this.grbPreposicoes.ResumeLayout(false);
            this.grbPreposicoes.PerformLayout();
            this.grbVerbos.ResumeLayout(false);
            this.grbVerbos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaixarTextoATextoB;
        private System.Windows.Forms.Button btnContarPreposicoesTextoA;
        private System.Windows.Forms.GroupBox grbAcoes;
        private System.Windows.Forms.Button btnContarVerbosTextoB;
        private System.Windows.Forms.Button btnContarVerbosTextoA;
        private System.Windows.Forms.Button btnContarPreposicoesTextoB;
        private System.Windows.Forms.GroupBox grbTextoATextoB;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.GroupBox grbPreposicoes;
        private System.Windows.Forms.Label lblPreposicoesTextoA;
        private System.Windows.Forms.Label lblLabelPreposicoesTextoA;
        private System.Windows.Forms.Label lblPreposicoesTextoB;
        private System.Windows.Forms.Label lblLabelPreposicoesTextoB;
        private System.Windows.Forms.GroupBox grbVerbos;
        private System.Windows.Forms.Label lblEmPrimeiraPessoaTextoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmPrimeiraPessoaTextoA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVerbosTextoB;
        private System.Windows.Forms.Label lblLabelVerbosTextoB;
        private System.Windows.Forms.Label lblVerbosTextoA;
        private System.Windows.Forms.Label lblLabelVerbosTextoA;
        private System.Windows.Forms.Label lblLetrasFoo;
        private System.Windows.Forms.Label lblLabelLetrasFoo;
        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.TextBox txtTextoA;
    }
}

