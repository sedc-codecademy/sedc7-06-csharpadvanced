using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    //public enum PrinterStatus
    //{
    //    OK = 0,
    //    Offline = 1,
    //    PaperEmpty = 2,
    //    TonerExhausted = 3,
    //    PaperJam = 4
    //}

    public enum PrinterStatus
    {
        [XmlEnum("On-line")]
        OK = 0,
        [XmlEnum("Off-line")]
        Offline = 1,
        [XmlEnum("No paper")]
        PaperEmpty = 2,
        [XmlEnum("No toner")]
        TonerExhausted = 3,
        [XmlEnum("Jammed")]
        PaperJam = 4
    }

    public class Printer
    {
        public string Name { get; set; }
        public PrinterStatus Status { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Status: {1}", Name, Status);
        }
    }
}
