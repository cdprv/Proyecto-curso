using System;
using Xunit;
using Proyectofuncion;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace Proyectofunciontest
{
    public class Pidesastest
    {
        private readonly ILogger logger = TestFactory.CreateLogger();

        [Fact]
        public void Pidesas_do_no_es_empty()
        {
            var sas = new Pidesas().Do();
            
            Assert.NotEmpty(sas);
        }

        [Fact]
        public async void Images_devuelve_no_devuelve_null()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await Getsas.Run(request, logger);

            var result = response as OkObjectResult;

            Assert.Contains("?sv=",result.Value.ToString());
            Assert.Contains("&sp=rl", result.Value.ToString());
        }
    }
}
