using System.Text.RegularExpressions;

namespace TrainingPrograms.cs.Problems
{
    public class TestMethods
    {
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
    }
}
