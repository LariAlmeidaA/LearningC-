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
//Execise one 
//Crie uma classe Calculadora que possui um método Somar(int a, int b). Dentro do método, declare uma variável chamada resultado,
//que é a soma de a e b. Fora do método Somar, tente acessar a variável resultado. O que acontece? Explique o motivo.
class Calculadora
{
    public void Somar(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine("O resultado da soma é " + resultado);
    }
}

// Teste da classe
class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();
        calculadora.Somar(7, 8);

        // Aqui, tente acessar `resultado` fora do método `Somar`.
        // Console.WriteLine(resultado); // Isso deve causar um erro de compilação.
    }
}

//Exercicio 2
//Implemente uma classe Carro com uma variável de instância velocidade e um método Acelerar(), que incrementa velocidade em 10. Crie um segundo método ExibirVelocidade() para imprimir o valor atual da velocidade. 
//Experimente declarar uma variável chamada velocidade dentro do método Acelerar(). Qual valor é exibido ao chamar ExibirVelocidade()?


using System;

class Carro
{
    float velocidade = 0;

    public void Acelerar()
    {
        float velocidade = 10; // Esta é uma nova variável local
        this.velocidade += 10; // Incrementa a variável de instância
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine("A velocidade atual é " + velocidade);
    }

    static void Main()
    {
        Carro carro = new Carro();
        carro.Acelerar();        // Incrementa a velocidade de instância em 10
        carro.ExibirVelocidade(); // Exibe a velocidade da instância (10)
    }
}

