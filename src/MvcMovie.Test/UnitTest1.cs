using System;
using Xunit;
using MvcMovie.Models;
using System.Linq;
using System.Collections.Generic;

namespace MvcMovie.Test
{
    public class UnitTest1
    {
        [Fact(DisplayName = "ソート(昇順)")]
        public void Test1()
        {
            var data = new SamplePostParameterViewModel
            {
                Numbers = new List<int>
                {
                    5,4,3,1,2,
                }
            };
            data = SampleHelper.Sort(data);

            Assert.Equal(1, data.Numbers[0]);
            Assert.Equal(2, data.Numbers[1]);
            Assert.Equal(3, data.Numbers[2]);
            Assert.Equal(4, data.Numbers[3]);
            Assert.Equal(5, data.Numbers[4]);
            Assert.Equal(5, data.Numbers.Count);
        }

        [Fact(DisplayName = "ソート(降順)")]
        public void Test2()
        {
            var data = new SamplePostParameterViewModel
            {
                Numbers = new List<int>
                {
                    5,4,3,1,2,
                }
            };
            data = SampleHelper.SortDescending(data);

            Assert.Equal(5, data.Numbers[0]);
            Assert.Equal(4, data.Numbers[1]);
            Assert.Equal(3, data.Numbers[2]);
            Assert.Equal(2, data.Numbers[3]);
            Assert.Equal(1, data.Numbers[4]);
            Assert.Equal(5, data.Numbers.Count);
        }

        [Fact(DisplayName = "値の検索(存在してる場合)")]
        public void Test3()
        {
            var data = new SamplePostParameterViewModel
            {
                Numbers = new List<int>
                {
                    5,4,3,1,2,
                },
                Number = 5,
            };
            var result = SampleHelper.Exist(data);

            Assert.True(result);
        }

        [Fact(DisplayName = "値の検索(存在していない場合)")]
        public void Test4()
        {
            var data = new SamplePostParameterViewModel
            {
                Numbers = new List<int>
                {
                    5,4,3,1,2,
                },
                Number = 10,
            };
            var result = SampleHelper.Exist(data);

            Assert.False(result);
        }

        // TODO: SampleHelperに追加したメソッドのテストを定義しましょう
    }
}
