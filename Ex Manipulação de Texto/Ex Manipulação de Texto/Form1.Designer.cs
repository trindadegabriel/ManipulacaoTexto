namespace Ex_Manipulação_de_Texto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmaiuscula = new System.Windows.Forms.Button();
            this.btncontarpalavras = new System.Windows.Forms.Button();
            this.btncontarletras = new System.Windows.Forms.Button();
            this.btninverterpalavras = new System.Windows.Forms.Button();
            this.btnquebralinha = new System.Windows.Forms.Button();
            this.btninverterletras = new System.Windows.Forms.Button();
            this.btnminuscula = new System.Windows.Forms.Button();
            this.btnembaralharpalavras = new System.Windows.Forms.Button();
            this.btnembaralharletras = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(186, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 46);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira seu Texto:";
            // 
            // btnmaiuscula
            // 
            this.btnmaiuscula.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmaiuscula.Location = new System.Drawing.Point(459, 177);
            this.btnmaiuscula.Name = "btnmaiuscula";
            this.btnmaiuscula.Size = new System.Drawing.Size(112, 74);
            this.btnmaiuscula.TabIndex = 2;
            this.btnmaiuscula.Text = "Maiúscula";
            this.btnmaiuscula.UseVisualStyleBackColor = true;
            this.btnmaiuscula.Click += new System.EventHandler(this.btnmaiuscula_Click);
            // 
            // btncontarpalavras
            // 
            this.btncontarpalavras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncontarpalavras.Location = new System.Drawing.Point(223, 177);
            this.btncontarpalavras.Name = "btncontarpalavras";
            this.btncontarpalavras.Size = new System.Drawing.Size(112, 74);
            this.btncontarpalavras.TabIndex = 3;
            this.btncontarpalavras.Text = "Contar Palavras";
            this.btncontarpalavras.UseVisualStyleBackColor = true;
            this.btncontarpalavras.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncontarletras
            // 
            this.btncontarletras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncontarletras.Location = new System.Drawing.Point(341, 177);
            this.btncontarletras.Name = "btncontarletras";
            this.btncontarletras.Size = new System.Drawing.Size(112, 74);
            this.btncontarletras.TabIndex = 4;
            this.btncontarletras.Text = "Contar Letras";
            this.btncontarletras.UseVisualStyleBackColor = true;
            this.btncontarletras.Click += new System.EventHandler(this.btncontarletras_Click);
            // 
            // btninverterpalavras
            // 
            this.btninverterpalavras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninverterpalavras.Location = new System.Drawing.Point(341, 257);
            this.btninverterpalavras.Name = "btninverterpalavras";
            this.btninverterpalavras.Size = new System.Drawing.Size(112, 74);
            this.btninverterpalavras.TabIndex = 5;
            this.btninverterpalavras.Text = "Inverter Palavras";
            this.btninverterpalavras.UseVisualStyleBackColor = true;
            this.btninverterpalavras.Click += new System.EventHandler(this.btninverterpalavras_Click);
            // 
            // btnquebralinha
            // 
            this.btnquebralinha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnquebralinha.Location = new System.Drawing.Point(223, 337);
            this.btnquebralinha.Name = "btnquebralinha";
            this.btnquebralinha.Size = new System.Drawing.Size(112, 74);
            this.btnquebralinha.TabIndex = 6;
            this.btnquebralinha.Text = "Quebra de Linha";
            this.btnquebralinha.UseVisualStyleBackColor = true;
            this.btnquebralinha.Click += new System.EventHandler(this.btnquebralinha_Click);
            // 
            // btninverterletras
            // 
            this.btninverterletras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninverterletras.Location = new System.Drawing.Point(459, 257);
            this.btninverterletras.Name = "btninverterletras";
            this.btninverterletras.Size = new System.Drawing.Size(112, 74);
            this.btninverterletras.TabIndex = 7;
            this.btninverterletras.Text = "Inverter Letras";
            this.btninverterletras.UseVisualStyleBackColor = true;
            this.btninverterletras.Click += new System.EventHandler(this.btninverterletras_Click);
            // 
            // btnminuscula
            // 
            this.btnminuscula.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnminuscula.Location = new System.Drawing.Point(223, 257);
            this.btnminuscula.Name = "btnminuscula";
            this.btnminuscula.Size = new System.Drawing.Size(112, 74);
            this.btnminuscula.TabIndex = 8;
            this.btnminuscula.Text = "Minúscula";
            this.btnminuscula.UseVisualStyleBackColor = true;
            this.btnminuscula.Click += new System.EventHandler(this.btnminuscula_Click);
            // 
            // btnembaralharpalavras
            // 
            this.btnembaralharpalavras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnembaralharpalavras.Location = new System.Drawing.Point(341, 337);
            this.btnembaralharpalavras.Name = "btnembaralharpalavras";
            this.btnembaralharpalavras.Size = new System.Drawing.Size(112, 74);
            this.btnembaralharpalavras.TabIndex = 9;
            this.btnembaralharpalavras.Text = "Embaralhar Palavras";
            this.btnembaralharpalavras.UseVisualStyleBackColor = true;
            this.btnembaralharpalavras.Click += new System.EventHandler(this.btnembaralharpalavras_Click);
            // 
            // btnembaralharletras
            // 
            this.btnembaralharletras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnembaralharletras.Location = new System.Drawing.Point(459, 337);
            this.btnembaralharletras.Name = "btnembaralharletras";
            this.btnembaralharletras.Size = new System.Drawing.Size(112, 74);
            this.btnembaralharletras.TabIndex = 10;
            this.btnembaralharletras.Text = "Embaralhar Letras";
            this.btnembaralharletras.UseVisualStyleBackColor = true;
            this.btnembaralharletras.Click += new System.EventHandler(this.btnembaralharletras_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(186, 451);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(425, 79);
            this.textBox2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 74);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnembaralharletras);
            this.Controls.Add(this.btnembaralharpalavras);
            this.Controls.Add(this.btnminuscula);
            this.Controls.Add(this.btninverterletras);
            this.Controls.Add(this.btnquebralinha);
            this.Controls.Add(this.btninverterpalavras);
            this.Controls.Add(this.btncontarletras);
            this.Controls.Add(this.btncontarpalavras);
            this.Controls.Add(this.btnmaiuscula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Manipulação de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnmaiuscula;
        private Button btncontarpalavras;
        private Button btncontarletras;
        private Button btninverterpalavras;
        private Button btnquebralinha;
        private Button btninverterletras;
        private Button btnminuscula;
        private Button btnembaralharpalavras;
        private Button btnembaralharletras;
        private TextBox textBox2;
        private Button button1;
    }
}