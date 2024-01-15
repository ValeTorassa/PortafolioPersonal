using Azure;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
    public class EmailController : Controller
    {
        private readonly EmailService _emailService;

        public EmailController(EmailService emailService)
        {
            _emailService = emailService;
        }


        public IActionResult EnviarMail(Email email)
        {
            try
            {
                _emailService.SendEmail(email);
                TempData["SuccessMessage"] = "El correo electrónico se envió correctamente";

            }catch(RequestFailedException)
            {
                TempData["ErrorMessage"] = "El correo electrónico no se pudo enviar";
            }             

            return Redirect(Url.Action("Index", "Home") + "#contact");
        }
    }
}
