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
    public class PeliculasController : ApiController
    {
        private IMapper mapper;
        private readonly PeliculaService peliculasService = new PeliculaService(new PeliculaRepository(VideoBlockContext.Create()));


        public PeliculasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {


            var peliculas = await peliculasService.GetAll();

            var peliculasDTO = peliculas.Select(x => mapper.Map<peliculaDTO>(x));

            return Ok(peliculasDTO);

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {

            var peliculas = await peliculasService.GetById(id);

            if (peliculas == null)
                return NotFound();

            var peliculasDTO = mapper.Map<peliculaDTO>(peliculas);
            return Ok(peliculasDTO);

        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(peliculaDTO peliculasDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            try
            {
                var peliculas = mapper.Map<Pelicula>(peliculasDTO);
                peliculas = await peliculasService.Insert(peliculas);
                return Ok(peliculas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
        [HttpPut]
        public async Task<IHttpActionResult> Put(peliculaDTO peliculasDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (peliculasDTO.id_peliculas != id)
                return BadRequest();

            var flag = await peliculasService.GetById(id);

            if (flag == null)
                return NotFound();

            try
            {
                var peliculas = mapper.Map<Pelicula>(peliculasDTO);
                peliculas = await peliculasService.Update(peliculas);
                return Ok(peliculas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
