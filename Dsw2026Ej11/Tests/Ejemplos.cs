using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var lista = new CasoList();
        List<Alumno> alumnos = new List<Alumno>();
        alumnos.Add( new Alumno(133, "Pedro",7));
        alumnos.Add(new Alumno(155, "Nacho", 6));
        alumnos.Add(new Alumno(444, "Juan", 9));

        lista.AgregarAlumno(alumnos);

        Console.WriteLine($"{lista.BuscarAlumnoPorNombre("Juan")}");
      
         Console.WriteLine($"{lista.BuscarAlumnoPorNombre("Ignacio")?.Nombre ?? "No existe"}");
        lista.EliminarDeterminadoAlumno(alumnos[1]);
        Console.WriteLine("---------");
        lista.GetAlumnos().ForEach(Console.WriteLine);
        Console.WriteLine("---------");
        lista.EliminarAlumnoEnPoicion(0);
        lista.GetAlumnos().ForEach(Console.WriteLine);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var diccionario = new CasoDictionary();

        diccionario.AgregarAlumno(77, new Alumno(133, "Pedro", 7));
        diccionario.AgregarAlumno(44, new Alumno(155, "Nacho", 6));
        diccionario.AgregarAlumno(33, new Alumno(444, "Juan", 9));
        foreach (var alumno in diccionario.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine($"{diccionario.BuscarAlumnoPorClave(44)}");

      
        Console.WriteLine($"{diccionario.BuscarAlumnoPorClave(66)?.Nombre ?? "No existe"}");

        diccionario.EliminarAlumnoPorClave(33);
        foreach (var alumno in diccionario.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

        //       *Para cada punto crear un método que permita:
        //       *1.Obtener el primer libro(GetPrimero)
        //       * 2.Obtener el último libro(GetUltimo)
        //       * 3.Obtener la suma de precios(GetTotalPrecios)
        //*4.Obtener el promedio de precios(GetPromedioPrecios)
        //*5.Obtener la lista de libros con Id mayor a 15(GetListById)
        //* 6.Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros)(debe retornar una lista de string)
        //* 7.Obtener el libro con el precio más alto(GetMayorPrecio)
        //* 8.Obtener el libro con el precio más bajo(GetMenorPrecio)
        //* 9.Obtener los libros cuyo precio sea mayor al promedio(GetMayorPromedio)
        //*10.Obtener los libros ordenados por título de forma descendente
        //*En todos los casos debe aplicarse LINQ
        //*/
        var libros = new List<Libro>();
        libros.Add(new Libro(12, "Don Quijote De la Mancha", 40.000M));
        libros.Add(new Libro(13, "La Riqueza de las naciones", 60.000M));
        libros.Add(new Libro(16, "El Principito", 35.000M));

        var listaLinq = new CasoLinq(libros);

       var primero = listaLinq.GetPrimero();
       var ultimo = listaLinq.GetUltimo();
        var precios = listaLinq.GetTotalPrecios();
        var promedioDePrecios = listaLinq.GetPromedioPrecios();
        var listaMayor = listaLinq.GetListById();
        var detalles = listaLinq.GetLibros();
        var mayorPrecio = listaLinq.GetMayorPrecio();
        var menorPrecio = listaLinq.GetMenorPrecio();
        var mayorPromedio = listaLinq.GetMayorPromedio();
        var listaOrdenada = listaLinq.GetLibrosOrdenadosPorTitulo();
        

    }
}
