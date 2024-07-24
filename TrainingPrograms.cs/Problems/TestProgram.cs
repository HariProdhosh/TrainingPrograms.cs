namespace TrainingPrograms.cs.Problems
{
    public class TestProgram : TestMethods
    {
        public static void Main()
        {
            SwapTwoVariables(20, 25);
            ArmStrongNumber(153);
            FibonnaciSeries(10);
            ReverseANumber(12321);
            FactorialNumebr(5);
            FindNumbersStartingWith1UsingString([12, 121, 31, 141, 5]);
            FindNumbersStartingWith1([121, 131, 41, 51, 100, 11]);
            FindDuplicateCharacters("Hari Prodhosh");
            CheckTheStringsAreAnagram("Hari", "riha");
            FindTheSecondLargestNumber([10, 80, 20, 40, 30, 90]);
            CheckPalindrome("mom");
            CheckRepeatedLettersAndPrintCount("ApPlE");
            CheckRepeatedWordsAndPrintCount("Hi how are you you how nice hi");
            CheckDuplicateElements([12, 90, 82, 34, 13, 12, 99, 13]);
            DecimalToBinary(25);
            RemoveSpecialCharactersUsingRegex("Hi!9, Hello World!!");
            ReplaceCharactersInTheGivenString("SuRvey Spparow");
            CountVowelsAndConsonantsInTheGivenString("SuRvey Spparow");
            AddAllTheElementsInTheArray([10, 20, 30, 40, 50]);
            ReverseTheGivenArray([1, 2, 3, 4, 5, 6, 7]);
            SortTheNumbersInTheGivenArray([10, 3, 5, 6, 2, 8, 1, 7], "Dsc");
        }
    }
}
