using RentMe.DAL;
using RentMe.Model;
using RentMe.Model.Validators;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the StatesDAL.
    /// </summary>
    public class StatesController
    {
        /// <summary>
        /// Get list of all States.
        /// </summary>
        /// <returns></returns>
        public List<State> GetStates()
        {
            return StatesDAL.GetStates();
        }

        /// <summary>
        /// Get list of all State names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetStateNames()
        {
            List<string> states = new List<string>(50);
            foreach(State state in this.GetStates())
            {
                states.Add(state.StateName);
            }

            return states;
        }

        /// <summary>
        /// Returns the acronym form for given State.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public State GetStateCode(State state)
        {
            StateValidator.ValidateStateNamePresent(state);
            return StatesDAL.GetStateCode(state);
        }

        /// <summary>
        /// Returns the full name for a given State.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public State GetStateName(State state)
        {
            StateValidator.ValidateStateCodePresent(state);
            return StatesDAL.GetStateName(state);
        }
    }
}
