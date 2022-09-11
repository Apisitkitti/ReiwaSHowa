using System;
public class Program
{
   public static void Main()
    {
        int Year = StringTOint(Input());
        int Month = StringTOint(Input());
        int day = StringTOint(Input());
        string Year_Jap = Yook(Year,Month,day);
        Console.WriteLine(Year_Jap);
        
    }
   public static string Input()
   {

    return Console.ReadLine();
   }


   public static int StringTOint(string input )
   {
    int.TryParse(input,out int Name);
    return Name;
   }
   public static string Yook(int year,int month,int day)
   {
    if(Meji(year,month,day))
    {
        return "Meji";
    }
    else if(Taizo(year,month,day))
    {
        return "Taizo";
    }
    else if(Showa(year,month,day))
    {
        return "Showa";
    }
    else if(Heisei(year,month,day))
    {
        return "Heisei";
    }
    else if (Reiwa(year,month,day))
    {
      return "Reiwa";   
    }
    else return Yook(year,month,day);
   }
    public static bool Meji(int year,int month,int day)
    {
       return year>=1868&&month<=9&&day>=8&&year<=1912&&month>=7&&day<=29;
    }
    public static bool Taizo(int year,int month,int day)
    {
        return year>=1912&&month<=12&&day>=24&&year<=1926&&month>=7&&day<=30;
    }
    public static bool Showa(int year,int month,int day)
    {
       return year>=1926&&month<=12&&day>=7&&year<=1989&&month>=1&&day<=25;
    }
     public static bool Heisei(int year,int month,int day)
    {
        return year>=1989&&month<=4&&day>=8&&year<=2019&&month>=1&&day<=30;
    }
    public static bool Reiwa(int year,int month,int day)
    {
       return year>=2019&&month>=5&&day>=1;
    }

    
    

}