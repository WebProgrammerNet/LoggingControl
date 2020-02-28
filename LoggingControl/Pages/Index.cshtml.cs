using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoggingControl.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        public IndexModel(ILoggerFactory _loggery)
        {
            _logger = _loggery.CreateLogger("DemoCategory");
        }

        public void OnGet()
        {
            // _logger.LogInformation(LoggingId.DemoCode,"This is first of from Demo Messages");//BuId ile qeyd etmek ucundur.

            // Logginig Levels
            _logger.LogTrace("Tis is LogTrace MESSAGES");
            _logger.LogDebug("Tis is LogDebug MESSAGES");
            _logger.LogInformation("Tis is LogInformation MESSAGES");
            _logger.LogWarning("Tis is LogWarning LogWarning");
            _logger.LogError("Tis is LogError MESSAGES Server Shout Down at {Time}", DateTime.UtcNow);
            _logger.LogCritical("Tis is LogCritical MESSAGES");


            _logger.LogError("Tis is LogError MESSAGES Server Shout Down at {Time}", DateTime.UtcNow);
            try
            {
                throw new Exception ("You are Lose Me");
            }
            catch (Exception ex)
            {

                _logger.LogCritical(ex, "Llease Your Exception Critical Error Begin at Time {Time}", DateTime.UtcNow);

            }

        }
    }

    internal class LoggingId
    {
        public const int DemoCode = 1001;
    }
}


#region Classic Older Variant
//namespace LoggingControl.Pages
//{
//    public class IndexModel : PageModel
//    {
//        private readonly ILogger<IndexModel> _logger;

//        public IndexModel(ILogger<IndexModel> logger)
//        {
//            _logger = logger;
//        }

//        public void OnGet()
//        {
//            // _logger.LogInformation(LoggingId.DemoCode,"This is first of from Demo Messages");//BuId ile qeyd etmek ucundur.

//            // Logginig Levels
//            //_logger.LogTrace("Tis is LogTrace MESSAGES");
//            //_logger.LogDebug("Tis is LogDebug MESSAGES");
//            //_logger.LogInformation("Tis is LogInformation MESSAGES");
//            //_logger.LogWarning("Tis is LogWarning LogWarning");
//            //_logger.LogError("Tis is LogError MESSAGES Server Shout Down at {Time}", DateTime.UtcNow);
//            //_logger.LogCritical("Tis is LogCritical MESSAGES");


//            _logger.LogError("Tis is LogError MESSAGES Server Shout Down at {Time}", DateTime.UtcNow);
//            try
//            {
//                throw new Exception("You are Lose Me");
//            }
//            catch (Exception ex)
//            {

//                _logger.LogCritical(ex, "Llease Your Exception Critical Error Begin at Time {Time}", DateTime.UtcNow);

//            }

//        }
//    }

//    internal class LoggingId
//    {
//        public const int DemoCode = 1001;
//    }
//}
#endregion