using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebApiSample
{
    internal class XmlParser
    {
        public IEnumerable<Record> Invoke()
        {
            XDocument xdoc = XDocument.Load("./sample.xml");

            var ret = from item in xdoc.Descendants("record")
                      select new Record() { LastName = item.Descendants("LastName").FirstOrDefault().Value, Sales = int.Parse(item.Descendants("Sales").FirstOrDefault().Value) };

            return ret;

        }
    }
}
