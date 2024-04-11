public class Personagem{
    private String nome;
    private int idade;
    private string poder;
  
    public Personagem(String nome , int idade, string poder){
        Nome = nome;
        Idade = idade;
        Poder = poder;
    }
    
 public string Nome{
    get{ return nome;}
    set{ nome = value;}
 }
 public decimal idade{ 
    get{return idade;}
    set{ idade = value;}
 }
 public string Poder{
    get { return poder;}
    set{poder = value;}
 }
}
public class Sereia : Personagem{
    private string Nadadeira;
  
    public Sereia (string nome, int idade, string poder):base(nome, idade, poder){
        Nadadeira = nadadeira;
    }

    public string Nadadeira{
        get{ return nadadeira;}
        set{ nadadeira = value;}
    }
}
public class Feiticeira : Personagem{
    private string feiticos;
   
    public Feiticeira (string nome, int idade, string poder):base(nome, idade, poder){
        Feiticos = feiticos;
    }
  
    public string feiticos{
        get{ return feiticos;}
        set{  feiticos = feiticos;}
    }
}
public class Fada : Personagem{
    private string poderosa;
        public Acessorio(string nome, int idade, string poder):base(nome, idade, poder){
        Poderosa = poderosa;
    }
    
    public string poderosa{
        get{ return poderosa;}
        set{  poderosa = value;}
    }
}

public class Program{

    public static void main (String [] args){

        Personagem personagem;
        Sereia sereia= new Sereia ("Sereia", 26, "A sereia tem a habilidade de nadar rapido");
   
        Feiticeira feiticeira = new Feiticeira("Feiticeira", 299, "A Feiticeira lança feiticos");

        Fada fada = new Fada ("Fada", 799, "A fada é super poderosa e lanca magias");
        
   
    } -5
}
public class Personagem {
    public virtual void Atacar(){
        Console.WriteLine("Ataque primário")
    }
}

public class Sereia: Personagem{
    public override void Atacar(){
        Console.WriteLine("Sereia ataca com a nadadeira!")
    }
}

public class Feiticeira: Personagem{
    public override void Atacar(){
        Console.WriteLine("Feiticeira ataca com feitico!")
    }
}

public class Fada: Personagem{
    public override void Atacar(){
        Console.WriteLine("Fada ataca com a magia!")
    }
}
}

