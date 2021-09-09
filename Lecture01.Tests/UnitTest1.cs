using System;
using Xunit;

namespace Lecture01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Program.IsLeapYear(1200).Equals("It is not possible to calculate leap years earlier that 1582. Please select another Year");

            Program.IsLeapYear(1581).Equals("It is not possible to calculate leap years earlier that 1582. Please select another Year");

            Program.IsLeapYear(2004).Equals(true);

            Program.IsLeapYear(1999).Equals(false);

            Program.IsLeapYear(2020).Equals(true);

            Program.IsLeapYear(2013).Equals(false);

            Program.IsLeapYear(2056).Equals(true);

            Program.IsLeapYear(2055).Equals(false);

            Program.IsLeapYear(2000).Equals(true);

            Program.IsLeapYear(2001).Equals(false);

            Program.IsLeapYear(2013).Equals(false);



        }
    }
}
