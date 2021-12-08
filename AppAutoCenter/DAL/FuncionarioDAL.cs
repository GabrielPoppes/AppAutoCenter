using AppAutoCenter.Models;
using System.Data.SqlClient;
using System.IO;

namespace AppAutoCenter.DAL
{
    class FuncionarioDAL
    {
        public static readonly string stringConexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoCenterDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region Método GetFoto - Para abrir a foto, fazer a leitura, e converter para o tipo inteiro
        public byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using(var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using(var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }
        #endregion

        #region Método para cadastrar o funcionário no banco de dados
        public void Salvar(Funcionario funcionario)
        {
            byte[] foto = GetFoto(funcionario.CaminhoFoto);

            var sql = "INSERT INTO FUNCIONARIO (Nome, Email, Celular, Senha, Foto) VALUES (@nome, @email, @celular, @senha, @foto)";

            using (var con = new SqlConnection(stringConexao))
            {
                con.Open();
                using(var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@email", funcionario.Email);
                    cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                    cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                    cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
