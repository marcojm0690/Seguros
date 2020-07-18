using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Seguros.DAL.Models;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DAL
{
    public class InsuranceRepository: IInsuranceRepository
    {

        private InsuranceContext _context;

        public InsuranceRepository(InsuranceContext insuranceContext)
        {
            this._context = insuranceContext;
        }

        public IEnumerable<Insurance> GetAllInsurances()
        {
            return _context.Insurances.ToList();
        }

        public Insurance GetInsuranceById(int id)
        {
            return _context.Insurances.Find(id);
        }

        public void AddInsurance(Insurance insurance)
        {
            _context.Insurances.Add(insurance);
        }

        public void DeleteInsurance(int insuranceId)
        {
            Insurance insurance= _context.Insurances.Find(insuranceId);
            _context.Insurances.Remove(insurance);
        }

        public void ModifyInsurance(Insurance insurance)
        {
            _context.Entry(insurance).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
