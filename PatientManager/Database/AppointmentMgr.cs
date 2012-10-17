using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PatientManager.Database
{
    public class AppointmentMgr : ADatabaseInteractor
    {
        public AppointmentMgr()
        {

        }

        public void saveAppointment(appointment app)
        {
            Context.AddToappointments(app);
            saveChanges();
        }

        public void updateAppointment()
        {
            saveChanges();
        }

        public void changeAppointmentDate(int appID, DateTime newStartDate, DateTime newEndDate)
        {
            appointment app = getAppointment(appID);
            app.appDate = newStartDate;
            app.appDuration = (int)newEndDate.Subtract(newStartDate).TotalMinutes;
            saveChanges();
        }

        public IQueryable<appointment> getAppointments()
        {
            return from app in Context.appointments
                       where app.patient.patActive == true
                       select app;
        }

        public IQueryable<appointment> getAppointments(DateTime startDate, DateTime endDate)
        {
            return from appointments in Context.appointments
                    where appointments.appDate > startDate && appointments.appDate < endDate && appointments.patient.patActive == true
                    select appointments;
        }

        public IQueryable<appointment> getAppointments(DateTime startDate, DateTime endDate, int docID)
        {
            return from appointments in Context.appointments
                   where appointments.appDate > startDate && appointments.appDate < endDate && appointments.patient.patActive == true
                        && appointments.docID == docID
                   select appointments;
        }

        public appointment getAppointment(int appID)
        {
            appointment app = null;
            var query = from appoitments in Context.appointments
                        where appoitments.appID == appID
                        select appoitments;
            if (query.Count() > 0)
            {
                app = query.First();
            }
            return app;
        }

        public bool bookNextAppointments(int appID, int weekOffset, bool[] days, DateTime[] times, int[] type)
        {
            return bookNextAppointments(getAppointment(appID), weekOffset, days, times, type);
        }

        public bool bookNextAppointments(appointment prevApp, int weekOffset, bool[] days, DateTime[] times, int[] type)
        {
            try
            {
                DateTime baseDate = Utility.GetFirstDayOfWeek(prevApp.appDate).AddDays(7 * weekOffset);
                appointment[] appointments = new appointment[5];
                for (int i = 0; i < 5; i++)
                {
                    if (days[i])
                    {
                        DateTime appDate = baseDate.AddDays(i+1) + times[i].TimeOfDay;
                        appointment app = new appointment();
                        app.appDate = appDate;
                        app.appDuration = prevApp.appDuration;
                        app.appStatusID = 0;
                        app.docID = prevApp.docID;
                        app.patID = prevApp.patID;
                        app.itryID = type[i];
                        app.appRenewIntervalID = 0;
                        app.appColour = prevApp.appColour;
                        app.appDateCreate = DateTime.Today;
                        appointments[i] = app;
                    }
                }

                // Once all the appointments have been parsed save to database
                foreach (appointment app in appointments)
                {
                    if(app != null)
                    {
                        saveAppointment(app);
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public appointment[] getAppointmentsAsArray(DateTime startDate, DateTime endDate)
        {
            try
            {
                return getAppointments(startDate, endDate).ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public appointment[] getAppointmentsAsArray(DateTime startDate, DateTime endDate, int docID)
        {
            return getAppointments(startDate, endDate, docID).ToArray();
        }

        public List<Calendar.Appointment> fillCalenderAppointments(DateTime dateTime, int docID = -1)
        {
            return fillCalenderAppointments(dateTime, dateTime.AddDays(1), docID);
        }

        public List<Calendar.Appointment> fillCalenderAppointments(DateTime startDate, DateTime endDate, int docID = -1)
        {
            List<Calendar.Appointment> appList = new List<Calendar.Appointment>();
            appointment[] appointmentsArray;
            if (docID == -1)
            {
                appointmentsArray = getAppointmentsAsArray(startDate, endDate);
            }
            else
            {
                appointmentsArray = getAppointmentsAsArray(startDate, endDate, docID);
            }

            if (appointmentsArray != null)
            {
                foreach (Database.appointment app in appointmentsArray)
                {
                    String docName = String.Empty;
                    // Prevent crash if doctor is missing from database
                    if (app.doctor != null)
                    {
                        docName = app.doctor.docFullName;
                    }

                    Calendar.Appointment calApp = new Calendar.Appointment();
                    calApp.StartDate = app.appDate;
                    calApp.EndDate = app.appDate.AddMinutes(app.appDuration); // End date is start date + duration
                    if (app.appDuration <= 15)
                    {
                        calApp.Title = "Patient: " + app.patient.FullName + " Doctor: " + docName;
                    }
                    else
                    {
                        calApp.Title = "Patient: " + app.patient.FullName + "\nDoctor: " + docName;
                    }
                    calApp.AppointmentID = app.appID;

                    calApp.Color = ColorTranslator.FromHtml(app.appColour);
                    calApp.DrawBorder = true;
                    switch (app.appStatusID)
                    {
                        case 0:
                            calApp.BorderColor = Color.Blue;
                            break;
                        case 1:
                            calApp.BorderColor = Color.ForestGreen;
                            break;
                        case 2:
                            calApp.BorderColor = Color.White;
                            break;
                        case 3:
                            calApp.BorderColor = Color.Red;
                            break;
                        default:
                            calApp.BorderColor = Color.Black;
                            break;
                    }
                    // add new appointment to the list that is used to populate the calendar view
                    appList.Add(calApp);
                }
            }
            return appList;
        }

        public void deleteAppointment(int appID)
        {
            Context.appointments.DeleteObject(getAppointment(appID));
            saveChanges();
        }

        public IQueryable<inventory> getAppointmentTypes()
        {
            return from itry in Context.inventories
                   where itry.catID == 1 && itry.itryActive == true
                   select itry;
        }

        public void changeAppointmentStatus(int appID, int statusID)
        {
            getAppointment(appID).appStatusID = statusID;
            saveChanges();
        }
    }
}
