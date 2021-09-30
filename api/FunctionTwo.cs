using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace SalaryCalculation.Function
{
    public static class FunctionTwo
    {
        [FunctionName("FunctionTwo")]
        public void Run([TimerTrigger("* /5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            try
            {
                log.LogInformation($"Timer Trigger fired at: {DateTime.Now}");
            }
            catch(Exception exception)
            {
                log.LogError("Timer Trigger Error.", exception);
            }
        }
    }
}
