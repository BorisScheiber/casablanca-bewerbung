using System;
using Xunit;
using MergeSortProject;

public class MergeSortTests
{
    [Fact]
    public void MergeSort_SortsArrayCorrectly()
    {
        int[] input = { 5, 3, 8, 1, 2, 7 };
        int[] expected = { 1, 2, 3, 5, 7, 8 };

        int[] result = MergeSortExample.MergeSort(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void MergeSort_EmptyArray_ReturnsEmpty()
    {
        int[] input = { };
        int[] expected = { };

        int[] result = MergeSortExample.MergeSort(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void MergeSort_SingleElement_ReturnsSameArray()
    {
        int[] input = { 42 };
        int[] expected = { 42 };

        int[] result = MergeSortExample.MergeSort(input);

        Assert.Equal(expected, result);
    }
}
