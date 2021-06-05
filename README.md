# quark_exam

Instrucciones de uso
1 - Abrir programa
2 - Ingresar datos de tienda (nombre y dirección) y presionar crear tienda
3 - Ingresar datos del vendedor (nombre, apellido y código) y presionar crear vendedor
4 - Probar distintas combinaciones de cotizaciones eligiendo distintas características y presionando Cotizar cuando se desee obtener una cotización.
5 - Abrir el Historial Cotizaciones para revisar las cotizaciones creadas anteriormente
6 - Probar de crear nuevas cotizaciones y ver como se actualiza el historial
7 - Para finalizar cerrar la ventana Cotizador Express



Respuesta a las preguntas Parte H
Nombre Completo Federico Cara
1. No, a lo sumo se puede heredar de una clase e implementar 1 o más interfaces
2. Las interfaces se utilizan para definir comportamientos (métodos) en una clase siguiendo una declaración predeterminada en la interfaz. La herencia en cambio define que es la clase, lo que implica compartir atributos y métodos con la/s super clase/s (clase padre, abuela, etc.). Un ejemplo simple puede ser definir la clase Animal, la subclase Perro y la subclase Loro. Tanto Perro como Loro son animales y pueden compartir atributos. Pero a la vez podríamos definir una interfaz ICaminador y otra IVolador y hacer que Perro implemente la primera y Loro la segunda.
Abajo el código aproximado.

public class Animal{
	public int cantidadPatas {get; set;}
	...
}

public class Perro : Animal, ICaminador{
	...
	public void Caminar{ ... }
}

public class Loro : Animal, IVolador{
	...
	public void Volar{ ... }
}

public interface ICaminador{
	void Caminar();
}

public interface IVolador{
	void Volar();
}

3. Cuando hay una relación de generalización entre una clase A y una B (A -> B), significa que la clase A es del tipo de B, es decir que A hereda los atributos (y demás características) de B. En la práctica es muy util cuando tenemos una clase funcionando y queremos hacer una clase que sea igual pero sume nuevas características (atributos) y comportamientos (métodos).

4. En la implementación (realización en UML), una clase tiene un contrato con la interfaz que le representa estar forzada a implementar métodos declarados en la interfaz. Y por lo tanto desde afuera (es decir desde el contexto de otras clases), al saber que una clase implementa una interfaz podemos estar seguros que contendrá los métodos declarados en la interfaz.

5. 
Cuando hay una relación de composición (A -> B, A contiene a B), nos aseguramos que solo A sepa de la existencia de B y se encargue de su creación y de su destrucción, por lo que desde afuera nunca interactuaremos directamente con instancias de B (aunque A se puede encargar de exponer el contenido de B con indirecciones). Además que si destruímos a A, todas las partes B serán destruidas también.

En el caso de la agregación, A está compuesto por las partes B. Pero a diferencia de la composición, en este caso B puede ser creado en otras clases, y posteriormente se puede agregar o quitar de A. Por lo tanto no tienen una dependencia total.

6. A) Verdadero
   B) Falso. Las asociaciones pueden tener cualquier tipo de cardinalidad y direccionalidad.
   C) Falso. Esto es una diferencia entre agregación y composición