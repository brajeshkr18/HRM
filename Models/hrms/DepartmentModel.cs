using HRM.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace HRM.Models.hrms
{
    public class DepartmentModel
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int companyId { get; set; }
        public CompanyModel? company { get; set;}
      
    }
    public class departmentViewModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int companyId { get; set; }
        public CompanyModel? company { get; set; }
        public List<DepartmentModel>? departments { get; set; }
    }
}
