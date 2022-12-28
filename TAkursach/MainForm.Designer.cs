namespace TAkursach
{
    partial class MainForm
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
            this.tBCode = new System.Windows.Forms.TextBox();
            this.btnCheckText = new System.Windows.Forms.Button();
            this.LexemTable = new System.Windows.Forms.DataGridView();
            this.lBClassf = new System.Windows.Forms.ListBox();
            this.TokensTable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lBDijkstra = new System.Windows.Forms.ListBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSyntax = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LexemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TokensTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBCode
            // 
            this.tBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBCode.Location = new System.Drawing.Point(13, 13);
            this.tBCode.Multiline = true;
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(434, 442);
            this.tBCode.TabIndex = 0;
            // 
            // btnCheckText
            // 
            this.btnCheckText.Location = new System.Drawing.Point(13, 461);
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
            this.LexemTable.Size = new System.Drawing.Size(531, 501);
            this.LexemTable.TabIndex = 2;
            // 
            // lBClassf
            // 
            this.lBClassf.FormattingEnabled = true;
            this.lBClassf.ItemHeight = 16;
            this.lBClassf.Location = new System.Drawing.Point(10, 30);
            this.lBClassf.Name = "lBClassf";
            this.lBClassf.Size = new System.Drawing.Size(192, 468);
            this.lBClassf.TabIndex = 3;
            // 
            // TokensTable
            // 
            this.TokensTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TokensTable.Location = new System.Drawing.Point(208, 30);
            this.TokensTable.Name = "TokensTable";
            this.TokensTable.RowHeadersWidth = 51;
            this.TokensTable.RowTemplate.Height = 24;
            this.TokensTable.Size = new System.Drawing.Size(325, 468);
            this.TokensTable.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(453, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 542);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.LexemTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица лексем";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.TokensTable);
            this.tabPage2.Controls.Add(this.lBClassf);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дополнительные таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 4);
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
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таблицы классификаций";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lBDijkstra);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(545, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Транслятор выражений";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lBDijkstra
            // 
            this.lBDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBDijkstra.FormattingEnabled = true;
            this.lBDijkstra.ItemHeight = 22;
            this.lBDijkstra.Location = new System.Drawing.Point(4, 22);
            this.lBDijkstra.Name = "lBDijkstra";
            this.lBDijkstra.Size = new System.Drawing.Size(538, 488);
            this.lBDijkstra.TabIndex = 0;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(309, 461);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(138, 44);
            this.btn_OpenFile.TabIndex = 6;
            this.btn_OpenFile.Text = "Открыть файл";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(309, 511);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистка данных";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSyntax
            // 
            this.btnSyntax.Location = new System.Drawing.Point(13, 511);
            this.btnSyntax.Name = "btnSyntax";
            this.btnSyntax.Size = new System.Drawing.Size(138, 44);
            this.btnSyntax.TabIndex = 8;
            this.btnSyntax.Text = "Синтаксис";
            this.btnSyntax.UseVisualStyleBackColor = true;
            this.btnSyntax.Click += new System.EventHandler(this.btnSyntax_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Метод Дейкстры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 567);
            this.Controls.Add(this.btnSyntax);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCheckText);
            this.Controls.Add(this.tBCode);
            this.Name = "MainForm";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Button btnCheckText;
        private System.Windows.Forms.DataGridView LexemTable;
        private System.Windows.Forms.ListBox lBClassf;
        private System.Windows.Forms.DataGridView TokensTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSyntax;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lBDijkstra;
        private System.Windows.Forms.Label label3;
    }
}

