using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.Frontend.Pages
{
    public class ListaPacientesModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new HospiEnCasa.App.Persistencia.AppContext());
        public IEnumerable<Paciente> Pacientes { get; set; }

        public ListaPacientesModel()
        {}

        public void OnGet()
        {
            this.Pacientes = _repositorioPaciente.GetAllPacientes();
        }
    }
}
