using AriBilgi.TekrarProjesi.Entities;
using AriBilgi.TekrarProjesi.Model.Company;
using AriBilgi.TekrarProjesi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AriBilgi.TekrarProjesi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpPost]
        [Route("Insert")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Insert(AddCompanyInput addCompanyInput)
        {
            try
            {
                CompanyManager companyManager = new();
                companyManager.Insert(addCompanyInput);
                return Ok("Firma başarıyla kayıt edildi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
