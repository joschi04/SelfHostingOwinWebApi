using RazorEngine;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using WebApiContrib.Formatting.Html;
using WebApiSample;
using System.Linq;

namespace OwinSelfhostSample
{
    public class MarkupController : ApiController
    {
        // GET api/values 
        public Records Get()
        {
            XmlParser parser = new XmlParser();
            var values = parser.Invoke();

            return new Records() { RecordsArray = values.ToArray() };
        }

        [View("Records")]
        public class Records
        {
            public Record[] RecordsArray { get; set; }
        }
    }
}