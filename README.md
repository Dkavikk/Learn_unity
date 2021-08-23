## Agrupacion de proyectos de unity.

***

Esta carpeta contiene todo lo que eh aprendido de unity utilizando un curso de Udemy

## Creditos: Complete C# Unity Game Developer 3D, of Ben Tristem, Rick Davidson,GameDev.tv Team. [Puedes ver el curso aqui](https://www.udemy.com/course/unitycourse2/).

### **Nota**: este repositorio lo cree cuando ya tenia la seccion 1 y 2 ya creada 

# Secciones

---

## **Seccion** 1:
  - Aprendi a Exportar y Inportar Prefabs y cree mi primer script en C#

## Seccion 2:
#### Todo lo aprendido lo hice creando un ObtacleCourse
- **Resumen:** ObtacleCourse es un MiniJuego es una pista de obtaculos donde se tiene que llegar del punto A al punto B Chocando lo menos posible con los obtaculos. Hay diferentes tipos de obtaculos, como por ejemplo obtaculos que su posicion es estatica pero rotan, otros que al pasar por un lugar caen y otros que no son estaticos y se pueden mover.
	- ![ObtacleCourse](https://github.com/The-Dkavik/Learn_unity/blob/main/Resources/ObstacleCourse.png?raw=true)

- Aprendizaje
	- Variables tipo:
		- float
		- int
		- bool
	- ```Time.deltaTime```
	- ```Time.time```
	- ```Input.GetAxis()```
	- Method
	- ```OnCollisionEnter()```
	- ```GetComponent<>()``` // *Lo aprendi a usar tanto en el mismo objeto como tambien en el objeto colisionado*
	- Guardar los ```GetComponent<>()``` en variable
	- ```Random.Range(N°min, N°max)```
	- ```if()```
	- ++, para incrementar las variable 1 a 1 
	- Transformaciones de tipo:
		- ```transform.Translate(x,y,z)```
		- ```transform.Rotate(x,y,z)```
	- Modificacion de Prefabs
	- Acceder de un Script a otro Script

## Seccion 3:
#### Todo lo aprendido lo hice creando un juego de una naver voladora 
- **Resumen:** El juego Del cohete es un minijuego donde ay que manejar una cohete y llevarlo del punto A al punto B. En el aprendi a utilizar efectos de sonido, efecto visuales, inputs.
	- ![El juego Del cohete](https://github.com/The-Dkavik/Learn_unity/blob/main/Resources/ElJuegoDelCohete.png?raw=true)

- Aprendizaje
	- Integracion de sonido
	- Integracion de efectos
	- Modificacion de vectore
	- Utilizar Build Settings
	- ```AddRelativeForce()```
	- ```Input.GetKey()```
	- ```Mathf.Sin```
	- ```Application.Quit()```
	- ```switch ()```
	- ```Invoke()```
	- ```SceneManager.```
		- ```LoadScene```
		- ```sceneCountInBuildSettings```
		- ```GetActiveScene().buildIndex ```