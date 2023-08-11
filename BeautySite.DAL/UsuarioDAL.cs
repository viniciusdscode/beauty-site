using BeautySite.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySite.DAL
{
    public class UsuarioDAL : Conexao
    {
        public UsuarioDTO Autenticar(string nome, string senha)
        {
			try
			{
				Conectar();
				cmd = new MySqlCommand("SELECT * FROM Usuario WHERE Nome = @Nome AND Senha = @Senha", conn);
				cmd.Parameters.AddWithValue("@Nome", nome);
				cmd.Parameters.AddWithValue("@Senha", senha);
				dr = cmd.ExecuteReader();
				UsuarioDTO obj = null;
				if (dr.Read())
				{
					obj = new UsuarioDTO();
					obj.Nome = dr["Nome"].ToString();
					obj.Senha = dr["Senha"].ToString();
					obj.TipoUsuario_IdTipoUsuario = dr["IdTipoUsuario"].ToString();

				}
				return obj;

			}
			catch (Exception ex)
			{

				throw new Exception("Usuário não cadastrado !" + ex.Message);
			}
			finally
			{
				Desconectar();
			}
        }

        public UsuarioDTO AutenticarDsk(string nome)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT * FROM Usuario WHERE Nome = @Nome", conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                dr = cmd.ExecuteReader();
                UsuarioDTO obj = null;
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.Nome = dr["Nome"].ToString();

                }
                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception("Usuário não cadastrado !" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<UsuarioDTO> Listar()
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("SELECT Usuario.idUsuario, Nome, Email, Senha, Telefone, DescricaoTipoUsuario FROM Usuario INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario ORDER BY Usuario.IdUsuario ASC;", conn);
				dr = cmd.ExecuteReader();
				List<UsuarioDTO> Lista = new List<UsuarioDTO>();//null list
				while (dr.Read())
				{
					UsuarioDTO obj = new UsuarioDTO();
					obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
					obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
					obj.Telefone = dr["Telefone"].ToString();
					obj.TipoUsuario_IdTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
					Lista.Add(obj);
                }
				return Lista;
			}
			catch (Exception ex)
			{

				throw new Exception("Deu Ruim !!" + ex.Message);	
			}
			finally
			{
				Desconectar();
			}
		}

        public List<TipoUsuarioDTO> CarregaDDL()
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("SELECT * FROM TipoUsuario;", conn);
				dr = cmd.ExecuteReader();
				List<TipoUsuarioDTO> Lista = new List<TipoUsuarioDTO>();
				while (dr.Read()) 
				{
					TipoUsuarioDTO obj = new TipoUsuarioDTO();
					obj.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
					obj.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
					Lista.Add(obj);
				}
				return Lista;
			}
			catch (Exception ex)
			{

				throw new Exception("Deu Ruim !!" + ex.Message);

			}
			finally 
			{ 
				Desconectar(); 
			}	
		}

		public UsuarioDTO SearchName(string  objSearch)
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuario.nome = @Nome;", conn);
				cmd.Parameters.AddWithValue("@Nome", objSearch);
				dr = cmd.ExecuteReader();
				UsuarioDTO obj = null;
				if (dr.Read())
				{
					obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Telefone = dr["Telefone"].ToString();
                    obj.TipoUsuario_IdTipoUsuario = dr["IdTipoUsuario"].ToString();
                }
				return obj;
			}
			catch (Exception ex)
			{

				throw new Exception("Deu Ruim !" + ex.Message);
			}
			finally 
			{
				Desconectar();
			}
		}

        public UsuarioDTO SearchNameDsk(string objSearch)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT Usuario.idusuario, Nome, Email, Senha, Telefone, DescricaoTipoUsuario FROM Usuario INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario WHERE Usuario.Nome = @Nome;", conn);
                cmd.Parameters.AddWithValue("@Nome", objSearch);
                dr = cmd.ExecuteReader();
                UsuarioDTO obj = null;
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Telefone = dr["Telefone"].ToString();
                    obj.TipoUsuario_IdTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Deu Ruim !" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public UsuarioDTO SearchId(int objSearch)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuario.IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", objSearch);
                dr = cmd.ExecuteReader();
                UsuarioDTO obj = null;
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Telefone = dr["Telefone"].ToString();
                    obj.TipoUsuario_IdTipoUsuario = dr["IdTipoUsuario"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Deu Merda !" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

		//CRUD

		public void Cadastrar(UsuarioDTO objCad)
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("INSERT INTO usuario (Nome,Email,Senha,Telefone,IdTipoUsuario) VALUES (@Nome,@Email,@Senha,@Telefone,@IdTipoUsuario);", conn);
				cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@Telefone", objCad.Telefone);
                cmd.Parameters.AddWithValue("@IdTipoUsuario", objCad.TipoUsuario_IdTipoUsuario);
				cmd.ExecuteNonQuery();

            }
			catch (Exception ex)
			{

				throw new Exception("Deu Ruim !" + ex.Message);
			}
			finally
			{
				Desconectar();
			}
		}

		public void Update(UsuarioDTO objUpdt)
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("UPDATE Usuario SET Nome=@Nome, Email=@Email, Senha=@Senha, Telefone=@Telefone, IdTipoUsuario=@IdTipoUsuario WHERE Usuario.IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@Nome", objUpdt.Nome);
                cmd.Parameters.AddWithValue("@Email", objUpdt.Email);
                cmd.Parameters.AddWithValue("@Senha", objUpdt.Senha);
                cmd.Parameters.AddWithValue("@Telefone", objUpdt.Telefone);
                cmd.Parameters.AddWithValue("@IdTipoUsuario", objUpdt.TipoUsuario_IdTipoUsuario);
				cmd.Parameters.AddWithValue("@IdUsuario", objUpdt.IdUsuario);
                cmd.ExecuteNonQuery();

            }
			catch (Exception ex)
			{
				throw new Exception("Deu Ruim!" + ex.Message);
			}
			finally 
			{
				Desconectar();
			}
		}
        

        public void Delete(int objDel)
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("DELETE FROM Usuario WHERE Usuario.IdUsuario = @IdUsuario;", conn);
				cmd.Parameters.AddWithValue("@IdUsuario", objDel);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{

				throw new Exception("Deu Ruim !" + ex.Message);
			}
			finally
			{
				Desconectar();
			}
		}


		//Cad Exclusivo Cadastro.aspx
        public void CadastrarCliente(UsuarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("INSERT INTO usuario (Nome,Email,Senha,Telefone,IdTipoUsuario) VALUES (@Nome,@Email,@Senha,@Telefone,2);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@Telefone", objCad.Telefone);
                cmd.Parameters.AddWithValue("2", objCad.TipoUsuario_IdTipoUsuario);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Deu Ruim !" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<UsuarioDTO> FiltrarUsuario(string objFilter)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT usuario.Idusuario, Nome, Email, Senha, Telefone, DescricaoTipoUsuario  FROM usuario INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario WHERE DescricaoTipoUsuario = @DescricaoTipoUsuario;", conn);
                cmd.Parameters.AddWithValue("@DescricaoTipoUsuario", objFilter);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>();//null list
                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Telefone = dr["Telefone"].ToString();
                    obj.TipoUsuario_IdTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
                    Lista.Add(obj);

                }

                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar registros" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }




    }
}
