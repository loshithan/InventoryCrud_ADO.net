namespace examadoNew2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            DoctorBO bo = new DoctorBO();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Insert doctor");
            Console.WriteLine("2.Update fees");
            Console.WriteLine("3.Delete doctor");
            Console.WriteLine("4.Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the name");
                    //Fill your code here
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the qualification");
                    //Fill your code here
                    string qualification = Console.ReadLine();
                    Console.WriteLine("Enter the experience");
                    //Fill your code here
                    int exp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the fees");
                    //Fill your code here
                    double fees = Convert.ToDouble(Console.ReadLine());
                    
                    if (bo.InsertDoctor(new Doctor(name,qualification,exp,fees)))
                    {
                        Console.WriteLine("Doctor inserted successfully");
                        //Fill your code here
                        bo.DisplayDoctors();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the doctor id");
                    //Fill your code here
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the fees");
                    //Fill your code here
                    double upFees = Convert.ToDouble(Console.ReadLine());

                    if (bo.UpdateDoctor(id,upFees))
                    {
                        Console.WriteLine("Doctor updated successfully");
                        //Fill your code here
                    }
                    else
                    {
                        Console.WriteLine("Invalid doctor id");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the doctor id");
                    //Fill your code here
                    int delId = Convert.ToInt32(Console.ReadLine());
                    if (bo.DeleteDoctor(delId))
                    {
                        Console.WriteLine("Doctor deleted successfully");
                        //Fill your code here
                    }
                    else
                    {
                        Console.WriteLine("Invalid doctor id");
                    }
                    break;
                case 4:
                    break;

                default:
                    //Fill your code here
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}