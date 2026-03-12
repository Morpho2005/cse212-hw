using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Runtime.Serialization.DataContracts;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // notes: this function is supposed to create an array that includes the multiples of value number up to the given length this can be done with a
        // simple for loop where number is multiplied by i with the result being add to the array
        var multiples = new double[length];
        for (int i = 1; i < length + 1; i++)
        {
            multiples[i - 1] = number * i;
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // it is quite simple to use insert and remove statements to change the location of a variable inside of an array, but since this array does not have a fixed size we will have
        // to use the count function of the array, and subtrat the amount variable from the resulting interger, to aquire the index value, we then use this to modify the original array.
        data.InsertRange(0, data.GetRange(data.Count-amount, amount));
        data.RemoveRange(data.Count-amount, amount);
    }
}
