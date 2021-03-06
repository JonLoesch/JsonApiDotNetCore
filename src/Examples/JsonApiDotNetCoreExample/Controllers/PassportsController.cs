using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiDotNetCoreExample.Models;
using Microsoft.Extensions.Logging;

namespace JsonApiDotNetCoreExample.Controllers
{
    public sealed class PassportsController : JsonApiController<Passport>
    {
        public PassportsController(
            IJsonApiOptions jsonApiOptions,
            ILoggerFactory loggerFactory,
            IResourceService<Passport, int> resourceService)
            : base(jsonApiOptions, loggerFactory, resourceService)
        { }
    }
}
