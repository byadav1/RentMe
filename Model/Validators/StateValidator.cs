using System;

namespace RentMe.Model.Validators
{
    /// <summary>
    /// This class serves as a validator
    /// for State objects.
    /// </summary>
    public class StateValidator
    {
        /// <summary>
        /// Throw exception if State object is null.
        /// </summary>
        /// <param name="state"></param>
        public static void ValidateStateNotNull(State state)
        {
            if (state == null)
            {
                throw new ArgumentException("The state cannot be null");
            }
        }

        /// <summary>
        /// Throw exception if StateCode not present.
        /// </summary>
        /// <param name="state"></param>
        public static void ValidateStateCodePresent(State state)
        {
            ValidateStateNotNull(state);
            if (string.IsNullOrWhiteSpace(state.StateCode))
            {
                throw new ArgumentException("The state must have a code");
            }
        }

        /// <summary>
        /// Throw exception if StateName not present.
        /// </summary>
        /// <param name="state"></param>
        public static void ValidateStateNamePresent(State state)
        {
            ValidateStateNotNull(state);
            if (string.IsNullOrWhiteSpace(state.StateName))
            {
                throw new ArgumentException("The state must have a name");
            }
        }
    }
}
