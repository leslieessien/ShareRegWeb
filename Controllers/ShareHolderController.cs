using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShareRegWeb.Models;
using ShareRegWeb.Services.Interfaces;

namespace ShareRegWeb.Controllers
{
    public class ShareHolderController(IShareholder shareholderService) : Controller
    {
        public async  Task<IActionResult> Create(ShareHolderDto shareholder)
        {
            if (ModelState.IsValid)
            {
                var results =await  shareholderService.AddShareholder(shareholder);
                if (!results)
                {
                    ModelState.AddModelError("ShareHolder Creation Error","Failed to create shareholder");
                }
            }
        
          
            return View();
        }
    }
}
