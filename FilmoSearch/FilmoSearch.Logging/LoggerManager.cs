using FilmoSearch.Contracts;
using Serilog;

namespace FilmoSearch.Logging
{
    public class LoggerManager : ILoggerManager
    {
        private readonly ILogger logger;

        public LoggerManager(ILogger logger)
        {
            this.logger = logger; 
        }

        public void LogDebug(string message) => logger.Debug(message);

        public void LogError(string message) => logger.Error(message);

        public void LogInfo(string message) => logger.Information(message);

        public void LogWarn(string message) => logger.Warning(message);
    }
}
