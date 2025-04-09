using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TituloController : ControllerBase
{
    private readonly TituloService _service;

    public TituloController(TituloService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Criar([FromBody] Titulo titulo) =>
        Ok(_service.Criar(titulo));

    [HttpPut("{id}/baixa")]
    public IActionResult Baixar(int id) =>
        Ok(_service.Baixar(id));

    [HttpPut("{id}/cancelar")]
    public IActionResult Cancelar(int id) =>
        Ok(_service.Cancelar(id));

    [HttpGet("{id}")]
    public IActionResult Obter(int id) =>
        Ok(_service.Obter(id));

    [HttpGet]
    public IActionResult Listar() =>
        Ok(_service.Listar());
}