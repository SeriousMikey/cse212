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
        // Create an empty fixed array
        var multiples = new double[length];

        // Create a multiplier variable equal to 1
        int multiplier = 1;

        /// Create a for loop that multiplies the number by the multiplier, which adds one after each loop, and 
        /// appends the result into the previous array until i is greater than length.
        for (int i = 0; i < length; i++) {
            multiples[i] = number * multiplier;
            multiplier++;
        }

        // Return the now-filled array
        return multiples;
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
        // Use the GetRange method to duplicate the beginning of the data array
        List<int>duplicate = data.GetRange(0, data.Count - amount);

        // Use the RemoveRange method to remove the same data we just duplicated
        data.RemoveRange(0, data.Count - amount);

        // Use the AddRange method to add the duplicated data to the end of the data array
        data.AddRange(duplicate);
    }
}
