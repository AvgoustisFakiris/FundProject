using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Model
{
    public class Project
    {
        public int Id { get; set; }
        [MaxLength(50)]
         [Required]
        public string Title { get; set; }
        [MaxLength(200)]
        [Required]
        public string Description { get; set; }
      //  public string Image { get; set; }
    //    public string Video { get; set; }

        //public bool StatusUpdate { get; set; }
    //    public DateTime DueDate { get; set; }
        public int CurrentAmount { get; set; }
        public int TotalBackers { get; set; }
        public int GoalAmount { get; set; }
    //    public DateTime DateInserted { get; set; }
        public virtual Category Category { get; set; }

        public virtual FundPackage FundPackages { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }


    /*    private ICollection<T> category { get; set; }

        public virtual ICollection<T> GetCategory()
        {
            return category;
        }

        public virtual void SetCategory(ICollection<T> value)
        {
            category = value;
        } */

    
     //   public virtual ICollection<ProjectBacker> ProjectBacker { get; set; }
        public Project()
        {
        //    ProjectBacker = new List<ProjectBacker>();

        }

    }
}
