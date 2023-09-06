namespace WinFormsApp1
{
    partial class Frm_Mascara
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
            Label Lbl_MascaraAtiva;
            Msk_TextBox = new MaskedTextBox();
            Lbl_Conteudo = new Label();
            Btn_Hora = new Button();
            Btn_CEP = new Button();
            Btn_Moeda = new Button();
            Btn_Data = new Button();
            Btn_Senha = new Button();
            button1 = new Button();
            button2 = new Button();
            Lbl_MascaraAtiva = new Label();
            SuspendLayout();
            // 
            // Msk_TextBox
            // 
            Msk_TextBox.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Msk_TextBox.Location = new Point(23, 31);
            Msk_TextBox.Name = "Msk_TextBox";
            Msk_TextBox.Size = new Size(258, 29);
            Msk_TextBox.TabIndex = 0;
            // 
            // Lbl_Conteudo
            // 
            Lbl_Conteudo.AutoSize = true;
            Lbl_Conteudo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Conteudo.Location = new Point(23, 246);
            Lbl_Conteudo.Name = "Lbl_Conteudo";
            Lbl_Conteudo.Size = new Size(0, 19);
            Lbl_Conteudo.TabIndex = 1;
            // 
            // Lbl_MascaraAtiva
            // 
            Lbl_MascaraAtiva.AutoSize = true;
            Lbl_MascaraAtiva.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_MascaraAtiva.Location = new Point(23, 75);
            Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            Lbl_MascaraAtiva.Size = new Size(0, 19);
            Lbl_MascaraAtiva.TabIndex = 2;
            // 
            // Btn_Hora
            // 
            Btn_Hora.ForeColor = SystemColors.ControlText;
            Btn_Hora.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Hora.Location = new Point(23, 110);
            Btn_Hora.Name = "Btn_Hora";
            Btn_Hora.Size = new Size(82, 37);
            Btn_Hora.TabIndex = 3;
            Btn_Hora.Text = "Hora";
            Btn_Hora.UseVisualStyleBackColor = true;
            // 
            // Btn_CEP
            // 
            Btn_CEP.ForeColor = SystemColors.ControlText;
            Btn_CEP.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_CEP.Location = new Point(111, 110);
            Btn_CEP.Name = "Btn_CEP";
            Btn_CEP.Size = new Size(82, 37);
            Btn_CEP.TabIndex = 4;
            Btn_CEP.Text = "CEP";
            Btn_CEP.UseVisualStyleBackColor = true;
            // 
            // Btn_Moeda
            // 
            Btn_Moeda.ForeColor = SystemColors.ControlText;
            Btn_Moeda.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Moeda.Location = new Point(199, 110);
            Btn_Moeda.Name = "Btn_Moeda";
            Btn_Moeda.Size = new Size(82, 37);
            Btn_Moeda.TabIndex = 5;
            Btn_Moeda.Text = "Moeda";
            Btn_Moeda.UseVisualStyleBackColor = true;
            // 
            // Btn_Data
            // 
            Btn_Data.ForeColor = SystemColors.ControlText;
            Btn_Data.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Data.Location = new Point(23, 153);
            Btn_Data.Name = "Btn_Data";
            Btn_Data.Size = new Size(82, 37);
            Btn_Data.TabIndex = 6;
            Btn_Data.Text = "Data";
            Btn_Data.UseVisualStyleBackColor = true;
            // 
            // Btn_Senha
            // 
            Btn_Senha.ForeColor = SystemColors.ControlText;
            Btn_Senha.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Senha.Location = new Point(111, 153);
            Btn_Senha.Name = "Btn_Senha";
            Btn_Senha.Size = new Size(82, 37);
            Btn_Senha.TabIndex = 7;
            Btn_Senha.Text = "Senha";
            Btn_Senha.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(199, 153);
            button1.Name = "button1";
            button1.Size = new Size(82, 37);
            button1.TabIndex = 8;
            button1.Text = "Telefone";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(23, 196);
            button2.Name = "button2";
            button2.Size = new Size(258, 37);
            button2.TabIndex = 9;
            button2.Text = "Ver Conteudo";
            button2.UseVisualStyleBackColor = true;
            // 
            // Frm_Mascara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 283);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Btn_Senha);
            Controls.Add(Btn_Data);
            Controls.Add(Btn_Moeda);
            Controls.Add(Btn_CEP);
            Controls.Add(Btn_Hora);
            Controls.Add(Lbl_MascaraAtiva);
            Controls.Add(Lbl_Conteudo);
            Controls.Add(Msk_TextBox);
            Name = "Frm_Mascara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Mascara";
            Load += Frm_Mascara_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Msk_TextBox;
        private Label Lbl_Conteudo;
        private Button Btn_Hora;
        private Button Btn_CEP;
        private Button Btn_Moeda;
        private Button Btn_Data;
        private Button Btn_Senha;
        private Button button1;
        private Button button2;
    }
}