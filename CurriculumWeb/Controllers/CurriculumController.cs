using Microsoft.AspNetCore.Mvc;
using CurriculumWeb.Models;

namespace CurriculumWeb.Controllers;

public class CurriculumController : Controller
{
    public IActionResult Index()
    {
        var curriculum = new CurriculumModel
        {
            Name = "Murilo Barberini Dias",
            Title = "Desenvolvedor de software",
            Skills = new List<string> {},
            Experiences = new List<Experience>
            {
                new Experience
                {
                    Position = "Estagiário",
                    Company = "Mutant",
                    DurationBegin = "10/2023",
                    DurationEnd = "Até o momento",
                    Location = "HÍBRIDO, SÃO PAULO, BRASIL",
                    Description = "Responsável por atuar na fábrica de software e atuar na manutenção e garantia de qualidade de robôs usados em canais de atendimento como URA, BOT e Webchat para vários clientes. Planejamento, modelagem e execução de testes progressivos e regressivos; Desenvolvimento e manutenção de testes automatizados; Solicitação e validação de massas de teste; Rastreamento de bugs e projetos utilizando Jira; Nesta função atuei utilizando Javascript, BDD, SQL, Grafana, Postman."
                },
                new Experience
                {
                    Position = "Desenvolvedor Web",
                    Company = "Pazzini Serviços de Informática",
                    DurationBegin = "08/2022",
                    DurationEnd = "08/2023",
                    Location = "HOME OFFICE",
                    Description = "Fui responsável por participar da implementação e manutenção de projetos e por realizar testes funcionais, exploratórios, de usabilidade e API. Nesta função eu atuei utilizando Javascript, Node.js, MongoDB."
                }
            },
            Educations = new List<Education>
            {
                new Education
                {
                    Course = "Ciências da Computação",
                    Institution = "Universidade São Judas Tadeu",
                    DurationBegin = "02/2022",
                    DurationEnd = "12/2026"
                },
                new Education
                {
                    Course = "Psicologia",
                    Institution = "Universidade Metodista de São Paulo",
                    DurationBegin = "08/2015",
                    DurationEnd = "07/2020"
                }
            },
            Project = new List<Projects>()
            {
                new Projects
                {
                    Title = "NeoMutants",
                    Description = "Neste projeto fui responsável por desenvolver uma automação com o objetivo de buscar dados de uma tabela no Notion utilizando uma API e enviar uma mensagem no Discord utilizando os dados obtidos por meio de Webhooks. Utilizei as seguintes tecnologias: Selenium, Visual Studio, .NET e Postman."
                },                
                new Projects
                {
                    Title = "Currículo Online",
                    Description = "Neste projeto o intuítuo foi desenvolver meu currículo profissional em uma página web utilizando ASP.NET, Bootstrap, Javascript e Azure."
                }

            }
        };

        return View(curriculum);
    }
}
