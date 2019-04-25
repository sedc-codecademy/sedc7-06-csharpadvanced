using System.Xml.Serialization;

namespace XmlSerialization
{
    public enum PrinterStatus {
        [XmlEnum("On-line")]
        OK =0,
        [XmlEnum("Off-line")]
        Offline =1,
        [XmlEnum("No paper")]
        PaperEmpty =2,
        [XmlEnum("No toner")]
        TonerExhausted =3,
        [XmlEnum("Jammed")]
        PaperJam =4
    }
}