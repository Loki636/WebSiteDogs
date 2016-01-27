using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dogs.Models
{
    internal class Receiving
    {
        private int _ID;
        private int _user_ID;
        private Dog _Dog;
        private DateTime dateReceiving;
        private string _DiscriptionTrouble;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (value > 0)
                {
                    _ID = value;
                }
            }

        }
        public int User_ID
        {
            get { return _user_ID; }
            set
            {
                if (value > 0)
                {
                    _user_ID = value;
                }
            }
        }
        public Dog Dog
        {
            get { return _Dog; }
            set
            {
                if (value != null)
                {
                    _Dog = value;
                }

            }
        }
        public string DiscriptionTrouble
        {
            get { return _DiscriptionTrouble; }
            set
            {
                if (value != null)
                {
                    _DiscriptionTrouble = value;
                }
            }
        }
        public DateTime DateReceiving
        {
            get { return dateReceiving; }
            set
            {
                if (value.ToString().CompareTo(DateTime.Now.ToString()) > 1)
                {
                    DateReceiving = value;
                }
            }
        }

        public Receiving()
        {
            Dog = new Dog();
        }
        public Receiving(int Id, int user_Id, Dog dog, string discriptionTrouble, DateTime dateReceiving)
        {
            ID = Id;
            User_ID = user_Id;
            Dog = dog;
            DiscriptionTrouble = discriptionTrouble;
            DateReceiving = dateReceiving;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Дата приема " + DateReceiving.ToString());
            text.AppendLine("Описание проблемы " + DiscriptionTrouble);
            text.AppendLine(Dog.ToString());
            return text.ToString();
        }
    }
}