namespace Retangulo
{
    partial class title
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
            this.subtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtLarg = new System.Windows.Forms.TextBox();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.bttnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(101, 9);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(537, 29);
            this.subtitle.TabIndex = 0;
            this.subtitle.Text = "Cálculo da área e perímetro de um triângulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comprimento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Largura: ";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(206, 88);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(100, 20);
            this.txtComp.TabIndex = 3;
            this.txtComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLarg
            // 
            this.txtLarg.Location = new System.Drawing.Point(464, 88);
            this.txtLarg.Name = "txtLarg";
            this.txtLarg.Size = new System.Drawing.Size(100, 20);
            this.txtLarg.TabIndex = 4;
            this.txtLarg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(125, 197);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 23);
            this.bttnCalcular.TabIndex = 5;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.Location = new System.Drawing.Point(327, 197);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttnLimpar.TabIndex = 6;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            this.bttnLimpar.Click += new System.EventHandler(this.bttnLimpar_Click);
            // 
            // bttnSair
            // 
            this.bttnSair.Location = new System.Drawing.Point(521, 197);
            this.bttnSair.Name = "bttnSair";
            this.bttnSair.Size = new System.Drawing.Size(75, 23);
            this.bttnSair.TabIndex = 7;
            this.bttnSair.Text = "Sair";
            this.bttnSair.UseVisualStyleBackColor = true;
            this.bttnSair.Click += new System.EventHandler(this.bttnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Área: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perímetro:";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(312, 277);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 11;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(338, 331);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(74, 20);
            this.txtPerimetro.TabIndex = 12;
            this.txtPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnSair);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.txtLarg);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtitle);
            this.Name = "title";
            this.Text = "Cálculo de área de um retângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtLarg;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.Button bttnSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
    }
}

