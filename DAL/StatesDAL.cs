using RentMe.Model;
using RentMe.Model.Validators;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class serves as the Data Access Layer
    /// for the cs6232-g3 DB States table.
    /// </summary>
    public class StatesDAL
    {
        /// <summary>
        /// Get list of all States.
        /// </summary>
        /// <returns></returns>
        public static List<State> GetStates()
        {
            List<State> states = new List<State>(50);
            string selectStatement = "SELECT StateCode, StateName FROM States";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            State state = new State
                            {
                                StateCode = reader["StateCode"].ToString(),
                                StateName = reader["StateName"].ToString()                                
                            };                          

                            states.Add(state);
                        }
                    }
                }
            }

            return states;
        }

        /// <summary>
        /// Returns the acronym form for given State.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static State GetStateCode(State state)
        {
            StateValidator.ValidateStateNamePresent(state);
            string selectStatement = "SELECT StateCode " +
                                     "FROM States " +
                                     "WHERE StateName = @StateName";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("StateName", state.StateName);
                    state.StateCode = selectCommand.ExecuteScalar().ToString();                                       
                }
            }

            return state;
        }

        /// <summary>
        /// Returns the full name for a given State.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static State GetStateName(State state)
        {
            StateValidator.ValidateStateCodePresent(state);
            string selectStatement = "SELECT StateName " +
                                     "FROM States " +
                                     "WHERE StateCode = @StateCode";

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("StateCode", state.StateCode);
                    state.StateName = selectCommand.ExecuteScalar().ToString();
                }
            }

            return state;
        }
    }
}
