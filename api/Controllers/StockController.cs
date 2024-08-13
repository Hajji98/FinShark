using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.StockDto;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;



namespace api.Controllers
{
    [Route("api/StockModel")]
    [ApiController]
    public class StockController : ControllerBase {
    
       private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetALL(){
            var stocks = _context.StockModel.ToList()
            .Select(s=> s.ToStockDto());
            return Ok(stocks);
        }

        [HttpGet("id")]
        public IActionResult GetById([FromRoute] int id )
        {
            var stocks = _context.StockModel.Find(id);

            if (stocks == null)

            return NotFound();

            return Ok(stocks.ToStockDto());
        }

        [HttpPost]
        public IActionResult Create( [FromBody] CreateStockRequestDto StockDto)
        {
            var stockmodell = StockDto.ToStockFromCreatDto();
            _context.StockModel.Add(stockmodell);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new{ id = stockmodell.ID }, stockmodell.ToStockDto());
        }
    }
    
}