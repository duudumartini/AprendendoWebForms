namespace WinFormsApp1
{
    partial class Frm_ValidaCPF2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaCPF2));
            Msk_CPF = new MaskedTextBox();
            Btn_Reset = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Msk_CPF
            // 
            Msk_CPF.Location = new Point(11, 45);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(218, 23);
            Msk_CPF.TabIndex = 0;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(245, 71);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 3;
            button1.Text = "Valida";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Frm_ValidaCPF2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(368, 154);
            Controls.Add(button1);
            Controls.Add(Btn_Reset);
            Controls.Add(Msk_CPF);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_ValidaCPF2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valida CPF";
            Load += Frm_ValidaCPF2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Msk_CPF;
        private Button Btn_Reset;
        private Button button1;
    }
}