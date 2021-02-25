using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using VideoBlock.DL.Data;
using VideoBlock.DL.DTOS;
using VideoBlock.DL.Model;
using VideoBlock.DL.Repositories.Implements;
using VideoBlock.DL.Services.Implements;

namespace VideoBlock.Controllers
{
    public class ActorController : ApiController
    {

        private IMapper mapper;
        private readonly ActorService actorService = new ActorService(new ActorRepository(VideoBlockContext.Create()));


        public ActorController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {


            var actor = await actorService.GetAll();

            var actorDTO = actor.Select(x => mapper.Map<actorDTO>(x));

            return Ok(actorDTO);

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {

            var actor = await actorService.GetById(id);

            if (actor == null)
                return NotFound();

            var actorDTO = mapper.Map<actorDTO>(actor);
            return Ok(actorDTO);

        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(actorDTO actorsDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            try
            {
                var actor = mapper.Map<Actor>(actorsDTO);
                actor = await actorService.Insert(actor);
                return Ok(actor);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
        [HttpPut]
        public async Task<IHttpActionResult> Put(actorDTO actorsDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (actorsDTO.actorID != id)
                return BadRequest();

            var flag = await actorService.GetById(id);

            if (flag == null)
                return NotFound();

            try
            {
                var actor = mapper.Map<Actor>(actorsDTO);
                actor = await actorService.Update(actor);
                return Ok(actor);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
