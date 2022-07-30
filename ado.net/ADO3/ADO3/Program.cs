namespace ADO3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Menu");
			Console.WriteLine("1.Search item type");
			Console.WriteLine("2.Delete item type");
			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 1)
			{
				Console.WriteLine("Enter the item type name");
				string searchName = Console.ReadLine();
				Console.WriteLine("Item type Details");
				ItemTypeBO itbo = new ItemTypeBO();
				ItemType it = itbo.GetItemTypeByName(searchName);
				Console.WriteLine("Id:{0}\nName:{1}\nDeposit:{2}\nCost per day:{3}", it.Id, it.Name, it.Deposit, it.CostPerDay);
				
				//Fill your code here
			}
			else if (choice == 2)
			{
				Console.WriteLine("Enter the item type name");
				string name = Console.ReadLine();
				bool flag;
				//Fill your code here
				ItemTypeBO itbo = new ItemTypeBO();
				flag = itbo.DeleteItemType(name);

				if (flag)
				{
					Console.WriteLine("Deleted successfully");
					Console.WriteLine("Item type details");
					Console.WriteLine(String.Format("{0,-5}{1,-15} {2,-15} {3}", "Id", "Name", "Deposit", "CostPerDay"));
					List<ItemType> list = itbo.GetAllItemType();
					foreach (ItemType item in list)
					{
						Console.WriteLine(String.Format("{0,-5}{1,-15} {2,-15} {3}", item.Id, item.Name,item.Deposit,item.CostPerDay));
					}
					//Fill your code here
				}
                else
                {
                    Console.WriteLine("Invalid input");
                }
			}
			else
			{
				Console.WriteLine("Invalid input");
			}
		}
	}
}