using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var s = new List<int> { 1, 1, 1 };

        var expected = "Second";
        var actual = Result.misereNim(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var s = new List<int> { 1, 2, 2 };

        var expected = "First";
        var actual = Result.misereNim(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var s = new List<int> { 1, 1 };

        var expected = "First";
        var actual = Result.misereNim(s);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var s = new List<int> { 2, 1, 3 };

        var expected = "Second";
        var actual = Result.misereNim(s);

        Assert.Equal(expected, actual);
    }
}