using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Address
    {
        private string state;
        private string city;
        private string street;
        private string apartmentNr;

        public Address(string state, string city, string street)
        {
            this.state = state;
            this.city = city;
            this.street = street;
            apartmentNr = String.Empty;
        }
        
        public Address(string state, string city, string street, string apartmentNr) : this(state, city, street)
        {
            this.apartmentNr = apartmentNr;
        }

        public override string ToString()
        {
            if(String.IsNullOrEmpty(apartmentNr))
            {
                return $"{street}, {city}, {state}";
            }
            else
            {
                return $"{street}, Apartment {apartmentNr}, {city}, {state}";
            }
        }
    }
}
