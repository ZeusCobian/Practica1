namespace HolaMundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtcontraUno = new TextBox();
            txtcontraDos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnValidar = new Button();
            lblRequisitos = new Label();
            SuspendLayout();
            // 
            // txtcontraUno
            // 
            txtcontraUno.BackColor = SystemColors.Info;
            txtcontraUno.BorderStyle = BorderStyle.FixedSingle;
            txtcontraUno.Location = new Point(246, 100);
            txtcontraUno.Name = "txtcontraUno";
            txtcontraUno.Size = new Size(195, 27);
            txtcontraUno.TabIndex = 0;
            txtcontraUno.TextChanged += txtcontraUno_TextChanged;
            // 
            // txtcontraDos
            // 
            txtcontraDos.BackColor = SystemColors.Info;
            txtcontraDos.BorderStyle = BorderStyle.FixedSingle;
            txtcontraDos.Location = new Point(246, 167);
            txtcontraDos.Name = "txtcontraDos";
            txtcontraDos.Size = new Size(195, 27);
            txtcontraDos.TabIndex = 1;
            txtcontraDos.TextChanged += txtcontraDos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
            label1.TabIndex = 2;
            label1.Text = "Ingrese Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(220, 24);
            label2.TabIndex = 3;
            label2.Text = "Repita la Contraseña";
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidar.Location = new Point(295, 269);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(146, 35);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblRequisitos
            // 
            lblRequisitos.AutoSize = true;
            lblRequisitos.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRequisitos.ForeColor = Color.Red;
            lblRequisitos.Location = new Point(479, 76);
            lblRequisitos.Name = "lblRequisitos";
            lblRequisitos.Size = new Size(0, 18);
            lblRequisitos.TabIndex = 5;
            lblRequisitos.Click += lblRequisitos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRequisitos);
            Controls.Add(btnValidar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcontraDos);
            Controls.Add(txtcontraUno);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Practica 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcontraUno;
        private TextBox txtcontraDos;
        private Label label1;
        private Label label2;
        private Button btnValidar;
        private Label lblRequisitos;
    }
}