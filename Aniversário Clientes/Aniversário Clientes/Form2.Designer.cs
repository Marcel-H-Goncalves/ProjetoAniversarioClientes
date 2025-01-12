namespace Aniversário_Clientes
{
    partial class Form2
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
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(66, 166);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(208, 23);
            maskedTextBox3.TabIndex = 18;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(48, 122);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(226, 23);
            maskedTextBox2.TabIndex = 17;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(136, 78);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(138, 23);
            maskedTextBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 174);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 130);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 13;
            label4.Text = "Cpf:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 12;
            label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 42);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // button1
            // 
            button1.Location = new Point(347, 59);
            button1.Name = "button1";
            button1.Size = new Size(152, 42);
            button1.TabIndex = 19;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(347, 107);
            button2.Name = "button2";
            button2.Size = new Size(152, 42);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 285);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}