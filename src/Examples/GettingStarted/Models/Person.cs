using System.Collections.Generic;
using JsonApiDotNetCore.Models;

namespace GettingStarted.Models
{
    public sealed class Person : Identifiable
    {
        [Attr] 
        public string Name { get; set; }
        [HasMany] 
        public List<Article> Articles { get; set; }
    }
}
