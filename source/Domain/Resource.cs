using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoard.Domain
{
    public  class Resource
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string FilePath { get; set; }
    }
}
