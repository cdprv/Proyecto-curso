using Azure.Storage.Blobs;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectofuncion
{
    public class Pidesas
    {
        public string Do()
        {

            var storageAccount = new Conexion().Create();
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("imagenes");

            //var sas = "Hola";

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
