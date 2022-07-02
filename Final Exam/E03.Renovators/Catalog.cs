using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public Catalog()
        {
            this.renovators = new List<Renovator>();
        }

        public Catalog(string name, int neededRenovators, string project) : this()
        {
            this.name = name;
            this.neededRenovators = neededRenovators;
            this.project = project;
        }

        public int Count => renovators.Count;
        public List<Renovator> Renovators => renovators;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int NeededRenovators
        {
            get => neededRenovators;
            set => neededRenovators = value;
        }
        public string Project
        {
            get => project;
            set => project = value;
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }

            if (Count < neededRenovators)
            {
                return "Renovators are no more needed.";
            }

            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            return renovators.Remove(renovators.Find(r => r.Name == name));
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            return renovators.RemoveAll(r => r.Type == type);
        }
        public Renovator HireRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(r => r.Name == name);
            if (renovator != null)
            {
                renovator.Hired = true;
                return renovator;
            }

            return null;
        }
        public List<Renovator> PayRenovators(int days)
        {
            var renovators = this.renovators.Where(r => r.Days >= days).ToList();
            foreach (var renovator in renovators)
            {
                renovator.Hired = true;
            }

            return renovators;
        }
        public string Report()
        {
            var filtered = renovators.Where(r => r.Hired == true);
            return $"Renovators available for Project {project}:" + Environment.NewLine +
                   string.Join(Environment.NewLine, filtered);
        }
    }
}
