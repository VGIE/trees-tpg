namespace UnitTests;
using System;
public class Tests
{
    [Fact]
    public void GenericTrees()
    {
        TimeoutHandler.Test(Trees.Tests.TestGenericTree, 1, Console.WriteLine, Assert.Fail);
    }

    [Fact]
    public void BinaryTrees()
    {
        TimeoutHandler.Test(global::BinaryTrees.Tests.TestBinaryTree, 1, Console.WriteLine, Assert.Fail);
    }

    [Fact]
    public void BinaryTreesPerformance()
    {
        TimeoutHandler.Test(global::BinaryTrees.Tests.MeasureBinaryTreeSpeed, 2, Console.WriteLine, Assert.Fail);
    }
}