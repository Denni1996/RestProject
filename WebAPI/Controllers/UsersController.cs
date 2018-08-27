using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : BaseController
    {
        public User UserModel { get; set; }

        public UsersController(User userModel)
        {
            this.UserModel = userModel;
        }

        public ActionResult Get()
        {
            return Ok(UserModel.Get());
        }

        public ActionResult Get(int id)
        {
            return Ok(UserModel.Get(id));
        }

        [HttpDelete]
        public ActionResult Delete([FromBody]User user)
        {
            UserModel.Delete(user);
            return Ok();
        }

        [HttpPost]
        public ActionResult Create([FromBody]User user)
        {
            UserModel.Create(user);
            return Ok();
        }

        [HttpPut]
        public ActionResult Post([FromBody]User user)
        {
            UserModel.Update(user);
            return Ok();
        }
    }
}