// Arrow function para calcular o dano causado por um ataque em um jogo
const calcularDano = (ataque, defesa) => {
    // Calcula o dano como 80% do ataque menos 20% da defesa
    const dano = ataque * 0.8 - defesa * 0.2;
    // Retorna o dano, garantindo que seja pelo menos 0
    return Math.max(0, dano);
};
    // Chamando a funçao para calcular o dano causado por um ataque
    const danoCausado = calcularDano(50, 20);
    console. log("Dano causado pelo ataque:", danoCausado);
    
    