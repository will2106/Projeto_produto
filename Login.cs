using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Login
    {


public bool Logado { get; set; } // propriedade Logado


public Login() // metodo login onde valida se o metodo LOGAR recebe como valor booleano TRUE entao executa o Metodo GerarMenu.
{
  Usuario user = new Usuario(); // novo objeto da classe Usuario com nome user

Logar(user);


if (Logado==true)
{
    
GerarMenu();


}

  
}


public void Logar(Usuario user)// metodo logar


{

Console.WriteLine($"Insira seu email:");
string email=Console.ReadLine();

Console.WriteLine($"digite sua senha:");
String senha =Console.ReadLine();


if (email== user.Email && senha== user.Senha)
{   

    this.Logado = true; // sempre usamos o "this" para citar uma propriedade que nao faz parte do metodo onde esta sendo implemantada, ou seja um metodo externo sendo referenciado dentro de outro metodo.
    Console.WriteLine($"Login efetuado com sucesso ! ");
    
}
else
{
    
    Console.WriteLine($"Falha ao logar!");
    


}



}




public void Deslogar()
{



}


public void GerarMenu()


{

Produto produto = new Produto ();// novo objeto produto 
Marca marca =new Marca(); // novo objeto marca

string opcao;



Console.WriteLine(@$"

*********************************************
               MENU DE OPCOES


  [1].CADASTRAR O PRODUTO

  [2].LISTAR O PRODUTO

  [3]. REMOVER O PRODUTO
********************************************
  
  [4]. CADASTRO MARCA
  
  [5]. LISTAR MARCA

  [6]. REMOVER MARCA


  [0]. SAIR

");


 int NovaMarca;
 opcao=Console.ReadLine();
 int codigo;

do
{
    switch (opcao)
{
    case "1":
       //cadastrar o produto 
        produto.CadastrarProduto();
        
        
        
        break;
    
    case "2":
       // listar produto
       produto.ListaDeProdutos();
       

        break;
    
    case "3":
        //remover o produto
        
        Console.WriteLine($"Digite o codigo:");
        
        codigo=int.Parse(Console.ReadLine());
        
        produto.deletarProduto(codigo);
        break;
    
    case "4":
        

        Console.WriteLine($"digite a marca do produto que deseja cadastrar: ");
        string marca_Produto = Console.ReadLine();
        
        marca.Cadastrar_Marca();
        
    
        
        break;
    
    case "5":
        //listar marca
        
        marca.Listar();
        
    
        break;
    
    
       case "6":
        //remover marca
       Console.WriteLine($"Digite o codigo da marca que deseja remover:");
       
       NovaMarca=int.Parse(Console.ReadLine());
       marca.DeletarMarca(NovaMarca);
        
    
        break;
    
    
    case "0":
        Console.WriteLine($"fechando Aplicativo");
        
    
        
        break;
        default:
        break;
}


    
} while (opcao!="0");


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    








}







    }
}






