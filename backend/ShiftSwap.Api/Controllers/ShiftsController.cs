using Microsoft.AspNetCore.Mvc;
using ShiftSwap.Api.Data;
using Microsoft.EntityFrameworkCore;
using ShiftSwap.Api.DTOs;

namespace ShiftSwap.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShiftsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ShiftsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<ShiftResponseDto>>> GetShifts() {
        return Ok();
    }
}