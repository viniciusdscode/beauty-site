using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySite.DAL;
using BeautySite.DTO;


namespace BeautySite.BLL
{
    public class UsuarioBLL
    {
        //obj para acessar os metodos DAL
        UsuarioDAL objBLL = new UsuarioDAL();

        public UsuarioDTO AutenticarUsuario(string objNome, string objSenha)
        {
            UsuarioDTO user = objBLL.Autenticar(objNome, objSenha);
            
              return user;
            
        }

        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

        public List<TipoUsuarioDTO> CarregaDDList()
        {
            return objBLL.CarregaDDL();
        }

        public UsuarioDTO SearchByName(string objSearch)
        {
            return objBLL.SearchName(objSearch);
        }

        public UsuarioDTO SearchByNameDesk(string objSearch)
        {
            return objBLL.SearchNameDsk(objSearch);
        }

        public UsuarioDTO SearchById(int objSearch)
        {
            return objBLL.SearchId(objSearch);
        }

        public void CadastrarUsuario(UsuarioDTO objCad)
        {
            objBLL.Cadastrar(objCad);
        }

        public void UpdateUser(UsuarioDTO objUpdt)
        {
            objBLL.Update(objUpdt);
        }

        public void DeleteUser(int objDel)
        {
            objBLL.Delete(objDel);
        }


        public void CadastrarClienteBLL(UsuarioDTO objCad)
        {
            objBLL.CadastrarCliente(objCad);
        }

    }
}
