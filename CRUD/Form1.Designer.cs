namespace CRUD
{
    partial class Form1
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tbMat = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbSal = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.Databox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsul = new System.Windows.Forms.Button();
            this.btnExclu = new System.Windows.Forms.Button();
            this.btnExib = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(21, 175);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(399, 150);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // tbMat
            // 
            this.tbMat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbMat.Location = new System.Drawing.Point(73, 8);
            this.tbMat.Name = "tbMat";
            this.tbMat.Size = new System.Drawing.Size(100, 20);
            this.tbMat.TabIndex = 1;
            this.tbMat.TextChanged += new System.EventHandler(this.tbMat_TextChanged);
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNom.Location = new System.Drawing.Point(73, 35);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 2;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // tbEnd
            // 
            this.tbEnd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbEnd.Location = new System.Drawing.Point(73, 61);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(100, 20);
            this.tbEnd.TabIndex = 3;
            this.tbEnd.TextChanged += new System.EventHandler(this.tbEnd_TextChanged);
            // 
            // tbSex
            // 
            this.tbSex.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSex.Location = new System.Drawing.Point(73, 86);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(100, 20);
            this.tbSex.TabIndex = 4;
            this.tbSex.TextChanged += new System.EventHandler(this.tbSex_TextChanged);
            // 
            // tbSal
            // 
            this.tbSal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSal.Location = new System.Drawing.Point(320, 4);
            this.tbSal.Name = "tbSal";
            this.tbSal.Size = new System.Drawing.Size(100, 20);
            this.tbSal.TabIndex = 6;
            // 
            // tbTel
            // 
            this.tbTel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbTel.Location = new System.Drawing.Point(320, 32);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(100, 20);
            this.tbTel.TabIndex = 7;
            // 
            // tbIdade
            // 
            this.tbIdade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbIdade.Location = new System.Drawing.Point(320, 62);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 20);
            this.tbIdade.TabIndex = 8;
            // 
            // Databox
            // 
            this.Databox.CalendarMonthBackground = System.Drawing.Color.White;
            this.Databox.Location = new System.Drawing.Point(235, 118);
            this.Databox.Name = "Databox";
            this.Databox.Size = new System.Drawing.Size(200, 20);
            this.Databox.TabIndex = 9;
            this.Databox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "endereco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(232, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "data de nascimento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(232, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "salario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(232, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "telefone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(232, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "idade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(183, 144);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsul
            // 
            this.btnConsul.Location = new System.Drawing.Point(102, 144);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(75, 23);
            this.btnConsul.TabIndex = 20;
            this.btnConsul.Text = "consultar";
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.btnConsul_Click);
            // 
            // btnExclu
            // 
            this.btnExclu.Location = new System.Drawing.Point(345, 144);
            this.btnExclu.Name = "btnExclu";
            this.btnExclu.Size = new System.Drawing.Size(75, 23);
            this.btnExclu.TabIndex = 21;
            this.btnExclu.Text = "excluir";
            this.btnExclu.UseVisualStyleBackColor = true;
            this.btnExclu.Click += new System.EventHandler(this.btnExclu_Click);
            // 
            // btnExib
            // 
            this.btnExib.Location = new System.Drawing.Point(264, 144);
            this.btnExib.Name = "btnExib";
            this.btnExib.Size = new System.Drawing.Size(75, 23);
            this.btnExib.TabIndex = 22;
            this.btnExib.Text = "exibir";
            this.btnExib.UseVisualStyleBackColor = true;
            this.btnExib.Click += new System.EventHandler(this.btnExib_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(459, 333);
            this.Controls.Add(this.btnExib);
            this.Controls.Add(this.btnExclu);
            this.Controls.Add(this.btnConsul);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Databox);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbSal);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbMat);
            this.Controls.Add(this.dgvDados);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox tbMat;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbSal;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbIdade;
        private System.Windows.Forms.DateTimePicker Databox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsul;
        private System.Windows.Forms.Button btnExclu;
        private System.Windows.Forms.Button btnExib;
    }
}

