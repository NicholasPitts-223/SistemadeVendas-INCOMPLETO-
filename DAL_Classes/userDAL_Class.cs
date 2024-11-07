using SistemaVendas.BLL_Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaVendas.DAL_Classes
{
    class userDAL
    {
        static string myconsnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Selecionar dados do banco de dados
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                // Usando 'using' para garantir o fechamento da conexão
                using (SqlConnection conn = new SqlConnection(myconsnstring))
                {
                    string sql = "SELECT * FROM tbl_usuarios";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        conn.Open();
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message + "\n" + ex.StackTrace);
            }
            return dt;
        }
        #endregion

        #region Cadastrar dados no banco de dados
        public bool Insert(userBLL_Class u)
        {
            bool isSucesso = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(myconsnstring))
                {
                    string sql = "INSERT INTO tbl_usuarios(nome, s_nome, email, usuário, senha, contato, endereco, sexo, usuário_tipo, add_data, add_por) " +
                                 "VALUES (@nome, @s_nome, @email, @usuário, @senha, @contato, @endereco, @sexo, @usuário_tipo, @add_data, @add_por)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@nome", SqlDbType.NVarChar).Value = u.nome;
                        cmd.Parameters.Add("@s_nome", SqlDbType.NVarChar).Value = u.s_nome;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = u.email;
                        cmd.Parameters.Add("@usuário", SqlDbType.NVarChar).Value = u.usuário;
                        cmd.Parameters.Add("@senha", SqlDbType.NVarChar).Value = u.senha;
                        cmd.Parameters.Add("@contato", SqlDbType.NVarChar).Value = u.contato;
                        cmd.Parameters.Add("@endereco", SqlDbType.NVarChar).Value = u.endereco;
                        cmd.Parameters.Add("@sexo", SqlDbType.NVarChar).Value = u.sexo;
                        cmd.Parameters.Add("@usuário_tipo", SqlDbType.NVarChar).Value = u.usuário_tipo;
                        cmd.Parameters.Add("@add_data", SqlDbType.DateTime).Value = u.add_data;
                        cmd.Parameters.Add("@add_por", SqlDbType.NVarChar).Value = u.add_por;

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        isSucesso = rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados: " + ex.Message + "\n" + ex.StackTrace);
            }
            return isSucesso;
        }
        #endregion

        #region Atualizar dados no banco de dados
        public bool Update(userBLL_Class u)
        {
            bool isSucesso = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(myconsnstring))
                {
                    // Corrigido o erro de sintaxe no comando SQL (UPTADE -> UPDATE)
                    string sql = "UPDATE tbl_usuarios SET nome=@nome, s_nome=@s_nome, email=@email, usuário=@usuário, senha=@senha, contato=@contato, " +
                                 "endereco=@endereco, sexo=@sexo, usuário_tipo=@usuário_tipo, add_data=@add_data, add_por=@add_por WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@nome", SqlDbType.NVarChar).Value = u.nome;
                        cmd.Parameters.Add("@s_nome", SqlDbType.NVarChar).Value = u.s_nome;
                        cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = u.email;
                        cmd.Parameters.Add("@usuário", SqlDbType.NVarChar).Value = u.usuário;
                        cmd.Parameters.Add("@senha", SqlDbType.NVarChar).Value = u.senha;
                        cmd.Parameters.Add("@contato", SqlDbType.NVarChar).Value = u.contato;
                        cmd.Parameters.Add("@endereco", SqlDbType.NVarChar).Value = u.endereco;
                        cmd.Parameters.Add("@sexo", SqlDbType.NVarChar).Value = u.sexo;
                        cmd.Parameters.Add("@usuário_tipo", SqlDbType.NVarChar).Value = u.usuário_tipo;
                        cmd.Parameters.Add("@add_data", SqlDbType.DateTime).Value = u.add_data;
                        cmd.Parameters.Add("@add_por", SqlDbType.NVarChar).Value = u.add_por;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = u.id;

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        isSucesso = rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados: " + ex.Message + "\n" + ex.StackTrace);
            }
            return isSucesso;
        }
        #endregion

        #region Deletar dados no banco de dados
        public bool Delete(userBLL_Class u)
        {
            bool isSucesso = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(myconsnstring))
                {
                    string sql = "DELETE FROM tbl_usuarios WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = u.id;

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        isSucesso = rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar dados: " + ex.Message + "\n" + ex.StackTrace);
            }
            return isSucesso;
        }
        #endregion
    }

}
