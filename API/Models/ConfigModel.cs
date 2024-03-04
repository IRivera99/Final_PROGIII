using System.Drawing;
using API.Data;

namespace API.Models;

public class ConfigModel
{
    public string PaddingTop { get; set; }
    public string PaddingLeft { get; set; }
    public string Border { get; set; }
    public string Color { get; set;}
    public string MensajeAlert { get; set; }

    public ConfigModel(Configuracion configuracion){
        PaddingTop = configuracion.PaddingTop + "px";
        PaddingLeft = configuracion.PaddingLeft + "px";
        Color = configuracion.Color;
        MensajeAlert = configuracion.MensajeAlert;
        if(configuracion.Border){
            Border = "1px solid black";
        }else{
            Border = "none";
        }
    }
    
}
