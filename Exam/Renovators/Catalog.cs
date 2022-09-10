using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators = new List<Renovator>();
        public List<Renovator> Renovators => this.renovators;
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public int Count => this.renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrWhiteSpace(renovator.Name))
            {
                return "Invalid renovator's information.";
            }

            if (Renovators.Count +1 > NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            
            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";


        }

        public bool RemoveRenovator(string name)
        {
            foreach (var item in Renovators)
            {
                if (item.Name == name)
                {
                    return true;
                }

            }
            
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int counter = 0;
            foreach (var item in Renovators)
            {
                
                if (item.Type == type)
                {
                    counter++;
                   
                }
                
            }
            return counter;

        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = null;
            foreach (var item in Renovators)
            {
                
                if (item.Name == name)
                {
                    item.Hired = true;
                    renovator = item;
                }

            }
            return renovator;

        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> listing = new List<Renovator>();
            foreach (var item in Renovators)
            {

                if (item.Days > days)
                {
                    listing.Add(item);
                }

            }
            return listing;
        }

        public string Report()
        {
            List<Renovator> listing = new List<Renovator>();
            StringBuilder sb = new StringBuilder();

            foreach (var item in Renovators)
            {
                if (item.Hired == false)
                {
                    listing.Add(item);
                }

            }
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in listing)
            {
                sb.AppendLine($"-Renovator: {item.Name}").ToString();
                sb.AppendLine($"--Specialty: {item.Type}").ToString();
                sb.AppendLine($"--Rate per day: {item.Rate}");

            }
            return sb.ToString().TrimEnd();
        }




    }
}
