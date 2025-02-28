using NLog;
public class AuthenticationService {
    private static Logger logger = LogManager.GetCurrentClassLogger();

    private Dictionary<string, string> Users = new Dictionary<string, string>() {
        {"abhi", "abhi1234" }
    };

    public bool Login(string username, string password)
    {
        logger.Info($"Login attempt has been made by: {username}");
        if (!Users.ContainsKey(username)){
            logger.Warn("Login failed");
            return false;
        }
        logger.Info("Login Successful");
        return true;
    }
    static void Main(string[] args)
    {
        var config = new NLog.Config.LoggingConfiguration();
        var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logfile.txt" };
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");    
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole);
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
       

        LogManager.Configuration = config;
        AuthenticationService service = new AuthenticationService();
        service.Login("abhi", "abhi1234");
        
    }
}

