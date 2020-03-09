using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADAuthenticaionAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ADAuthenticaionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly DataContext _context;

        public PolicyController(DataContext context)
        {
            _context = context;
        }
        // GET: api/Policy
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Policy/5
        [HttpGet("{id}", Name = "GetPolicy")]
        public async Task<IActionResult> GetPolicy(long id)
        {
            var policy = await _context.Policies.FirstOrDefaultAsync(p => p.AwsFolderKey == id);
            if (policy.Url == null)
            {
                policy.Url = "https://sawgrass-mutual.s3.amazonaws.com/archives/11/10/10/" + policy.Year + "/" + policy.AwsFolderKey + "/Uploads/" + policy.AwsKey + "_.pdf";
                _context.SaveChanges();
            }

            return Ok(policy);
        }

        // POST: api/Policy
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Policy/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
