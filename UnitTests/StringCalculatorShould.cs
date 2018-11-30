using System;
using NUnit.Framework;
using FluentAssertions;

namespace UnitTests
{
    public class StringCalculatorShould
    {
        [Test]
        public void ReturnZeroGivenAnEmptyString()
        {
            var result = AddNumbers("");

            result.Should().Be(0);
        }

        [Test]
        public void ReturnNumberGivenASingleNumber()
        {
            var result = AddNumbers("1");
            result.Should().Be(1);
        }

        [Test]
        public void ReturnSumGivenTwoNumbers()
        {
            var result = AddNumbers("1,2");
            result.Should().Be(3);
        }

        [Test]
        public void ReturnSumGivenNNumbers()
        {
            var result = AddNumbers("1,2,3,4");
            result.Should().Be(10);
        }

        [Test]
        public void IgnoreNumbersGreaterThan1000()
        {
            var result = AddNumbers("1,2,3,4,1001,1000,5");
            result.Should().Be(1015);
        }

        public int AddNumbers(string numbers)
        {
            
            if (!string.IsNullOrEmpty(numbers))
            {
                var sum = 0;
                var arrayOfNumbers = numbers.Split(',');
                var count = arrayOfNumbers.Length;
                for (int i = 0; i < count; i++)
                    {
                        if (!(Convert.ToInt32(arrayOfNumbers[i]) >1000))
                            
                        sum = Convert.ToInt32(arrayOfNumbers[i]) + sum;
                       
                    }
                    return sum;
            }
            
            return 0;
        }
    }
}
