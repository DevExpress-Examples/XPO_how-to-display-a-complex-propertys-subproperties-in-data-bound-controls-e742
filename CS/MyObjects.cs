using System;
using DevExpress.Xpo;

namespace ComplexProperty {
	public class Person : XPObject {
        public Person(Session session) : base(session) { }

        string _name;
        public string Name {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

        Address _address;
        [Aggregated]
        public Address Address {
            get { return _address; }
            set { SetPropertyValue("Address", ref _address, value); }
        }
	}

	public class Address : XPObject {
        public Address(Session session) : base(session) { }

		string _addressLine1;
        public string AddressLine1 {
            get { return _addressLine1; }
            set { SetPropertyValue("AddressLine1", ref _addressLine1, value); }
        }

        string _city;
        public string City {
            get { return _city; }
            set { SetPropertyValue("City", ref _city, value); }
        }

        string _zip;
        public string Zip {
            get { return _zip; }
            set { SetPropertyValue("Zip", ref _zip, value); }
        }
	}
}
