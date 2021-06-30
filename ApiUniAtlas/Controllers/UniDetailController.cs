using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;
using DataAccessLayer;
using BusinessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiUniAtlas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniDetailController : ControllerBase
    {

        UniDetailProseccing data;

        public UniDetailController()
        {
            data = new UniDetailProseccing();
        }
        /// <summary>
        /// Full List
        /// </summary>
        /// <returns></returns>
        // GET: api/<UniDetailController>
        [HttpGet]
        public string Get()
        {
            return (new JavaScriptSerializer().Serialize(data.Detail()));
        }

        /// <summary>
        /// Id' sine göre üniversitenin bütün özelliklerini listeler.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("fromid/{Id}")]
        [HttpGet()]
        public string DetailGetId(int Id)
        {
            return (new JavaScriptSerializer().Serialize(data.FromId(Id))); // Id' sine göre üniversitenin bütün özelliklerini listeler.
        }

        /// <summary>
        /// Universitenin ismine göre istediğim 5 özelliği listeler.
        /// </summary>
        /// <param name="UniName"></param>
        /// <returns></returns>
        [Route("detailuniname/{UniName}")]
        [HttpGet()]
        public string DetailGetName(string UniName)
        {
            return (new JavaScriptSerializer().Serialize(data.DetailName(UniName))); // Universitenin ismine göre istediğim 5 özelliği listeler.
        }
        

    }
}
