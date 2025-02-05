using System;
namespace Interfaces
{
    interface iSalaryDetails
    {
        public void LastDrawn() 
        { 

        }
      
    }
    abstract class PersonalDetails
    {
        private string pandetails;
        private string basicpay;
        public string GetPanDetails()
        {
           return pandetails;
        }
        public void SetPanDetails(string pan)
        {
            pandetails = pan;
        }
        private void SetBasicPay(string basic)
        {
            basicpay = basic;
        }

    }

 



}
