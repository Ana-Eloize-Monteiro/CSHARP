using System;

public class Personagem
    {

        private string nome;
        private int nivel;
        private double pontuacao;
        private double vida;
        private double forca ;
        private double agilidade;
        private double inteligencia;
        private string [] armasEquipamentos;
    }
    public Personagem (string nome, int nivel, double pontuacao,double vida,double forca,double agilidade,double inteligencia, string[] armasEquipamentos)
    {

        this.nome = nome;
        this.nivel = nivel;
        this.pontuacao = pontuacao;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
        this.inteligencia = inteligencia;
        this.armasEquipamentos = armasEquipamentos;
    }

    public string GetNome(){
        return nome;
    }

    public void SetNome(string nome){
        this.nome = nome;
    }
     public int GetNivel(){
        return nivel;
     }

        public void SetNivel(int nivel){
            this.nivel = nivel;
        }

        public double GetPontuacao(){
            return pontuacao;
        }

        public SetPontuacao(double pontuacao){
            this.pontuacao = pontuacao;
        }

        public double GetVida(){
            return vida;
        }

        public void SetVida(double vida){
            this.vida = vida;
        }

        public double GetForca(){
            return forca;
        }

        public void SetForca(double forca){
            this.forca = forca;
        }
         public void GetAgilidade(){;
         return agilidade;
         }

         public void SetAgilidade(double agilidade){
            this.agilidade = agilidade;
         }
         public double GetInteligencia(){
            return inteligencia;
         }
            public void SetInteligencia(double inteligencia){
                this.inteligencia = inteligencia;
            }
            public string [] GetArmasEquipamentos(){
                return GetArmasEquipamentos;
            }

            public void SetEquipamentos(string[] armasEquipamentos){
                this.armasEquipamentos = armasEquipamentos;
            }

public void Mover(string direcao, double distancia){
    Console.WriteLine($"{GetNome()} esta se movendo na direcao {direcao} por {distancia} passos.");
}

public void Atacar (Personagem alvo){
    Console.WriteLine($"{GetNome ()} esta atacando {alvo.GetNome()}.");
}

public void ReceberDano(double dano){
    GetVida -= dano;
    if ( vida<= 0){
        Morrer();
    }else{
        Console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
    }

// Método para usar uma habilidade public void UsarHabilidade(string habilidade, Personagem alvo)€
Console. WriteLine($"{GetNome()} esta usando a habilidade (habilidade) em {alvo.GetNome()}.");

// Método para subir de nivel public void SubirDeNivel4 nivel++;
Console. WriteLine($"{GetNome()} subiu para o nivel {GetNivel)}!");
}
// Método para quando o personagem morre private void MorrerOt
Console.WriteLine($" {GetNome()} morreu.");
/* Aqui você pode adicionar lógica adicional, como reiniciar o personagem, exibir uma mensagem de game over, etc.
*/

    

class Program{
static void Main(string[] args){
// Criando um objeto(batman) da classe Personagem
Personagem batman = new Personagem("Batman", 1, 0, 100, 90, 80, 100, new string[]{
"Multi-Batarangue", "Lançador de Gel", "Bomba de fumaça", "ULtra Bat-Garra", "Sintetizador de Voz" });
// Exibindo informações do personagem Batman
Console. WriteLine("Personagem Heroi");
Console. WriteLine($"Nome: (batman. GetNome()}");
Console. WriteLine($"Nivel: (batman.GetNivelO}");
Console, WriteLine($"Pontuacao do Batman: (batman. GetPontuacao}");
Console.WriteLine($"Vida: (batman.GetVida()}");
Console. WriteLine($"Forca: (batman.GetForca(}");
Console.WriteLine($"Agilidade: (batman. GetAgilidade}");
Console. WriteLine($"Inteligencia: (batman.GetInteligencia)}");
Console WriteLine($"Armas e Equipamentos: {string.Join(", , batman.GetArmasEquipamentos)});
Console. WriteLine("");

Console.WriteLine("-----------");
Console WriteLine("");
// Criando um objeto (coringa) da classe Personagem

Personagem coringa = new Personagem ("Coringa", 1, 0, 100, 70, 65, , new string[] {
"Gas do Riso", "Flores que Esguicham Ácido", "Baralhas de Carta", "Luva de Choque" });
// Exibindo informações do personagem Coringa
Console. WriteLine("Personagem Inimigo");
Console. WriteLine($"Nome: {coringa. GetNome()}");
 Console. WriteLine($"Nivel: (coringa.GetNivel}");
Console. WriteLine($"Pontuacao do Coringa: {coringa.GetPontuacao()}");
Console .WriteLine($"Vida: {coringa.GetVida()}");
Console. WriteLine($"Forca: {coringa.GetForca}");
Console. WriteLine($"Agilidade: {coringa.GetAgilidade}");
Console. WriteLine($"Inteligencia: {coringa.GetInteligencia}");
Console. WriteLine($"Armas e Equipamentos: {string.Join(", ", coringa.GetArmasEquipamentos())}");
Console. WriteLine("");
Console. WriteLine("----------------");
Console. WriteLine("");

batman. Mover ("norte", 10);
// Coringa movendo
coringa. Mover ("sul", 10);
// Batman batendo no Coringa
batman. Atacar (coringa);
// Batman usando uma habilidade
batman. UsarHabilidade("Multi-Batarangue", coringa);
// Coringa Recebendo dano
coringa. ReceberDano (50);
// Batman ganha pontos
batman. SetPontuacao (50);
Console .WriteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
// Coringa usando uma habilidade
coringa. UsarHabilidade ("Gas do Riso", batman);
// Coringa ganha pontos
coringa. SetPontuacao(30);
Console. WriteLine($"Pontuacao do Coringa: {coringa.GetPontuacao}");
// Batman usando uma habilidade
batman. UsarHabilidade("Ultra Bat-Garra", coringa);
// Coringa Morrendo
coringa. ReceberDano(999); // Para simular a morte
// Batman ganha pontos
batman. SetPontuacao (100);
Console. WriteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
// Subindo de nível após matar Coringa 
batman.SubirgeNivel();
Console. ReadLine();
}
}