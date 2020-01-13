class Lecture
{
	private String subject;
	public void setSubject(String name)
	{
		subject=name;
	}
	public String getSubject()
	{
		return subject;
	}
}
class Student
{
	private Lecture l;
	public Student()
	{
        	this.l=new Lecture();
        	l.setSubject(".Net");
    	}
    	public String getSubject() 
	{
        	return l.getSubject();
    	}

}
public class Composition 
{
	public static void main(String[] args) 
	{
        	Student s = new Student();
        	String name =s.getSubject();
		System.out.println("Subject: "+name);
    	}
}
	

