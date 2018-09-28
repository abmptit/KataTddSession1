namespace FooBarQixProject
{
    using System;

    public static class FooBarQix
    {
        public static string Compute(string input)
        {
            var decimalInput = Convert.ToDecimal(input);

            string replacedWord = DividedReplace(decimalInput);
            replacedWord += ContainsReplace(input);

            return
                replacedWord.Contains("Foo") ||
                replacedWord.Contains("Bar") ||
                replacedWord.Contains("Qix")
                ?
                    replacedWord :
                    decimalInput.ToString().Replace('0', '*');
        }

        private static string DividedReplace(decimal decimalInput)
        {
            string replacedString = String.Empty;

            if (decimalInput % 3 == 0)
            {
                replacedString += "Foo";
            }

            if (decimalInput % 5 == 0)
            {
                replacedString += "Bar";
            }

            if (decimalInput % 7 == 0)
            {
                replacedString += "Qix";
            }

            return replacedString;
        }

        private static string ContainsReplace(string input)
        {
            string replacedString = String.Empty;

            foreach (char car in input)
            {
                switch (car)
                {
                    case ('3'):
                        replacedString += "Foo";
                        break;
                    case ('5'):
                        replacedString += "Bar";
                        break;
                    case ('7'):
                        replacedString += "Qix";
                        break;
                    case ('0'):
                        replacedString += "*";
                        break;
                }
            }

            return replacedString;
        }
    }
}
