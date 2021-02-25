using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoBlock.DL.Data;
using VideoBlock.DL.Serivces.Implements;
using VideoBlock.DL.Repositories.Implements;
using System.Threading.Tasks;
using AutoMapper; 
using VideoBlock.DL.Repositories;
using VideoBlock.DL.DTOS;
using VideoBlock.DL.Model;

namespace VideoBlock.Controllers
{
    public class TipoPeliculaController : ApiController
    {
        private IMapper mapper;
        private readonly TipoPeliculasService tipopeliculaService = new TipoPeliculasService(new TipopeliculasRepository(VideoBlockContext.Create()));


        public TipoPeliculaController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {

            var tipopeliculas = await tipopeliculaService.GetAll();

            var tipospeliculasDTO = tipopeliculas.Select(x => mapper.Map<tipopeliculasDTO>(x));

            return Ok(tipospeliculasDTO);

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {

            var tipopeliculas = await tipopeliculaService.GetById(id);

            if (tipopeliculas == null)
                return NotFound();

            var tipospeliculasDTO = mapper.Map<tipopeliculasDTO>(tipopeliculas);
            return Ok(tipospeliculasDTO);

        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(tipopeliculasDTO tipospeliculasDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            try
            {
                var tipopeliculas = mapper.Map<TipoPelicula>(tipospeliculasDTO);
                tipopeliculas = await tipopeliculaService.Insert(tipopeliculas);
                return Ok(tipopeliculas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
        [HttpPut]
        public async Task<IHttpActionResult> Put(tipopeliculasDTO tipospeliculasDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (tipospeliculasDTO.tipopeliculaID != id)
                return BadRequest();

            var flag = await tipopeliculaService.GetById(id);

            if (flag == null)
                return NotFound();

            try
            {
                var tipopeliculas = mapper.Map<TipoPelicula>(tipospeliculasDTO);
                tipopeliculas = await tipopeliculaService.Update(tipopeliculas);
                return Ok(tipopeliculas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
        //[HttpDelete]
        //public async Task<IHttpActionResult> Delete(int id)
        //{


        //    var flag = await tipopeliculaService.GetById(id);

        //    if (flag == null)
        //        return NotFound();

        //    try
        //    {
        //        if (!await tipopeliculaService.DeleteCheckOnEntity(id))
        //            await tipopeliculaService.Delete(id);
        //        else
        //            throw new Exception("Foreign Key");

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return InternalServerError(ex);
        //    }
        //}
    }
}
