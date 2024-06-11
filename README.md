# CinemaHaven

## Errores presentados
Aqui se explicaran algunos errores que se presentaron durante la realizacion de este programa y como fueron solucionados.

- Aparicion de atributos extensos en Json: Esto sucede al intentar conectar nuestras tablas ubicadas `DAL` -> `Entities`. Los ICollection y ID´s deben ser utilizados con el DataAnnotation [JsonIgnore], con este sobre las entidades que hacen referencia al muchos o a uno en la asociacion evitaremos tener que rellenar estos datos que nos pueden llegar a causar un poco de confucion a la hora de insertar o editar un dato en la BD.
- System.InvalidCastException: The field of type System.Single must be a string, array or ICollection type: Este es un error que nos esta diciendo que estamos haceindo algo mal en el momento de la conversion de datos. Esto en mi caso sucedio porque estaba utilizando el DataAnnotation [Maxlength] en un atributo Float, lo cual no es valido. 
