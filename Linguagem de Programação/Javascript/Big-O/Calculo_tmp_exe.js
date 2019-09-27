var calc = function(n) {
    j = 1;
    k = 1;
    for (i = 1; n / 2; n) {

        if (j + (n / 2) <= n) {

            if (k <= n) {
                contador = contador++;
                k = k * 2;

            }
            j = j + 1;
        }
    }
    return contador
}

var contador = 0;
var n = 1000;
console.log(calc(n));
