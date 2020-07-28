using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory objectFactory = new ObjectFactory();
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Id", 1);
            Armour armour = objectFactory.Get(ObjectType.Armour, data) as Armour;
            Weapon weapon = objectFactory.Get(ObjectType.Weapon, data) as Weapon;

            Console.WriteLine(armour.GetInfo());
            Console.WriteLine(weapon.GetInfo());
        }
    }

    enum ObjectType
    {
        Armour,
        Weapon
    }
    //class factory
    interface IObject
    {
        String GetInfo();
    }

    class ObjectFactory
    {
        private ObjectType _type;
        private Dictionary<string, object> _data;
        public IObject Get(ObjectType type, Dictionary<string, object> data)
        {
            _type = type;
            _data = data;

            return GetObject();
        }

        private IObject GetObject()
        {
            IObject obj = null;

            Int32 id = Convert.ToInt32(_data["Id"]);

            //fetch the object information based on the supplied type and data
            switch (_type)
            {
                case ObjectType.Armour:
                    if (id == 1)
                    {
                        obj = new Armour()
                        {
                            Id = 1, Name = "Shield of Sunlight", DefenceRating = 5, Weight = 67, Type = "Shield"
                        };
                    }

                    break;

                case ObjectType.Weapon:
                    if (id == 1)
                    {
                        obj = new Weapon()
                        {
                            Id = 1, Name = "Sword Of Flames", DamageRating = 12, Weight = 67, Type = "One-Handed Sword"
                        };
                    }

                    break;

                default:
                    obj = null;
                    break;
            }

            return obj;
        }
    }
    class Armour:IObject
    {
        public Int32 Id;
        public String Name;
        public Int32 DefenceRating;
        public Int32 Weight;
        public String Type;

        public virtual String GetInfo()
        {
            return String.Format("Armour name is {0}", Name);
        }
    }

    class Weapon:IObject
    {
        public Int32 Id;
        public String Name;
        public Int32 DamageRating;
        public Int32 Weight;
        public String Type;

        public virtual String GetInfo()
        {
            return String.Format("Weapon name is {0}", Name);
        }
    }
}
