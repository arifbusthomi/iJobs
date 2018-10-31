using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dal
{
    public class DAL
    {
        static iJobsEntities DbContext;
        static DAL()
        {
            DbContext = new iJobsEntities();
        }
        public static List<Tbl_Candidate> GetAllCandidate()
        {
            return DbContext.Tbl_Candidate.ToList();
        }
        public static Tbl_Candidate GetCandidate(int productId)
        {
            return DbContext.Tbl_Candidate.Where(p => p.ID == productId).FirstOrDefault();
        }
        public static bool InsertCandidate(Tbl_Candidate candidateItem)
        {
            bool status;
            try
            {
                DbContext.Tbl_Candidate.Add(candidateItem);
                DbContext.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public static bool UpdateCandidate(Tbl_Candidate candidateItem)
        {
            bool status;
            try
            {
                Tbl_Candidate candItem = DbContext.Tbl_Candidate.Where(p => p.ID == candidateItem.ID).FirstOrDefault();
                if (candItem != null)
                {
                    candItem.Username = candidateItem.Username;
                    candItem.Firstname = candidateItem.Firstname;
                    candItem.Lastname = candidateItem.Lastname;
                    candItem.Password = candidateItem.Password;
                    candItem.UserRole = candidateItem.UserRole;
                    candItem.IsActive = candidateItem.IsActive;
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
        public static bool DeleteCandidate(int id)
        {
            bool status;
            try
            {
                Tbl_Candidate candItem = DbContext.Tbl_Candidate.Where(p => p.ID == id).FirstOrDefault();
                if (candItem != null)
                {
                    DbContext.Tbl_Candidate.Remove(candItem);
                    DbContext.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}