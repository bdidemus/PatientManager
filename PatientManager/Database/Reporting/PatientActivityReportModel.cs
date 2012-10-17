using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database.Reporting
{
    public class PatientActivityReportModel
    {
        private patient m_patient;
        private DateTime m_lastRecord;

        public patient Patient 
        { 
            set 
            { 
                m_patient = value; 
            }
            get
            {
                return m_patient;
            }
        }
        public String PatientName { get { return m_patient.FullName; } }
        public int PatientID { get { return m_patient.patID; } }
        public DateTime LastRecord
        {
            get
            {
                return m_lastRecord;
            }
            set
            {
                if (value > m_lastRecord)
                {
                    m_lastRecord = value;
                }
            }
        }


        public static List<PatientActivityReportModel> getInactivePatientActivityModel(DateTime date, int docID = 0)
        {
            var context = ADatabaseInteractor.Context;
            List<PatientActivityReportModel> list = null;

            var query = from inv in context.invoices
                        group inv by inv.patient into g
                        select new { Patient = g.Key, Date = g.Max(inv => inv.invDate)};

            var inActivePats = from pat in query
                               where pat.Date <= date
                               select new PatientActivityReportModel
                               {
                                   Patient = pat.Patient,
                                   LastRecord = pat.Date
                               };
 
            if (docID != 0)
            {
                inActivePats = from pat in inActivePats
                               where pat.Patient.docID == docID
                               select pat;
            }

            list = inActivePats.ToList();

            return list;
        }
    }
}
