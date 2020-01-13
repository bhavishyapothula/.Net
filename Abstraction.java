abstract class Data
{
	public String name;
	public Data(String name)
	{
		this.name=name;	
	}
	abstract void getDetails();
}
class PersonalData extends Data
{
	private String fbid;
	private String instaid;
	public PersonalData(String name,String fbid,String instaid)
	{
		super(name);
		System.out.println("Personal Details:");
		this.fbid=fbid;
		this.instaid=instaid;
	}
	void getDetails()
	{
		System.out.println("Name:"+super.name);
		System.out.println("Facebook id:"+fbid);
		System.out.println("Instagram id:"+instaid);
		
	}
}
class ProfessionalData extends Data
{
	private String empid;
	private String systemno;
	private String empmail;
	public ProfessionalData(String name,String empid,String systemno,String empmail)
	{
		super(name);
		System.out.println("Professional Details:");
		this.empid=empid;
		this.systemno=systemno;
		this.empmail=empmail;
	}
	void getDetails()
	{
		System.out.println("Name:"+super.name);
		System.out.println("Employee id:"+empid);
		System.out.println("System id:"+systemno);
		System.out.println("Employee email:"+empmail);		
	}
}
public class Abstraction
{
	public static void main(String args[])
	{
		Data pd=new PersonalData("bhavi","bp","b_p");
		pd.getDetails();
		Data prd=new ProfessionalData("bhavi","102","955","123");
		prd.getDetails();
	}
}

  