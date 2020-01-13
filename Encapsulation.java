class Entry
{
	private String entered_emp[]=new String[20];
	private int count=-1;
	public void entered(String name)
	{
 		entered_emp[++count]=name;
	}
	public int count_of_employees()
	{
		return count+1;
	}
	public void display_present_employees()
	{
		for(int i=0;i<=count;i++)
		System.out.println(entered_emp[i]);
	}
}
public class Encapsulation
{
	public static void main(String args[])
	{
		Entry e=new Entry();
		e.entered("Bhavishya");
		e.entered("Ram");
		e.entered("Sita");
		System.out.println("Total no.of employees present:"+e.count_of_employees());
		System.out.println("Employees present:");
		e.display_present_employees();
	}
}
