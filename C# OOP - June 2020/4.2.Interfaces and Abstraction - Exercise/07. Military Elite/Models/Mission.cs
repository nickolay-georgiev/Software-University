using MilitaryElite.Enumerators;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission :  IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = CompleteMission(state);
        }

        public string CodeName { get; }

        public State State { get; }

        public State CompleteMission(string state)
        {
            State currentState;

            bool isValidMission = State.TryParse(state, out currentState);

            if(!isValidMission)
            {
                throw new Exception("Invalid mission");
            }

            return currentState;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
