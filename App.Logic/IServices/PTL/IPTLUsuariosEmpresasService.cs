using App.Models.Models.PTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.logic.IServices.PTL
{
    public interface IPTLUsuariosEmpresasService
    {
        Task<List<PTLUsuariosEmpresasModels>> ListaUsuariosEmpresa();
    }
}
