using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoBlock.DL.Model;
namespace VideoBlock.DL.DTOS
{
   public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TipoPelicula, tipopeliculasDTO>(); // GET
                cfg.CreateMap<tipopeliculasDTO, TipoPelicula>();// POST, PUT 


                cfg.CreateMap<Cliente, clienteDTO>(); // GET
                cfg.CreateMap<clienteDTO, Cliente>();// POST, PUT 

                cfg.CreateMap<Actor, actorDTO>(); // GET
                cfg.CreateMap<actorDTO, Actor>();// POST, PUT 

                cfg.CreateMap<Alquiler, AlquilerDTO>(); // GET
                cfg.CreateMap<AlquilerDTO, Alquiler>();// POST, PUT 

                cfg.CreateMap<Pelicula, peliculaDTO>(); // GET
                cfg.CreateMap<peliculaDTO, Pelicula>();// POST, PUT 

                //cfg.CreateMap<Student, StudentDTO>();
                //cfg.CreateMap<StudentDTO, Student>();

                //cfg.CreateMap<Enrollment, EnrollmentDTO>();
                //cfg.CreateMap<EnrollmentDTO, Enrollment>();
            });

        }
    }
}
