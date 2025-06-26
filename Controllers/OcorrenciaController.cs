using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApiOcorrenciaMvc.Models;

namespace ApiOcorrenciaMvc.Controllers
{
    public class OcorrenciaController : Controller
    {
        private readonly HttpClient _httpClient;

        public OcorrenciaController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("http://ApiOcorrencia.somee.com/api/ocorrencia");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var ocorrencias = JsonSerializer.Deserialize<List<Ocorrencia>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return View(ocorrencias);
        }
    }
}