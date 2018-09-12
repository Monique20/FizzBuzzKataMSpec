using FizzBuzzMSpec;
using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpecTests
{
    [Subject("Given a number is Divisible by three, should return fizz")]
    public class WhenNumberIsDivisibleBy3
    {
        //Arrange
        static int number = 9;
        static FizzBuzz fizzBuzz;

        Establish context = () =>
            fizzBuzz = new FizzBuzz();

        //Act
        static string actual;

        Because of = () =>
            actual = fizzBuzz.FizzBuzzer(number);

        //Assert
        static string expected = "Fizz";

        It Should_Return_Fizz = () =>
            actual.ShouldEqual(expected);

    }
}
