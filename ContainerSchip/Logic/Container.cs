using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip.Logic
{
    public class Container
    {
        public int Weight { get; private set; }
        public int MaxWeight = 30;
        public int MinWeight { get; private set; } = 4;


        public bool Coolable { get; private set; }
        public bool Valuable { get; private set; }
        public ContainerTypes type { get; private set; }


        public enum ContainerTypes
        {
            Normal = 1,
            Valuable = 2,
            Coolable = 3,
            ValuebleCoolable = 4
        }


        public Container(int weight, bool valuable, bool coolable)
        {
            Weight = weight;
            Valuable = valuable;
            Coolable = coolable;
            type = SetType();
        }


        private ContainerTypes SetType()
        {
            if (!Valuable && !Coolable)
            {
                return (ContainerTypes.Normal);
            }
            if (Valuable && !Coolable)
            {
                return (ContainerTypes.Valuable);
            }
            if (!Valuable && Coolable)
            {
                return (ContainerTypes.Coolable);
            }
            if (Valuable && Coolable)
            {
                return (ContainerTypes.ValuebleCoolable);
            }

            return (ContainerTypes.Normal);
        }


        public int SetWeight(int weight)
        {
            if (weight < MinWeight)
            {
                throw new Exception("MINIMUM WEIGHT IS 4");
            }
            else if (weight > MaxWeight)
            {
                throw new Exception("MAX WEIGHT IS 30");
            }

            return weight;
        }
        public override string ToString()
        {
            string type = Coolable ? "Coolable" : "Standard";
            string value = Valuable ? "Valuable" : "Not Valuable";

            return $"({type}, {value}), Weight: {Weight} kg";
        }

    }
}
