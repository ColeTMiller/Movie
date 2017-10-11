using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDetails
{
    public class Details
    {
        // public readonly Product None = new Product(); 

        /// <summary> Gerts or sets the Title of movie</summary>
        public string Title
        {
            //string to get the Title
            get
            {
                return _title ?? " "; 
            }
            //void set Title strinv value.
            set
            {
                _title = value ? .Trim();  
            }
        }
        public string Description
        {
            get
            {
                return _description ?? " "; 
            }
            set
            {
                _description = value ? .Trim(); 
            }
        }
        public decimal Time { get; set; } = 0;

        public bool Own { get; set; }

        public override string ToString()
        {
            return Title; 
        }

        public virtual string Validate()
        {
            // Title cannot be empty
            if (String. IsNullOrEmpty(Title))
                    return "Title cannot be empty";
            // Description cannot be empty
            if (String.IsNullOrEmpty(Description))
                return "Description cannot be empty";
            // Time>=1
            if (Time <= 1)
                return "Time has to be >= 1";


            return null; 
        }

        private string _title;
        private string _description; 
    }
}
