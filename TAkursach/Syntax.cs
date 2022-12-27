using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAkursach
{
    public class Syntax
    {
        bool isEnd = false;
        int state = 0;
        int nextLex = 0;
        Stack<string> lexemStack = new Stack<string>();
        Stack<int> stateStack = new Stack<int>();
        public List<string> matrix = new List<string>();
        Lexem lexAnalis;
        public Syntax(Lexem lexem) => this.lexAnalis = lexem;
        public void CheckSyntax()
        {
            GoToState(0);
            while (isEnd != true)
            {
                switch (state)
                {
                    case -1:
                        isEnd = true;
                        break;
                    case 0:
                        State0();
                        break;
                    case 1:
                        State1();
                        break;
                    case 2:
                        State2();
                        break;
                    case 3:
                        State3();
                        break;
                    case 4:
                        State4();
                        break;
                    case 5:
                        State5();
                        break;
                    case 6:
                        State6();
                        break;
                    case 7:
                        State7();
                        break;
                    case 8:
                        State8();
                        break;
                    case 9:
                        State9();
                        break;
                    case 10:
                        State10();
                        break;
                    case 11:
                        State11();
                        break;
                    case 12:
                        State12();
                        break;
                    case 13:
                        State13();
                        break;
                    case 15:
                        State15();
                        break;
                    case 16:
                        State16();
                        break;
                    case 18:
                        State18();
                        break;
                    case 19:
                        State19();
                        break;
                    case 21:
                        State21();
                        break;
                    case 22:
                        State22();
                        break;
                    case 23:
                        State23();
                        break;
                    case 24:
                        State24();
                        break;
                    case 26:
                        State26();
                        break;
                    case 27:
                        State27();
                        break;
                    case 28:
                        State28();
                        break;
                    case 29:
                        State29();
                        break;
                    case 30:
                        State30();
                        break;
                    case 31:
                        State31();
                        break;
                    case 32:
                        State32();
                        break;
                    case 33:
                        State33();
                        break;
                    case 34:
                        State34();
                        break;
                    case 35:
                        State35();
                        break;
                    case 36:
                        State36();
                        break;
                    case 37:
                        State37();
                        break;
                    case 38:
                        State38();
                        break;
                    case 39:
                        State39();
                        break;
                    case 40:
                        State40();
                        break;
                    case 41:
                        State41();
                        break;
                    case 42:
                        State42();
                        break;
                    case 43:
                        State43();
                        break;
                    case 44:
                        State44();
                        break;
                    case 45:
                        State45();
                        break;
                    case 46:
                        State46();
                        break;
                    case 47:
                        State47();
                        break;
                    case 48:
                        State48();
                        break;
                    case 49:
                        State49();
                        break;
                    case 50:
                        State50();
                        break;
                    case 51:
                        State51();
                        break;
                }
            }
            if(isEnd)
            {
                if (state != -1)
                    MessageBox.Show("Синтаксический разбор выполнен успешно", "Уведомление", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Синтаксический разбор был закончен с ошибкой", "Уведомление", MessageBoxButtons.OK);
                return;
            }
        }
        void Error(string lexem, string expectedlexems)
        {
            state = -1;
            try
            {
                throw new MissingExceptions(lexem, expectedlexems);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
        void Shift()
        {
            lexemStack.Push(GetLexeme(nextLex));
            nextLex++;
        }
        string GetLexeme(int number)
        {
            char lexType = lexAnalis.TableTokens[number].Item1;
            int i = lexAnalis.TableTokens[number].Item2;
            switch (lexType)
            {
                case 'K':
                    return lexAnalis.CodeWords[i];
                case 'S':
                    return lexAnalis.CodeSeparators[i];
                case 'L':
                    return "lit";
                case 'V':
                    return "id";
                default:
                    return "undefined";
            }
        }
        string GetDijLexeme(int number)
        {
            char lexType = lexAnalis.TableTokens[number].Item1;
            int i = lexAnalis.TableTokens[number].Item2;
            switch (lexType)
            {
                case 'K':
                    return lexAnalis.CodeWords[i];
                case 'S':
                    return lexAnalis.CodeSeparators[i];
                case 'L':
                    return lexAnalis.CodeLiterals[i];
                case 'V':
                    return lexAnalis.CodeVariables[i];
                default:
                    return "undefined";
            }
        }
        void GoToState(int i)
        {
            stateStack.Push(i);
            this.state = i;
        }
        void ProgramEnd()
        {
            isEnd = true;
            lexemStack.Clear();
            stateStack.Clear();
            nextLex = 0;
        }
        private void Convolution(int count, string N)
        {
            if(count == 0)
                lexemStack.Push(N);
            else
            {
                for (int i = 0; i < count; i++)
                {
                    lexemStack.Pop();
                    state = stateStack.Pop();
                    state = stateStack.Peek();
                }
                state = stateStack.Peek();
                lexemStack.Push(N);
            }
        }
        void State0()
        {
            if(lexemStack.Count == 0)
                Shift();
            switch (lexemStack.Peek())
            {
                case "<программа>":
                    ProgramEnd();
                    break;
                case "Public":
                    GoToState(1);
                    break;
                default:
                    Error(lexemStack.Peek(), "Public");
                    break;
            }
        }
        void State1()
        {
            switch (lexemStack.Peek())
            {
                case "Public":
                    Shift();
                    break;
                case "Sub":
                    GoToState(2);
                    break;
                default:
                    Error(lexemStack.Peek(), "Sub после Public");
                    break;
            }
        }
        void State2()
        {
            switch (lexemStack.Peek())
            {
                case "Sub":
                    Shift();
                    break;
                case "Main":
                    GoToState(3);
                    break;
                default:
                    Error(lexemStack.Peek(), "Main после Sub");
                    break;
            }
        }
        void State3()
        {
            switch (lexemStack.Peek())
            {
                case "Main":
                    Shift();
                    break;
                case "(":
                    GoToState(4);
                    break;
                default:
                    Error(lexemStack.Peek(), "( после Main");
                    break;
            }
        }
        void State4()
        {
            switch (lexemStack.Peek())
            {
                case "(":
                    Shift();
                    break;
                case ")":
                    GoToState(5);
                    break;
                default:
                    Error(lexemStack.Peek(), ") после (");
                    break;
            }
        }
        void State5()
        {
            switch (lexemStack.Peek())
            {
                case ")":
                    Shift();
                    break;
                case "\n":
                    GoToState(6);
                    break;
                default:
                    Error(lexemStack.Peek(), "/n после )");
                    break;
            }
        }
        void State6()
        {
            switch (lexemStack.Peek())
            {
                case "\n":
                    Shift();
                    break;
                case "<спис_опер>":
                    GoToState(7);
                    break;
                case "<опер>":
                    GoToState(8);
                    break;
                case "<цикл>":
                    GoToState(9);
                    break;
                case "<присв>":
                    GoToState(10);
                    break;
                case "<опис>":
                    GoToState(11);
                    break;
                case "do":
                    GoToState(12);
                    break;
                case "id":
                    GoToState(13);
                    break;
                case "Dim":
                    GoToState(15);
                    break;
                default:
                    Error(lexemStack.Peek(), "либо do, либо id, либо dim");
                    break;
            }
        }
        void State7()
        {
            switch (lexemStack.Peek())
            {
                case "<спис_опер>":
                    Shift();
                    break;
                case "\n":
                    GoToState(16);
                    break;
                default:
                    Error(lexemStack.Peek(), "/n");
                    break;
            }
        }
        void State8()
        {
            if (lexemStack.Peek() == "<опер>")
                Convolution(1, "<спис_опер>");
        }
        void State9()
        {
            if (lexemStack.Peek() == "<цикл>")
                Convolution(1, "<опер>");
        }
        void State10()
        {
            if (lexemStack.Peek() == "<присв>")
                Convolution(1, "<опер>");
        }
        void State11()
        {
            if (lexemStack.Peek() == "<опис>")
                Convolution(1, "<опер>");
        }
        void State12()
        {
            switch (lexemStack.Peek())
            {
                case "do":
                    Shift();
                    break;
                case "while":
                    GoToState(18);
                    break;
                default:
                    Error(lexemStack.Peek(), "while после do");
                    break;
            }
        }
        void State13()
        {
            switch (lexemStack.Peek())
            {
                case "id":
                    Shift();
                    break;
                case "=":
                    GoToState(19);
                    break;
                default:
                    Error(lexemStack.Peek(), "= после id");
                    break;
            }
        }
        void State15()
        {
            switch (lexemStack.Peek())
            {
                case "Dim":
                    Shift();
                    break;
                case "<спис_перем>":
                    GoToState(21);
                    break;
                case "id":
                    GoToState(22);
                    break;
                default:
                    Error(lexemStack.Peek(), "id после Dim");
                    break;
            }
        }
        void State16()
        {
            switch (lexemStack.Peek())
            {
                case "\n":
                    Shift();
                    break;
                case "EndSub":
                    GoToState(24);
                    break;
                case "<опер>":
                    GoToState(23);
                    break;
                case "<цикл>":
                    GoToState(9);
                    break;
                case "<присв>":
                    GoToState(10);
                    break;
                case "<опис>":
                    GoToState(11);
                    break;
                case "do":
                    GoToState(12);
                    break;
                case "id":
                    GoToState(13);
                    break;
                case "Dim":
                    GoToState(15);
                    break;
                default:
                    Error(lexemStack.Peek(), "либо do, либо id, либо Dim");
                    break;
            }
        }
        void State18()
        {
            switch (lexemStack.Peek())
            {
                case "while":
                    Expr();
                    break;
                case "expr":
                    GoToState(26);
                    break;
                default:
                    Error(lexemStack.Peek(), "expr после while");
                    break;
            }
        }
        void State19()
        {
            switch (lexemStack.Peek())
            {
                case "=":
                    Shift();
                    break;
                case "<ариф_выр>":
                    GoToState(27);
                    break;
                case "<операнд>":
                    GoToState(28);
                    break;
                case "id":
                    GoToState(29);
                    break;
                case "lit":
                    GoToState(30);
                    break;
                default:
                    Error(lexemStack.Peek(), "id или lit после =");
                    break;
            }
        }
        void State21()
        {
            switch (lexemStack.Peek())
            {
                case "<спис_перем>":
                    Shift();
                    break;
                case "as":
                    GoToState(31);
                    break;
                default:
                    Error(lexemStack.Peek(), "as после id");
                    break;
            }
        }
        void State22()
        {
            switch (lexemStack.Peek())
            {
                case "id":
                    if (GetLexeme(nextLex) == "as")
                        Convolution(1, "<спис_перем>");
                    else if (GetLexeme(nextLex) == ",")
                        Shift();
                    else Error(lexemStack.Peek(), "as или , после id");
                    break;
                case ",":
                    GoToState(32);
                    break;
                default:
                    Error(lexemStack.Peek(), ", после id");
                    break;
            }
        }
        void State23()
        {
            if (lexemStack.Peek() == "<опер>")
                Convolution(3, "<спис_опер>");
        }
        void State24()
        {
            if (lexemStack.Peek() == "EndSub")
                Convolution(9, "<программа>");
        }
        void State26()
        {
            switch (lexemStack.Peek())
            {
                case "expr":
                    Shift();
                    break;
                case "\n":
                    GoToState(33);
                    break;
                default:
                    Error(lexemStack.Peek(), "/n после expr");
                    break;
            }
        }
        void State27()
        {
            if (lexemStack.Peek() == "<ариф_выр>")
                Convolution(3, "<присв>");
        }
        void State28()
        {
            switch (lexemStack.Peek())
            {
                case "<операнд>":
                    if (GetLexeme(nextLex) == "\n")
                        Convolution(3, "<присв>");
                    else if(GetLexeme(nextLex) == "+" || GetLexeme(nextLex) == "-" || GetLexeme(nextLex) == "*" || GetLexeme(nextLex) == "/" || GetLexeme(nextLex) == "^")
                        Shift();
                    else
                        Error(lexemStack.Peek(), "что-то из следующего списка: /n, +, -, *, /,  ^");
                    break;
                case "<знак>":
                    GoToState(34);
                    break;
                case "+":
                    GoToState(35);
                    break;
                case "-":
                    GoToState(36);
                    break;
                case "*":
                    GoToState(37);
                    break;
                case "/":
                    GoToState(38);
                    break;
                case "^":
                    GoToState(39);
                    break;
                default:
                    Error(lexemStack.Peek(), "что-то из следующего списка: +, -, *, /, ^");
                    break;
            }
        }
        void State29()
        {
            if (lexemStack.Peek() == "id")
                Convolution(1, "<операнд>");
        }
        void State30()
        {
            if (lexemStack.Peek() == "lit")
                Convolution(1, "<операнд>");
        }
        void State31()
        {
            switch (lexemStack.Peek())
            {
                case "as":
                    Shift();
                    break;
                case "<тип>":
                    GoToState(40);
                    break;
                case "integer":
                    GoToState(41);
                    break;
                case "float":
                    GoToState(42);
                    break;
                case "long":
                    GoToState(43);
                    break;
                default:
                    Error(lexemStack.Peek(), "либо integer, либо float, либо long");
                    break;
            }
        }
        void State32()
        {
            switch (lexemStack.Peek())
            {
                case ",":
                    Shift();
                    break;
                case "<спис_перем>":
                    GoToState(44);
                    break;
                case "id":
                    GoToState(22);
                    break;
                default:
                    Error(lexemStack.Peek(), "id после ,");
                    break;
            }
        }
        void State33()
        {
            switch (lexemStack.Peek())
            {
                case "\n":
                    Shift();
                    break;
                case "<спис_опер>":
                    GoToState(45);
                    break;
                case "<опер>":
                    GoToState(8);
                    break;
                case "<цикл>":
                    GoToState(9);
                    break;
                case "<присв>":
                    GoToState(10);
                    break;
                case "<опис>":
                    GoToState(11);
                    break;
                case "do":
                    GoToState(12);
                    break;
                case "id":
                    GoToState(13);
                    break;
                case "Dim":
                    GoToState(15);
                    break;
                default:
                    Error(lexemStack.Peek(), "либо do, либо id, либо Dim");
                    break;
            }
        }
        void State34()
        {
            switch (lexemStack.Peek())
            {
                case "<знак>":
                    Shift();
                    break;
                case "<операнд>":
                    GoToState(46);
                    break;
                case "id":
                    GoToState(29);
                    break;
                case "lit":
                    GoToState(30);
                    break;
                default:
                    Error(lexemStack.Peek(), "id или lit");
                    break;
            }
        }
        void State35()
        {
            if (lexemStack.Peek() == "+")
                Convolution(1, "<знак>");
        }
        void State36()
        {
            if (lexemStack.Peek() == "-")
                Convolution(1, "<знак>");
        }
        void State37()
        {
            if (lexemStack.Peek() == "*")
                Convolution(1, "<знак>");
        }
        void State38()
        {
            if (lexemStack.Peek() == "/")
                Convolution(1, "<знак>");
        }
        void State39()
        {
            if (lexemStack.Peek() == "^")
                Convolution(1, "<знак>");
        }
        void State40()
        {
            switch (lexemStack.Peek())
            {
                case "<тип>":
                    if (GetLexeme(nextLex) == "\n")
                        Convolution(0, "<иниц>");
                    else if (GetLexeme(nextLex) == "=")
                        Shift();
                    else Error(lexemStack.Peek(), "/n или = после integer, float или long");
                    break;
                case "<иниц>":
                    GoToState(47);
                    break;
                case "=":
                    GoToState(48);
                    break;
                default:
                    Error(lexemStack.Peek(), "= после integer, float или long");
                    break;
            }
        }
        void State41()
        {
            if (lexemStack.Peek() == "integer")
                Convolution(1, "<тип>");
        }
        void State42()
        {
            if (lexemStack.Peek() == "float")
                Convolution(1, "<тип>");
        }
        void State43()
        {
            if (lexemStack.Peek() == "long")
                Convolution(1, "<тип>");
        }
        void State44()
        {
            if (lexemStack.Peek() == "<спис_перем>")
                Convolution(3, "<спис_перем>");
        }
        void State45()
        {
            switch (lexemStack.Peek())
            {
                case "<спис_опер>":
                    Shift();
                    break;
                case "\n":
                    GoToState(49);
                    break;
                default:
                    Error(lexemStack.Peek(), "/n");
                    break;
            }
        }
        void State46()
        {
            if (lexemStack.Peek() == "<операнд>")
                Convolution(3, "<ариф_выр>");
        }
        void State47()
        {
            if (lexemStack.Peek() == "<иниц>")
                Convolution(5, "<опис>");
        }
        void State48()
        {
            switch (lexemStack.Peek())
            {
                case "=":
                    Shift();
                    break;
                case "<операнд>":
                    GoToState(50);
                    break;
                case "id":
                    GoToState(29);
                    break;
                case "lit":
                    GoToState(30);
                    break;
                default:
                    Error(lexemStack.Peek(), "id или lit после =");
                    break;
            }
        }
        void State49()
        {
            switch (lexemStack.Peek())
            {
                case "\n":
                    Shift();
                    break;
                case "loop":
                    GoToState(51);
                    break;
                case "<опер>":
                    GoToState(23);
                    break;
                case "<цикл>":
                    GoToState(9);
                    break;
                case "<присв>":
                    GoToState(10);
                    break;
                case "<опис>":
                    GoToState(11);
                    break;
                case "do":
                    GoToState(12);
                    break;
                case "id":
                    GoToState(13);
                    break;
                case "Dim":
                    GoToState(15);
                    break;
                default:
                    Error(lexemStack.Peek(), "loop для завершения do while или do, id, Dim для последующих действий");
                    break;
            }
        }
        void State50()
        {
            if (lexemStack.Peek() == "<операнд>")
                Convolution(2, "<иниц>");
        }
        void State51()
        {
            if (lexemStack.Peek() == "loop")
                Convolution(7, "<цикл>");
        }
        void Expr()
        {
            Queue<string> line = new Queue<string>();
            int count = 0;
            while(GetLexeme(nextLex) != "\n")
            {
                line.Enqueue((GetDijLexeme(nextLex)));
                Shift();
                stateStack.Push(100);
                count++;
            }
            Dijkstra(line);
            Convolution(count, "expr");
        }
        void Dijkstra(Queue<string> line)
        {
            Queue<string> revPolNat = OPN(line);
            Stack<String> stack = new Stack<String>();
            int m = 1;
            while(revPolNat.Count != 0)
            {
                string lexem = revPolNat.Dequeue();
                if(lexAnalis.CodeVariables.Contains(lexem) || lexAnalis.CodeLiterals.Contains(lexem))
                {
                    stack.Push(lexem);
                }
                else
                {
                    string temp = "";
                    for(int i = 0; i < 2; i++)
                    {
                        temp += stack.Pop() + " ";
                    }
                    matrix.Add($"M{m}: {lexem} {temp}");
                    stack.Push($"M{m}");
                    m++;
                }
            }
        }
        Queue<string> OPN(Queue<string> line)
        {
            Stack<string> stackOp = new Stack<string>();
            Queue<string> resultLine = new Queue<string>();
            while (line.Count != 0)
            {
                string lexem = line.Dequeue();
                if (lexem == "(")
                {
                    stackOp.Push(lexem);
                }
                else if (lexAnalis.CodeVariables.Contains(lexem) || lexAnalis.CodeLiterals.Contains(lexem))
                {
                    resultLine.Enqueue(lexem);
                }
                else if (lexem == "+" || lexem == "-" || lexem == "*" || lexem == "/" || lexem == "^" ||
                        lexem == "==" || lexem == "<>" || lexem == "<" || lexem == ">" ||
                        lexem == "or" || lexem == "and" || lexem == "not")
                {
                    int priority = LexemPriorit(lexem);
                    if (priority == 0)
                    {
                        stackOp.Push(lexem);
                    }
                    else if (stackOp.Count == 0)
                    {
                        stackOp.Push(lexem);
                    }
                    else if (priority > LexemPriorit(stackOp.Peek()))
                    {
                        stackOp.Push(lexem);
                    }
                    else
                    {
                        while (priority <= LexemPriorit(stackOp.Peek()))
                        {
                            resultLine.Enqueue(stackOp.Pop());
                        }
                        stackOp.Push(lexem);
                    }
                }
                else if (lexem == ")")
                {
                    while (stackOp.Peek() != "(")
                    {
                        resultLine.Enqueue(stackOp.Pop());
                        if(stackOp.Count == 0)
                        {
                            OpnError();
                            break;
                        }
                    }
                    stackOp.Pop();
                }
            }
            while(stackOp.Count != 0)
            {
                resultLine.Enqueue(stackOp.Pop());
            }
            return resultLine;
        }
        void OpnError()
        {
            try
            {
                throw new Exception("В выражении EXPR обнаружены несогласованные скобки!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Уведовление", MessageBoxButtons.OK);
            }
        }
        int LexemPriorit(string lexem)
        {
            int i = 0;
            switch (lexem)
            {
                case "+": i = 6; break;
                case "-": i = 6; break;
                case "*": i = 7; break;
                case "/": i = 7; break;
                case "^": i = 8; break;
                case "<>": i = 5; break;
                case "<": i = 5; break;
                case ">": i = 5; break;
                case "==": i = 5; break;
                case "or": i = 2; break;
                case "and": i = 3; break;
                case "not": i = 4; break;
                case "(": i = 0; break;
                case ")": i = 1; break;
            }
            return i;
        }
    }
}