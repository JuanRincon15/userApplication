# Aplicacion de creacion de usuarios
## Base de datos 
se implemento una base de datos postgreSQL en el entorno local se diseño un esquema en base al siguiente modelado de clases para la solucion 

![image](https://github.com/user-attachments/assets/a559eee3-c758-4b0a-ab92-e9fbc46a90e6)

obedeciendo al modelo se construyeron  4 tablas una de usuarios y tablas parametricas de pais, departamento y municipio relacionadas entre si por ids, el script que genera las tablas esta disponible en la carpeta SQL Scripts del repositorio

![image](https://github.com/user-attachments/assets/c7da2f1a-608d-4619-a63b-f3d8c6dfca34)


## Backend de la aplicacion 
se expusieron 4 servicios para la el registro de los entidades modeladas pais, departamento, municipio y usuario con todos sus datos relacionados

![image](https://github.com/user-attachments/assets/3681bbf5-bf79-400b-aeec-d17da44e0ea5)

![image](https://github.com/user-attachments/assets/e051bac3-91fa-4454-961e-e6ba2d848c21)

Para el registro de la informacion segun la indicacion se implementaron procedimientos almacenados para el registro de la informacion

![image](https://github.com/user-attachments/assets/8ac4211c-5666-4385-b325-171e0b7c604a)

![image](https://github.com/user-attachments/assets/4647463c-9161-4278-a86e-dd563af88f5d)

Finalmente la implemantacion se diseño en base a ar arquitectura hexagonal un patron de diseño que tiene como idea principal la separacion de responsabilidades facilmente intercambiable, independiente de las tecnologias 

![image](https://github.com/user-attachments/assets/63e7772c-dd54-4a67-b3f7-3cad2232eff6)


![image](https://github.com/user-attachments/assets/f03b8f5f-f890-452f-b04e-3f5c5604de98)


 
