using System;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using EP.CursoMvc.Application;
using EP.CursoMvc.Application.Interfaces;
using EP.CursoMvc.Application.ViewModels;
using EP.CursoMvc.Domain.Entities;

namespace EP.CursoMvc.UI.Mvc.Controllers
{
	public class ClientesController : MapController
    {
		private readonly IClienteAppService _clienteApp = new ClienteAppService();

		public ClientesController()
		{
			AutomMapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Cliente, ClienteViewModel>();
				cfg.CreateMap<ClienteViewModel, Cliente>();
			});

			Mapper = AutomMapperConfig.CreateMapper();
		}


        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            //var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.ObterTodos(1,7));
            //return View(clienteViewModel);
            return View(_clienteApp.ObterTodos(1, 50));
        }

        /*public ActionResult Especiais()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.ObterClientesEspeciais());

            return View(clienteViewModel);
        }*/

        // GET: Clientes/Details/5
        public ActionResult Details(Guid? id)
        {
			var model = new ClienteViewModel();

			var clienteViewModel = Mapper.Map<Cliente>(model);

            return View(clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
				//[ERRO]  - O método Adicionar recebe por parâmetro o ClienteEnderecoViewModel e não Cliente que é o tipo convertido. 
				//Atalho para verificar o método ctrl+f12
				//_clienteApp.Adicionar(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
            var clienteViewModel = _clienteApp.ObterPorId(id);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteApp.Atualizar(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(Guid id)
        {
            var clienteViewModel = _clienteApp.ObterPorId(id);
			//Não precisa converter para "Cliente" para ClienteViewModel, o método ObterPorId já está retornando como ViewModel.
            //var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            //var cliente = _clienteApp.ObterPorId(id);
            _clienteApp.Remover(id);

            return RedirectToAction("Index");
        }
    }
}
