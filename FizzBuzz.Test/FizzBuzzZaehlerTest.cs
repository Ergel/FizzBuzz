using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzZaehlerTest
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(7, "7")]
        [TestCase(0, "FizzBuzz")] // Edge case: Zero
        [TestCase(-3, "Fizz")] // Negative number divisible by 3
        [TestCase(-5, "Buzz")] // Negative number divisible by 5
        [TestCase(-15, "FizzBuzz")] // Negative number divisible by 3 and 5
        [TestCase(-7, "-7")] // Negative number not divisible by 3 or 5
        [TestCase(1, "1")] // Positive number not divisible by 3 or 5
        [TestCase(2, "2")] // Another positive number not divisible by 3 or 5
        public void GibtErwartetesErgebnisZurueck(int eingabe, string erwartet)
        {
            var ergebnis = FizzBuzzZaehler.FizzBuzz(eingabe);
            Assert.That(ergebnis, Is.EqualTo(erwartet));
        }
    }
}
