using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dogs.Models
{
    public class Dog
    {
        private String _TypeDog;
        private Int32 _Age;
        private String _Name;

        public String TypeDog
        {
            get { return _TypeDog; }
            set
            {
                if (value != null)
                {
                    _TypeDog = value;
                }
            }
        }
        public Int32 Age
        {
            get { return _Age; }
            set
            {
                if (value > 0)
                {
                    _Age = value;
                }
            }
        }
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _Name = value;
                }
            }
        }
        public Dog() { }
        public Dog(String typeDog, Int32 age, String name)
        {
            TypeDog = typeDog;
            Age = age;
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("Тип собаки: {0} Возраст: {1} Имя: {2} ", TypeDog, Age, Name);
        }
    }
}