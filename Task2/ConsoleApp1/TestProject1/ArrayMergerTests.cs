using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ClassLibrary1.ArrayMerger;

[TestClass]
public class ArrayMergerTests
{
   

    [TestMethod]
    public void MergeArrays_ValidArrays_ReturnsMergedArray()
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5};

        int[] result = MergeArrays(array1, array2);

        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MergeArrays_NullArray_ThrowsArgumentNullException()
    {
        int[] array1 = null;
        int[] array2 = { 1 };

        MergeArrays(array1, array2);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MergeArrays_NullArray2_ThrowsArgumentNullException()
    {
        int[] array1 = { 1 };
        int[] array2 = null;

        MergeArrays(array1, array2);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MergeArrays_NullArray1AndArray2_ThrowsArgumentNullException()
    {
        int[] array1 = null;
        int[] array2 = null;

        MergeArrays(array1, array2);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void MergeArrays_EmptyArray_ThrowsArgumentException()
    {
        int[] array1 = { };
        int[] array2 = { 1, 2 };

        MergeArrays(array1, array2);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void MergeArrays_EmptyArray2_ThrowsArgumentException()
    {
        int[] array1 = {2 };
        int[] array2 = {};

        MergeArrays(array1, array2);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void MergeArrays_EmptyArray2AndArray1_ThrowsArgumentException()
    {
        int[] array1 = { };
        int[] array2 = { };

        MergeArrays(array1, array2);
    }
}