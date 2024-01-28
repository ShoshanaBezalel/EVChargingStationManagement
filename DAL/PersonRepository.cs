using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    internal class PersonRepository : IPersonRepository
    {

        LibraryContext context;
        public PersonRepository(LibraryContext context)
        {
            this.context = context;
        }
        public bool Create(Person entity)
        {
            throw new NotImplementedException();
            //try
            //{
            //    Person CreateNewPerson = new Person(FirstName, LastName, Password, Phone, Email);
            //    var createdPerosn = context.People.Add(CreateNewPerson);
            //    context.SaveChanges();
            //    return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
            //return context.People.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Person entity)
        {
            throw new NotImplementedException();
        }

    }
}
