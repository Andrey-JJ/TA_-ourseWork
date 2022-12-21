using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAkursach
{
    public class Syntax
    {
        static bool isEnd = false;
        int state = 0;
        int lexnumber = 0;
        static Stack<string> stack = new Stack<string>();
        static Stack<int> stateStack = new Stack<int>();
        //List<(char, int)> list = new List<(char, int)>();
        Lexem lexAnalis;
        public Syntax(Lexem lexem)
        {
            this.lexAnalis = lexem;
        }
        public void CheckSyntax()
        {
            GoToState(0);
            while (!isEnd)
            {
                switch (state)
                {
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
        }
        void Shift()
        {
            stack.Push(GetLexeme(lexnumber));
            lexnumber++;
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
                    return "Something";
            }
        }
        void GoToState(int i)
        {
            stateStack.Push(i);
            this.state = i;
        }
        void State0()
        {
            if (GetLexeme(lexnumber) != "Public")
                throw new Exception();
        }
        void State1()
        {
            if (GetLexeme(lexnumber) != "Sub")
                throw new Exception();
            Shift();
        }
        void State2()
        {
            if (GetLexeme(lexnumber) != "Main")
                throw new Exception();
            Shift();
        }
        void State3()
        {
            if (GetLexeme(lexnumber) != "(")
                throw new Exception();
            Shift();
        }
        void State4()
        {
            if (GetLexeme(lexnumber) != ")")
                throw new Exception();
            Shift();
        }
        void State5()
        {
            if (GetLexeme(lexnumber) != "\n")
                throw new Exception();
            Shift();
        }
        void State6()
        {
            if (GetLexeme(lexnumber) != "")
                throw new Exception();
            Shift();
        }
        void State7()
        { }
        void State8()
        { }
        void State9()
        { }
        void State10()
        { }
        void State11()
        { }
        void State12()
        { }
        void State13()
        { }
        void State15()
        { }
        void State16()
        { }
        void State18()
        { }
        void State19()
        { }
        void State21()
        { }
        void State22()
        { }
        void State23()
        { }
        void State24()
        { }
        void State26()
        { }
        void State27()
        { }
        void State28()
        { }
        void State29()
        { }
        void State30()
        { }
        void State31()
        { }
        void State32()
        { }
        void State33()
        { }
        void State34()
        { }
        void State35()
        { }
        void State36()
        { }
        void State37()
        { }
        void State38()
        { }
        void State39()
        { }
        void State40()
        { }
        void State41()
        { }
        void State42()
        { }
        void State43()
        { }
        void State44()
        { }
        void State45()
        { }
        void State46()
        { }
        void State47()
        { }
        void State48()
        { }
        void State49()
        { }
        void State50()
        { }
        void State51()
        { }
        void Expr()
        {

        }
    }
}
