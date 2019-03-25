using System;
using Xunit;
using isen.DotNet.Library.Lists;

namespace isen.DotNet.Library.Tests
{
    public class MyCollectionStringTest
    {
        [Fact]
        public void CountTest()
        {
            var list = new MyCollection<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            Assert.True(list.Count == 3);
        }

        [Fact]
        public void AddTest()
        {
            var list = new MyCollection<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            var targetArray = new string[] {"A","B","C"};
            Assert.Equal(targetArray, list.Values);
        }

        [Fact]
        public void IndexTest()
        {
            var list = new MyCollection<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            Assert.True(list[0] == "A");
            Assert.True(list[1] == "B");
            Assert.True(list[2] == "C");

            list[0] = "Z";
            Assert.True(list[0] == "Z");
        }

        [Fact]
        public void RemoveAtTest()
        {
            var list = new MyCollection<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            
            try
            {
                list.RemoveAt(5);
            }
            catch(Exception e)
            {
                Assert.True(e is IndexOutOfRangeException);
            }

            list.RemoveAt(0);
            Assert.True(list.Count == 3);
            Assert.True(list[0] == "B");
            Assert.True(list[1] == "C");
            Assert.True(list[2] == "D");

            list.RemoveAt(1);
            Assert.True(list.Count == 2);
            Assert.True(list[0] == "B");
            Assert.True(list[1] == "D");

            list.RemoveAt(1);
            Assert.True(list.Count == 1);
            Assert.True(list[0] == "B");

            list.RemoveAt(0);
            Assert.True(list.Count == 0);

            try
            {
                list.RemoveAt(0);
            }
            catch(Exception e)
            {
                Assert.True(e is IndexOutOfRangeException);
            }
            try
            {
                list.RemoveAt(-1);
            }
            catch(Exception e)
            {
                Assert.True(e is IndexOutOfRangeException);
            }
        }
    }
}