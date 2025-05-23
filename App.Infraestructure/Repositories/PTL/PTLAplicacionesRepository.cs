﻿using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLAplicacionesRepository : IPTLAplicacionesRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLAplicacionesRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLAplicacionesModels>> ListaAplicaciones()
        {
            try
            {
                var objResult = await _context.PTLAplicaciones
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLAplicacionesModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaAplicaciones", ex, "");
                throw;
            }
        }
    }
}
