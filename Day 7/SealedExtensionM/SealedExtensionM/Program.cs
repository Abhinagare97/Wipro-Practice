using System;
using SealedExtensionM;
public class Program
{
    public static void Main(String[] args)
    {
        OldService service = new OldService();
        service.Test1();
        service.Test2();
        service.NoOfWords("hello how are you");


    }
}

