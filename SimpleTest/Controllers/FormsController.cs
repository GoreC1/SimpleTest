using SimpleTest.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleTest.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleTest.Controllers
{
    [Route("api/forms")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        private readonly IUnitOfWork _unit;

        public FormsController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        // GET: api/forms/
        [HttpGet]
        public async Task<IActionResult> GetAllForms()
        {
            IEnumerable<Form> forms = await _unit.Forms.GetAllAsync();
            if (forms == null)
                return NotFound();
            return Ok(forms);
        }

        // GET: api/forms/[id]
        [HttpGet("{id}", Name = nameof(GetForm))]
        [ProducesResponseType(200, Type = typeof(Form))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetForm(int id)
        {
            IForm form = await _unit.Forms.GetById(id);
            return Ok(form);
        }

        // POST api/forms
        // FromBody (JSON)
        [HttpPost]
        [ProducesResponseType(201, Type=typeof(Form))]
        [ProducesResponseType(404)]
        public async Task<ActionResult> CreateForm([FromBody] JObject serialisedForm)
        {
            var forms = new Form[] { };
            var options = new JsonSerializerOptions();

            var form = JsonSerializer.Deserialize<Form>(serialisedForm.ToString(), options);

            if (form == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Form added = await _unit.Forms.AddAsync(form);
            return Ok(added);
        }

        // PUT api/forms/[id]
        // FromBody (JSON)
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateForm(int id, [FromBody] Form form)
        {
            if (form == null || form.id != id)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = await _unit.Forms.GetById(id);
            if ( existing == null)
            {
                return NotFound();
            }

            Form updated = await _unit.Forms.UpdateAsync(id, form);
            return Ok(updated);
        }

        // DELETE api/forms/[id]
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _unit.Forms.GetById(id);
            if (existing == null)
            {
                return NotFound();
            }

            await _unit.Forms.Remove(existing);
            return new NoContentResult();

        }
    }
}
