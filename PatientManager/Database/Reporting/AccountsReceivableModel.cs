﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database.Reporting
{
    public class AccountsReceivableModel
    {
        private patient m_patient;
        private decimal m_oweing;

        public patient Patient { get { return m_patient; } set { m_patient = value; } }

        public int patID { get { return m_patient.patID; } }
        public String patName { get { return m_patient.FullName; } }
        public String patAddress { get { return m_patient.patAddress; } }
        public String patAddress2 { get { return m_patient.patAddress2; } }
        public String patPhone { get { return m_patient.patPhoneNumber; } }
        public String patPCode { get { return m_patient.patPCode; } }
        public String patCity { get { return m_patient.patCity; } }
        public decimal AmountOweing { get { return m_oweing; } set { m_oweing = value; } }

        public static List<AccountsReceivableModel> getAccountsReceiveableModel(DateTime startDate,
            DateTime endDate, Forms.Reporting.Dialogs.AccountsRecivableDialog.updateFormProgress callback, int docID = 0)
        {
            List<AccountsReceivableModel> lstAccReceivables = new List<AccountsReceivableModel>();

            patient[] allPatients;
            if(docID == 0)
            {
                PatientMgr patMgr = new PatientMgr();
                allPatients = patMgr.getPatients().ToArray();
            }
            else
            {
                DoctorMgr docMgr = new DoctorMgr();
                allPatients = docMgr.getDoctor(docID).patients.ToArray();
            }

            int total = allPatients.Length;
            int progress = 0;
            foreach (patient pat in allPatients)
            {
                decimal balance = pat.rangedAccountBalance(startDate, endDate.AddDays(1).Date);
                if (balance < 0)
                {
                    AccountsReceivableModel accRec = new AccountsReceivableModel();

                    accRec.Patient = pat;
                    accRec.AmountOweing = -balance; // just to remove the minus sign on the report

                    lstAccReceivables.Add(accRec);   
                }
                callback(++progress, total);
            }

            lstAccReceivables.Sort((p1, p2) => string.Compare(p1.Patient.FullName, p2.Patient.FullName));
                  
            return lstAccReceivables;
        }
    }
}
