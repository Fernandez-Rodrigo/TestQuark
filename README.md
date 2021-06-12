# TestQuark
Resolución test quark academy
Por favor, especifica tu nombre completo: Rodrigo Fernandez

¿C# permite herencia múltiple?
No, C# No permite herencia múltiple, si se pueden tener hacer herencia y aplicar interfaces al mismo tiempo, pero no se puede tener 2 padres.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
Cuando los objetos que van a heredar de la clase abstracta comparten ciertas características que permiten la utilización de los métodos definidos en la clase padre.
 En caso de tener la clase padre Prenda, puedo hacer que sea abstracta y definir ciertos métodos que sean comunes a las clases hijas de prenda, pueden compartir por ejemplo
 el método Lavado()  o Tejido() ya que toda prenda puede utilizar esos métodos sin problemas. Pero si el problema plantea generar prendas que se lavan en agua caliente o con 
 productos específicos, podría implementar una interfaz para aquellas que requieran este tipo de procesos.

¿Qué implica una relación de Generalización entre dos clases?
La generalización se aplica cuando en 2 objetos puedo utilizar la frase "es un tipo de..", la clase hija es un tipo de la clase padre.

¿Qué implica una relación de Implementación entre una clase y una interfaz?
Que una clase debe implementar si o si los métodos declarados en la interfaz aplicada.

¿Qué diferencia hay entre la relación de Composición y la Agregación?
Que en la composición los objetos tienen una relación directa de existencia, si uno deja de existir el otro también; en la Agregación son objetos aislados que no dependen 
mutuamente para poder seguir existiendo.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
V
Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
F
Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 
F
