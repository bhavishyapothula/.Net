import java.util.Calendar;  
class Wish
{
	Wish()//no args,default access specifier
	{
		System.out.println("Hello");
	}
	Wish(String name)//parameterized
	{
		System.out.println("Hello "+name);
	}
}
class Motive
{
	protected Motive()//protected constructor
	{
		System.out.println("This is protected constructor");
	}
}
class Timed
{
	public Timed()//public constructor
	{
		int a=Calendar.getInstance().get(Calendar.HOUR_OF_DAY);
		if(a>=6 && a<=11)
		System.out.println("Good morning");
		else if(a>=12 && a<=15)
		System.out.println("Good afternoon");
		else if(a>=16 && a<=19)
		System.out.println("Good evening");
		else
		System.out.println("Good night");
	}
}
public class Constructor extends Motive
{
	public static void main(String args[])
	{
		Wish w=new Wish();
		Wish x=new Wish("Bhavishya");
		Timed t=new Timed();
		Motive m=new Motive();
	}
}