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
    public class ClienteController : ApiController
    {
        private IMapper mapper;
        private readonly ClienteService clienteService = new ClienteService(new ClienteRepository(VideoBlockContext.Create()));


        public ClienteController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {

            var cliente = await clienteService.GetAll();

            var ClienteDTO = cliente.Select(x => mapper.Map<clienteDTO>(x));

            return Ok(ClienteDTO);

        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {

            var cliente = await clienteService.GetById(id);

            if (cliente == null)
                return NotFound();

            var ClienteDTO = mapper.Map<clienteDTO>(cliente);
            return Ok(ClienteDTO);

        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(clienteDTO ClienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            try
            {
                var cliente = mapper.Map<Cliente>(ClienteDTO);
                cliente = await clienteService.Insert(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }



        }
        [HttpPut]
        public async Task<IHttpActionResult> Put(clienteDTO ClienteDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (ClienteDTO.clienteID != id)
                return BadRequest();

            var flag = await clienteService.GetById(id);

            if (flag == null)
                return NotFound();

            try
            {
                var cliente = mapper.Map<Cliente>(ClienteDTO);
                cliente = await clienteService.Update(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
    }
}
