using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionsController : Controller
{
    private readonly IMapper _mapper;
    private readonly IRegionRepository _regionRepository;

    public RegionsController(IRegionRepository regionRepository, IMapper mapper)
    {
        _regionRepository = regionRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRegions()
    {
        var regions = await _regionRepository.GetAllAsync();

        var regionsDTO = _mapper.Map<List<Region>>(regions);

        return Ok(regionsDTO);
    }
}