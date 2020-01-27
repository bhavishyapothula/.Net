using System;

namespace ClassLibrary1
{
    public class CustomerValidation
    {
        public virtual bool CheckValid(int id)
        {
            //Check if database contains id
            return true;
        }


    }
}
