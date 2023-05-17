using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Marca
    {


public int Codigo_Produto { get; set; }

public string NomeMarca { get; set; }

public DateTime DataCadastro { get; set; }


List<Marca> listaDeMarcas = new List<Marca>();


public Marca Cadastrar_Marca()  // metodo de cadastro de marca
{

Marca NovaMarca = new Marca();

return NovaMarca;
}


public void Listar()


{



}


public void DeletarMarca(int Codigo_Produto )
{

return ;

}


    }
}


