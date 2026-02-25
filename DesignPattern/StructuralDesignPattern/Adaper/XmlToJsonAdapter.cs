using DesignPattern.StructuralDesignPattern.Adaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.Adaper
{
    /*
        * Adapter convert the interface of a class into another interface that client expect.
        * Adapter lets the class work together that could'nt compatible to each other due to incompatible interface.
       */

    // 1. Target interface expected by the client
    interface IReports
    {
        // now takes the raw data string and returns JSON
        String getJsonData(String data);
    }

    // 2. Adaptee: provides XML data from a raw input
    class XmlDataProvider
    {
        // Expect data in "name:id" format (e.g. "Alice:42")
       public String getXmlData(String data)
        {
            int sep = data.IndexOf(':');
            String name = data.Substring(0, sep);
            String id = data.Substring(sep + 1);
            // Build an XML representation
            return "<user>"
                    + "<name>" + name + "</name>"
                    + "<id>" + id + "</id>"
                    + "</user>";
        }
    }

    // 3. Adapter: implements IReports by converting XML → JSON
    class XmlDataProviderAdapter : IReports
    {
        private XmlDataProvider xmlProvider;
        public XmlDataProviderAdapter(XmlDataProvider provider)
        {
            this.xmlProvider = provider;
        }

        public String getJsonData(String data)
        {
            // 1. Get XML from the adaptee
            String xml = xmlProvider.getXmlData(data);

            // 2. Naïvely parse out <name> and <id> values
            int startName = xml.IndexOf("<name>") + 6;
            int endName = xml.IndexOf("</name>");
            String name = xml.Substring(startName, endName);

            int startId = xml.IndexOf("<id>") + 4;
            int endId = xml.IndexOf("</id>");
            String id = xml.Substring(startId, endId - startId);

            // 3. Build and return JSON
            return "{\"name\":\"" + name + "\", \"id\":" + id + "}";
        }


        // 4. Client code works only with IReports
        class Client
        {
            public void getReport(IReports report, String rawData)
            {
                Console.WriteLine("Processed JSON: "
                + report.getJsonData(rawData));
            }
        }

        public class AdapterPattern
        {
            public static void main()
            {
                // 1. Create the adaptee
                XmlDataProvider xmlProv = new XmlDataProvider();

                // 2. Make our adapter
                IReports adapter = new XmlDataProviderAdapter(xmlProv);

                // 3. Give it some raw data
                String rawData = "Alice:42";

                // 4. Client prints the JSON
                Client client = new Client();

                client.getReport(adapter, rawData);
                // → Processed JSON: {"name":"Alice", "id":42}
            }
        }
    }
}