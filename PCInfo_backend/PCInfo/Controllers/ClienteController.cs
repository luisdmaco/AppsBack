using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCInfo_backend.PCInfo.Domain.Models;
using PCInfo_backend.PCInfo.Domain.Services;
using PCInfo_backend.PCInfo.Resources;
using PCInfo_backend.PCInfo.Services;
using PCInfo_backend.Shared.Extensions;

namespace PCInfo_backend.PCInfo.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _clienteService;
    private readonly IMapper _mapper;
    
    public ClienteController(ClienteService clienteService, IMapper mapper)
    {
        _clienteService = clienteService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<ClienteResource>> GetAllAsync()
    {
        var clients = await _clienteService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteResource>>(clients);

        return resources;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveClienteResource resource)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());
        var cliente = _mapper.Map<SaveClienteResource, Cliente>(resource);
        var result = await _clienteService.SaveAsync(cliente);
        if (!result.Success)
            return BadRequest(result.Message);
        var clienteResource = _mapper.Map<Cliente, ClienteResource>(result.Resource);
        return Ok(clienteResource);
    }
}