using BeautySite.DAL;
using BeautySite.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySite.BLL
{
    public class ServicoBLL 
    {
        ServicoDAL objBLL = new ServicoDAL();

        public List<ServicoDTO> ListarServico()
        {
            return objBLL.Listar();
        }

        public ServicoDTO SearchServicoBLL(int objSearch)
        {
            return objBLL.SearchServico(objSearch);
        }

        public ServicoDTO SearchServicoDesk(string objSearchDsk)
        {
            return objBLL.SearchServicoDsk(objSearchDsk);
        }

        //CRUD BLL
        public void CadastrarServicoBLL(ServicoDTO objCad)
        {
            objBLL.CadastrarServico(objCad);
        }

        public void UpdateServico(ServicoDTO objUpdt)
        {
            objBLL.Update(objUpdt);
        }

        public void UpdateServicoDsk(ServicoDTO objUpdt)
        {
            objBLL.UpdateDsk(objUpdt);
        }

        public void DeleteServico(int objDel)
        {
            objBLL.Delete(objDel);
        }

        public List<ServicoDTO> FiltrarServicoBLL(string objFilter)
        {
            return objBLL.FiltrarServico(objFilter);
        }

        

    }
}
