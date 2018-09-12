using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzMSpec;
using Machine.Specifications;
using Machine.Specifications.Model;

namespace FizzBuzzMSpecTests
{
    [Subject("When a number is divisible by 3 and 5 should return FizzBuzz")]
    public class WhenANumberIsDivisableBy3And5
    {
        //Arrange
        static int number = 15;

        static FizzBuzz fizzBuzz;

        Establish context = () =>
           fizzBuzz = new FizzBuzz();

        //Act
        static string actual;

        Because of = () =>
           actual = fizzBuzz.FizzBuzzer(number);

        //Assert
        static string expected = "FizzBuzz";

        It Should_Return_FizzBuzz = () =>
           actual.ShouldEqual(expected);
    }
}
