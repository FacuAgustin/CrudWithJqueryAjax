using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudWithJqueryAjax.ViewModel
{
    public class StudentViewModel
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public int DepartamentId { get; set; }
        public string DepartamentName { get; set; }
    }
}