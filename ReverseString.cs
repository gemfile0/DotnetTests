using System;
using System.Text;
using Xunit;

namespace DotnetTests
{
    public class ReverseString
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("dcba", Reverse("abcd"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("dcba  ", Reverse("  abcd"));
        }

        string Reverse(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                result.Insert(0, c);
            }

            return result.ToString();
        }
    }
}
