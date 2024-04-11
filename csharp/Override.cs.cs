public class Personagem{
    private String nome;
    private string elemeto;
    private int idade;

    public Personagem(string nome, string elemento,int idade,){
        Nome = nome;
        Elemento = elemento
        Idade = idade;
        
    }

    public string Nome {
        get {return nome;}
        set {nome = value;}
    }
    public string Elemento{
        get {return elemento;}
        set {elemento = value;}
    }
    public int Idade{
        get{ return idade;}
        set{ idade = value;}
    }

    public virtual void Nadar (){
        console.WriteLine("Nadar rapido");
    }
}


public class Sereia : Personagem{ 
    private string nadadeira;
    public Sereia(string nome, string elemento, int idade,  string nadadeira): base(nome,elemento,idade){
        Nadadeira = nadadeira;
    }
    public string Nadadeira {
        get {return nadadeira;}
        set {nadadeira = value;}
    } 
    public override void Nadar(){
        Console.WriteLine ("A sereia esta nadando rapido");
    }
}


