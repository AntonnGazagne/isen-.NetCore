using System;
using System.Collections.Generic;
using Xunit;
using isen.DotNet.Library.Lists;

namespace isen.DotNet.Library.Tests
{
    public class MyCollectionCharTest
    {
        [Fact]
        public void CountTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('C');
            Assert.True(list.Count == 3);
        }

        [Fact]
        public void AddTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('C');
            var targetArray = new char[] {'A','B','C'};
            Assert.Equal(targetArray, list);
        }

        [Fact]
        public void IndexTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('C');
            Assert.True(list[0] == 'A');
            Assert.True(list[1] == 'B');
            Assert.True(list[2] == 'C');

            list[0] = 'Z';
            Assert.True(list[0] == 'Z');
        }

        [Fact]
        public void RemoveAtTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('C');
            list.Add('D');

            
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
            Assert.True(list[0] == 'B');
            Assert.True(list[1] == 'C');
            Assert.True(list[2] == 'D');

            list.RemoveAt(1);
            Assert.True(list.Count == 2);
            Assert.True(list[0] == 'B');
            Assert.True(list[1] == 'D');

            list.RemoveAt(1);
            Assert.True(list.Count == 1);
            Assert.True(list[0] == 'B');

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

        [Fact]
        public void IndexOfTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('B');
            list.Add('C');
            Assert.True(list.IndexOf('A') == 0);
            Assert.True(list.IndexOf('B') == 1);
            Assert.True(list.IndexOf('C') == 3);
            Assert.True(list.IndexOf('Z') < 0);

            #pragma warning disable xUnit2017
            Assert.True(list.Contains('A'));
            Assert.False(list.Contains('Z'));
            #pragma warning restore xUnit2017
        }

        [Fact]
        public void RemoveTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('B');
            list.Add('C');

            Assert.True(list.Remove('B'));
            Assert.True(list.Count == 3);
            Assert.True(list[2] == 'C');

            Assert.False(list.Remove('Z'));
        }

        [Fact]
        public void InsertTest()
        {
            var list = new MyCollection<char>();
            list.Insert(0,'C');//C
            list.Insert(0,'B');//BC
            list.Insert(0,'A');//ABC
            list.Insert(3,'D');//ABCD
            list.Insert(2,'b');//ABbCD

            var targetArray = 
                new char[] {'A', 'B', 'b', 'C', 'D'};
                Assert.Equal(targetArray, list);

            try
            {
                list.Insert(-1,'Z');
            }
            catch(Exception e)
            {
                Assert.True(e is ArgumentOutOfRangeException);
            }

            try
            {
                list.Insert(6,'Z');
            }
            catch(Exception e)
            {
                Assert.True(e is ArgumentOutOfRangeException);
            }
        }

        [Fact]
        public void EmuratorTest()
        {
            var list = new MyCollection<char>();
            list.Add('A');
            list.Add('B');
            list.Add('B');
            list.Add('C');

            Assert.True(list is IEnumerable<char>);

            var targetArray = 
                new char[] {'A', 'B', 'B', 'C'};
            foreach(var item in list)
            {
                Assert.True(true);
            }
            Assert.Equal(targetArray, list);
        }

        [Fact]
        public void CopyToTest()
        {
            var list = new MyCollection<char>{ 'A' , 'B', 'C' };

            var biggerArray = new char[] {'0', '1', '2', 'a', 'b', 'c', 'd'};
            var biggerExpected = new char[] {'0', '1', '2', 'A', 'B', 'C', 'd'};
            list.CopyTo(biggerArray, 3);
            Assert.Equal(biggerArray,biggerExpected);
            
            var equalArray = new char[] {'0', '1', '2', 'a', 'b', 'c'};
            var equalExpected = new char[] {'0', '1', '2', 'A', 'B', 'C'};
            list.CopyTo(equalArray, 3);
            Assert.Equal(equalArray,equalExpected);
            
            var smallerArray = new char[] {'0', '1', '2', 'a', 'b'};
            try
            {
                list.CopyTo(smallerArray,3);
            }
            catch(Exception e)
            {
                Assert.True(e is ArgumentException);
            }

        }
    }
}
