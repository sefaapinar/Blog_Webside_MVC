using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(500)]

        public string WriterName { get; set; }
        [StringLength(500)]

        public string WriterSurName { get; set; }
        [StringLength(500)]

        public string WriterImage { get; set; }
        [StringLength(500)]

        public string WriterMail { get; set; }
        [StringLength(500)]

        public string WriterPassword { get; set; }
        [StringLength(1000)]


        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
