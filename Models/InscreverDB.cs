using MySqlConnector;
using System;
using System.Collections.Generic;

namespace area51.Models

{
    public class InscreverDB
    {
        private const string DadosConexao = "Database=Etapa4;Data Source=localhost;User Id=root";

public void TestarConexao(){

MySqlConnection Conexao = new MySqlConnection(DadosConexao);

Conexao.Open();

Console.WriteLine("Banco de dados funcionando");

Conexao.Close();

}

public void Excluir(Inscrever user){

MySqlConnection Conexao = new MySqlConnection(DadosConexao);

Conexao.Open();

String QuerySql = "delete from Inscricao Where Id=@Id";

MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);

Comando.Parameters.AddWithValue("@Id",user.Id);

Comando.ExecuteNonQuery();


Conexao.Close();
}



public void Alterar(Inscrever user){

MySqlConnection Conexao = new MySqlConnection(DadosConexao);

Conexao.Open();

String QuerySql = "Update Inscricao set Nome=@Nome, Modalidade=@Modalidade, Idade=@Idade Where Id=@Id";

MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);

Comando.Parameters.AddWithValue("@Id",user.Id);
Comando.Parameters.AddWithValue("@Nome",user.Nome);
Comando.Parameters.AddWithValue("@Modalidade",user.Modalidade);
Comando.Parameters.AddWithValue("@Idade",user.Idade);


Comando.ExecuteNonQuery();


Conexao.Close();
}

public void Inserir(Inscrever user){

MySqlConnection Conexao = new MySqlConnection(DadosConexao);

Conexao.Open();

String QuerySql = "Insert into Inscricao (Nome,Modalidade,Idade) values (@Nome,@Modalidade,@Idade)";

MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);

Comando.Parameters.AddWithValue("@Id",user.Id);
Comando.Parameters.AddWithValue("@Nome",user.Nome);
Comando.Parameters.AddWithValue("@Modalidade",user.Modalidade);
Comando.Parameters.AddWithValue("@Idade",user.Idade);


Comando.ExecuteNonQuery();


Conexao.Close();
}

public List<Inscrever> Listar(){

MySqlConnection Conexao = new MySqlConnection(DadosConexao);
Conexao.Open();
String QuerySql = "select * from Inscricao";
MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);
MySqlDataReader Reader =  Comando.ExecuteReader();
List<Inscrever> Lista = new List<Inscrever>();
while(Reader.Read()){
    Inscrever userEncontrado = new Inscrever();

userEncontrado.Id = Reader.GetInt32("Id");
if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
userEncontrado.Nome = Reader.GetString("Nome");
if(!Reader.IsDBNull(Reader.GetOrdinal("Modalidade")))
userEncontrado.Modalidade = Reader.GetString("Modalidade");

if(!Reader.IsDBNull(Reader.GetOrdinal("Idade")))
userEncontrado.Idade = Reader.GetString("Idade");



    Lista.Add(userEncontrado);
}


Conexao.Close();

return Lista;

}

public Inscrever BuscarPorId(int Id){

MySqlConnection Conexao = new MySqlConnection(DadosConexao);
Conexao.Open();
String QuerySql = "select * from Inscricao where Id=@Id";
MySqlCommand Comando = new MySqlCommand(QuerySql,Conexao);

Comando.Parameters.AddWithValue("@Id",Id);

MySqlDataReader Reader = Comando.ExecuteReader();

Inscrever InscreveEncontrado = new Inscrever();



 if (Reader.Read()){
InscreveEncontrado.Id = Reader.GetInt32("Id");
if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
InscreveEncontrado.Nome = Reader.GetString("Nome");
if(!Reader.IsDBNull(Reader.GetOrdinal("Modalidade")))
InscreveEncontrado.Modalidade = Reader.GetString("Modalidade");
if(!Reader.IsDBNull(Reader.GetOrdinal("Idade")))
InscreveEncontrado.Idade = Reader.GetString("Idade");

 }




Conexao.Close();

return InscreveEncontrado;
}















    }
}