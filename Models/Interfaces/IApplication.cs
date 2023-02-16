//using SchoolApp.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models.Interfaces
{
    public interface IApplication
    {
        IEnumerable<Application> Applications { get; }

        Task SaveApplication(Application Application);

        Application DeleteApplication(int ApplicationID);
    }
}