using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Usuario
    {







public string Nome { get; set; }


public string Email{get;set;}


public string Senha{get;set;}


public DateTime DataCadastro;






public void Cadastrar_usuario()

{

this.Nome="William";
this.Senha="1234";
this.Email="teste";

}



public void Deletar_usuario()

{

this.Nome=" ";
this.Senha=" ";
this.Email=" ";




}


    }
}


