using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumnos;

    public CasoList()
    {
        _alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(List<Alumno> alumnos){
        _alumnos.AddRange(alumnos);
    }

    public List<Alumno> GetAlumnos(){
        return _alumnos;
    }

    public Alumno? BuscarAlumnoPorNombre(string name) { 
        return _alumnos.Find(a => a.Nombre == name);
    }

    public void EliminarDeterminadoAlumno(Alumno alumno) { 
    
        _alumnos.Remove(alumno);

    }

    public void EliminarAlumnoEnPoicion(int Indice) { 
        
        _alumnos.RemoveAt(Indice);

    }
}
