//using SchoolApp.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models.Interfaces
{
    public interface ISchool
    {
        IEnumerable<School> Schools { get; }

        Task SaveSchool(School School);

        School DeleteSchool(int SchoolID);
        
    }
}