using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectofuncion
{
    public class Conexion
    {

        public CloudStorageAccount Create()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=sastoragecdp;AccountKey=Jw9R1LpZ4OqLjs7TNReKTshO7CNRr/o/N7k90hRZ/M4uu1PsFD44y8Oni0Lj0iuuyhxZu/tm531FzuByf+elSQ==;EndpointSuffix=core.windows.net";
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            return storageAccount;
        }
    }
}
