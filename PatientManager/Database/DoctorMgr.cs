using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public class DoctorMgr : ADatabaseInteractor
    {
        public IQueryable<doctor> getDoctors()
        {
            return Context.doctors;
        }

        public IQueryable<doctor> getActiveDoctors()
        {
            return from doc in Context.doctors
                   where doc.docActive == true
                   select doc;
        }

        public doctor getDoctor(int docID, bool showInactive = false)
        {
            doctor doc = null;
            IQueryable<doctor> query;
            if (!showInactive)
            {
                query = from doctors in Context.doctors
                        where doctors.docID == docID && doctors.docActive == true
                        select doctors;
            }
            else
            {
                query = from doctors in Context.doctors
                        where doctors.docID == docID
                        select doctors;
            }

            if (query.Count() > 0)
            {
                doc = query.First();
            }
            return doc;
        }

        public void insertNewDoctor(doctor doc)
        {
            Context.AddTodoctors(doc);
            saveChanges();
        }

        public void saveNewDoctor(doctor doc)
        {
            Context.AddTodoctors(doc);
            Context.SaveChanges();
        }

        public bool deleteDoctor(doctor doc)
        {
            bool result = true;
            try
            {
                Context.doctors.DeleteObject(doc);
                saveChanges();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool deleteDoctor(int docID)
        {
            return deleteDoctor(getDoctor(docID));
        }

        public bool softDeleteDoctor(doctor doc)
        {
            if (doc != null)
            {
                doc.docActive = false;
                saveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool softDeleteDoctor(int docID)
        {
            return softDeleteDoctor(getDoctor(docID));
        }

        public bool unSoftDeleteDoctor(doctor doc)
        {
            if (doc != null)
            {
                doc.docActive = true;
                saveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool unSoftDeletDoctor(int docID)
        {
            return unSoftDeleteDoctor(getDoctor(docID));
        }
    }
}
