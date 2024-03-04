namespace API.Data;

public class Configuracion
{
    public Guid Id { get; set; }
    public int PaddingTop { get; set; }
    public int PaddingLeft { get; set; }
    public bool Border { get; set; }
    public string Color { get; set;} = "black";
    public string MensajeAlert { get; set; } = "";
}
