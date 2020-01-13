import java.util.Scanner;
class Transport
{
	double distance,cost=0,fare=0;
	void calculatecost()
	{
		cost=cost+(distance*fare);
		System.out.println(cost);
	}
}
class Railways extends Transport
{
	String train_r_type; 
	Railways()
	{
		System.out.println("Enter seat type:AC/General");
		Scanner sc = new Scanner(System.in);  
		train_r_type=sc.nextLine();
	}
	void train_fare()
	{
		if(train_r_type.equalsIgnoreCase("AC"))
		{
			fare=3.6;
		}
		if(train_r_type.equalsIgnoreCase("General"))
		{
			fare=1.2;
		}
	}
	
}
class Roadways extends Transport
{
	int inter_state_type,add_charges=0;
	Roadways()
	{
		System.out.println("Enter if inter state:1 or 0 otherwise");
		Scanner sc = new Scanner(System.in);  
		inter_state_type=sc.nextInt();
		if(inter_state_type==1)
		{
			add_charges=100;
		}
		cost=cost+add_charges;
	}
		
}
class Bus extends Roadways
{
	String bus_r_type;
	Bus()
	{
		System.out.println("Enter seat type:Sleeper/Seater");
		Scanner sc = new Scanner(System.in);  
		bus_r_type=sc.nextLine();
	}
	void bus_fare()
	{
		if(bus_r_type.equalsIgnoreCase("Sleeper"))
		{
			fare=4.2;
		}
		if(bus_r_type.equalsIgnoreCase("Seater"))
		{
			fare=2.5;
		}
	}
	
}
public class Inheritance
{
	public static void main(String args[])
	{
		Scanner sc = new Scanner(System.in);
		System.out.println("Enter distance");
		double dist=sc.nextDouble();
		System.out.println("Select one transport method");
		System.out.println("1.Railways");
		System.out.println("2.Roadways");  
		int choice=sc.nextInt();
		if(choice==1)
		{
			Railways r=new Railways();
			r.distance=dist;
			r.train_fare();
			r.calculatecost();	
		}
		if(choice==2)
		{
			Bus b=new Bus();
			b.distance=dist;
			b.bus_fare();
			b.calculatecost();
		}

	}
}