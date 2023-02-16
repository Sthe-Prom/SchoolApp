//using SchoolApp.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models.Interfaces
{
    public interface IAddress
    {
        IEnumerable<Address> Addresses { get; }

        Task SaveAddress(Address Address);
        
        Address DeleteAddress(int AddressID);
    }
}