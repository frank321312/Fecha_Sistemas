using Include;

class Program
{
    public static void Main(string[] args)
    {
        int estado;

        Fecha fecha_uno = new Fecha(12, 4, 2022);

        System.Console.WriteLine("\nPrimera fecha - Envio como parametros los tres atributos de fecha UNO\n");
        Mostrar_Fecha(fecha_uno.dd, fecha_uno.mm, fecha_uno.aaaa);

        estado = Validar_Fecha(fecha_uno.dd, fecha_uno.mm, fecha_uno.aaaa);

        Procesar_Mensaje_Validar_Fecha(estado, fecha_uno);

        if (estado != 0)
        {
            Environment.Exit(0);
        }

        Fecha fecha_dos = new Fecha(7, 5, 2022);

        System.Console.WriteLine("\nSegunda fecha - Envio como parametro la estructura del tipo FECHA\n");
        Mostrar_Est_Fecha(fecha_dos);

        estado = Validar_Est_Fecha(fecha_dos);
    }

    // Servcio
    public static void Mostrar_Fecha(int dd, int mm, int aaaa)
    {
        FechaEstatic.Procesar_Mostrar_Fecha(dd, mm, aaaa);
    }
    public static void Mostrar_Est_Fecha(Fecha fecha)
    {
        FechaEstatic.Procesar_Mostrar_Fecha(fecha.dd, fecha.mm, fecha.aaaa);
    }
    public static void Mostrar_Pun_Est_Fecha(ref Fecha fecha)
    {
        FechaEstatic.Procesar_Mostrar_Fecha(fecha.dd, fecha.mm, fecha.aaaa);
    }
    public static int Validar_Fecha(int dd, int mm, int aaaa)
    {
        return FechaEstatic.Procesar_Validar_Fecha(dd, mm, aaaa);
    }
    public static int Validar_Est_Fecha(Fecha fecha)
    {
        return FechaEstatic.Procesar_Validar_Fecha(fecha.dd, fecha.mm, fecha.aaaa);
    }
    public static int Validar_Pun_Est_Fecha(ref Fecha fecha)
    {
        return FechaEstatic.Procesar_Validar_Fecha(fecha.dd, fecha.mm, fecha.aaaa);
    }
    public static int Comparar_Fecha(int fecha_Uno_DD, int fecha_Uno_MM, int fecha_Uno_AAAA, int fecha_Dos_DD, int fecha_Dos_MM, int fecha_Dos_AAAA)
    {
        return FechaEstatic.Procesar_Comparar_Fecha(fecha_Uno_DD, fecha_Uno_MM, fecha_Uno_AAAA, fecha_Dos_DD, fecha_Dos_MM, fecha_Dos_AAAA);
    }
    public static int Comparar_Fecha(Fecha fecha_Uno, Fecha fecha_Dos)
    {
        return FechaEstatic.Procesar_Comparar_Fecha(fecha_Uno.dd, fecha_Uno.mm, fecha_Uno.aaaa, fecha_Dos.dd, fecha_Dos.mm, fecha_Dos.aaaa);
    }
    public static int Comparar_Fecha(Fecha fecha_Uno, int fecha_Dos_DD, int fecha_Dos_MM, int fecha_Dos_AAAA)
    {
        return FechaEstatic.Procesar_Comparar_Fecha(fecha_Uno.dd, fecha_Uno.mm, fecha_Uno.aaaa, fecha_Dos_DD, fecha_Dos_MM, fecha_Dos_AAAA);
    }
    public static int Comparar_Fecha(int fecha_Uno_DD, int fecha_Uno_MM, int fecha_Uno_AAAA, Fecha fecha_Dos)
    {
        return FechaEstatic.Procesar_Comparar_Fecha(fecha_Uno_DD, fecha_Uno_MM, fecha_Uno_AAAA, fecha_Dos.dd, fecha_Dos.mm, fecha_Dos.aaaa);
    }
    public static void Procesar_Mensaje_Validar_Fecha(int estado, Fecha fecha)
    {
        if (estado == -3)
        {
            System.Console.WriteLine($"El a#o es menor a cero {fecha.aaaa}\n");

            return;
        }

        if (estado == -2)
        {
            System.Console.WriteLine($"El mes es incorrecto {fecha.mm}\n");

            return;
        }

        if (estado == -1)
        {
            System.Console.WriteLine($"El dia es incorrecto {fecha.dd}\n");

            return;
        }

        System.Console.WriteLine("Fecha correcta\n");

        return;
    }
}