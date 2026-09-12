# Laboratorio # 2 — Clases en C#

**Fecha:** 7/9/2026

## Contenido del Repositorio

Este laboratorio corresponde al curso **Herramientas de la Programación Aplicada III (.Net)**. Se desarrollaron tres versiones progresivas de una aplicación de consola llamada **Libro de Calificaciones**, cuyo objetivo es practicar la creación de clases en C#: desde un método simple sin parámetros, pasando por el paso de parámetros a un método, hasta el uso de constructores y propiedades (encapsulamiento).

## Tecnologías Utilizadas

- **Lenguaje / Framework:** C# — .NET 10.0 (aplicaciones de consola)
- **IDE:** Visual Studio

## Ejercicios

- **Ejercicio 1 — `Aplicacion libro de calificacion`:** Clase `LibroCalificacion` con un método `MostrarMensaje()` sin parámetros que imprime un mensaje de bienvenida fijo por consola.
- **Ejercicio 2 — `LibroCalificaciones2`:** Clase `MilibroCalificaciones` con un método `MostrarMensaje(string nombreDelCurso)` que recibe el nombre del curso como parámetro (solicitado al usuario con validación de campo vacío) y lo muestra en el mensaje de bienvenida.
- **Ejercicio 3 — `LibroCalificaciones_3`:** Clase `LibroCalificaciones` con **constructor** que recibe el nombre del curso y una **propiedad** `NombreCurso` (get/set). Se crean dos instancias distintas y se permite reasignar el nombre del curso ingresado por el usuario, validando que no quede vacío.

## Estructura de Carpetas

```
Lab_2/
├── Aplicacion libro de calificacion/   # Ejercicio 1: método sin parámetros
│   ├── Program.cs
│   └── Class1.cs
├── LibroCalificaciones2/               # Ejercicio 2: método con parámetro
│   ├── Program.cs
│   └── Class1.cs
├── LibroCalificaciones_3/              # Ejercicio 3: constructor + propiedad
    ├── Program.cs
    └── Class1.cs
```

## Autor y Contexto

- **Nombre:** Kankibe
- **Institución:** Universidad Tecnológica de Panamá (UTP)
- **Curso:** Herramientas de la Programación Aplicada III (.Net) — Ing. Irina Fong
- **Fecha de Realización:** 12/09/2026
