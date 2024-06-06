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
        Mostrar_Fecha(fecha_dos);

        estado = Validar_Fecha(fecha_dos);

        Procesar_Mensaje_Validar_Fecha(estado, fecha_dos);

        if (estado != 0)
        {
            Environment.Exit(0);
        }

        Fecha fecha_tres = new Fecha(23, 6, 2022);

        System.Console.WriteLine("\nTercera fecha - Envio como parametro un puntero a la estructura del tipo FECHA\n");
        Mostrar_Fecha(fecha_tres);

        estado = Validar_Fecha(fecha_tres);

        Procesar_Mensaje_Validar_Fecha(estado, fecha_tres);

        if (estado != 0)
        {
            Environment.Exit(0);
        }

        System.Console.WriteLine("\nEnvio como parametro los tres atributos de fecha UNO y envio como parametro los tres atributos fecha DOS\n");
        estado = Comparar_Fecha(fecha_uno.dd, fecha_uno.mm, fecha_uno.aaaa, fecha_dos.dd, fecha_dos.mm, fecha_dos.aaaa);

        if (estado == 1)
        {
            System.Console.WriteLine($"Primera fecha {fecha_uno.dd}/{fecha_uno.mm}/{fecha_uno.aaaa} mayor segunda fecha {fecha_dos.dd}/{fecha_dos.mm}/{fecha_dos.aaaa}");
        }
        else
        {
            if (estado == -1)
            {
                System.Console.WriteLine($"Segunda fecha {fecha_dos.dd}/{fecha_dos.mm}/{fecha_dos.aaaa} mayor primera fecha {fecha_uno.dd}/{fecha_uno.mm}/{fecha_uno.aaaa}");
            }
            else
            {
                System.Console.WriteLine($"Primera fecha {fecha_uno.dd}/{fecha_uno.mm}/{fecha_uno.aaaa} igual segunda fecha {fecha_dos.dd}/{fecha_dos.mm}/{fecha_dos.aaaa}");
            }
        }

        System.Console.WriteLine("\nEnvio como parametro la estructura fecha UNO y envio como parametro la estructura fecha TRES\n");
        estado = Comparar_Fecha(fecha_uno, fecha_tres);

        if (estado == 1)
        {
            System.Console.WriteLine($"Primera fecha {fecha_uno.dd}/{fecha_uno.mm}/{fecha_uno.aaaa} mayor tercera fecha {fecha_tres.dd}/{fecha_tres.mm}/{fecha_tres.aaaa}");
        }
        else
        {
            if (estado == -1)
            {
                System.Console.WriteLine($"Tercera fecha {fecha_tres.dd}/{fecha_tres.mm}/{fecha_tres.aaaa} mayor primera fecha {fecha_uno.dd}/{fecha_uno.mm}/{fecha_uno.aaaa}");
            }
            else
            {
                System.Console.WriteLine($"Primera fecha {fecha_uno.dd}/{fecha_uno.mm}/{fecha_uno.aaaa} igual tercera fecha {fecha_tres.dd}/{fecha_tres.mm}/{fecha_tres.aaaa}");
            }
        }

        System.Console.WriteLine("\nEnvio el puntero como parametro de la estructura fecha DOS y envio como parametro el puntero de la estructura fecha TRES\n");
        estado = Comparar_Fecha(fecha_dos, fecha_tres);

        if (estado == 1)
        {
            System.Console.WriteLine($"Segunda fecha {fecha_dos.dd}/{fecha_dos.mm}/{fecha_dos.aaaa} mayor tercera fecha {fecha_tres.dd}/{fecha_tres.mm}/{fecha_tres.aaaa}");
        }
        else
        {
            if (estado == -1)
            {
                System.Console.WriteLine($"Tercera fecha {fecha_tres.dd}/{fecha_tres.mm}/{fecha_tres.aaaa} mayor segunda fecha {fecha_dos.dd}/{fecha_dos.mm}/{fecha_dos.aaaa}");
            }
            else
            {
                System.Console.WriteLine($"Segunda fecha {fecha_dos.dd}/{fecha_dos.mm}/{fecha_dos.aaaa} igual tercera fecha {fecha_tres.dd}/{fecha_tres.mm}/{fecha_tres.aaaa}");
            }
        }
    }

    // Servcio
    public static void Mostrar_Fecha(int dd, int mm, int aaaa)
    {
        FechaEstatic.Procesar_Mostrar_Fecha(dd, mm, aaaa);
    }
    public static void Mostrar_Fecha(Fecha fecha)
    {
        FechaEstatic.Procesar_Mostrar_Fecha(fecha.dd, fecha.mm, fecha.aaaa);
    }
    public static int Validar_Fecha(int dd, int mm, int aaaa)
    {
        return FechaEstatic.Procesar_Validar_Fecha(dd, mm, aaaa);
    }
    public static int Validar_Fecha(Fecha fecha)
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