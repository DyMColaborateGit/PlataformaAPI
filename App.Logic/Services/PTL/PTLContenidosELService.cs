using App.Infraestructure.IRepositories.PTL;
using App.Infraestructure.Repositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLContenidosELService : IPTLContenidosELService
    {
        private readonly IPTLContenidosELRepository _PTLContenidosELRepository;

        public PTLContenidosELService(IPTLContenidosELRepository PTLContenidosELRepository)
        {
            _PTLContenidosELRepository = PTLContenidosELRepository;
        }

        public async Task<List<PTLContenidosELModels>> ListaContenidos()
        {
            return await _PTLContenidosELRepository.ListaContenidos();
        }

        public async Task<PTLContenidosELModels> GetContenidoById(int ContenidoId)
        {
            return await _PTLContenidosELRepository.GetContenidoById(ContenidoId);
        }

        public async Task<PTLContenidosELModels> PostInsertarContenido(PTLContenidosELModels ObjInsertarContenido, string NombreContenido, string DescripcionContenido, string Contenido, bool EstadoContenido)
        {
            ObjInsertarContenido.NombreContenido = NombreContenido;
            ObjInsertarContenido.DescripcionContenido = DescripcionContenido;
            ObjInsertarContenido.Contenido = Contenido;
            ObjInsertarContenido.EstadoContenido = EstadoContenido;

            return await _PTLContenidosELRepository.PostInsertarContenido(ObjInsertarContenido);
        }
        public async Task<PTLContenidosELModels> PutModificarContenido(PTLContenidosELModels ObjModificarContenido, string NombreContenido, string DescripcionContenido, string Contenido, bool EstadoContenido)
        {
            ObjModificarContenido.NombreContenido = NombreContenido;
            ObjModificarContenido.DescripcionContenido = DescripcionContenido;
            ObjModificarContenido.Contenido = Contenido;
            ObjModificarContenido.EstadoContenido = EstadoContenido;

            return await _PTLContenidosELRepository.PutModificarContenido(ObjModificarContenido);
        }
        public async Task<PTLContenidosELModels> DeleteContenido(int ContenidoId)
        {
            var ListResult = await _PTLContenidosELRepository.DeleteContenido(ContenidoId);
            return ListResult;
        }
    }
}
