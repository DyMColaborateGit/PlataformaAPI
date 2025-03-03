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
    public class PruebaRepository : IPruebaRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PruebaRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PruebaModels>> ListaPrueba()
        {
            try
            {
                var objResult = await _context.PTLSitios.AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PruebaModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaPrueba", ex, "");
                throw;
            }
        }
    }
}
