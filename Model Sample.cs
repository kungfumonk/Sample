using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class Model
    {
        
        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        
        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }


        [Required]
        [Display(Name = "State")]
        public String State { get; set; }

       
        [Required]
        [RegularExpression(@"^@?[a-z0-9][-a-z0-9.!#$%&'*+-=?^_`{|}~\/]+@([-a-z0-9]+\.)+[a-z]{2,5}@?$", ErrorMessage = "Please enter a valid email")]
        [Display(Name = "Primary Email")]
        public String Email { get; set; }

        public List<String> StateList { get; set; }

        
        public Model(String pFirstName, String pLastName, String pState, String pEmail)
        {
            FirstName = pFirstName;
            LastName = pLastName;
            State = pState;
            Email = pEmail;
            
            if (StateList == null)
            {
                StateList = new List<string>();
            }

        }

        public Model()
        {
            if (StateList == null)
            {
                StateList = new List<string>();
            }
        }
