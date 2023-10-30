using SmartKern.Models;

namespace SmartKern.Data;

public class Cliente
{
    public int Id { get; set; }
    public string Nome {get; set;}
    public int ContatoId {get; set;}
    public Contato Contato {get; set;}


    public Cliente()
    {

    }

    public Cliente(int id, string nome, Contato contato)
    {
        Id = id;
        Nome = nome;
        Contato = contato;
    }
}