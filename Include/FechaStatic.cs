namespace Include;

public static class FechaEstatic
{
    public static int Procesar_Validar_Fecha(int dd, int mm, int aaaa)
    {
        if (aaaa < 0)
        {
            return (-3);
        }

        if ((mm < 1) || (mm > 12))
        {
            return (-2);
        }

        if (dd < 1)
        {
            return (-1);
        }

        switch (mm)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (dd > 31)
                {
                    return (-1);
                }

                break;

            case 4:
            case 6:
            case 9:
            case 11:
                if (dd > 30)
                {
                    return (-1);
                }

                break;

            case 2:
                if ((aaaa % 4) != 0)
                {
                    if (dd > 28)
                    {
                        return (-1);
                    }

                    break;
                }

                if ((aaaa % 100) == 0)
                {
                    if ((aaaa % 400) != 0)
                    {
                        if (dd > 28)
                        {
                            return (-1);
                        }
                    }
                }

                if (dd > 29)
                {
                    return (-1);
                }

                break;

            default:
                break;
        }

        return (0);
    }
    public static int Procesar_Comparar_Fecha(int fechaUnoDD, int fechaUnoMM, int fechaUnoAAAA, int fechaDosDD, int fechaDosMM, int fechaDosAAAA)
    {
        if (fechaUnoAAAA > fechaDosAAAA)
        {
            return (1);
        }

        if (fechaUnoAAAA < fechaDosAAAA)
        {
            return (-1);
        }

        if (fechaUnoMM > fechaDosMM)
        {
            return (1);
        }

        if (fechaUnoMM < fechaDosMM)
        {
            return (-1);
        }

        if (fechaUnoDD > fechaDosDD)
        {
            return (1);
        }

        if (fechaUnoDD < fechaDosDD)
        {
            return (-1);
        }

        return (0);
    }
    public static void Procesar_Mostrar_Fecha(int dd, int mm, int aaaa)
    {
        System.Console.WriteLine($"Dia: {dd}\n");
        System.Console.WriteLine($"Mes: {mm}\n");
        System.Console.WriteLine($"A#o: {aaaa}\n");

        return;
    }
}
