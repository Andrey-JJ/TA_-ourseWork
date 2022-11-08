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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LexemTable.Columns.Add("Word", "Слово");
            LexemTable.Columns.Add("Lexeme", "Лексема");
            listBox1.Items.Clear();
            textBox1.Clear();
            TokensTable.Columns.Add("TableNumber", "Номер таблицы");
            TokensTable.Columns.Add("NumberInTable", "Номер в таблице");
        }
        private void btnCheckText_Click(object sender, EventArgs e)
        {
            Analizator analizator = new Analizator(textBox1.Text);
            //Вывод таблицы лексем
            List<(string, char)> table = analizator.LexemMap;
            foreach (var item in table)
                LexemTable.Rows.Add(item.Item1 != "\n" ? item.Item1 : "#", item.Item2);
            //Вывод таблицы ключевых слов
            listBox1.Items.Add("Слова");
            string[] words = analizator.CodeWords;
            foreach (string word in words)
                listBox1.Items.Add(Array.IndexOf(words, word) + " | " + word);
            listBox1.Items.Add("");
            //Вывод таблицы разделителей
            listBox1.Items.Add("Разделители");
            string[] separs = analizator.CodeSeparators;
            foreach (string sep in separs)
                listBox1.Items.Add(Array.IndexOf(separs, sep) + " | " + (sep != "\n" ? sep : "#"));
            listBox1.Items.Add("");
            //Вывод таблицы переменные
            listBox1.Items.Add("Переменные");
            List<string> variabls = analizator.CodeVariables;
            foreach (string var in variabls)
                listBox1.Items.Add(variabls.IndexOf(var) + " | " + var);
            listBox1.Items.Add("");
            //Вывод таблицы чисел
            List<string> literals = analizator.CodeLiterals;
            listBox1.Items.Add("Литералы");
            foreach (string literal in literals)
                listBox1.Items.Add(literals.IndexOf(literal) + " | " + literal);
            //Вывод таблицы токенов
            List<(int, int)> tokens = analizator.TableTokens;
            foreach(var item in tokens)
                TokensTable.Rows.Add(item.Item1, item.Item2);
        }
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            string file = "";
            OpenFileDialog opfd = new OpenFileDialog();
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                file = File.ReadAllText(opfd.FileName);
                textBox1.Text = file;
            }
            //else MessageBox.Show("Файл не был найден");
        }
    }
}
