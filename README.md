# SoftwareEngineeringChallenge
Esta es mi solución de código desarrollando el challenge proporcionado.

Para cumplir con las expectativas utilicé como proyecto principal web api. Y trate de usar la mayor parte de conceptos e implementarlos y así poder solventar las preguntas que al inferior del documento se presenta.

Primero desarrollé la lógica del programa tratando de separar todos los concetos que se necesitan, entre ellos, destacan 3 principales problemas a solucionar.

1.- Saber cuál de los nombres de cada una de las canicas en la lista es palíndromo.

2.- Obtener solo aquellas que en su peso sea igual o menor a 0.5 oz

3.- Ordenar la lista de nombres de las canicas conforme a una regla especifica.(ROYGBIV)

Utilizando Net Core 6 solucioné el problema creando una entidad que contenga todas las propiedades necesarias, solo expuse un método GET en el servicio puesto que no creo necesitar más. 

Esta solución puede ser incluida en Azure como tecnología Cloud, mediante ella podemos registrar nuestro web api haciendo uso de las mejores prácticas como incluir CORS o HATEOAS. Y ser administrada desde el portal y así ser accesible implementando Open Api y Swagger.

Con la inyección de dependencias el servicio se hace escalable ya que incluyendo servicios estos pueden cambiar su firma y su comportamiento sin afectar la funcionalidad completa del programa. 

Y con toda la configuración viniendo desde el appsettings.json esta se oculta al momento de ser publicada y podemos incluir configuraciones extra que podemos utilizar más adelante.

Sobre la automatización, creo que es importante adoptar las nuevas tecnologías, con nuestro servicio en Azure podemos hacer uso del ADO (Azure DevOps) para implementar la gestión de todo el código y a su vez tener todo en una misma plataforma. 

También de pueden implementar otras tecnologías como Jenkins, Nexus (Repository Manager) SonarQube y GitHub para implementar DevOps en nuestra solución y mantener la escalabilidad. 

