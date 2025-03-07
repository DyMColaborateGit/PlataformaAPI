using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLVersionesAPRepository : IPTLVersionesAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLVersionesAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLVersionesAPModels>> ListaVersiones()
        {
            try
            {
                var objResult = await _context.PTLVersionesAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLVersionesAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaVersiones", ex, "");
                throw;
            }
        }
    }
}
