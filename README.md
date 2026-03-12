He creado un script llamado PlayerController, dentro he creado las variables velocidad,
fuerzasuelo y rb.
En la funcion start() cojo el rigidbody del componente actual con this. y lo 
guardo en la variable creada rb.
Dentro de la funcion update() tengo una parte donde me centro en el movimiento del personaje usando getaxis() para
poder moverme con cualquier dispositivo, ya sea, mando, teclado. Creo un vector y uso el movimiento que coje del personaje 
en horizontal y vertical y uso la velocidad para modificar la posicion.
Igualo la velocidad del rigidbody a este movimiento.

En la parte de salto tengo un condicional, que comprueba que si se clickea el espacio y esta en el suelo, llama
a la funcion salta(). Esta funcion usa la variable fuerzasuelo para darle impulso a el jugador hacia arriba y pone
el booleano de suelo en falso.
La funcion oncollisionenter se usa para verificar los tags y ver si el elemento que toca tiene el tag "suelo"
