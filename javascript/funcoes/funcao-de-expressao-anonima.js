// Função de expressão para gerar um número aleatório entre um intervalo especificado
const gerarNumeroAleatorio = function(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
    // Chamando a função para gerar um número aleatório entre 1 e 100
    const numeroAleatorio = gerarNumeroAleatorio(1, 100);
    console.log("Número aleatório:", numeroAleatorio);
    
    