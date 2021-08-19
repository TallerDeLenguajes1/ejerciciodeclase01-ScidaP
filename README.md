# ejerciciodeclase01-ScidaP #
ejerciciodeclase01-ScidaP created by GitHub Classroom
=============
## Ejercicio N°1 ##
R: Aparentemente, la condición del bucle for es incorrecta en este código. Nuestro arreglo de string tiene en total 5 elementos, pero al hacer que la condición sea
"i=0;i<=5;i++", en la linea de abajo estamos intentando acceder al ítem N°6 del arreglo, el cual no existe. Es por esto que conviene utilizar un try catch,
coloco el bucle dentro del try, y un catch por fuera. En caso que falle el bucle y se intente acceder a un índice no existente del arreglo, el catch va a permitirme 
que el programa no se crashee. De todas maneras, habría sido una mejor opción usar list.Length en la condición del bucle, en lugar de un número constante.
---------------
## Ejercicio N°2 ##
