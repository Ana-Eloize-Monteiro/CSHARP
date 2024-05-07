
let a = (1 < 2) || (3 > 4)// true || false = true
let b = (1 > 2) || (3 > 4)// false || false = false
let c = (10 < 20) && (20 < 30)// true && true = true
let d = (20 < 30) && (30 > 40)// true && false = false
let e = (20 < 30) && ! (30 > 40) // true && !false = true
console.log(a, b, c, d, e);
