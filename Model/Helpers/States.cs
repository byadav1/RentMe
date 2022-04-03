using System;
using System.Collections.Generic;
using System.Linq;

namespace RentMe.Model.Helpers
{
    /// <summary>
    /// This class models a collection of States
    /// </summary>
    public class States
    {
        private Dictionary<string, string> statesList;

        public States()
        {
            InitializeStates();
        }

        /// <summary>
        /// Gets the list of states.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetStatePairs()
        {
            return this.statesList;
        }

        /// <summary>
        /// Gets statesList keys.
        /// </summary>
        /// <returns></returns>
        public List<string> GetStateKeys()
        {
            List<string> stateKeys = new List<string>();
            foreach (string key in this.statesList.Keys)
            {
                stateKeys.Add(key);
            }

            return stateKeys;
        }

        /// <summary>
        /// Gets stateList values.
        /// </summary>
        /// <returns></returns>
        public List<string> GetStateNames()
        {
            List<string> stateNames = new List<string>();
            foreach (string state in this.statesList.Values)
            {
                stateNames.Add(state);
            }

            return stateNames;
        }

        /// <summary>
        /// Get the key associated with stateName value.
        /// </summary>
        /// <param name="stateName"></param>
        /// <returns></returns>
        public string GetStateCharFormat(string stateName)
        {
            try
            {
                return this.statesList.FirstOrDefault(stateKey => stateKey.Value == stateName).Key;
            }
            catch(Exception)
            {
                return "Key does not exist for this state";
            }           
        }

        /// <summary>
        /// Get the value associated with stateAsChar key.
        /// </summary>
        /// <param name="stateAsChar"></param>
        /// <returns></returns>
        public string GetStateName(string stateAsChar)
        {
            return this.statesList[stateAsChar];
        }

        /// <summary>
        /// Populate the list of states.
        /// </summary>
        private void InitializeStates()
        {
            this.statesList = new Dictionary<string, string>(50)
            {
                { "AL", "Alabama" },
                { "AK", "Alaska" },
                { "AZ", "Arizona" },
                { "AR", "Arkansas" },
                { "CA", "California" },
                { "CO", "Colorado" },
                { "CT", "Connecticut" },
                { "DE", "Delaware" },
                { "DC", "District Of Columbia" },
                { "FL", "Florida" },
                { "GA", "Georgia" },
                { "HI", "Hawaii" },
                { "ID", "Idaho" },
                { "IL", "Illinois" },
                { "IN", "Indiana" },
                { "IA", "Iowa" },
                { "KS", "Kansas" },
                { "KY", "Kentucky" },
                { "LA", "Louisiana" },
                { "ME", "Maine" },
                { "MD", "Maryland" },
                { "MA", "Massachusetts" },
                { "MI", "Michigan" },
                { "MN", "Minnesota" },
                { "MS", "Mississippi" },
                { "MO", "Missouri" },
                { "MT", "Montana" },
                { "NE", "Nebraska" },
                { "NV", "Nevada" },
                { "NH", "New Hampshire" },
                { "NJ", "New Jersey" },
                { "NM", "New Mexico" },
                { "NY", "New York" },
                { "NC", "North Carolina" },
                { "ND", "North Dakota" },
                { "OH", "Ohio" },
                { "OK", "Oklahoma" },
                { "OR", "Oregon" },
                { "PA", "Pennsylvania" },
                { "RI", "Rhode Island" },
                { "SC", "South Carolina" },
                { "SD", "South Dakota" },
                { "TN", "Tennessee" },
                { "TX", "Texas" },
                { "UT", "Utah" },
                { "VT", "Vermont" },
                { "VA", "Virginia" },
                { "WA", "Washington" },
                { "WV", "West Virginia" },
                { "WI", "Wisconsin" },
                { "WY", "Wyoming" }
            };
        }
    }
}
