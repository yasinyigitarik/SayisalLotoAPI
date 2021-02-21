using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumberAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumbers()
        {
            try
            {

                int length = 6;
                Random rnd = new Random();
                ResponseModel model = new ResponseModel();
                for (int i = 0; i < length; i++)
                {
                    model.Numbers.Add(rnd.Next(1, 100).ToString());
                }
                model.Status = model.Numbers.Count == 6 ? model.Status = true : model.Status = false;
                string jsonData = JsonConvert.SerializeObject(model);
                return Ok(jsonData);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
