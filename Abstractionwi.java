interface Data
{
	public void getDetails();
	public void setDetails(String a,String b,String c);
}
class PersonalData implements Data
{
	private String fbid=null;
	private String instaid=null;
	private String name=null;
	public void setDetails(String name,String fbid,String instaid)
	{
		System.out.println("Personal Details:");
		this.name=name;
		this.fbid=fbid;
		this.instaid=instaid;
	}
	public void getDetails()
	{
		System.out.println("Name:"+name);
		System.out.println("Facebook id:"+fbid);
		System.out.println("Instagram id:"+instaid);
		System.out.println("Personal");
		
	}
}
class ProfessionalData implements Data
{
	private String empid=null;
	private String empmail=null;
	private String name=null;
	public void setDetails(String name,String empid,String empmail)
	{
		System.out.println("Professional Details:");
		this.name=name;
		this.empid=empid;
		
		this.empmail=empmail;
	}
	public void getDetails()
	{
		System.out.println("Name:"+name);
		System.out.println("Employee id:"+empid);
		System.out.println("Employee email:"+empmail);
				
	}
}
public class Abstractionwi
{
	public static void main(String args[])
	{
		Data pd=new PersonalData();
		pd.setDetails("bhavi","bp","b_p");
		pd.getDetails();
		Data prd=new ProfessionalData();
		prd.setDetails("bhavi","102","B_P@domain.com");
		prd.getDetails();
	}
}