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
        static bool isEnd = false;
        bool error = false;
        int state = 0;
        int lexnumber = 0;
        static Stack<string> stack = new Stack<string>();
        static Stack<int> stateStack = new Stack<int>();
        Lexem lexAnalis;
        public Syntax(Lexem lexem) => this.lexAnalis = lexem;
        public void CheckSyntax()
        {
            GoToState(0);
            while (!isEnd)
            {
                switch (state)
                {
                    case -1:
                        error = true;
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
                if (!error)
                    MessageBox.Show("Синтаксический разбор выполнен успешно", "Уведомление", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Синтаксический разбор был закончен с ошибкой", "Уведомление", MessageBoxButtons.OK);
                state = 0;
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
            stack.Push(GetLexeme(lexnumber));
            lexnumber++;
        }
        string GetLexeme(int number)
        {
            try
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
            catch
            {
                MessageBox.Show("Так как лексический анализ был произведен с ошибкой,\n то невозможно произвести синтаксический анализ", "", MessageBoxButtons.OK);
                state = -1;
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
            stack.Clear();
            stateStack.Clear();
            lexnumber = 0;
        }
        private void Convolution(int count, string N)
        {
            if(count == 0)
                stack.Push(N);
            else
            {
                for (int i = 0; i < count; i++)
                {
                    stack.Pop();
                    state = stateStack.Pop();
                    state = stateStack.Peek();
                }
                state = stateStack.Peek();
                stack.Push(N);
            }
        }
        void State0()
        {
            if(stack.Count == 0)
                Shift();
            switch (stack.Peek())
            {
                case "<программа>":
                    ProgramEnd();
                    break;
                case "Public":
                    GoToState(1);
                    break;
                default:
                    Error(stack.Peek(), "Public");
                    break;
            }
        }
        void State1()
        {
            switch (stack.Peek())
            {
                case "Public":
                    Shift();
                    break;
                case "Sub":
                    GoToState(2);
                    break;
                default:
                    Error(stack.Peek(), "Sub");
                    break;
            }
        }
        void State2()
        {
            switch (stack.Peek())
            {
                case "Sub":
                    Shift();
                    break;
                case "Main":
                    GoToState(3);
                    break;
                default:
                    Error(stack.Peek(), "Main");
                    break;
            }
        }
        void State3()
        {
            switch (stack.Peek())
            {
                case "Main":
                    Shift();
                    break;
                case "(":
                    GoToState(4);
                    break;
                default:
                    Error(stack.Peek(), "(");
                    break;
            }
        }
        void State4()
        {
            switch (stack.Peek())
            {
                case "(":
                    Shift();
                    break;
                case ")":
                    GoToState(5);
                    break;
                default:
                    Error(stack.Peek(), ")");
                    break;
            }
        }
        void State5()
        {
            switch (stack.Peek())
            {
                case ")":
                    Shift();
                    break;
                case "\n":
                    GoToState(6);
                    break;
                default:
                    Error(stack.Peek(), "/n");
                    break;
            }
        }
        void State6()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "do, id, dim");
                    break;
            }
        }
        void State7()
        {
            switch (stack.Peek())
            {
                case "<спис_опер>":
                    Shift();
                    break;
                case "\n":
                    GoToState(16);
                    break;
                default:
                    Error(stack.Peek(), "/n");
                    break;
            }
        }
        void State8()
        {
            if (stack.Peek() == "<опер>")
                Convolution(1, "<спис_опер>");
        }
        void State9()
        {
            if (stack.Peek() == "<цикл>")
                Convolution(1, "<опер>");
        }
        void State10()
        {
            if (stack.Peek() == "<присв>")
                Convolution(1, "<опер>");
        }
        void State11()
        {
            if (stack.Peek() == "<опис>")
                Convolution(1, "<опер>");
        }
        void State12()
        {
            switch (stack.Peek())
            {
                case "do":
                    Shift();
                    break;
                case "while":
                    GoToState(18);
                    break;
                default:
                    Error(stack.Peek(), "while");
                    break;
            }
        }
        void State13()
        {
            switch (stack.Peek())
            {
                case "id":
                    Shift();
                    break;
                case "=":
                    GoToState(19);
                    break;
                default:
                    Error(stack.Peek(), "=");
                    break;
            }
        }
        void State15()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "id");
                    break;
            }
        }
        void State16()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "do, id, Dim");
                    break;
            }
        }
        void State18()
        {
            switch (stack.Peek())
            {
                case "while":
                    Shift();
                    break;
                case "(":
                    Expr(8);
                    break;
                case "expr":
                    GoToState(26);
                    break;
                default:
                    Error(stack.Peek(), "expr");
                    break;
            }
        }
        void State19()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "id, lit");
                    break;
            }
        }
        void State21()
        {
            switch (stack.Peek())
            {
                case "<спис_перем>":
                    Shift();
                    break;
                case "as":
                    GoToState(31);
                    break;
                default:
                    Error(stack.Peek(), "as");
                    break;
            }
        }
        void State22()
        {
            switch (stack.Peek())
            {
                case "id":
                    if (GetLexeme(lexnumber) == "as")
                        Convolution(1, "<спис_перем>");
                    else if (GetLexeme(lexnumber) == ",")
                        Shift();
                    else Error(stack.Peek(), "as или , после id");
                    break;
                case ",":
                    GoToState(32);
                    break;
                default:
                    Error(stack.Peek(), ",");
                    break;
            }
        }
        void State23()
        {
            if (stack.Peek() == "<опер>")
                Convolution(3, "<спис_опер>");
        }
        void State24()
        {
            if (stack.Peek() == "EndSub")
                Convolution(9, "<программа>");
        }
        void State26()
        {
            switch (stack.Peek())
            {
                case "expr":
                    Shift();
                    break;
                case "\n":
                    GoToState(33);
                    break;
            }
        }
        void State27()
        {
            if (stack.Peek() == "<ариф_выр>")
                Convolution(1, "<присв>");
        }
        void State28()
        {
            switch (stack.Peek())
            {
                case "<операнд>":
                    if (GetLexeme(lexnumber) == "\n")
                        Convolution(3, "<присв>");
                    else if(GetLexeme(lexnumber) == "<знак>")
                        Shift();
                    else
                        Error(stack.Peek(), "/n, +, -, *, /,  ^");
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
                    Error(stack.Peek(), "+, -, *, /, ^");
                    break;
            }
        }
        void State29()
        {
            if (stack.Peek() == "id")
                Convolution(1, "<операнд>");
        }
        void State30()
        {
            if (stack.Peek() == "lit")
                Convolution(1, "<операнд>");
        }
        void State31()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "integer, float, long");
                    break;
            }
        }
        void State32()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "id");
                    break;
            }
        }
        void State33()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "do, id, Dim");
                    break;
            }
        }
        void State34()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "id или lit");
                    break;
            }
        }
        void State35()
        {
            if (stack.Peek() == "+")
                Convolution(1, "<знак>");
        }
        void State36()
        {
            if (stack.Peek() == "-")
                Convolution(1, "<знак>");
        }
        void State37()
        {
            if (stack.Peek() == "*")
                Convolution(1, "<знак>");
        }
        void State38()
        {
            if (stack.Peek() == "/")
                Convolution(1, "<знак>");
        }
        void State39()
        {
            if (stack.Peek() == "^")
                Convolution(1, "<знак>");
        }
        void State40()
        {
            switch (stack.Peek())
            {
                case "<тип>":
                    if (GetLexeme(lexnumber) == "\n")
                        Convolution(0, "<иниц>");
                    else if (GetLexeme(lexnumber) == "=")
                        Shift();
                    else Error(stack.Peek(), "/n или =");
                    break;
                case "<иниц>":
                    GoToState(47);
                    break;
                case "=":
                    GoToState(48);
                    break;
                default:
                    Error(stack.Peek(), "/n или =");
                    break;
            }
        }
        void State41()
        {
            if (stack.Peek() == "integer")
                Convolution(1, "<тип>");
        }
        void State42()
        {
            if (stack.Peek() == "float")
                Convolution(1, "<тип>");
        }
        void State43()
        {
            if (stack.Peek() == "long")
                Convolution(1, "<тип>");
        }
        void State44()
        {
            if (stack.Peek() == "<спис_перем>")
                Convolution(3, "<спис_перем>");
        }
        void State45()
        {
            switch (stack.Peek())
            {
                case "<спис_опер>":
                    Shift();
                    break;
                case "\n":
                    GoToState(49);
                    break;
                default:
                    Error(stack.Peek(), "/n");
                    break;
            }
        }
        void State46()
        {
            if (stack.Peek() == "<операнд>")
                Convolution(3, "<ариф_выр>");
        }
        void State47()
        {
            if (stack.Peek() == "<иниц>")
                Convolution(5, "<опис>");
        }
        void State48()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "id или lit");
                    break;
            }
        }
        void State49()
        {
            switch (stack.Peek())
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
                    Error(stack.Peek(), "loop, do, id, Dim");
                    break;
            }
        }
        void State50()
        {
            if (stack.Peek() == "<операнд>")
                Convolution(2, "<иниц>");
        }
        void State51()
        {
            if (stack.Peek() == "loop")
                Convolution(7, "<цикл>");
        }
        void Expr(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Shift();
                stateStack.Push(100);
            }
            Convolution(count + 1, "expr");
        }
    }
}
