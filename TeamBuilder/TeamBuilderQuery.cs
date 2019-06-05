using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceMastersDiscordBot.TeamBuilder
{
    public class TeamBuilderQuery
    {
        ILogger _log;
        public TeamBuilderQuery(ILogger logger)
        {
            _log = logger;
        }
        public void Initialize()
        {
            string jsonWeb = System.IO.File.ReadAllText(System.IO.Path.Combine("TeamBuilder", "cards.php"));
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonWeb);
            _log.LogDebug("Did we convert?");

        }
    }


}
