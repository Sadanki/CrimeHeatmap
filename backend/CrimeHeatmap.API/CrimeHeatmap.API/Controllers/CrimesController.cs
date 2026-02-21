using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrimeHeatmap.API.Data;
using CrimeHeatmap.API.Models;

namespace CrimeHeatmap.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CrimesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CrimesController(AppDbContext context)
    {
        _context = context;
    }

    // ✅ GET ALL CRIMES
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var crimes = await _context.CrimeReports
            .OrderByDescending(c => c.ReportedAt)
            .ToListAsync();

        return Ok(crimes);
    }

    // ✅ GET CRIME BY ID (integer constraint avoids conflict with "heatmap")
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var crime = await _context.CrimeReports.FindAsync(id);

        if (crime == null)
            return NotFound();

        return Ok(crime);
    }

    // ✅ CREATE CRIME
    [HttpPost]
    public async Task<IActionResult> Create(CrimeReport report)
    {
        _context.CrimeReports.Add(report);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = report.Id }, report);
    }

    // ✅ UPDATE CRIME
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, CrimeReport updatedReport)
    {
        var crime = await _context.CrimeReports.FindAsync(id);

        if (crime == null)
            return NotFound();

        crime.Title = updatedReport.Title;
        crime.Description = updatedReport.Description;
        crime.Status = updatedReport.Status;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id:int}/verify")]
    public async Task<IActionResult> VerifyCrime(int id)
    {
        var crime = await _context.CrimeReports.FindAsync(id);

        if (crime == null)
            return NotFound();

        crime.Status = "Verified";
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // 🌍 MAP DATA (all crimes with type info)
    [HttpGet("map-data")]
    public async Task<IActionResult> GetMapData()
    {
        var data = await _context.CrimeReports
            .Select(c => new
            {
                c.Latitude,
                c.Longitude,
                c.CrimeType
            })
            .ToListAsync();

        return Ok(data);
    }

    // 🔥 HEATMAP DATA (only verified crimes)
    [HttpGet("heatmap")]
    public async Task<IActionResult> GetHeatmapData()
    {
        var heatmapData = await _context.CrimeReports
            .Where(c => c.Status == "Verified")
            .Select(c => new
            {
                lat = c.Latitude,
                lng = c.Longitude,
                weight = 1.0
            })
            .ToListAsync();

        return Ok(heatmapData);
    }
}