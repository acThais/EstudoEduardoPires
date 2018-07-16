using AutoMapper;
using System.Web.Http;
using System.Web.Mvc;

namespace EP.CursoMvc.UI.Mvc.Controllers
{
	public class MapController : Controller
    {
		public MapperConfiguration AutomMapperConfig { get; set; }
		public IMapper Mapper { get; set; }
	}
}
