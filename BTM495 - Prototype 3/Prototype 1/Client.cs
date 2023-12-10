using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Client
    {
       
        private int clientID;
        private string firstName;
        private string lastName;
        private double familyIncome;
        private string livingArrangement;
        private int noChildren;
        private List<Appointment> appointments;
        private List<Application> applications;
        private List<Invoice> invoices;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double FamilyIncome
        {
            get { return familyIncome; }
            set { familyIncome = value; }
        }

        public string LivingArrangement
        {
            get { return livingArrangement; }
            set { livingArrangement = value; }
        }

        public int NoChildren
        {
            get { return noChildren; }
            set { noChildren = value; }
        }

        public Client() { }

        public Client(int cID, string fn, string ln, double fi, string la, int nc)
        {
            ClientID = cID;
            FirstName = fn;
            LastName = ln;
            FamilyIncome = fi;
            LivingArrangement = la;
            NoChildren = nc;
        }

        public void applyAdopt(Animal animal)
        {
            string applicationStatus = "Pending";
            if (this.noChildren > 0 && this.livingArrangement != "rented" && this.FamilyIncome > 50000)
            {
                applicationStatus = "Approved";
            }
            else
            {
                applicationStatus = "Rejected";
            }

            var application = new Application { Status = applicationStatus };
        }  

        public void bookAppoint(DateTime selectedDateTime)
        {
            if (appointments.Any(a => a != null && a.Time == selectedDateTime))
            {
                Console.WriteLine($"Sorry, {firstName}, there is already an appointment scheduled at {selectedDateTime}. Please choose another time.");
            }
            else
            {
                var appointment = new Appointment { Time = selectedDateTime };
                Console.WriteLine($"Appointment booked for {firstName} at {selectedDateTime}.");
            }
        }

        public void CancelAppoint(Appointment app)
        {
            appointments = new List<Appointment>();
            appointments.Remove(app);
        }


    }
}
