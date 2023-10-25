using System;

namespace labMID_010
{
    public class LL1Parser
    {
        private readonly string input;
        public int currentPosition;

        public LL1Parser(string input)
        {
            this.input = input;
            currentPosition = 0;
        }

        public void Parse()
        {
            S();
        }

        private void S()
        {
            E();
            Match('$');
        }

        private void E()
        {
            T();
            EPrime();
        }

        private void EPrime()
        {
            if (Match('+'))
            {
                T();
                EPrime();
            }
        }

        private void T()
        {
            F();
            TPrime();
        }

        private void TPrime()
        {
            if (Match('*'))
            {
                F();
                TPrime();
            }
        }

        private void F()
        {
            if (Match('('))
            {
                E();
                Match(')');
            }
            else
            {
                Match('i');
                Match('d');
            }
        }

        private bool Match(char expected)
        {
            if (currentPosition >= input.Length)
            {
                return false;
            }

            if (input[currentPosition] == expected)
            {
                currentPosition++;
                return true;
            }

            return false;
        }
    }
}

