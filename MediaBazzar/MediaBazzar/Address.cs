using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Address
    {

        private string state;
        private string city;
        private string street;
        private string apartmentNr;

        public string State { get { return this.state; } }
        public string City { get { return this.city; } }
        public string Street { get { return this.street; } }
        public string ApartmentNr { get { return this.apartmentNr; } }
        public Address(string state, string city, string street, string apartmentNr)
        {
            this.state = state;
            this.city = city;
            this.street = street;
            this.apartmentNr = apartmentNr;
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(apartmentNr))
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
