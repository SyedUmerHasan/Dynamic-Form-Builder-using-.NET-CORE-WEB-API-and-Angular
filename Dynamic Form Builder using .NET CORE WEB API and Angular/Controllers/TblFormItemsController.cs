using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.Models;

namespace Dynamic_Form_Builder_using_.NET_CORE_WEB_API_and_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblFormItemsController : ControllerBase
    {
        private readonly DynamicFormDBContext _context;

        public TblFormItemsController(DynamicFormDBContext context)
        {
            _context = context;
        }

        // GET: api/TblFormItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblFormItem>>> GetTblFormItems()
        {
            return await _context.TblFormItems.ToListAsync();
        }

        // GET: api/TblFormItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblFormItem>> GetTblFormItem(long id)
        {
            var tblFormItem = await _context.TblFormItems.FindAsync(id);

            if (tblFormItem == null)
            {
                return NotFound();
            }

            return tblFormItem;
        }

        // PUT: api/TblFormItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblFormItem(long id, TblFormItem tblFormItem)
        {
            if (id != tblFormItem.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(tblFormItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblFormItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TblFormItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TblFormItem>> PostTblFormItem(TblFormItem tblFormItem)
        {
            _context.TblFormItems.Add(tblFormItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblFormItem", new { id = tblFormItem.ItemId }, tblFormItem);
        }

        // DELETE: api/TblFormItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblFormItem>> DeleteTblFormItem(long id)
        {
            var tblFormItem = await _context.TblFormItems.FindAsync(id);
            if (tblFormItem == null)
            {
                return NotFound();
            }

            _context.TblFormItems.Remove(tblFormItem);
            await _context.SaveChangesAsync();

            return tblFormItem;
        }

        private bool TblFormItemExists(long id)
        {
            return _context.TblFormItems.Any(e => e.ItemId == id);
        }
    }
}
