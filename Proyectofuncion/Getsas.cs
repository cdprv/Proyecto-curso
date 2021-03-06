using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Proyectofuncion
{
    public static class Getsas
    {
        [FunctionName("Getsas")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            string responseMessage = new Pidesas().Do();

            return new OkObjectResult(responseMessage);

          //  log.LogInformation("C# HTTP trigger function processed a request.");

            //string name = req.Query["name"];

           // string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
           // dynamic data = JsonConvert.DeserializeObject(requestBody);
           // name = name ?? data?.name;

          //  return name != null
           //     ? (ActionResult)new OkObjectResult($"Hello, {name}")
            //    : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }

    public class Nueva
    {
        public string Do()
        {
            
            var storageAcoount = new Conexion().Create();
            var blobClient = storageAcoount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("imagenes");

            SharedAccessBlobPolicy adHocPolicy = new SharedAccessBlobPolicy()
            {
                SharedAccessExpiryTime = System.DateTime.UtcNow.AddHours(1),
                Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.List
            };

            var sas = container.GetSharedAccessSignature(adHocPolicy, "imagenes");

            return sas;
        }

    }
}
