﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Help_Desk.Modelo;

namespace Help_Desk.DAL
{
    public class ChamadoDAO : intChamadoDAO
    {
        public String mensagem ="";
        public bool possui = false;
        SqlDataReader dataReader;
        Conexao conexaoBD = new Conexao();

        public bool VerificarLogin(String login, String senha)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"select id_Usuario from Acesso where nome_Acesso =@login and senha_Acesso = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            cmd.Connection = conexaoBD.Conectar();
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            { 
            atbEstaticos.id_Usuario = Convert.ToInt32(dataReader["id_Usuario"].ToString());
            }
            try
            {
                //HasRows = se tiver linhas
                if(dataReader.HasRows)
                {
                    possui = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro Banco";
            }
            return possui;
        }

        public Chamado PesquisaSolicitantePorID(Chamado chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select nome_Usuario from Usuarios where id_usuario =@id_Usuario";
            cmd.Parameters.AddWithValue("@id_Usuario", atbEstaticos.id_Usuario);

            cmd.Connection = conexaoBD.Conectar();
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                atbEstaticos.nome_Usuario = dataReader["nome_Usuario"].ToString();
            }

            return chamado;
        }

        public void CadastraChamado(Chamado chamado)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Chamados
                    (id_Funcionario,id_Usuario, Setor, Prioridade, Status_Chamado, desc_Chamado, dti_Chamado, dtf_Chamad, solucao_Chamado)
                    values( Null, @id_Usuario, @Setor, @Prioridade, null , @desc_Chamado, @dti_Chamado, null, null)";
            cmd.Parameters.AddWithValue("@id_Usuario", atbEstaticos.id_Usuario);
            cmd.Parameters.AddWithValue("@Setor", chamado.setor);
            cmd.Parameters.AddWithValue("@Prioridade", chamado.prioridade);
            cmd.Parameters.AddWithValue("@desc_Chamado", chamado.descricao);
            cmd.Parameters.AddWithValue("@dti_Chamado", chamado.data);

            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Chamado cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public Chamado PesquisaChamadoPorId(Chamado chamado)
        {

            return chamado;
        }

        public void EditarChamado(Chamado chamado)
        {
            throw new NotImplementedException();
        }

        public void ExcluirChamado(Chamado chamado)
        {
            throw new NotImplementedException();
        }

    }
}
