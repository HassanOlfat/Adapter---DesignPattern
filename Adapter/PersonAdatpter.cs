using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class PersonAdatpter : Employee
    {
        private Person _person;
        public PersonAdatpter(Person person)
        {
            this._person = person;
        }

        public override int Id => this._person.NationalCode;
        public override string Name => this._person.FristName;
        public override string Family => this._person.LastName;

    }
}
