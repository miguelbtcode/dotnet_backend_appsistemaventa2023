﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.BLL.Servicios.Contrato;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVenta.DTO;
using SistemaVenta.Model;

namespace SistemaVenta.BLL.Servicios
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Rol> _rolRepositorio;
        private readonly IMapper _mapper;

        public RolService(IGenericRepository<Rol> rolRepositorio, IMapper mapper)
        {
            _rolRepositorio = rolRepositorio;
            _mapper = mapper;
        }

        public async Task<List<RolDto>> Lista()
        {
            try
            {
                var listaRoles = await _rolRepositorio.GetAllAsync();
                return _mapper.Map<List<RolDto>>(listaRoles.ToList());
            }
            catch
            {
                throw;
            }
        }
    }
}