using FizzBuzzMSpec;
using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpecTests
{
    [Subject("When a number is a prime number should return Whiz")]
    public class WhenANumberIsAPrimeNumber
    {

        //Arrange
        static int number = 2;

        static FizzBuzz fizzBuzz;

        Establish context = () =>
            fizzBuzz = new FizzBuzz();

        //Act
        static string actual;

        Because of = () =>
            actual = fizzBuzz.FizzBuzzer(number);

        //Assert
        static string expected = "Whiz";

        It Should_Return_Whiz = () =>
            actual.ShouldEqual(expected);
    }
}
