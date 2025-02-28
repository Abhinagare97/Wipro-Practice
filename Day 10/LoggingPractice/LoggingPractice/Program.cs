using NLog;
using System.Collections.Generic;
public class LoggingPractice
{
    private static Logger logger = LogManager.GetCurrentClassLogger();

    public Dictionary<string, string> Dict = new Dictionary<string, string>()
    {
        { "abhi", "Nagare18" }
    };

    public bool Login(string username, string password)
    {
        logger.Info("Login attempt has been made:");
        if (!Dict.ContainsKey(username))
        {
            logger.Info("Login failed");
            return false;
        }
        else
        {
            logger.Info("Login Success");
            return true;
        }
    }
    public static void Main(string[] args)
    {
        var config = new NLog.Config.LoggingConfiguration();
        var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
        
        LogManager.Configuration = config;  
        LoggingPractice pp =new LoggingPractice();
        pp.Login("abhi", "Nagare18");

    }
}