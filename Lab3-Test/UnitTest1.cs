
using System;
using Lab3;

namespace Lab3_Review_Test;

public class UnitTest1
{
    [Theory]
    [InlineData("1 2 3", 6)] // Expected product: 1 * 2 * 3 = 6
    [InlineData("5 10 2", 100)] // Expected product: 5 * 10 * 2 = 100
    [InlineData("4 2 abc", 8)] // Expected product: 4 * 2 * 1 (default value for "abc") = 8
    [InlineData("-2 4 5", -40)]
    [InlineData("-4 6 abc", -24)]
    [InlineData("1 2", 0)]
    [InlineData("4 3", 0)]
    [InlineData("3 4 5 6", 60)]
    public void Challenge_1_Test(string numbers, int expectedProduct)
    {
        int actualProduct = Program.Challenge_1_Test(numbers);
        Assert.Equal(expectedProduct, actualProduct);
    }

    public static IEnumerable<object[]> TestData =>
       new List<object[]>
       {
    new object[] { 3, new decimal[] { 1m, 2m, 3m }, 2m },
    new object[] { 3, new decimal[] { 2m, 2m, 3m },  2.333333333m },
    new object[] { 3, new decimal[] { 7m, 9m, 17m },  11m },
       };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Challenge_2_Test(int num, decimal[] range, decimal expectedAverage)
    {
        decimal actualAverage = Program.Challenge_2_Test(num, range);
        int precisionAfterTheDecimalPoint = 9;
        Assert.Equal(expectedAverage, actualAverage, precisionAfterTheDecimalPoint);
    }


    [Theory]
    [InlineData(3, new int[] { 1, 2, 2, 3, 3, 3 })]
    [InlineData(2, new int[] { 1, 2, 2, 3, 3 })]
    [InlineData(1, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(3, new int[] { 3, 3, 3, 3, 3, 3 })]

    public void Challenge_4_Test(int mostFreq, int[] numbers)
    {
        int actualFreq = Program.Challenge_4_Test(numbers);
        Assert.Equal(mostFreq, actualFreq);
    }


    [Theory]
    [InlineData(555, new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 })]
    [InlineData(4, new int[] { -1, 2, -3, 4, -5 })]
    [InlineData(3, new int[] { 3, 3, 3, 3, 3, 3 })]
    public void Challenge_5(int highestNum, int[] numbers)
    {
        int highestNumFromFunction = Program.Challenge_5_Test(numbers);
        Assert.Equal(highestNum, highestNumFromFunction);
    }


    [Fact]
    public void GetWordsWithCharacterCount_ReturnsCorrectArray()
    {
        // Arrange
        string inputSentence = "The quick brown fox";
        string[][] expectedOutput = new string[][]
        {
                new string[] { "The", "3" },
                new string[] { "quick", "5" },
                new string[] { "brown", "5" },
                new string[] { "fox", "3" }
        };

        // Act
        string[][] result = Program.GetWordsWithCharacterCount(inputSentence);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void GetWordsWithCharacterCount_ReturnsArray()
    {
        // Arrange
        string inputSentence = "This is a test";

        // Act
        string[][] result = Program.GetWordsWithCharacterCount(inputSentence);

        // Assert
        Assert.NotNull(result);
        Assert.IsType<string[][]>(result);
    }

    [Fact]
    public void GetWordsWithCharacterCount_UsesDifferentSentencesWithSymbols()
    {
        // Arrange
        string inputSentence = "Hello! How's it going?";
        string[][] expectedOutput = new string[][]
        {
                new string[] { "Hello!", "6" },
                new string[] { "How's", "5" },
                new string[] { "it", "2" },
                new string[] { "going?", "6" }
        };

        // Act
        string[][] result = Program.GetWordsWithCharacterCount(inputSentence);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
}


