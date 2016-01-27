using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dogs.Models
{
    public class Doctor
    {
        private Int32 ID;
        private String _FirstName;
        private String _LastName;
        private String _Phone;
        private String _Email;
        private String _Address;
        private IList<Receiving> _Receivings;

        public String FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value != null)
                {
                    _FirstName = value;
                }
            }
        }

        public String LastName
        {
            get { return _LastName; }
            set
            {
                if (value != null)
                {
                    _LastName = value;
                }
            }
        }

        public String Phone
        {
            get { return _Phone; }
            set
            {
                if (value != null)
                {
                    _Phone = value;
                }
            }
        }

        public String Email
        {
            get { return _Email; }
            set
            {
                if (value != null)
                {
                    _Email = value;
                }
            }
        }

        public String Address
        {
            get { return _Address; }
            set
            {
                if (value != null)
                {
                    _Address = value;
                }
            }
        }

        public IList<Receiving> Receivings
        {
            get { return _Receivings; }
        }

        public Doctor()
        {
            _Receivings = new List<Receiving>();
        }
        public Doctor(Int32 ID, string firstname, string lastname, string phone, string email, string address)
        {
            this.ID = ID;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Email = email;
            Address = address;
            _Receivings = new List<Receiving>();
        }

        public IList<Receiving> ShowReceivings()
        {
            return Receivings;
        }

        public bool TransferReceiving(Receiving receiving, DateTime dateReceiving)
        {
            if (receiving != null && dateReceiving.CompareTo(receiving.DateReceiving) > 1)
            {
                receiving.DateReceiving = dateReceiving;
                return true;
            }
            return false;
        }
        public void AddReceiving(Receiving receiving)
        {
            if (receiving != null)
            {
                Receivings.Add(receiving);
            }
        }
    }
}