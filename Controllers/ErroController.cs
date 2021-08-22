using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Hotsite.Controllers
{
    public class ErroController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ErroController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/erro/500")]
        public IActionResult Erro500()
        {
            var errosOcorridos = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            
            if (errosOcorridos != null) 
            {
                //mensagem da exceção disparada
                string mensagemErro = errosOcorridos.Error.Message;
                //url que o usuário acessou e gerou a exceção 
                string urlErro = errosOcorridos.Path; 
                _logger.LogError($"Falha: {mensagemErro} acessando {urlErro} ");   
            }
    
            return View();
        }
        
    }
}