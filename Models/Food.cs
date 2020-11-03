using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Application.Models {
    public class Food {
        /*Start of database design*/
        [Key]
        public int FoodID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PersonFood> PersonFoods { get; set; }
        /*End of database design*/

        //Temporary data-database structure along with selectedFood structure
        [NotMapped]
        public Dictionary<string,string> FoodDetails { get; set; } // Food structure ,temporary use in view,probably use database data after generating database 
        [NotMapped]
        public Dictionary<string,bool> SelectedFood { get; set; } // use for selected food

        public Food( ) {
            FoodDetails = new Dictionary<string, string>() {
                {"1","Pizza" },
                {"2","Pasta" },
                {"3","Pap and Wors" },
                {"4","Chicken Stir Fry" },
                {"5","Beef Stir Fry" },
                {"6","Other" },
            };

            SelectedFood = new Dictionary<string, bool>();
            for (int i = 1; i< 7; i++) {
                SelectedFood.Add(i.ToString(), false);
            }



        }
    }
     
}