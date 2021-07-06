using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Premis
    {
        public int Id { get; set; }
        public string FileNo { get; set; }
        public string ConsultantName { get; set; }
        public string LotNo { get; set; }
        public string Unit { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }

    }
}
