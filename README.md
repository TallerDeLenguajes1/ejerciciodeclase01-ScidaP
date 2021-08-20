## Ejercicio N°1 ##
* Aparentemente, la condición del bucle for es incorrecta en este código. Nuestro arreglo de string tiene en total 5 elementos, pero al hacer que la condición sea "i=0;i<=5;i++", en la linea de abajo estamos intentando acceder al ítem N°6 del arreglo, el cual no existe. Es por esto que conviene utilizar un try catch, coloco el bucle dentro del try, y un catch por fuera. En caso que falle el bucle y se intente acceder a un índice no existente del arreglo, el catch va a permitirme que el programa no se crashee. De todas maneras, habría sido una mejor opción usar list.Length en la condición del bucle, en lugar de un número constante.

## Ejercicio N°2 ##
* En este código, la multiplicación de las variables num1 y num2 dá como resultado 1800. La función ToByte() convierte este valor en un int de 8 bits. Esta conversión es imposible porque no se puede representar el número 1800 con solamente 8 bits; usando 8 bits se puede alcanzar la cifra 255 como máximo, o 127 si es que la máquina utiliza complemento a dos (yo sabía que algún día serviría lo que vi en ayoc) (igual no estoy seguro si esa es la razón del error, pero me pareció lo más razonable jejeje). Por lo tanto, al ser una multiplicación que __probablemente__ podría generar un error en ejecución, utilizo un try catch que me ataje el error y no me crashee el programa.

## Ejercicio N°3 ##
* No encuentro la necesidad de usar try catch en este ejercicio, no hay errores potenciales.

## Ejercicio N°4 ##
* En este ejercicio tampoco es necesario usar try catch.. es mucho más conveniente arreglar el WriteLine().
