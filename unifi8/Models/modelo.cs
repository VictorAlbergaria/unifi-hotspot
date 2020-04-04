using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace unifi8.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Voucher { get; set; }
    }

    public class Vouchers
    {
        public int Id { get; set; }
        public string Voucher { get; set; }
    }

}
