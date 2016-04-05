# AppPMDM

***Documentación del proyecto de PMDM***

En esta documentacion explicaremos el contenido del proyecto

# Tabla de contenido
- [Intro](#intro).
- [El Código](#el-código).
- [Seguridad](#seguridad).
- [FAQs](#faqs).

## Intro:

El proyecto es un videojuego en vista 2d desarollado sobre el motor gráfico de Unity 5. Este juego puede ser usado tanto en dispositivos móviles como en Pc o incluso como juego Flash en una web.

La mecánica del juego es  sencilla, el personaje principal se va moviendo por turnos con respecto a los enemigos desde un punto inicial hasta la salida.
Para esto el personaje dispone de una cantidad limitada e movivmientos, cada movimiento gasta una unidad de comida.
Al principio el personaje dispone de 100 unidades y al empezar cada siguiente nivel la cantidad es igual a la que tenia al terminar el nivel anterior.
En el escenario se van generando aleatoriamente comida, enemigos y muros.
Hay dos tipos difententes de comida que suman 10 y 20 unidades, hay dos tipos de enemigos que restan 20 y 40 unidades y los muros se pueden destruir gastando 2 unidades.
La partida termina al quedarnos sin comida. Cuando ocurra se nos dirá cuantos dias hemos sobrevivido y cual ha sido nuestra mejor puntuación.

En el repositorio esta el contenido de la carpeta Assets del proyecto, esta es la estructura que se usa normalmente para organizar un proyecto, cada uno puee organizarlo a su gusto:

* Animations: contiene todas las animaciones que hay en el juego.
* Audio: contiene los archivos de audio usados.
* Fonts: contiene los tipos de letras usados.
* Materials: aqui se guardan los materiales crados y usados en el juego.
* PhysicsMaterials: contiene material con caracteristicas que afectan a las fisiscas del juego.
* Prefabs2: contiene los objetos creados.
* Scenes: contiene las escenas creadas.
* Scipts2: contiene scripts (código del juego).
* ScriptsPrueba: contiene scripts (código del juego).
* Sprites: contiene las imagenes o conjunto de imagenes que sirven para texturizar el juego.
* SpritesPrueba: contiene las imagenes o conjunto de imagenes que sirven para texturizar el juego.

![**](https://github.com/mpereirasalgado/Module-TutorialE/blob/master/openacademy/images/primera.png)


## El Código 

El código del juego se divide en 12 Scripts (hay mas scripts que forman parte de una futura modificación del juego):

* BoardManager
* GameManager
* Loader
* Player
* Ememy
* Wall
* MovingObject
* SoundManager
* AspectUtility
* scroll
* EstadoJuego
* BotonCargarEscena

###BoardManager

Este script contiene una parte muy importante de juego, aqui se define todo el tablero de juego.
Se marcán los limites del mapa, se genera una rejilla de la medida deseada en la cual iran apareciendo aleatoriamente según unos pámetros que nosotros definimos la comida los enemigos y los muros.
Se especifica el punto de inicio y el punto de salida para que al generar el tablero aleatorio no se vean afectados estos.

### GameManager

En este script cargamos el script anterior.
Controlamos la mayor parte del juego. Hay metodos para controlar que al generar objetos aleatorios no se sobreescriban unos a otros.
Se controla el nivel de dificultad de cada nivel.Se carga la pantalla de espera entre cada nivel.
Se controla el movivmiento de los enemigos con respecto al del personaje.

### Loader

Uso este script asociado con la camara del juego y cargo aqui el script anterior.

### PLayer

Aqui controlamos todo lo que hace el personaje.
Aqui esta la parte del codigo que usa la aplicación para detectar en que dispositivo lo estamos ejecutando y asi definir unos controles.
Se aplican las animaciones al personaje segun convenga y tambien se añade o quita vida según la situación.
Tambien comprobamos si hemos llegado al final para acceder al siguiente nivel o si hemos muerto para lanzar la pantalla de GameOver.

### Enemy 

Muy similar a player.

### Wall

Para poder controlar al objeto Wall.
La cantidad necesaria para poder derivar uno asi como el sonido al hacerlo

### MovingObject

Este script es usado para como control de movimiento de los enemigos y el jugador.

### SoundManager

Controlamos los efectos de audio y musica del juego

### AspectUtility

Este es un script de unity sirve para adaptar el juego a cualquier pantalla. 

### scroll

Para que fonde de l apntalla principal se mueva.

### EstadoJuego

Gracias a este script puedo crear un archivo .dat y guardar la puntucaion maxima para así poder mostrala 
Tambien lo uso para pasar informacion de una escena a otra.

### BotonCargarEscena

Este script asociado a un botón permite cargar la escena deseada.

## Seguridad:

Unity nos porporciona la opción de crear un certificado de seguridad con nuestra propia firma digital de tal manera que al distribuir el proyecto no se pueda modificar sin esas credencialesque solo el creador tiene .

## FAQs
Micael Pereira Salgado

mpereirasalgado@danielcastelao.org

micaelcaballero@gmail.com
