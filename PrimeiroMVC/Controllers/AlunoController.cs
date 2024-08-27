using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Cristiano de Paula", "cristiano.paula@sp.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Rayssa Nanclares da Silveira", "rayssa.silveira@aluno.senai.br", 223344);
            Aluno a3 = new Aluno(3, "Emanuelly Lima", "emanuelly.v.lima@aluno.senai.br", 333636);
            Aluno a4 = new Aluno(4, "Ítalo Francesco", "italo.francesco@aluno.senai.br", 444444);
            Aluno a5 = new Aluno(5, "Bruno Alves", "bruno.alves@aluno.senai.br", 4354665);

            // Criar uma lista de alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            // Adicionar os objetos alunos na lista alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            // Enviando a lista de alunos por parametro na View Index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
