using System;

public abstract class Protagonista
{
    public string nome;
    public int vida;

    public Protagonista(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }
    public string GetNome(){
        return nome;
    }

    public void SetNome(string nome){
        this.nome = nome;
    }
public string GetVida(){
        return nome;
    }

    public void SetVida(string nome){
        this.nome = nome;
    }


    public abstract void Atacar();

}

public class Elfo : Protagonista
{
    public Elfo(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou com o seu cajado!");
    }

    public override void Aspectoflamejante()
    {
        Console.WriteLine($"{Nome} invocou uma magia para atacar!");
    }
}

public class Fada : Protagonista{
    public Fada(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou com um feitiço com sua varinha magica!");
    }

    public override void Escudo()    {

        Console.WriteLine($"{Nome} criou uma barreira mágica para se defender!");
    }
}

public class Vampiro: Protagonista
{
    public Vampiro(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou com suas presas!");
    }

    public override void Teletransporte()
    {
        Console.WriteLine($"{Nome} se telantrasportou rapidamente para se defender!");
    }
}

public class Lobisomen : Protagonista
{
    public Lobisomen(string nome, int vida) : base(nome, vida) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} atacou com suas garras!");
    }

    public override void Proteger()
    {
        Console.WriteLine($"{Nome} Uivou para se proteger!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Protagonista elfo = new Elfo ("Elfo", 1000);
        Protagonista fada = new Fada("Fada", 90);
        Protagonista vampiro = new Vampiro ("Vampiro", 110);
        Protagonista lobisomen = new  Lobisomen("Lobisomen", 170);

        elfo.Atacar();
        fada.Atacar();
        vampiro.Atacar();
        lobisomen.Atacar();

        elfo.Aspectoflamejante(); // Chamando o método concreto adicionado
        fada.Escudo(); // Chamando o método concreto adicionado
        vampiro.Teletransporta(); // Chamando o método concreto adicionado
        lobisomen.Proteger(); // Chamando o método concreto adicionado
    }
}