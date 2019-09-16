using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace WindowsFormsApp1
{
    [Serializable]
    public class Address
    {
        public Address()
        {

        }
        [XmlElement(ElementName = "Adress")]
        public string Adress;
        public Address(string Adress)
        {
            this.Adress = Adress;
        }
    }
}
