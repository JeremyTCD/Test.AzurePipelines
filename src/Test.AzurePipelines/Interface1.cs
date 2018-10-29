﻿namespace Test.AzurePipelines
{
    /// <summary>
    /// An abstraction.
    /// </summary>
    public interface IInterface1
    {
        /// <summary>
        /// Converts all of the characters in a string to lowercase.
        /// </summary>
        string ToLower(string message);

        /// <summary>
        /// Converts all of the characters in a string to uppercase.
        /// </summary>
        string ToUpper(string message);

        /// <summary>
        /// Increments a number by 1.
        /// </summary>
        int Increment(int num);

        /// <summary>
        /// Decrements a number by 1.
        /// </summary>
        int Decrement(int num);
    }
}
