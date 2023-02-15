using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Buy_your_dream_house.data;
using Buy_your_dream_house.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Buy_your_dream_house.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly IHousesRepository _housesRepository;

        public HousesController(IHousesRepository repository)
        {
            _housesRepository = repository;
        }
        // GET: api/Houses
        [HttpGet]
        public IEnumerable<House> GetHouses()
        {
            return _housesRepository.GetAllHouses();
        }

        // GET: api/Houses/5
        [HttpGet("{id}")]
        public House Get(int id)
        {
            return _housesRepository.GetOneHouse(id);
        }

        // POST: api/Houses
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Houses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Houses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
