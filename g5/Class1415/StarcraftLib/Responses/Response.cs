namespace StarcraftLib.Responses
{
    public abstract class Response
    {
        public bool Success { get; protected set; }
        public string ErrorMessage { get; protected set; }

        public override string ToString()
        {
            if (Success)
            {
                return "Success";
            }
            return $"Error: {ErrorMessage}";
        }
    }
}