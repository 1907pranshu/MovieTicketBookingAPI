using System;

namespace MovieService.Exceptions
{
    public class MovieNotCreatedException : Exception
    {
        public MovieNotCreatedException() { }
        public MovieNotCreatedException(string message) : base(message) { }
    }
}
