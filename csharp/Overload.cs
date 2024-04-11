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
        Baforada = baforada;
    }
    public string poderosa{
        get{ return poderosa;}
        set{  poderosa = value;}
    }
}

public class Program{

    public static void main (String [] args){

        Personagem personagem;
        Nativo nativo= new Sereia("Sereia", 26, "A sereia tem a habilidade de nadar rapido");
        nativo.Atacar();
        nativo.Atacar( Nadar e atacar com agua);
        Feiticeira feiticeira = new Feiticeira("Fewiticeira", 299, "A Feiticeira lança freiticos");
        feiticeira.Atacar();
        feiticeira.Atacar( lança feiticos para atordoar);
        Dragao dragao = new Fada ("Fada", 799, " A fada ataca com seus poderes");
        dragao.Atacar();
        dragao.Atacar( ataca com magia);
        
   
    } -5
}

public class Personagem{
    public void Atacar(){
        ConsoleWrite.Line("Ataque Básico!");
    }
    public class Atacar(string habilidade){
        ConsoleWrite.Line("Ataque especial: + habilidade");
        
    }
}
public class Sereia : Personagem{
    public void Atacar(){
        ConsoleWrite.Line("Com a habilidade de Nadar rapido!");
    }
}
public class Feiteceira : Personagem{
    public void Atacar(){
        ConsoleWrite.Line("lança feiticos para atacar!");
    }
}
public class Fada : Personagem{
    public void Atacar(){
        ConsoleWrite.Line("Faz magia!");
    }
}
