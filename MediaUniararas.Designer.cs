namespace CalculoUNIP
{
    partial class MediaUniararas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaUniararas));
            MSK_P1 = new MaskedTextBox();
            LB_P1 = new Label();
            LB_P2 = new Label();
            MSK_P2 = new MaskedTextBox();
            LB_MEDIA = new Label();
            LB_RESULT = new Label();
            BTN_CALCULAR = new Button();
            lbl_valorP1 = new Label();
            lbl_valorP2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label_Situacao = new Label();
            FHO_LOGO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FHO_LOGO).BeginInit();
            SuspendLayout();
            // 
            // MSK_P1
            // 
            MSK_P1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MSK_P1.Location = new Point(94, 32);
            MSK_P1.Mask = "00.00";
            MSK_P1.Name = "MSK_P1";
            MSK_P1.Size = new Size(100, 29);
            MSK_P1.TabIndex = 0;
            MSK_P1.TextAlign = HorizontalAlignment.Center;
            MSK_P1.ValidatingType = typeof(int);
            // 
            // LB_P1
            // 
            LB_P1.AutoSize = true;
            LB_P1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_P1.Location = new Point(26, 36);
            LB_P1.Name = "LB_P1";
            LB_P1.Size = new Size(66, 21);
            LB_P1.TabIndex = 1;
            LB_P1.Text = "Nota P1";
            // 
            // LB_P2
            // 
            LB_P2.AutoSize = true;
            LB_P2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_P2.Location = new Point(26, 88);
            LB_P2.Name = "LB_P2";
            LB_P2.Size = new Size(66, 21);
            LB_P2.TabIndex = 3;
            LB_P2.Text = "Nota P2";
            // 
            // MSK_P2
            // 
            MSK_P2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MSK_P2.Location = new Point(94, 84);
            MSK_P2.Mask = "00.00";
            MSK_P2.Name = "MSK_P2";
            MSK_P2.Size = new Size(100, 29);
            MSK_P2.TabIndex = 2;
            MSK_P2.TextAlign = HorizontalAlignment.Center;
            // 
            // LB_MEDIA
            // 
            LB_MEDIA.AutoSize = true;
            LB_MEDIA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_MEDIA.Location = new Point(26, 161);
            LB_MEDIA.Name = "LB_MEDIA";
            LB_MEDIA.Size = new Size(53, 21);
            LB_MEDIA.TabIndex = 3;
            LB_MEDIA.Text = "Média";
            // 
            // LB_RESULT
            // 
            LB_RESULT.AutoSize = true;
            LB_RESULT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LB_RESULT.Location = new Point(99, 161);
            LB_RESULT.Name = "LB_RESULT";
            LB_RESULT.Size = new Size(138, 21);
            LB_RESULT.TabIndex = 3;
            LB_RESULT.Text = "Resultado Média";
            // 
            // BTN_CALCULAR
            // 
            BTN_CALCULAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_CALCULAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_CALCULAR.Location = new Point(222, 30);
            BTN_CALCULAR.Name = "BTN_CALCULAR";
            BTN_CALCULAR.Size = new Size(88, 39);
            BTN_CALCULAR.TabIndex = 4;
            BTN_CALCULAR.Text = "Calcular";
            BTN_CALCULAR.UseVisualStyleBackColor = true;
            BTN_CALCULAR.Click += BTN_CALCULAR_Click;
            // 
            // lbl_valorP1
            // 
            lbl_valorP1.AutoSize = true;
            lbl_valorP1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valorP1.Location = new Point(77, 219);
            lbl_valorP1.Name = "lbl_valorP1";
            lbl_valorP1.Size = new Size(56, 25);
            lbl_valorP1.TabIndex = 5;
            lbl_valorP1.Text = "P1 + ";
            // 
            // lbl_valorP2
            // 
            lbl_valorP2.AutoSize = true;
            lbl_valorP2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valorP2.Location = new Point(143, 219);
            lbl_valorP2.Name = "lbl_valorP2";
            lbl_valorP2.Size = new Size(84, 25);
            lbl_valorP2.TabIndex = 6;
            lbl_valorP2.Text = "( 2 x P2 )";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 225);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 7;
            label5.Text = "________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(140, 247);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 8;
            label6.Text = "3";
            // 
            // label_Situacao
            // 
            label_Situacao.AutoSize = true;
            label_Situacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Situacao.Location = new Point(99, 140);
            label_Situacao.Name = "label_Situacao";
            label_Situacao.Size = new Size(0, 21);
            label_Situacao.TabIndex = 9;
            label_Situacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FHO_LOGO
            // 
            FHO_LOGO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FHO_LOGO.Image = CalculoFHO.Properties.Resources.FHO2;
            FHO_LOGO.Location = new Point(222, 69);
            FHO_LOGO.Margin = new Padding(0);
            FHO_LOGO.Name = "FHO_LOGO";
            FHO_LOGO.Size = new Size(88, 92);
            FHO_LOGO.SizeMode = PictureBoxSizeMode.Zoom;
            FHO_LOGO.TabIndex = 10;
            FHO_LOGO.TabStop = false;
            // 
            // MediaUniararas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 281);
            Controls.Add(FHO_LOGO);
            Controls.Add(lbl_valorP1);
            Controls.Add(label_Situacao);
            Controls.Add(lbl_valorP2);
            Controls.Add(BTN_CALCULAR);
            Controls.Add(LB_RESULT);
            Controls.Add(LB_MEDIA);
            Controls.Add(LB_P2);
            Controls.Add(MSK_P2);
            Controls.Add(LB_P1);
            Controls.Add(MSK_P1);
            Controls.Add(label5);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MediaUniararas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de Média - FHO";
            ((System.ComponentModel.ISupportInitialize)FHO_LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MSK_P1;
        private Label LB_P1;
        private Label LB_P2;
        private MaskedTextBox MSK_P2;
        private Label LB_MEDIA;
        private Label LB_RESULT;
        private Button BTN_CALCULAR;
        private Label lbl_valorP1;
        private Label lbl_valorP2;
        private Label label5;
        private Label label6;
        private Label label_Situacao;
        private PictureBox FHO_LOGO;
    }
}