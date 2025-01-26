using OpenQA.Selenium.DevTools.V125.HeapProfiler;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using TrainingPrograms.cs.ChromeActions.ControlsExtension;

namespace TrainingPrograms.cs.Problems
{
    public class TestMethods
    {
        /// <summary>
        /// inp a=10,b=20
        /// op a=20,b=10
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SwapTwoVariables(int a, int b)
        {
            Console.WriteLine($"Before swapping: a={a}, b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping: a={a}, b={b}");
        }

        public static void ArmStrongNumber(int number)
        {
            int temp, sum = 0, reminder;
            temp = number;
            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                sum = sum + (reminder * reminder * reminder);
            }

            if (temp == sum)
            {
                Console.WriteLine($"The given number is a armstrong number: {temp}");
            }
            else
            {
                Console.WriteLine($"The given number is not a armstrong number: {temp}");
            }
        }

        public static void FibonnaciSeries(int numbersToBePrint)
        {
            int num1 = 0, num2 = 1;
            for (int i = 0; i < numbersToBePrint; i++)
            {
                Console.WriteLine($"{num1}, iteration: {i}");
                int num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
        }

        public static void ReverseANumber(int number)
        {
            int rev = 0, reminder, temp = number;
            while (number > 0)
            {
                reminder = number % 10;
                rev = (rev * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine($"The reverse of the given number: {temp} is {rev}");
            if (temp == rev)
            {
                Console.WriteLine($"The given number: {temp} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The given number: {temp} is not a palindrome");
            }
        }

        public static void FactorialNumebr(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
                if (i == number)
                {
                    Console.WriteLine($"The factorial value of the given number: {number} is: {fact}");
                }
            }
        }

        public static void FindNumbersStartingWith1UsingString(int[] numbers)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (number.ToString().StartsWith("1"))
                {
                    result.Add(number);
                }
            }
            Console.WriteLine($"The numbers starts with 1 are: {string.Join(",", result)}");
        }

        public static void FindNumbersStartingWith1(int[] num)
        {
            List<int> result = new List<int>();
            foreach (var item in num)
            {
                int temp = item;
                while (temp > 0)
                {
                    temp /= 10;
                    if (temp == 1)
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine($"The values starts with 1 are as follows: {string.Join(",", result)}");
        }

        public static void FindDuplicateCharacters(string input)
        {
            input = input.ToUpper();
            Dictionary<char, int> processedValues = new();
            foreach (char c in input)
            {
                if (processedValues.ContainsKey(c))
                {
                    processedValues[c]++;
                }
                else
                {
                    processedValues.Add(c, 1);
                }
            }
            Console.WriteLine($"The duplicate characters in the given string: {input} is as follows");
            foreach (var c in processedValues)
            {
                if (c.Value > 1)
                {
                    Console.WriteLine($"The character {c.Key} is repeated for {c.Value} times");
                }
            }
        }

        public static bool CheckTheStringsAreAnagram(string input1, string input2)
        {
            input1 = input1.ToLower().Replace(" ", "");
            input2 = input2.ToLower().Replace(" ", "");
            Dictionary<char, int> dic = new();
            if (input1.Length != input2.Length)
            {
                Console.WriteLine($"The given strings {input1} and {input2} are not Anagram");
                return false;
            }
            foreach (char item in input1)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            foreach (char item in input2)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]--;
                }
                else
                {
                    Console.WriteLine($"The given strings {input1} and {input2} are not Anagram");
                    return false;
                }
            }
            foreach (var item in dic.Values)
            {
                if (item != 0)
                {
                    Console.WriteLine($"The given strings {input1} and {input2} are not Anagram");
                    return false;
                }
            }
            Console.WriteLine($"The given strings {input1} and {input2} are Anagram");
            return true;
        }

        public static void FindTheSecondLargestNumber(int[] num)
        {
            int max = 0, nextmax = 0;
            foreach (var item in num)
            {
                if (item > max)
                {
                    nextmax = max;
                    max = item;
                }
                else if (item > nextmax && item != max)
                {
                    nextmax = item;
                }
            }
            Console.WriteLine($"The second larget number in the given array is {nextmax}");
        }

        public static void CheckPalindrome(string inp)
        {
            inp.ToLower();
            int last = inp.Length - 1;
            for (int i = 0; i < inp.Length / 2; i++)
            {
                if (inp[i] != inp[last])
                {
                    Console.WriteLine($"The given string: {inp} is not a palindrome");
                    break;
                }
                last--;
            }
            Console.WriteLine($"The given string: {inp} is a palindrome");
        }

        public static void CheckRepeatedLettersAndPrintCount(string inp)
        {
            inp = inp.ToLower();
            Dictionary<char, int> dic = new();
            foreach (char c in inp)
            {
                if (char.IsLetter(c))
                {
                    if (dic.ContainsKey(c))
                    {
                        dic[c]++;
                    }
                    else
                    {
                        dic.Add(c, 1);
                    }
                }
            }
            foreach (var c in dic)
            {
                Console.WriteLine($"The character {c.Key} is repeated {c.Value} times");
            }
        }

        public static void CheckRepeatedWordsAndPrintCount(string inp)
        {
            inp = inp.ToLower();
            Dictionary<string, int> dic = new();
            foreach (var item in inp.Split(" "))
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"The word {item.Key} is repeated {item.Value} times");
            }
        }

        public static void CheckDuplicateElements(int[] inp)
        {
            Dictionary<int, int> dic = new();
            foreach (var item in inp)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic.Add(item, 1);
                }
            }
            foreach (var item in dic)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"The number: {item.Key} is repeated {item.Value} times");
                }
            }
        }

        public static void DecimalToBinary(int inp)
        {
            if (inp == 0)
            {
                Console.WriteLine($"The binary value for the given input {inp} is 0");
            }
            int temp = inp, rem;
            string res = "";
            while (temp > 0)
            {
                rem = temp % 2;
                res = rem + res;
                temp /= 2;
            }
            Console.WriteLine($"The binary value for the given input {inp} is {res}");
        }

        public static void RemoveSpecialCharactersUsingRegex(string inp)
        {
            string pattern = "[^a-zA-Z0-9 ]";//Using ^ will keep things said after it
                                             //string pattern = "[a-zA-Z0-9 ]";//Not using ^ will remove things said after it
                                             //string pattern = @"[^\w ]";//Will remove the special characters, since w means word
                                             //string pattern = @"[\s]";//Will remove the space
                                             //string pattern = @"[^\d]";//Will keep only numbers, since d means digits
            string res = Regex.Replace(inp, pattern, "");
            Console.WriteLine($"The given string without the special character is: {res}");
        }

        public static void ReplaceCharactersInTheGivenString(string inp)
        {
            Console.WriteLine($"The given string is: {inp}");
            Dictionary<char, char> dic = new()
        {
            {'S','R' },
            {'R','S' },
            {'r','s' },
            {'s','r' }
        };
            foreach (char i in inp)
            {
                if (dic.ContainsKey(i))
                {
                    Console.Write(dic[i]);
                }
                else
                {
                    Console.Write(i);
                }
            }
        }

        public static void CountVowelsAndConsonantsInTheGivenString(string inp)
        {
            string pattern = @"[^a-zA-Z0-9]";
            string res = Regex.Replace(inp, pattern, "");
            int vow = 0, con = 0;
            foreach (char i in res)
            {
                if (i == 'a' | i == 'e' | i == 'i' | i == 'o' | i == 'u' | i == 'A' | i == 'E' | i == 'I' | i == 'O' | i == 'U')
                {
                    vow++;
                }
                else
                {
                    con++;
                }
            }
            Console.WriteLine($"Consonant = {con}, Vowels = {vow}");
        }

        public static void AddAllTheElementsInTheArray(int[] inp)
        {
            int res = 0;
            foreach (int i in inp)
            {
                res = res + i;
            }
            Console.WriteLine($"The total value of the given array is: {res}");
        }

        public static void ReverseTheGivenArray(int[] inp)
        {
            int len = inp.Length;
            int[] rev = new int[len];
            for (int i = 0; i < len; i++)
            {
                rev[i] = inp[len - 1 - i];
            }
            Console.WriteLine($"The reversed givenarray is: {string.Join(",", rev)}");
        }

        public static void SortTheNumbersInTheGivenArray(int[] inp, string ascOrDsc)
        {
            for (int i = 0; i < inp.Length - 1; i++)
            {
                for (int j = 0; j < inp.Length - 1 - i; j++)
                {
                    if (ascOrDsc.Contains("asc", StringComparison.OrdinalIgnoreCase))
                    {
                        if (inp[j] > inp[j + 1])
                        {
                            int temp = inp[j];
                            inp[j] = inp[j + 1];
                            inp[j + 1] = temp;
                        }
                    }
                    else if (ascOrDsc.Contains("dsc", StringComparison.OrdinalIgnoreCase))
                    {
                        if (inp[j] < inp[j + 1])
                        {
                            int temp = inp[j];
                            inp[j] = inp[j + 1];
                            inp[j + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(",", inp));
        }

        public static void ChecKTheNumberIsOddOrEven(int inp)
        {
            if (inp % 2 == 0)
            {
                Console.WriteLine($"The given number {inp} is an Even num");
            }
            else
            {
                Console.WriteLine($"The given number {inp} is an Odd num");
            }
        }

        /// <summary>
        /// inp=7
        /// op=prime
        /// </summary>
        /// <param name="inp"></param>
        /// <returns></returns>
        public static bool CheckTheNumberIsAPrimeOrNot(int inp)
        {
            if (inp <= 1)
            {
                Console.WriteLine($"The given number {inp} is not a prime number");
                return false;
            }
            if (inp % 2 == 0)
            {
                Console.WriteLine($"The given number {inp} is not a prime number");
                return false;
            }

            if (inp == 2)
            {
                Console.WriteLine($"The given number {inp} is a prime number");
                return true;
            }
            for (int i = 3; i < Math.Sqrt(inp); i += 2)
            {
                if (inp % i == 0)
                {
                    Console.WriteLine($"The given number {inp} is not a prime number");
                    return false;
                }
            }
            Console.WriteLine($"The given number {inp} is a prime number");
            return true;
        }

        /// <summary>
        /// inp num1=10,num2=20,num3=15
        /// op=20
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        public static void FindTheLargestNumberFromTheGIvenThreeNumbers(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The number {num1} is the greatest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The number {num2} is the greatest");
            }
            else
            {
                Console.WriteLine($"The number {num3} is the greatest");
            }
        }

        /// <summary>
        /// inp=1234
        /// op=10
        /// </summary>
        /// <param name="inp"></param>
        public static void SumOfAllTheDigitsInTheGivenNumber(int inp)
        {
            int temp = inp;
            int sum = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                sum = sum + rem;
                temp = temp / 10;
            }
            Console.WriteLine($"The sum of the numbers in the given number {inp} is {sum}");
        }

        /// <summary>
        /// inp=321
        /// op=3
        /// </summary>
        /// <param name="inp"></param>
        public static void CountDigitsInAGivenInteger(int inp)
        {
            int count = 0, temp = inp;
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }
            Console.WriteLine($"The count of digits in the given number {inp} is {count}");
        }

        /// <summary>
        /// 3 2 1
        /// 3 2
        /// 3
        /// </summary>
        /// <param name="numb"></param>
        public static void PrintNumbersInTheRangeAsPettern(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                for (int j = numb; i <= j; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 1
        /// 1 2
        /// 1 2 3
        /// </summary>
        public static void PrintNumbersInPattern(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// *
        /// * *
        /// * * *
        /// * * * *
        /// * * * * *
        /// </summary>
        /// <param name="numberOfRows"></param>
        public static void PrintHalfPyramid(int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// * * * * *
        /// * * * *
        /// * * *
        /// * *
        /// *
        /// </summary>
        /// <param name="numberOfRows"></param>
        public static void PrintInvertedHalfPyramid(int numberOfRows)
        {
            for (int i = numberOfRows; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        ///        *
        ///      * * *
        ///    * * * * *
        ///  * * * * * * *
        ///* * * * * * * * *
        /// </summary>
        /// <param name="numberOfRows"></param>
        public static void PrintFullPyramid(int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = numberOfRows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        ///* * * * * * * * *
        ///  * * * * * * *
        ///    * * * * *
        ///      * * *
        ///        *
        /// </summary>
        /// <param name="numberOfRows"></param>
        public static void PrintInvertedFullPyramid(int numberOfRows)
        {
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = numberOfRows; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
            }
        }

        /// <summary>
        ///        *
        ///      * * *
        ///    * * * * *
        ///  * * * * * * *
        ///* * * * * * * * *
        ///  * * * * * * *
        ///    * * * * *
        ///      * * *
        ///        *
        /// </summary>
        /// <param name="numberOfRows"></param>
        public static void PrintDiamondPattern(int numberOfRows)
        {
            if (numberOfRows % 2 == 0)
            {
                numberOfRows++;
            }
            for (int i = 0; i < numberOfRows - 1; i++)
            {
                for (int j = numberOfRows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = numberOfRows; j >= i; j--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
            }
        }

        /// <summary>
        /// "( { [ ] } )" => true
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool CheckValidPranthesis(string str)
        {
            Stack<char> stack = new Stack<char>();

            if (str.Length % 2 != 0)
            {
                return false;
            }

            foreach (var item in str)
            {
                if (item == '{' || item == '(' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == '}' && stack.Peek().Equals('{'))
                {
                    stack.Pop();
                }
                else if (item == ')' && stack.Peek().Equals('('))
                {
                    stack.Pop();
                }
                else if (item == ']' && stack.Peek().Equals('['))
                {
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// inp=program
        /// out=
        ///        G
        ///       GR
        ///      GRA
        ///     GRAM
        ///    GRAMP
        ///   GRAMPR
        ///  GRAMPRO
        /// </summary>
        /// <param name="str"></param>
        public static void PrintTheStringFromCentreToEndFollowedByStart(string str)
        {
            //List<string> res = new();
            //var mid = str.Length / 2;
            //for (int i = mid; i < str.Length; i++)
            //{
            //    res.Add(str[i].ToString());
            //}
            //for (int i = 0; i < mid; i++)
            //{
            //    res.Add(str[i].ToString());
            //}
            //for (int i = 0; i < res.Count; i++)
            //{
            //    for (int j = str.Length - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(res[j].ToUpper());
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - i - 1; j++)
                {
                    Console.Write(" ");
                }
                int mid = str.Length / 2;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(str[mid].ToString().ToUpper());
                    mid++;
                    if (mid == str.Length)
                    {
                        mid = 0;
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// inp=a1b10
        /// op=abbbbbbbbbb
        /// </summary>
        public static void ExpandTheGivenString(string str)
        {
            Console.WriteLine($"The given input is {str}");
            Dictionary<char, string> dic = new();
            //for (int i = 0; i < str.Length; i++)  //found better way so commenting
            //{
            //    if (char.IsLetter(str[i]))
            //    {
            //        dic.Add(str[i], "0");
            //    }
            //    if (char.IsDigit(str[i]) && char.IsLetter(str[i - 1]))
            //    {
            //        dic[str[i - 1]] = str[i].ToString();
            //    }
            //    if (char.IsDigit(str[i]) && char.IsDigit(str[i - 1]))
            //    {
            //        dic[str[i - 2]] = dic.Last().Value + str[i];
            //    }
            //}
            //foreach (var item in dic)
            //{
            //    for (int i = 0; i < int.Parse(item.Value); i++)
            //    {
            //        Console.Write(item.Key);
            //    }
            //}
            char ch = '$';
            string num = "";
            for (int i = 0; i < str.Length; i++)
            {
                char newRes = str[i];
                if (char.IsLetter(str[i]))
                {
                    if (ch != '$' && !string.IsNullOrEmpty(num))
                    {
                        dic.Add(ch, num!);
                        num = null!;
                    }
                    ch = newRes;
                }
                else if (char.IsDigit(str[i]))
                {
                    num = num + str[i];
                    if (i == str.Length - 1 && !dic.ContainsKey(ch))
                    {
                        dic.Add(ch, num);
                    }
                }
            }
            foreach (var item in dic)
            {
                for (int i = 0; i < int.Parse(item.Value); i++)
                {
                    Console.Write(item.Key);
                }
            }
        }

        /// <summary>
        /// 01 07 13 19 25 31
        /// 02 08 14 20 26
        /// 03 09 15 21
        /// 04 10 16
        /// 05 11
        /// 06
        /// </summary>
        /// <param name="enterNumberOfRows"></param>
        public static void PrintNumbersInRageAsRows(int enterNumberOfRows)
        {
            int temp = enterNumberOfRows;
            for (int i = 1; i <= enterNumberOfRows; i++)
            {
                int num = i;
                for (int j = temp; j >= i; j--)
                {
                    if (num <= 9)
                    {
                        Console.Write($"0{num} ");
                    }
                    else
                    {
                        Console.Write($"{num} ");
                    }
                    num += enterNumberOfRows;
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Example: [4, 6, 23, 10, 1, 3] the output should return true because 4 + 6 + 10 + 3 = 23
        /// Input: new int[] {5,7,16,1,2}
        /// Output: false
        /// Input: new int[] {3,5,-1,8,12}
        /// Output: true
        /// </summary>
        /// <param name="inp"></param>
        public static string VerifyTheInputNumbersStoredInArray(int[] inpList)//yet to complete inp-[3, 5, 10, 18, 19, 4, 8, 12], op-true
        {
            var val = inpList.ToList();
            val.Sort();
            int max = val.Last();
            val.Remove(max);
            for (int i = 0; i < val.Count; i++)
            {
                int result = val[i];
                for (int j = i + 1; j < val.Count; j++)
                {
                    result += val[j];
                    if (result == max)
                    {
                        return "true";
                    }
                    else if (result > max)
                    {
                        break;
                    }
                }
            }
            return "false";
        }

        /// <summary>
        /// 0 1 2 3 4 5 6
        /// * * * * * * * 0
        /// * *       * * 1
        /// *   *   *   * 2
        /// *     *     * 3
        /// *   *   *   * 4
        /// * *       * * 5
        /// * * * * * * * 6
        /// </summary>
        /// <param name="rowCount"></param>
        public static void PrintHourGlassPattern(int rowCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if (i == j | i == 0 | i == rowCount - 1 | j == 0 | j == rowCount - 1 | i + j == rowCount - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static int recursiveHelper(int inp)
        {
            if (inp <= 1)
            {
                //Console.WriteLine("if = " + inp);
                return inp;
            }
            else
            {
                //Console.WriteLine("else = " + inp);
                return recursiveHelper(inp - 1) + recursiveHelper(inp - 2);
            }
        }

        public static int FibonaciUsingRecursive(int inp)
        {
            for (int i = 0; i < inp; i++)
            {
                Console.Write(recursiveHelper(i) + " ");
            }
            return inp;
        }

        /// <summary>
        /// Input: haystack = "sadbutsad", needle = "sad"
        /// Explanation: "sad" occurs at index 0 and 6.
        /// The first occurrence is at index 0, so we return 0.
        /// Output: 0
        ///
        /// Input: haystack = "leetcode", needle = "leeto"
        /// Output: -1
        /// Explanation: "leeto" did not occur in "leetcode", so we return -1.
        /// </summary>
        public static void FindIndexOfFirstOccurrenceInString(string inp, string subStr)//using sliding window concept
        {
            if (subStr.Length > inp.Length)
            {
                Console.WriteLine("-1");
                return;
            }
            for (int i = 0; i < inp.Length + 1 - subStr.Length; i++)
            {
                string str = "";
                int j = 0, k = i;
                while (j < subStr.Length)
                {
                    str += inp[k++];
                    j++;
                }
                if (str == subStr)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("-1");
            return;
        }

        public static void SplitNumbersAndTextInTheGivenString(string str)
        {
            string textReg = @"[^a-zA-Z]";
            string numbReg = @"[^\d]";
            //string numbReg = @"[^0-9]";
            string text, numb;
            text = Regex.Replace(str, textReg, "");
            numb = Regex.Replace(str, numbReg, "");
            Console.WriteLine($"Text is {text}, number is {numb}");
        }
    }
}