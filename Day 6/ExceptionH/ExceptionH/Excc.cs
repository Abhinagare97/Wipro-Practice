using System;
public class InvalidNoExc : Exception
{
   public override string Message
    {
        get
        {
            return "Cannot use no greater than 299";

        }
    }
}