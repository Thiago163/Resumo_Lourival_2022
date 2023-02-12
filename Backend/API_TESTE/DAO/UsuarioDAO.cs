using API_TESTE.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TESTE.DAO
{
    public class UsuarioDAO
    {
        public List<UsuarioDTO> Listar()
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM dados";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var dado = new List<UsuarioDTO>();

            while (dataReader.Read())
            {
                var dados = new UsuarioDTO();
                dados.id = int.Parse(dataReader["ID"].ToString());
                dados.nome = dataReader["NOME"].ToString();
                dados.email = dataReader["EMAIL"].ToString();
                dado.Add(dados);
            }
            conexao.Close();

            return dado;
        }
            public void Cadastrar(UsuarioDTO dados)
            {
                var conexao = ConnectionFactory.Build();
                conexao.Open();

                var query = @"INSERT INTO Livros (nome, email) VALUES
						(@nome, @email)";

                var comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@nome", dados.nome);
                comando.Parameters.AddWithValue("@email", dados.email);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }
    }

