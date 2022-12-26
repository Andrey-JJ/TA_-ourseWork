namespace TAkursach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheckText = new System.Windows.Forms.Button();
            this.LexemTable = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TokensTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSyntax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LexemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokensTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 386);
            this.textBox1.TabIndex = 0;
            // 
            // btnCheckText
            // 
            this.btnCheckText.Location = new System.Drawing.Point(13, 405);
            this.btnCheckText.Name = "btnCheckText";
            this.btnCheckText.Size = new System.Drawing.Size(138, 44);
            this.btnCheckText.TabIndex = 1;
            this.btnCheckText.Text = "Выполнить анализ";
            this.btnCheckText.UseVisualStyleBackColor = true;
            this.btnCheckText.Click += new System.EventHandler(this.btnCheckText_Click);
            // 
            // LexemTable
            // 
            this.LexemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LexemTable.Location = new System.Drawing.Point(6, 6);
            this.LexemTable.Name = "LexemTable";
            this.LexemTable.RowHeadersWidth = 51;
            this.LexemTable.RowTemplate.Height = 24;
            this.LexemTable.Size = new System.Drawing.Size(517, 345);
            this.LexemTable.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 324);
            this.listBox1.TabIndex = 3;
            // 
            // TokensTable
            // 
            this.TokensTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TokensTable.Location = new System.Drawing.Point(169, 30);
            this.TokensTable.Name = "TokensTable";
            this.TokensTable.RowHeadersWidth = 51;
            this.TokensTable.RowTemplate.Height = 24;
            this.TokensTable.Size = new System.Drawing.Size(354, 324);
            this.TokensTable.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(345, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 386);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.LexemTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица лексем";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.TokensTable);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дополнительные таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Таблица токенов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таблицы значений";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(345, 405);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(138, 44);
            this.btn_OpenFile.TabIndex = 6;
            this.btn_OpenFile.Text = "Открыть файл";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(489, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистка вывода";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSyntax
            // 
            this.btnSyntax.Location = new System.Drawing.Point(157, 405);
            this.btnSyntax.Name = "btnSyntax";
            this.btnSyntax.Size = new System.Drawing.Size(138, 44);
            this.btnSyntax.TabIndex = 8;
            this.btnSyntax.Text = "Синтаксис";
            this.btnSyntax.UseVisualStyleBackColor = true;
            this.btnSyntax.Click += new System.EventHandler(this.btnSyntax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.btnSyntax);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCheckText);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Лексический анализатор";
            ((System.ComponentModel.ISupportInitialize)(this.LexemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokensTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheckText;
        private System.Windows.Forms.DataGridView LexemTable;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView TokensTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSyntax;
    }
}

