using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examadoNew2
{
    class DoctorBO
    {
        public bool InsertDoctor(Doctor doctor)
        {
            return new DoctorDAO().InsertDoctor(doctor);
        }

        public bool UpdateDoctor(int doctorId, double fees)
        {
            return new DoctorDAO().UpdateDoctor(doctorId, fees);
        }

        public bool DeleteDoctor(int doctorId)
        {
            return new DoctorDAO().DeleteDoctor(doctorId);
        }
        public void DisplayDoctors()
        {
            List<Doctor> list = new DoctorDAO().GetAllDoctor();
            if (list.Count > 0)
            {
                Console.WriteLine(String.Format("{0,-5}{1,-10}{2,-15}{3,-15}{4}", "Id", "Name", "Qualification", "Experience", "Fees"));
                
                foreach (Doctor d in list)
                {
                    //Fill your code here
                    
                    Console.WriteLine(String.Format("{0,-5}{1,-10}{2,-15}{3,-15}{4}", d.Id, d.Name, d.Qualification, d.Experience, d.Fees));
                    

                }
            }
            else
            {
                //Fill your code here
                Console.WriteLine("No doctor available");
            }
        }
    }
}
