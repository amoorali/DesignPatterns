namespace Singleton
{
    public class Logger
    {
        // Lazy<T>
        private static readonly Lazy<Logger> _lazylogger
            = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return _lazylogger.Value;
            }
        }

        protected Logger()
        {
        }

        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message">Message to log</param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
