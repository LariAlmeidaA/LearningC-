using System;
//Creation of the Car class
class Carro {
    private String marca = "Toyota";//Variable declaration and value assignment
    public void MostrarMarca()//Method creation
    { 
        Console.WriteLine("A marca do carro é:" + marca);//The method shows the brand
    }

    public void AlterarMarca(string novaMarca)//The method to change the brand
    {
        marca = novaMarca;
    }
}
// variable can be accessed by any method that is within the class, since it is not embedded in the
class Programa //Program execution
{
    static void Main(string[] args) { 
        Carro meuCarro = new Carro(); //Criando uma nova instância(Modelo ou objeto, podemos assim entender)
        meuCarro.MostrarMarca(); //Mostrando o valor atribuído a carro
        meuCarro.AlterarMarca("Honda"); //Alterando nome da marca
        meuCarro.MostrarMarca();//Mostrando o nome novo que foi atribuído
    }
}
