using System;
					
public class Program
{
	
	
	public  static void transaction(){
	int account_type;
	Customer customer = new Customer();
	Account account = new Account();
	
		
	Console.WriteLine("enter  your first name:");
	customer.first_name = Console.ReadLine();
	Console.WriteLine("enter  your last name:");
	customer.last_name = Console.ReadLine();
	Console.WriteLine("Please choice account type:");
	Console.WriteLine("______________________________");
	Console.WriteLine("1.Local account");
	Console.WriteLine("2.USS");
	
	
	account_type = Convert.ToInt32(Console.ReadLine());
	if(account_type==1){
	 
		account.currency ="local";
		
		int InitialBalence;
		int transaction;
		InitialBalence =50000;
		Console.WriteLine("please select the trascation");
		Console.WriteLine("____________________________");
		Console.WriteLine("1.widthdraw");
		Console.WriteLine("2.deposit");
		transaction = Convert.ToInt32(Console.ReadLine());
		if (transaction==1){
		
			int widthdraw_amount;
			Console.WriteLine("Please enter widthdraw amount");
			widthdraw_amount = Convert.ToInt32(Console.ReadLine());
			if ( widthdraw_amount <= InitialBalence){
				int final_amount = InitialBalence-widthdraw_amount;
				Console.WriteLine("Your current balance:" + final_amount + " "+ "Frw" );
			
			}
			
			else {
				
				Console.WriteLine("Sorry you do not have enough amount for the transation"  );
			
			}
			
			
		
		
		}
		else if (transaction==2){
			int deposit_amount;
			Console.WriteLine("Please enter deposit amount");
			deposit_amount= Convert.ToInt32(Console.ReadLine());
			int final_amount = InitialBalence + deposit_amount;
			Console.WriteLine("Your current balance:" + final_amount + " "+ "Frw" );
			
		
		
		}
		
		else  {
		
		 Console.WriteLine("Invalid transaction");
		}
		
		
	
	
	}
		
	if(account_type==2){
	 
		account.currency ="USD";
		
		int InitialBalence;
		int transaction;
		InitialBalence =50;
		Console.WriteLine("please select the trascation");
		Console.WriteLine("____________________________");
		Console.WriteLine("1.widthdraw");
		Console.WriteLine("2.deposit");
		transaction = Convert.ToInt32(Console.ReadLine());
		if (transaction==1){
		
			int widthdraw_amount;
			Console.WriteLine("Please enter widthdraw amount");
			widthdraw_amount = Convert.ToInt32(Console.ReadLine());
			if ( widthdraw_amount <= InitialBalence){
				int final_amount = InitialBalence-widthdraw_amount;
				Console.WriteLine("Your current balance:" + final_amount + " "+ "$" );
			
			}
			
			else {
				
				Console.WriteLine("Sorry you do not have enough amount for the transation"  );
			
			}
			
			
			
		
		
		}
		else if (transaction==2){
			int deposit_amount;
			Console.WriteLine("Please enter deposit amount");
			deposit_amount= Convert.ToInt32(Console.ReadLine());
			int final_amount = InitialBalence + deposit_amount;
			Console.WriteLine("Your current balance:" + final_amount + " "+ "$" );
			
		
		
		}
		
		else  {
		
		 Console.WriteLine("Invalid transaction");
		}
		
		
	
	
	}
		
		
	
		
		
		
	
	
		else {
			Console.WriteLine("Invalid account type");
		
		}
	
	
	
		
	
		
	}

	
	
	
	
	
	public static void Main()
	{
		
		
		
		
		
		
		
		transaction();
		
		
		
	
	

	
}





class Customer{
	
	public string first_name;
	public string last_name;
	public string gender ;
	
	
	
	}




class Account{
	
	public int account_number;
	public string account_type;
	public string currency;
}
}





