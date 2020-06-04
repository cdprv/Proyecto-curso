using System;
using Xunit;
using Proyectofuncion;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace Proyectofunciontest
{
    public class Getsastest
    {
        private readonly ILogger logger = TestFactory.CreateLogger();

       

        [Fact]
        public async void Images_devuelve_no_devuelve_null()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await Getsas.Run(request, logger);

            Assert.NotNull(response);

        }

        [Fact]
        public async void Getsas_devuelve_una_Sas_con_permisos_de_lectura_y_listados()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await Getsas.Run(request, logger);

            var result = response as OkObjectResult;

            Assert.Contains("?sv=", result.Value.ToString()); ;
            Assert.Contains("&sp=rl", result.Value.ToString()); ;

        }
    }
}
