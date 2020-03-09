using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADAuthenticaionAPI.Models
{
    public class Policy
    {
        public int Year { get; set; }
        public long Id { get; set; }
        public string Url { get; set; }
        public string NamedInsured { get; set; }
        public long PolicyNumber { get; set; }
        public long AwsKey { get; set; }
        public long AwsFolderKey { get; set; }
    }
}
