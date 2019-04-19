using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsvWriter {
    public class CsvWriter : StreamWriter
    {
        public char Delimiter { get; set; }
        public char Quote { get; set; }
        public string CommonToken { get; set; }

        public CsvWriter(string path, bool append, Encoding encoding): base(path, append, encoding) {
            Delimiter = ',';
            Quote = '"';
            CommonToken = "## ";
        }
        public CsvWriter(string file) : this(file, false, Encoding.UTF8) { }
        public CsvWriter(string file, bool append) : this(file, append, Encoding.UTF8) { }

    }
}
