using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAkursach
{
    public class Analizator
    {
        #region Used Variables 
        public List<(string, char)> LexemMap { get; private set; } //Список исходных лексем
        static string textfrom; //Считанный текст из файла
        //Исходный файл с кодом и свойство для данного файла
        static string filename = "need.txt"; 
        public static string FileName { get => filename; set => filename = value; }
        string buffer_lexem = ""; //Буффер для лексем  
        static char[] separators = { '+', '-', '/', '*', '>', '=', '<', '\n', '(', ')', '^' }; //разделители
        static string[] separatorsPairs = { "++", "--", "+=", "-=", "==", "<>", ">=", "<=" }; //Двойные разделители
        #endregion
        #region Variables Tables
        string[] allSeparators;
        public string[] CodeSeparators {
            get { return allSeparators; }
            private set { allSeparators = value; }
        }
        public readonly string[] CodeWords = new string[] { "or", "while", "do", "Dim", "as", "integer", "loop" };
        List<string> codeVariables = new List<string>();
        public List<string> CodeVariables { get => codeVariables; private set => codeVariables = value; }
        List<string> codeLiterals = new List<string>();
        public List<string> CodeLiterals { get => codeLiterals; private set => codeLiterals = value; }
        List<(int, int)> tableTokens = new List<(int, int)>();
        public List<(int, int)> TableTokens { get => tableTokens; private set => tableTokens = value; }
        #endregion
        #region Class Construct
        public Analizator() {}
        public Analizator(string from)
        {
            textfrom = from;
            LexemMap = new List<(string, char)>();
            GetAllSeparators();
            LexemAnalysis();
            ClassificationOfTokens();
        }
        #endregion
        #region Class Operations
        /// <summary>
        /// Метод поиска дексем в исходном тексте и присвоения каждой лексеме одного из базовых типов(I, D, R)
        /// </summary>
        /// <exception cref="Exception"> Ошибка о некорректно введенных данных </exception>
        void LexemAnalysis()
        {
            char symbol = ' ', type = ' ';
            for (int i = 0; i < textfrom.Length; i++) 
            {
                symbol = textfrom[i];
                if ((int)symbol >= 66 && (int)symbol <= 122)
                    type = 'I';
                else if (Char.IsDigit(symbol))
                    type = 'D';
                else if (separators.Contains(symbol))
                    type = 'R';
                else if (symbol == ' ' || symbol == '\r' || symbol == '\t')
                    continue;
                else
                    throw new Exception($"Введен не корректный символ - {symbol}");
                switch (type)
                {
                    case 'I':
                        AddToBuffer(textfrom[i]);
                        if ((i+1 < textfrom.Length) && (CheckIsLetter(textfrom[i + 1]) || Char.IsDigit(textfrom[i + 1])))
                        { i++; goto case 'I'; }
                        else
                        { Out(buffer_lexem, type); type = ' '; }
                        break;
                    case 'D':
                        AddToBuffer(textfrom[i]);
                        if ((i + 1 < textfrom.Length) && Char.IsDigit(textfrom[i + 1]))
                        { i++; goto case 'D'; }
                        else
                        { Out(buffer_lexem, type); type = ' '; }
                        break;
                    case 'R':
                        AddToBuffer(textfrom[i]);
                        if ((i + 1 < textfrom.Length) && CheckDoubleSepars(textfrom[i + 1]))
                        { i++; goto case 'R'; }
                        else
                        { Out(buffer_lexem, type); type = ' '; }
                        break;
                }
            }
        }
        /// <summary>
        /// Метод получения базового типа лексемы для последующего заполнения или сравнения переменных соответстующих таблиц
        /// </summary>
        /// <exception cref="Exception"> Ошибка при получении неопределенных данных </exception>
        void ClassificationOfTokens()
        {
            int type = 0;
            for (int i = 0; i < LexemMap.Count; i++)
            {
                if (CodeWords.Any(LexemMap[i].Item1.Contains))
                    type = 1;
                else if (allSeparators.Any(LexemMap[i].Item1.Contains))
                    type = 2;
                else if (LexemMap[i].Item2 == 'I')
                    type = 3;
                else if (LexemMap[i].Item2 == 'D')
                    type = 4;
                else
                    throw new Exception("Неопределенные данные в таблице");
                type = GetTokensForlexem(type, i);
            }
        }
        /// <summary>
        /// Метод разбивки лексем по таблицам и создания общей таблицы
        /// </summary>
        /// <param name="type"> Переменная указывабщая тип таблицы для записи или сравнения переменной </param>
        /// <param name="i"> Переменная отвечающая за индекс текущей переменной </param>
        /// <returns></returns>
        int GetTokensForlexem(int type, int i)
        {
            switch (type)
            {
                case 1:
                    for (int j = 0; j < CodeWords.Length; j++)
                        if (CodeWords[j] == LexemMap[i].Item1)
                            tableTokens.Add((type, j));
                    type = 0;
                    break;
                case 2:
                    for (int j = 0; j < allSeparators.Length; j++)
                        if (allSeparators[j] == LexemMap[i].Item1)
                            tableTokens.Add((type, j));
                    type = 0;
                    break;
                case 3:
                    if (!codeVariables.Contains(LexemMap[i].Item1))
                        codeVariables.Add(LexemMap[i].Item1);
                    tableTokens.Add((type, codeVariables.IndexOf(LexemMap[i].Item1)));
                    type = 0;
                    break;
                case 4:
                    if (!codeLiterals.Contains(LexemMap[i].Item1))
                        codeLiterals.Add(LexemMap[i].Item1);
                    tableTokens.Add((type, codeLiterals.IndexOf(LexemMap[i].Item1)));
                    type = 0;
                    break;
            }
            return type;
        }
        /// <summary>
        /// Метод используется для объединения всех разделителей в один массив
        /// </summary>
        void GetAllSeparators()
        {
            string[] tmp = (from var in separators select var.ToString()).ToArray();
            allSeparators = new string[separators.Length + separatorsPairs.Length];
            Array.Copy(tmp, allSeparators, tmp.Length);
            Array.Copy(separatorsPairs, 0, allSeparators, tmp.Length, separatorsPairs.Length);
        }
        #endregion
        #region Add and Out operations
        /// <summary>
        /// Метод добавления текущего символа в временный буффер
        /// </summary>
        /// <param name="symbol"> Переменная содержащая полученный символ для добавления </param>
        void AddToBuffer(char symbol) => buffer_lexem += symbol;
        /// <summary>
        /// Метод добавления полученной лексемы в таблицу лексем
        /// </summary>
        /// <param name="buffer_lexem"> Временный буффер содержащий лексему </param>
        /// <param name="type"> Переменная содержащая базовый тип лексемы </param>
        void Out(string buffer_lexem, char type)
        {
            if (buffer_lexem.Length > 0)
            {
                LexemMap.Add((buffer_lexem, type));
                this.buffer_lexem = "";
            }
        }
        #endregion
        #region Check operations
        /// <summary>
        /// Метод проверки на двойной разделитель
        /// </summary>
        /// <param name="symbol"> Переменная содержащая полученный символ </param>
        /// <returns></returns>
        bool CheckDoubleSepars(char symbol)
        {
            string tmp = buffer_lexem + symbol;
            bool check = false;
            foreach (var item in separatorsPairs)
                if (item == tmp)
                    check = true;
            return check;
        }
        /// <summary>
        /// Метод проверки на корректный символ англ алфавита
        /// </summary>
        /// <param name="symbol"> Переменная содержащая полученный символ </param>
        /// <returns></returns>
        bool CheckIsLetter(char symbol)
        { return ((int)symbol >= 65 && (int)symbol <= 90) || ((int)symbol >= 97 && (int)symbol <= 122); }
        #endregion
    }
}