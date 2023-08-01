using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;//
using BeautySite.DTO;//

namespace BeautySite.DAL
{
    public class ServicoDAL : Conexao
    {

        public List<ServicoDTO> Listar()
        {
			try
			{
				Conectar();
				cmd = new MySqlCommand("SELECT IdServico, NomeServico, DescricaoServico, UrlImgServico FROM servico ORDER BY NomeServico;", conn);
				dr = cmd.ExecuteReader();
				List<ServicoDTO> Lista = new List<ServicoDTO>();
				while (dr.Read()) 
				{
					ServicoDTO obj = new ServicoDTO();
					obj.IdServico = Convert.ToInt32(dr["IdServico"]);
					obj.NomeServico = dr["NomeServico"].ToString();
                    obj.DescricaoServico = dr["DescricaoServico"].ToString();
                    obj.UrlImgServico = dr["UrlImgServico"].ToString();

                    Lista.Add(obj);
				}
				return Lista;

			}
			catch (Exception ex)
			{

				throw new Exception ("Deu Ruim !!" + ex.Message);
			}
			finally 
			{
				Desconectar();
			}

        }

		public ServicoDTO SearchServico(int objSearch)
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("SELECT * FROM Servico WHERE Servico.IdServico = @IdServico;", conn);
				cmd.Parameters.AddWithValue("@IdServico", objSearch);
				dr = cmd.ExecuteReader();
				ServicoDTO obj = null;
				if (dr.Read())
				{
					obj = new ServicoDTO();
                    obj.IdServico = Convert.ToInt32(dr["IdServico"]);
                    obj.NomeServico = dr["NomeServico"].ToString();
                    obj.DescricaoServico = dr["DescricaoServico"].ToString();
                    obj.UrlImgServico = dr["UrlImgServico"].ToString();
                }
				return obj;
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

		//CRUD
		public void CadastrarServico(ServicoDTO objCad)
		{
			try
			{
				Conectar();
				cmd = new MySqlCommand("INSERT INTO servico (NomeServico, DescricaoServico, UrlImgServico) VALUES (@NomeServico, @DescricaoServico, @UrlImgServico);", conn);
				cmd.Parameters.AddWithValue("@NomeServico", objCad.NomeServico);
                cmd.Parameters.AddWithValue("@DescricaoServico", objCad.DescricaoServico);
                cmd.Parameters.AddWithValue("@UrlImgServico", objCad.UrlImgServico);
				cmd.ExecuteNonQuery();

            }
			catch (Exception ex)
			{

				throw new Exception("Deu Ruim!!!" + ex.Message);
			}
			finally 
			{
				Desconectar();
			}
		}

        public void Update(ServicoDTO objUpdt)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("UPDATE servico SET NomeServico=@NomeServico, DescricaoServico=@DescricaoServico, UrlImgServico=@UrlImgServico WHERE servico.IdServico = @IdServico;", conn);
                cmd.Parameters.AddWithValue("@NomeServico", objUpdt.NomeServico);
                cmd.Parameters.AddWithValue("@DescricaoServico", objUpdt.DescricaoServico);
                cmd.Parameters.AddWithValue("@UrlImgServico", objUpdt.UrlImgServico);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Deu Ruim!!!" + ex.Message);
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
                cmd = new MySqlCommand("DELETE servico FROM servico WHERE servico.IdServico = @IdServico;", conn);
                cmd.Parameters.AddWithValue("@IdServico", objDel);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Deu Ruim!!!" + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public List<ServicoDTO> FiltrarServico(string objFilter)
        {
            try
            {
                Conectar();
                cmd = new MySqlCommand("SELECT servico.idservico, NomeServico, DescricaoServico, UrlImgServico FROM servico WHERE NomeServico = @NomeServico;", conn);
                cmd.Parameters.AddWithValue("@NomeServico", objFilter);
                dr = cmd.ExecuteReader();
                List<ServicoDTO> Lista = new List<ServicoDTO>();
                while (dr.Read()) 
                {
                    ServicoDTO obj = new ServicoDTO();
                    obj.IdServico = Convert.ToInt32(dr["IdServico"]);
                    obj.NomeServico = dr["NomeServico"].ToString();
                    obj.DescricaoServico = dr["DescricaoServico"].ToString();
                    obj.UrlImgServico = dr["UrlImgServico"].ToString();

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
