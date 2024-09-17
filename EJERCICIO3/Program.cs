public class Miembro
{
    public string Nombre { get; set; }
    public int NumeroMiembro { get; set; }

    public Miembro(string nombre, int numeroMiembro)
    {
        Nombre = nombre;
        NumeroMiembro = numeroMiembro;
    }

    public void InscribirseEnClase(Clase clase)
    {
        if (clase.LugaresDisponibles > 0)
        {
            clase.ReducirLugares();
            Console.WriteLine($"{Nombre} se inscribio en la clase {clase.Nombre}.");
        }
        else
        {
            Console.WriteLine($"No hay lugares disponibles en la clase {clase.Nombre}.");
        }
    }
}

public class Instructor
{
    public string Nombre { get; set; }
    public int Experiencia { get; set; }

    public Instructor(string nombre, int experiencia)
    {
        Nombre = nombre;
        Experiencia = experiencia;
    }

    public void AsignarClase(Clase clase)
    {
        clase.Instructor = this;
        Console.WriteLine($"{Nombre} fue asignado a la clase {clase.Nombre}.");
    }
}

public class Clase
{
    public string Nombre { get; set; }
    public Instructor Instructor { get; set; }
    public int LugaresDisponibles { get; set; }
    public decimal Costo { get; set; }

    public Clase(string nombre, int lugaresDisponibles, decimal costo)
    {
        Nombre = nombre;
        LugaresDisponibles = lugaresDisponibles;
        Costo = costo;
    }

    public void ReducirLugares()
    {
        if (LugaresDisponibles > 0)
        {
            LugaresDisponibles--;
        }
    }
}

public class Inscripcion
{
    public Miembro Miembro { get; set; }
    public Clase Clase { get; set; }

    public Inscripcion(Miembro miembro, Clase clase)
    {
        Miembro = miembro;
        Clase = clase;
    }

    public void RegistrarInscripcion()
    {
        Miembro.InscribirseEnClase(Clase);
    }
}

public class Program
{
    public static void Main()
    {
        Instructor instructor1 = new Instructor("Tomas", 5);
        Clase clase1 = new Clase("Musculacion", 10, 15.50m);
        instructor1.AsignarClase(clase1);

        Miembro miembro1 = new Miembro("pepin", 1);
        Inscripcion inscripcion1 = new Inscripcion(miembro1, clase1);
        inscripcion1.RegistrarInscripcion();
    }
}


