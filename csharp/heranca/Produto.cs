    public class Produto{
        private String produto ;
       
        private decimal preco;

        private String descricao;

        private String categoria;

         public Produto(string nome,decimal preco, string descricao, string categoria){
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
            this.categoria = categoria;
        }

        public string Nome {
            get {return nome;}
            set {nome= value;}
        }
        public decimal Preco {
            get {return preco;}
            set {preco=value;}
        }
        public string Descricao{
            get{ return descricao;}
            set{descricao = value;}
        }
        public string Categoria{
            get{ return categoria;}
            set{ categoria = value;}
        }
    }

     public class ConsoleGame : Produto{
        private int capacidadeArmazenamento;

        public ConsoleGame(string nome,decimal preco, string descricao, string categoria, int capacidadeArmazenamento) : base(nome,preco,descricao,categoria) {
            CapacidadeArmazenamento = capacidadeArmazenamento
        }

        public string CapacidadeArmazenamento{
            get{ return capacidadeArmazenamento;}
            set{ capacidadeArmazenamento = value;}
        }
    }

    public class Jogo : Produto {
        private string Genero ;

        public Jogo(string nome,decimal preco, string descricao, string categoria, string Genero) : base(nome,preco,descricao,categoria)
         {
            Genero = genero
        }

        public string Genero{
            get{ return genero;}
            set{ genero = value;}
        }
    }

      public class Acessorio : Produto {
        private string Acessorio;

        public Acessorio(string nome,decimal preco, string descricao, string categoria, string Acessorio) : base(nome,preco,descricao,categoria)
         {
            Acessorio = acessorio;
        }

        public string Acessorio{
            get{ return acessorio;}
            set{ acessorio = value;}
        }
      }

        public class Colecionavel : Produto {
        private bool edicaoLimitada;

        public Colecionavel (string nome,decimal preco, string descricao, string categoria, bool Colecionavel) : base(nome,preco,descricao,categoria)
         {
            EdicaoLimitada = edicaoLimitada;
        }

        public string EdicaoLimitada{
            get{ return edicaoLimitada;}
            set{ edicaoLimitada = value;}
        }
      }
      public class Program {
        
        public static void main (String[] args){

            Produto produto;
            produto = new ConsoleGame ("Playstation 5", 5.900,"Console de Video Game Playstation 5 Slm com 1 Tera de armazenamneto", "Console", 1024000 ) ;

            Jogo jogo= new Jogo ("Marvel's Spider-Man 2 PREMIUM",  299.9, "Jogo completo Marvel'S Spider-Man 2 para PS5." ,"Jogo PS5", "Acao e Aventura");
             
            Acessorio acessorio= new Acessorio (fone de ouvido );

            Colecionavel colecionavel= new Colecionavel( Jogo War Edição Especial) ;
        }
      }