using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
//C: \Users\User\Desktop\Programs\Package Apps\mvc\Template no auth\Web Application\
namespace Web_Application.Models {
    public class Person {
        /*Start of database design*/
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Surname required")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Name required")]
        [Display(Name ="First Names")]
        public string FirstNames { get; set; }

        [Required(ErrorMessage = "Contact required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no Eg 076305185566")] // Review reqular expression
        [Display(Name = "Contact Number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Date of birth required")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage ="Age required")]
        [Range(5,120 ,ErrorMessage ="Age should be between 5 and 120")]
        public int  Age { get; set; }
        public virtual ICollection<PersonFood> PersonFoods { get; set; }
        public virtual ICollection<PersonLiking> PersonLikings { get; set; }

        /*End of database design*/


        // Food and liking selected collected from the form
        [NotMapped]
        public Food Food { get; set; }

        [NotMapped]
        public Liking Liking { get; set; }

        public Person( ) {
            Food = new Food();
            Liking = new Liking();
        }
    }
}