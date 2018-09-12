using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzMSpec;
using Machine.Specifications;

namespace FizzBuzzMSpecTests
{
    [Subject("When a number is divisible by 5 should return Buzz")]
    public class WhenANumberIsDivisibleBy5
    {
        //Arrange
        static int number = 10;

        static FizzBuzz fizzBuzz;

        Establish context = () =>
            fizzBuzz = new FizzBuzz();

        //Act
       static string actual;

       Because of = () =>
            actual = fizzBuzz.FizzBuzzer(number);

        //Assert
        static string expected = "Buzz";

        It Should_Return_Buzz = () =>
            actual.ShouldEqual(expected);
    }
}
