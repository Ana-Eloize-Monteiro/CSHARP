// Arrow function que soma dois numeros
const soma = (numero1, numero2) => numero1 + numero2;

// Arrow function que subtrai dois números
const subtracao = (numero1, numero2) => numero1 - numero2;

// Arrow function que subtrai dois números
const multiplicacao = (numero1, numero2) => numero1 * numero2;

// Arrow function que subtrai dois números
const divisao = (numero1, numero2) => numero1 / numero2;

// Arrow function executarOperacao que recebe dois números e uma funçao de callback
const executarOperacao = (numero1, numero2, callback) => callback(numero1, numero2);

// Chamando a funcao executarOperacao com a funcao soma como callback
const resultadoSoma = executarOperacao(5, 3, soma);
console.log("Resultado da soma:", resultadoSoma);

// Chamando a funcao executarOperacao com a funcao subtracao como callback
const resultadoSubtracao = executarOperacao(10, 4, subtracao);
console.log("Resultado da subtração:", resultadoSubtracao);

// Chamando a função executarOperacao com a função multiplicação como callback
const resultadoMultiplicacao = executarOperacao(12, 5, multiplicacao);
console.log("Resultado da multiplicaçao:", resultadoMultiplicacao);

// Chamando a função executarOperacao com a função divisao como callback
const resultadoDivisao = executarOperacao(150, 3, divisao);
console.log("Resultado da divisão:", resultadoDivisao);