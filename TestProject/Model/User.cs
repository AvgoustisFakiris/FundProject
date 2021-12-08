using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject.Model
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

     //   public virtual ICollection<ProjectBacker> ProjectsBacker { get; set; }
     //   public virtual ICollection<ProjectPage> ProjectPages { get; set; }
      /*  public User()
        {
            ProjectsBacker = new List<ProjectBacker>();
           ProjectPages = new List<ProjectPage>();
        }
      */
    }
}