namespace WinFormsApp1
{
    partial class Frm_HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            Lbl_Titulo = new Label();
            Btn_Sair = new Button();
            Btn_ModificaLabel = new Button();
            Txt_ConteudoLabel = new TextBox();
            SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lbl_Titulo.Location = new Point(209, 173);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(431, 47);
            Lbl_Titulo.TabIndex = 0;
            Lbl_Titulo.Text = "Visual Studio .Net Version";
            Lbl_Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(627, 360);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(235, 78);
            Btn_Sair.TabIndex = 1;
            Btn_Sair.Text = "Sair da Aplicação";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_ModificaLabel
            // 
            Btn_ModificaLabel.Location = new Point(350, 223);
            Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            Btn_ModificaLabel.Size = new Size(141, 34);
            Btn_ModificaLabel.TabIndex = 2;
            Btn_ModificaLabel.Text = "Modifica Texto Label";
            Btn_ModificaLabel.UseVisualStyleBackColor = true;
            Btn_ModificaLabel.Click += Btn_ModificaLabel_Click;
            // 
            // Txt_ConteudoLabel
            // 
            Txt_ConteudoLabel.Location = new Point(209, 266);
            Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            Txt_ConteudoLabel.Size = new Size(431, 23);
            Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 450);
            Controls.Add(Txt_ConteudoLabel);
            Controls.Add(Btn_ModificaLabel);
            Controls.Add(Btn_Sair);
            Controls.Add(Lbl_Titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_HelloWorld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelloWorld";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Titulo;
        private Button Btn_Sair;
        private Button Btn_ModificaLabel;
        private TextBox Txt_ConteudoLabel;
    }
}