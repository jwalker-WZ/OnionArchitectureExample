using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeServer.Controllers
{
    /*
     * All controllers inherit from from this base controller, which handles
     * all of the default functionality. As you can see the API controller
     * simply wraps up each of the functions defined in the service. This is
     * the "presentation" layer, but since this is an API and WebAPI handles
     * alot of the stuff for us there isn't much code here.
     */
    public class HomeServerBaseController<T> : ControllerBase where T : IEntity
    {
        IService<T> _service;
        public HomeServerBaseController(IService<T> service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _service.Get().ToList();
            return Ok(books);
        }

        //FromFrom to accept urlencoded
        [HttpPost]
        public IActionResult Post([FromForm]T entity)
        {
            _service.Insert(entity);
            return Ok();
        }

        //FromFrom to accept urlencoded
        [HttpPut]
        public IActionResult Put([FromForm]T entity)
        {
            _service.Update(entity);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
