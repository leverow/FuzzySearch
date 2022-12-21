using FuzzySearchApi.Data;
using FuzzySearchApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimplifiedSearch;
using System.Diagnostics.Metrics;

namespace FuzzySearchApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public StudentsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> GetStudents(string name)
    {
        IList<Student> students = _context.Set<Student>().ToList();
        IList<Student> matches = await students.SimplifiedSearchAsync(name, x => x.Name);
        var result = string.Empty;
        foreach (var student in matches)
        {
            result += student.Name + "\n";
        }
        return Ok(result);
    }
}