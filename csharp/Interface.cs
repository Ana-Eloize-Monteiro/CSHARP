using System;

interface IAtaque
{
    void Atacar();
}

public abstract class Heroi
{
    // Atributos da classe Heroi
    public string nome;
    public int vida;

    // Construtor da classe Heroi
    public Heroi(string nome, int vida)
    {
        this.nome = nome;
        this.vida = vida;
    }

    // Getters e setters para os atributos
    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetVida()
    {
        return vida;
    }

    public void SetVida(int vida)
    {
        this.vida = vida;
    }

    // Método abstrato para o ataque
    public abstract void Forca();

    public abstract void Especial();
}

class Guerreiro: Heroi, IAtaque
{
    public Guerreiro(string nome, int vida) : base(nome, vida)
    {
    }

    public void Atacar()
    {
        Console.WriteLine("Guerreiro ataca com espada!");
    }

    public override void Forca()
    {
        Console.WriteLine($"{nome} atacou com o seu martelo!");
    }

    public override void Especial()
    {
        Console.WriteLine($"Ataque devastador!");
    }

}

class Mago: Heroi, IAtaque
{
    public Mago(string nome, int vida) : base(nome, vida)
    {
    }

    public void Atacar()
    {
        Console.WriteLine("Mago ataca com varinha mágica!");
    }

    public override void Forca()
    {
        Console.WriteLine($"Mago invoca uma barreira de proteção!");
    }

    public override void Especial()
    {
        Console.WriteLine($"Mago tem um aumento no poder!");
    }
}

class Arqueiro: Heroi, IAtaque
{
    public Arqueiro(string nome, int vida) : base(nome, vida)
    {
    }

    public void Atacar()
    {
        Console.WriteLine("Arqueiro ataca com as sua flecha!");
    }

    public override void Forca()
    {
        Console.WriteLine($"Arqueiro atacou com as seu arco e flecha!");
    }

    public override void Especial()
    {
        Console.WriteLine($"Arqueiro recebe super velocidade para causar mais dano!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        //Criando instâncias das classes corretamente
        IAtaque ferreiro = new Ferreiro("Ferreiro", 1000);
        IAtaque feiticeira = new Feiticeira("Feiticeira", 1000);
        IAtaque duende = new Duende("Duende", 1000);

        // Chamando o método Atacar() de cada instância
        ferreiro.Atacar();
        feiticeira.Atacar();
        duende.Atacar();
    }
}
