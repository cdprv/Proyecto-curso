using System;
using Xunit;
using Proyectofuncion;
using Microsoft.Extensions.Logging;

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
    }
}
