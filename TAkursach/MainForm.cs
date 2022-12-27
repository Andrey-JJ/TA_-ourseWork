using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TAkursach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LexemTable.Columns.Add("Word", "Слово");
            LexemTable.Columns.Add("Lexeme", "Лексема");
            tBCode.Clear();
            TokensTable.Columns.Add("TableNumber", "Номер таблицы");
            TokensTable.Columns.Add("NumberInTable", "Номер в таблице");
            ClearAll();
            GetAllFromFile("need.txt");
        }
        Lexem lexemAnalysator;
        Syntax syntaxAnalysator;
        private void btnCheckText_Click(object sender, EventArgs e)
        {
            ClearAll();
            lexemAnalysator = new Lexem(tBCode.Text);
            //Вывод таблицы лексем
            List<(string, char)> table = lexemAnalysator.LexemMap;
            foreach (var item in table)
                LexemTable.Rows.Add(item.Item1 != "\n" ? item.Item1 : "#", item.Item2);
            //Вывод таблицы ключевых слов
            lBClassf.Items.Add("Слова");
            string[] words = lexemAnalysator.CodeWords;
            foreach (string word in words)
                lBClassf.Items.Add(Array.IndexOf(words, word) + " | " + word);
            lBClassf.Items.Add("");
            //Вывод таблицы разделителей
            lBClassf.Items.Add("Разделители");
            string[] separs = lexemAnalysator.CodeSeparators;
            foreach (string sep in separs)
                lBClassf.Items.Add(Array.IndexOf(separs, sep) + " | " + (sep != "\n" ? sep : "#"));
            lBClassf.Items.Add("");
            //Вывод таблицы переменные
            lBClassf.Items.Add("Переменные");
            List<string> variabls = lexemAnalysator.CodeVariables;
            foreach (string var in variabls)
                lBClassf.Items.Add(variabls.IndexOf(var) + " | " + var);
            lBClassf.Items.Add("");
            //Вывод таблицы чисел
            List<string> literals = lexemAnalysator.CodeLiterals;
            lBClassf.Items.Add("Литералы");
            foreach (string literal in literals)
                lBClassf.Items.Add(literals.IndexOf(literal) + " | " + literal);
            //Вывод таблицы токенов
            List<(char, int)> tokens = lexemAnalysator.TableTokens;
            foreach(var item in tokens)
                TokensTable.Rows.Add(item.Item1, item.Item2);
        }
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            if (opfd.ShowDialog() == DialogResult.OK)
                GetAllFromFile(opfd.FileName);
            else MessageBox.Show("Файл не был найден");
        }
        void ClearAll()
        {
            LexemTable.Rows.Clear();
            lBClassf.Items.Clear();
            TokensTable.Rows.Clear();
            lBDijkstra.Items.Clear();
        }
        void GetAllFromFile(string s)
        {
            string file = File.ReadAllText(s);
            tBCode.Text = file;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void btnSyntax_Click(object sender, EventArgs e)
        {
            lBDijkstra.Items.Clear();
            syntaxAnalysator = new Syntax(lexemAnalysator);
            syntaxAnalysator.CheckSyntax();
            foreach (var i in syntaxAnalysator.matrix)
                lBDijkstra.Items.Add(i);
        }
    }
}
