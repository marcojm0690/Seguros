using Seguros.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DAL
{
    public interface IInsuranceRepository : IDisposable
    {
        IEnumerable<Insurance> GetAllInsurances();
        IEnumerable<Client> GetAllClients();
        //Insurance GetInsuranceById(int insuranceID);
        void AddInsurance(Insurance insurance);
        void DeleteInsurance(int insuranceID);
        void ModifyInsurance(Insurance insurance);
        void Save();
        Insurance GetInsuranceById(int? clientID);
    }
}
