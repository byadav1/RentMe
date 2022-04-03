using System.Collections.Generic;

namespace RentMe.Model.Helpers
{
    /// <summary>
    /// This class models a collection of States
    /// </summary>
    public class States
    {
        private List<KeyValuePair<string, string>> StatesList;

        public States()
        {
            InitializeStates();
        }

        /// <summary>
        /// Gets the list of states.
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<string, string>> GetStates()
        {
            return this.StatesList;
        }

        /// <summary>
        /// Populate the list of states.
        /// </summary>
        private void InitializeStates()
        {
            StatesList = new List<KeyValuePair<string, string>>(50);
            StatesList.Add(new KeyValuePair<string, string>("AL", "Alabama"));
            StatesList.Add(new KeyValuePair<string, string>("AK", "Alaska"));
            StatesList.Add(new KeyValuePair<string, string>("AZ", "Arizona"));
            StatesList.Add(new KeyValuePair<string, string>("AR", "Arkansas"));
            StatesList.Add(new KeyValuePair<string, string>("CA", "California"));
            StatesList.Add(new KeyValuePair<string, string>("CO", "Colorado"));
            StatesList.Add(new KeyValuePair<string, string>("CT", "Connecticut"));
            StatesList.Add(new KeyValuePair<string, string>("DE", "Delaware"));
            StatesList.Add(new KeyValuePair<string, string>("DC", "District Of Columbia"));
            StatesList.Add(new KeyValuePair<string, string>("FL", "Florida"));
            StatesList.Add(new KeyValuePair<string, string>("GA", "Georgia"));
            StatesList.Add(new KeyValuePair<string, string>("HI", "Hawaii"));
            StatesList.Add(new KeyValuePair<string, string>("ID", "Idaho"));
            StatesList.Add(new KeyValuePair<string, string>("IL", "Illinois"));
            StatesList.Add(new KeyValuePair<string, string>("IN", "Indiana"));
            StatesList.Add(new KeyValuePair<string, string>("IA", "Iowa"));
            StatesList.Add(new KeyValuePair<string, string>("KS", "Kansas"));
            StatesList.Add(new KeyValuePair<string, string>("KY", "Kentucky"));
            StatesList.Add(new KeyValuePair<string, string>("LA", "Louisiana"));
            StatesList.Add(new KeyValuePair<string, string>("ME", "Maine"));
            StatesList.Add(new KeyValuePair<string, string>("MD", "Maryland"));
            StatesList.Add(new KeyValuePair<string, string>("MA", "Massachusetts"));
            StatesList.Add(new KeyValuePair<string, string>("MI", "Michigan"));
            StatesList.Add(new KeyValuePair<string, string>("MN", "Minnesota"));
            StatesList.Add(new KeyValuePair<string, string>("MS", "Mississippi"));
            StatesList.Add(new KeyValuePair<string, string>("MO", "Missouri"));
            StatesList.Add(new KeyValuePair<string, string>("MT", "Montana"));
            StatesList.Add(new KeyValuePair<string, string>("NE", "Nebraska"));
            StatesList.Add(new KeyValuePair<string, string>("NV", "Nevada"));
            StatesList.Add(new KeyValuePair<string, string>("NH", "New Hampshire"));
            StatesList.Add(new KeyValuePair<string, string>("NJ", "New Jersey"));
            StatesList.Add(new KeyValuePair<string, string>("NM", "New Mexico"));
            StatesList.Add(new KeyValuePair<string, string>("NY", "New York"));
            StatesList.Add(new KeyValuePair<string, string>("NC", "North Carolina"));
            StatesList.Add(new KeyValuePair<string, string>("ND", "North Dakota"));
            StatesList.Add(new KeyValuePair<string, string>("OH", "Ohio"));
            StatesList.Add(new KeyValuePair<string, string>("OK", "Oklahoma"));
            StatesList.Add(new KeyValuePair<string, string>("OR", "Oregon"));
            StatesList.Add(new KeyValuePair<string, string>("PA", "Pennsylvania"));
            StatesList.Add(new KeyValuePair<string, string>("RI", "Rhode Island"));
            StatesList.Add(new KeyValuePair<string, string>("SC", "South Carolina"));
            StatesList.Add(new KeyValuePair<string, string>("SD", "South Dakota"));
            StatesList.Add(new KeyValuePair<string, string>("TN", "Tennessee"));
            StatesList.Add(new KeyValuePair<string, string>("TX", "Texas"));
            StatesList.Add(new KeyValuePair<string, string>("UT", "Utah"));
            StatesList.Add(new KeyValuePair<string, string>("VT", "Vermont"));
            StatesList.Add(new KeyValuePair<string, string>("VA", "Virginia"));
            StatesList.Add(new KeyValuePair<string, string>("WA", "Washington"));
            StatesList.Add(new KeyValuePair<string, string>("WV", "West Virginia"));
            StatesList.Add(new KeyValuePair<string, string>("WI", "Wisconsin"));
            StatesList.Add(new KeyValuePair<string, string>("WY", "Wyoming"));
        }
    }
}
