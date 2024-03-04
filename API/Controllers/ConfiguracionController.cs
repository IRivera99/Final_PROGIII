using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("Configuracion")]

public class ConfiguracionController : ControllerBase
{
    private readonly Context _context;
    public ConfiguracionController(Context context){
        _context = context;
    }

    [HttpGet("Get")]
    public async Task<ActionResult<Configuracion>> GetConfig(){
        Configuracion? config = await _context.Configuracion.FirstOrDefaultAsync<Configuracion>();

        if(config == null){
            return Unauthorized("No hay datos");
        }        

        return Ok(config);
    }

    [HttpPut("Put")]
    public async Task<ActionResult<Configuracion>> PutConfig(Configuracion configuracion){
        Configuracion? config = await _context.Configuracion.FirstOrDefaultAsync(c => c.Id == configuracion.Id);

        if(config == null){
            return Unauthorized("No existe la configuracion");
        }
        
        config.PaddingTop = configuracion.PaddingTop;
        config.PaddingLeft = configuracion.PaddingLeft;
        config.Border = configuracion.Border;
        config.Color = configuracion.Color;
        config.MensajeAlert = configuracion.MensajeAlert;

        await _context.SaveChangesAsync();

        return Ok(config);
    }
}
