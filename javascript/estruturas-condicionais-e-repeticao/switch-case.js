// Funçao para exibir informacoes sobre cada classe de personagem
function exibirInfoclasse(classe) {
    switch (classe) {
    case "Guerreiro":
    console.log("Classe: Guerreiro");
    console.log("Descrição: Os guerreiros são combatentes corpo a corpo resistentes, especializados no uso de armas e armaduras pesadas.");
    console. log("Habilidades: Ataque poderoso, resistência a danos.");
    break;
    case "Mago":
    console. log("Classe: Mago");
    console. log("Descricao: Os magos sao mestres do poder arcano, capazes de lancar feiticos poderosos e controlar os elementos.");
    console. log("Habilidades: Magias de ataque, controle elemental.");
    break;
    case "Ladino":
    console. log("Classe: Ladino");
    console.log("Descrição: Os ladrões são especialistas em furtividade e astúcia, capazes de realizar ataques furtivos e desarmar armadilhas.");
    console.log("Habilidades: Furtividade, ataques precisos.");
    break;
    default:
    console. log("Classe nao reconhecida. Escolha entre Guerreiro, Mago ou Ladino.");
    }
}
    
    // Chamando a função e passando como parâmetro "Mago"
    exibirInfoClasse("Mago");