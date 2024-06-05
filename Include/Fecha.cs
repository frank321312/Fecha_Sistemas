namespace Include;

public class Fecha
{
    public int dd { get; set; }
    public int mm { get; set; }
    public int aaaa { get; set; }
    public Fecha(int dd, int mm, int aaaa)
    {
        this.dd = dd;
        this.mm = mm;
        this.aaaa = aaaa;
    }
}