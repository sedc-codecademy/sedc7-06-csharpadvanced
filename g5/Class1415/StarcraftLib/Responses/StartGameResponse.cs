using System;

namespace StarcraftLib.Responses
{
    public class StartGameResponse : Response
    {
        private StartGameResponse() {}

        public static StartGameResponse Error(string errorMessage)
        {
            return new StartGameResponse { Success = false, ErrorMessage = errorMessage };
        }

        internal static StartGameResponse Ok()
        {
            return new StartGameResponse { Success = true };
        }
    }
}