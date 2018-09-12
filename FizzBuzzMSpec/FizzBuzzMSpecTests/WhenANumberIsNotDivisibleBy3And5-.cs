using FizzBuzzMSpec;
using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpecTests
{
    [Subject("When a number is not divisible by 3 and 5 should return that number")]
    public class WhenANumberIsNotDivisibleBy3And5_
    {
        //Arrange
        static int number = 1;

        static FizzBuzz fizzBuzz;

        Establish context = () =>
            fizzBuzz = new FizzBuzz();

        //Act
        static string actual;

        Because of = () =>
            actual = fizzBuzz.FizzBuzzer(number);

        //Assert
        static string expected = "1";

        It Should_Return_FizzBuzz = () =>
            actual.ShouldEqual(expected);
    }
}
