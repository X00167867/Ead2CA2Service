using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA2WebService
{
    public class Library
    {
        [Key]
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }
        public string LibraryAddress { get; set; }

    }

    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public bool AvailableForLoan { get; set; }

        [ForeignKey("Library")]
        public int LibraryID { get; set; }

    }
}
