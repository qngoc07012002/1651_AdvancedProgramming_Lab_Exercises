using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Exercises
{
    internal class Commando : ICommando
    {
        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }
        public string Corps { get; }
        public IReadOnlyCollection<IMission> Missions => missions.AsReadOnly();

        private List<IMission> missions;

        public Commando(string id, string firstName, string lastName, double salary, string corps)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;
            missions = new List<IMission>();
        }

        public void AddMission(IMission mission)
        {
            missions.Add(mission);
        }

        public void CompleteMission(string missionCodeName)
        {
            var mission = missions.Find(m => m.CodeName == missionCodeName);

            if (mission != null)
            {
                mission.CompleteMission();
            }
        }

        public override string ToString()
        {
            string result = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}\nCorps: {Corps}\nMissions:\n";

            foreach (var mission in missions)
            {
                result += $"  {mission.ToString()}\n";
            }

            return result;
        }
    }
}
