// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class SampleMain
{


    public static void Main(string[] args)
    {
        //1
        string getResource = Console.ReadLine();
        FileAvailable(getResource);


        //2
        string getNum = Console.ReadLine();
        int x = Int32.Parse(getNum);
        if (x < 0 || x > 1000)
        {
            throw new Exception();
        }

        //4
        string getValue = Console.ReadLine();
        try
        {
            int parseInt = Int32.Parse(getNum);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //
        string getSquareRoot = Console.ReadLine();
        SquareRoot(getSquareRoot);

        //9
        string getDobule = Console.ReadLine();
        Console.WriteLine(UpperValue(getDobule));
    }


    private static string FileAvailable(string loc) {
        string setFileData = String.Empty;
        try
        {
            if (!File.Exists(loc))
            {
                throw new Exception("File does not Exist");
            }

            using (FileStream fileStream = File.OpenRead(loc))
            {
                //file read here
            }
        }
        catch (Exception e) { 
            Console.WriteLine(e.Message);
        }
        return setFileData;
    }
    //5
    public List<int> GetList(List<int> setList) {

        try
        {
            foreach (int i in setList)
            {
                int checker = Int32.Parse(i);
            }
        }
        catch (Exception e) {
            throw;
        }
        return setList;
    }

    //6
    public int DivideNumber(int x, int y) {
        int totalValue = 0;
        try
        {
            totalValue =  x / y;
        }
        catch (DivideByZeroException) {
            Console.WriteLine();
        }
        return totalValue;
    }


    //7
    public DateTime ParseDate(string s) {
        CultureInfo provider = CultureInfo.InvariantCulture;
        return DateTime.ParseExact(s, "dd/mm/yyyy", provider);
    }

    //8
    public static double ? SquareRoot(string s) {
        try
        {
            return Math.Sqrt(Int32.Parse(s));
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        return null;
    }

    //9

    public static string UpperValue(string val) {

        try {
            if (val == null) {
                throw new NullReferenceException("Null value");
            }
           return val.ToUpper();
        }
        catch (NullReferenceException ex) {
            Console.WriteLine(ex.Message);
        }
        return null;
    }

}
