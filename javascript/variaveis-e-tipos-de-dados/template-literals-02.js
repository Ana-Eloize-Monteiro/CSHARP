let preco = 19.99;
let desconto = 0.1;

// Usando template literals com expressões matemáticas
let precoFinal = `0 preço final do produto com desconto é ${preco * (1 - desconto)} reais.`;
console.log(precoFinal); // Saída: "0 preço final do produto com desconto é 17.991 reais."