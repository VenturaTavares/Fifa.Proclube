using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;


namespace Fifa.Proclube.API.Controllers
{
    
		public class BaseController : ApiController
		{

			public const string NOT_FOUND_MESSAGE = "Não foram encontrados registros.";
			public const string GENERIC_ERROR_MESSAGE = "O recurso solicitado não existe no servidor.";

			public BaseResponse response;
			public JsonMediaTypeFormatter formatter;
			public HttpStatusCode responseCode;
		}
    
}
