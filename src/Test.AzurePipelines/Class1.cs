namespace Test.AzurePipelines
{
    /// <summary>
    /// An implementation of an abstraction.
    /// </summary>
    public class Class1 : IInterface1
    {
        /// <inheritdoc />
        public string ToLower(string message)
        {
            return message.ToLower();
        }

        /// <inheritdoc />
        public string ToUpper(string message)
        {
            return message.ToUpper();
        }

        /// <inheritdoc />
        public int Increment(int num)
        {
            return num++;
        }
    }
}
