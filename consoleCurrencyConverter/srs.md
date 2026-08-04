<div style="max-width: 800px;">

1. **Objetivo**<br>
Desarrollar una aplicación de consola en C# que permita convertir un monto desde una moneda de origen hacia una moneda de destino utilizando el dólar estadounidense (USD) como moneda de referencia.

2. **Requisitos Funcionales (RF)**<br>
RF1. El sistema almacenará una base de datos con las monedas disponibles y su cotización respecto al dólar estadounidense.
RF2. El sistema solicitará al usuario la moneda de origen.
RF3. El sistema validará que la moneda de origen exista en la base de datos.
RF4. El sistema solicitará el monto a convertir.
RF5. El sistema validará que el monto ingresado sea un valor numérico válido.
RF6. El sistema solicitará al usuario la moneda de destino.
RF7. El sistema validará que la moneda de destino exista en la base de datos.
RF8. El sistema calculará el equivalente del monto ingresado en dólares estadounidenses.
RF9. El sistema calculará el monto equivalente en la moneda de destino.
RF10. El sistema mostrará el resultado de la conversión por consola.

3. **Reglas de Negocio (RN)**<br>
RN1. El dólar estadounidense (USD) será la moneda base utilizada para todas las conversiones.
RN2. El sistema trabajará únicamente con cinco monedas predefinidas para este prototipo.
RN3. Las cotizaciones serán valores fijos definidos en el código fuente.
RN4. No se obtendrán cotizaciones desde Internet ni desde archivos externos.

4. **Requisitos No Funcionales (RNF)**<br>
RNF1. La aplicación será una aplicación de consola.
RNF2. El desarrollo se realizará utilizando C# y .NET.
RNF3. La interacción con el usuario se realizará mediante consola.
RNF4. El programa no utilizará bases de datos ni servicios externos.
5. **Casos de prueba**<br>
(Los completaremos cuando esté implementado el prototipo.)

6. **Posibles mejoras (Backlog)**<br>
⬜ Leer cotizaciones desde un archivo.<br>
⬜ Obtener cotizaciones desde una API.<br>
⬜ Permitir agregar nuevas monedas.<br>
⬜ Mostrar todas las cotizaciones disponibles.<br>
⬜ Mostrar el historial de conversiones.<br>
⬜ Permitir realizar múltiples conversiones sin reiniciar la aplicación.
⬜ Mejorar reporte por consola (agregar mensajes, símbolos de $, moneda (ARS, USD, etc))

</div>