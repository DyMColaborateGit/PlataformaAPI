﻿using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLLogActualizacionesRepository : IPTLLogActualizacionesRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLLogActualizacionesRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLLogActualizacionesModels>> ListaLogActualizaciones()
        {
            try
            {
                var objResult = await _context.PTLLogActualizaciones
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLLogActualizacionesModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaLogActualizaciones", ex, "");
                throw;
            }
        }
    }
}
