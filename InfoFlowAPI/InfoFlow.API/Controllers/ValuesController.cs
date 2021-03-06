﻿using System.Collections.Generic;
using InfoFlow.API.Helpers;
using InfoFlow.Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace InfoFlow.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Auth(Role.Admin,Role.OfficeWorker)]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return User.IsInRole("Admin").ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
