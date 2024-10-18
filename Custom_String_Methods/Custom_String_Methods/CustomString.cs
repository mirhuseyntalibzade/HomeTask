using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_String_Methods
{
    internal class CustomString
    {
        private string _input;
        public CustomString(string input)
        {
            _input = input;
        }
        public string[] CustomSplit(char seperator)
        {
            string[] result = [];
            string temp = "";
            int index = 0;
            for (int i = 0; i < _input.Length; i++)
            {
                if (seperator == _input[i])
                {
                    if (index >= result.Length)
                    {
                        Array.Resize(ref result, result.Length + 1);
                    }
                    result[index] = temp;
                    index++;
                    temp = "";
                }
                else
                {
                    temp += _input[i];
                }

            }
            if (temp.Length > 0)
            {
                if (index >= result.Length)
                {
                    Array.Resize(ref result, result.Length + 1);
                }
                result[index] = temp;
            }

            return result;
        }
        public string CustomReplace(char oldChar, char newChar)
        {
            string result = "";
            for (int i = 0; i < _input.Length; i++)
            {
                if (_input[i] == oldChar)
                {
                    result += newChar;
                }
                else
                {
                    result += _input[i];
                }
            }
            return result;
        }

        public int CustomLastIndexOf(string value)
        {
            int valueLength = value.Length;
            int inputLength = _input.Length;

            for (int i = inputLength - valueLength; i >= 0; i--)
            {
                bool matchFound = true;

                for (int j = 0; j < valueLength; j++)
                {
                    if (_input[i + j] != value[j])
                    {
                        matchFound = false;
                        break;
                    }
                }

                if (matchFound)
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
