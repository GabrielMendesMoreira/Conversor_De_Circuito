namespace WindowsFormsApp1
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
            this.R2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.r111 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.R4 = new System.Windows.Forms.TextBox();
            this.R5 = new System.Windows.Forms.TextBox();
            this.R6 = new System.Windows.Forms.TextBox();
            this.SAIR = new System.Windows.Forms.Button();
            this.LIMPAR = new System.Windows.Forms.Button();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.R1 = new System.Windows.Forms.TextBox();
            this.R3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(95, 135);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(100, 20);
            this.R2.TabIndex = 2;
            this.R2.TextChanged += new System.EventHandler(this.R2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Museo 700", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "CIRCUITO DELTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.R3);
            this.panel1.Controls.Add(this.R1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.r111);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.R2);
            this.panel1.Location = new System.Drawing.Point(119, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 243);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // r111
            // 
            this.r111.AutoSize = true;
            this.r111.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r111.ForeColor = System.Drawing.Color.Navy;
            this.r111.Location = new System.Drawing.Point(26, 79);
            this.r111.Name = "r111";
            this.r111.Size = new System.Drawing.Size(44, 24);
            this.r111.TabIndex = 4;
            this.r111.Text = "R1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "R2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "R3:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.R6);
            this.panel2.Controls.Add(this.R5);
            this.panel2.Controls.Add(this.R4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(409, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 243);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Museo 700", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(32, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "CIRCUITO Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(29, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "R4:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(29, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "R5:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(29, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "R6:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // R4
            // 
            this.R4.Cursor = System.Windows.Forms.Cursors.No;
            this.R4.Enabled = false;
            this.R4.Location = new System.Drawing.Point(90, 85);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(100, 20);
            this.R4.TabIndex = 4;
            this.R4.TextChanged += new System.EventHandler(this.R4_TextChanged);
            // 
            // R5
            // 
            this.R5.Cursor = System.Windows.Forms.Cursors.No;
            this.R5.Enabled = false;
            this.R5.Location = new System.Drawing.Point(90, 135);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(100, 20);
            this.R5.TabIndex = 5;
            this.R5.TextChanged += new System.EventHandler(this.R5_TextChanged);
            // 
            // R6
            // 
            this.R6.Cursor = System.Windows.Forms.Cursors.No;
            this.R6.Enabled = false;
            this.R6.Location = new System.Drawing.Point(90, 185);
            this.R6.Name = "R6";
            this.R6.Size = new System.Drawing.Size(100, 20);
            this.R6.TabIndex = 6;
            this.R6.TextChanged += new System.EventHandler(this.R6_TextChanged);
            // 
            // SAIR
            // 
            this.SAIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAIR.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAIR.Location = new System.Drawing.Point(687, 393);
            this.SAIR.Name = "SAIR";
            this.SAIR.Size = new System.Drawing.Size(101, 45);
            this.SAIR.TabIndex = 9;
            this.SAIR.Text = "SAIR";
            this.SAIR.UseVisualStyleBackColor = true;
            this.SAIR.Click += new System.EventHandler(this.SAIR_Click);
            // 
            // LIMPAR
            // 
            this.LIMPAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LIMPAR.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPAR.Location = new System.Drawing.Point(459, 339);
            this.LIMPAR.Name = "LIMPAR";
            this.LIMPAR.Size = new System.Drawing.Size(140, 60);
            this.LIMPAR.TabIndex = 8;
            this.LIMPAR.Text = "LIMPAR";
            this.LIMPAR.UseVisualStyleBackColor = true;
            this.LIMPAR.Click += new System.EventHandler(this.LIMPAR_Click);
            // 
            // CALCULAR
            // 
            this.CALCULAR.BackColor = System.Drawing.Color.White;
            this.CALCULAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CALCULAR.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(174, 339);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(140, 60);
            this.CALCULAR.TabIndex = 7;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = false;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(95, 85);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(100, 20);
            this.R1.TabIndex = 1;
            this.R1.TextChanged += new System.EventHandler(this.R1_TextChanged);
            // 
            // R3
            // 
            this.R3.Location = new System.Drawing.Point(95, 185);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(100, 20);
            this.R3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.LIMPAR);
            this.Controls.Add(this.SAIR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CONVERSOR DE CIRCUITO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label r111;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox R6;
        private System.Windows.Forms.TextBox R5;
        private System.Windows.Forms.TextBox R4;
        private System.Windows.Forms.Button SAIR;
        private System.Windows.Forms.Button LIMPAR;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.TextBox R3;
    }
}

