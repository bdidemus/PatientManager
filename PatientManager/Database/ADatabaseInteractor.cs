using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public abstract class ADatabaseInteractor
    {
        public void saveChanges()
        {
            m_context.SaveChanges();
            m_dataChanged = true;
        }

        internal static Database.PatientManagerEntities Context
        {
            get
            {
                return m_context;
            }
        }

        protected static void createNewContext()
        {
            m_context = new Database.PatientManagerEntities();
        }

        public void refreshFromDataSource()
        {
            // Refreshing using refresh dosen't seem to work so just make a new context
            createNewContext();
        }

        // Once data changed is queryed the bool value flips back to false
        public bool DataChanged
        {
            get
            {
                if (m_dataChanged)
                {
                    m_dataChanged = false;
                    return true;
                }
                return false;
            }
        }

        // Database object
        private static Database.PatientManagerEntities m_context = new Database.PatientManagerEntities();
        private bool m_dataChanged = false;
    }
}
