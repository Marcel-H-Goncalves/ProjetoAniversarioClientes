namespace Aniversário_Clientes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button5 = new Button();
            label7 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(731, 276);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ButtonFace;
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(maskedTextBox3);
            tabPage1.Controls.Add(maskedTextBox2);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(723, 248);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            // 
            // button5
            // 
            button5.Font = new Font("Arial", 12F, FontStyle.Bold);
            button5.Location = new Point(447, 160);
            button5.Name = "button5";
            button5.Size = new Size(168, 67);
            button5.TabIndex = 12;
            button5.Text = "Editar ";
            button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(202, 14);
            label7.Name = "label7";
            label7.Size = new Size(303, 38);
            label7.TabIndex = 11;
            label7.Text = "Cadastrar Paciente";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox3.Location = new Point(81, 201);
            maskedTextBox3.Mask = "(00)90000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(279, 26);
            maskedTextBox3.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox2.Location = new Point(54, 153);
            maskedTextBox2.Mask = "000 000 000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(306, 26);
            maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(176, 113);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(184, 26);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Bold);
            textBox2.Location = new Point(72, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 26);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(6, 208);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 5;
            label5.Text = "Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 160);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 4;
            label4.Text = "Cpf:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 120);
            label3.Name = "label3";
            label3.Size = new Size(168, 19);
            label3.TabIndex = 3;
            label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(447, 65);
            button1.Name = "button1";
            button1.Size = new Size(168, 74);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Paciente";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(723, 248);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Aniversários";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(384, 113);
            button4.Name = "button4";
            button4.Size = new Size(110, 43);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(384, 64);
            button3.Name = "button3";
            button3.Size = new Size(110, 43);
            button3.TabIndex = 2;
            button3.Text = "Editar Mensagem";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(384, 15);
            button2.Name = "button2";
            button2.Size = new Size(110, 43);
            button2.TabIndex = 1;
            button2.Text = "Enviar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(338, 229);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 25);
            label1.Name = "label1";
            label1.Size = new Size(337, 45);
            label1.TabIndex = 1;
            label1.Text = "Clínica Pelle Nova";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 386);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 2;
            label6.Text = "CodeKaze Innovations";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 67);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(755, 410);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private ListBox listBox1;
    }
}
