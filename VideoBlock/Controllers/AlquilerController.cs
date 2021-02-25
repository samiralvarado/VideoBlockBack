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
using VideoBlock.DL.Serivces.Implements;
using VideoBlock.DL.Services.Implements;

namespace VideoBlock.Controllers
{
    public class AlquilerController : ApiController
    {
        private IMapper mapper;
        private readonly AlquilerService alquilerService = new AlquilerService(new AlquilerRepository(VideoBlockContext.Create()));


        public AlquilerController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {

            var alquiler = await alquilerService.GetAll();

            var alquilerDTO = alquiler.Select(x => mapper.Map<AlquilerDTO>(x));

            return Ok(alquilerDTO);

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {

            var alquiler = await alquilerService.GetById(id);

            if (alquiler == null)
                return NotFound();

            var alquilerDTO = mapper.Map<AlquilerDTO>(alquiler);
            return Ok(alquilerDTO);

        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(AlquilerDTO alquilerDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            try
            {
                var alquiler = mapper.Map<Alquiler>(alquilerDTO);
                alquiler = await alquilerService.Insert(alquiler);
                return Ok(alquiler);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
        [HttpPut]
        public async Task<IHttpActionResult> Put(AlquilerDTO alquilerDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (alquilerDTO.alquilerID != id)
                return BadRequest();

            var flag = await alquilerService.GetById(id);

            if (flag == null)
                return NotFound();

            try
            {
                var alquiler = mapper.Map<Alquiler>(alquilerDTO);
                alquiler = await alquilerService.Update(alquiler);
                return Ok(alquiler);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
    }
}
