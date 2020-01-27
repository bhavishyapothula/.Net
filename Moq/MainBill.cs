using System;
using ClassLibrary1;
namespace ClassLibraryMock
{
    public class Bill
    {
       
        public double GenerateBill(CustomerValidation ob,int custid,int quantity,double price)
        {

            if (ob.CheckValid(custid))
            {
                return quantity*price; 
            }
            return 0;
        }
    }
}
