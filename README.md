[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

¿String es una tipo por valor o un tipo por referencia?

string es un tipo por referencia, ya que internamente es un objeto de la clase System.String. Sin embargo, se comporta como si fuera inmutable, lo que significa que cada vez que modificás un string, en realidad se crea uno nuevo en memoria.

¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape permiten insertar caracteres especiales dentro de una cadena. Las más comunes son:

\n:	Nueva línea
\t:	Tabulación
\\:	Barra invertida (\)
\":	Comillas dobles (")
\':	Comillas simples (')
\0:	Carácter nulo
\f:	Salto de página

¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena?

@ permite escribir cadenas textuales donde las secuencias de escape no se interpretan. Es muy útil para rutas de archivo o texto con muchas barras invertidas. Ej: 
string ruta = @"C:\Usuarios\Juan\Documentos";

$ permite interpolación de cadenas, es decir, insertar variables dentro del texto usando {}. Ej: 
string nombre = "Juan";
string saludo = $"Hola, {nombre}!";