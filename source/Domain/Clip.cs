using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoard.Domain
{
    public class Clip
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        [ForeignKey("ClipId")]
        public List<Resource> Resources { get; set; }
        public Clip()
        {
            Resources = new List<Resource>();
        }
    }
}
