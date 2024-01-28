//using DocumentFormat.OpenXml.Bibliography;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL

{
    // This repository does inherits from IRepository,
    // but if one day we want to add more functions to the Person object,
    // we will add them here.   
    internal interface IPersonRepository : IRepository<Person>
    {
 
    }
}
