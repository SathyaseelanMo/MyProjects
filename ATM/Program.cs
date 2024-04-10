using System;
namespace ATM
{
public class Cardholder
{ 
   string Cardnum;
   int Pass;
   public string first;
   public string last;
   double balance;
   public Cardholder(string Cardnum,int Pass,string first,string last,double balance)
   {
     this.Cardnum=Cardnum;
     this.Pass=Pass;
     this.first=first;
     this.last=last;
     this.balance=balance;
   }
    public string getfirst()
    {
        return first;
    }
    public string getlast()
    {
        return last;
    }
    public double getbalance()
    {
        return balance;
    }

    public void setbalance(double balance)
    {
        this.balance=balance;
    }



public static void Main(String[] args)
{  Cardholder currentuser;
    
    void printoptions()
{
    Console.WriteLine("Please select the options");
    Console.WriteLine("1.Deposit\n 2.Withdraw\n 3.Checkbalance\n 4.Exit\n");

}
void deposit()
{
     Console.WriteLine("Please enter the amount to deposit $");
     double cash=double.Parse(Console.ReadLine());
     currentuser.setbalance(currentuser.getbalance()+cash);
     Console.WriteLine("you have a total of $"+currentuser.getbalance());

}
void withdraw()
{
     Console.WriteLine("Please enter the amount to withdraw $");
     double cash=double.Parse(Console.ReadLine());
     if (cash>currentuser.getbalance()){
        Console.WriteLine("Insufficient balance :(");
     }
     else{
     currentuser.setbalance(currentuser.getbalance()-cash);
     }
     Console.WriteLine("you have a total of $"+currentuser.getbalance());

}
List<Cardholder>lists=new List<Cardholder>();
lists.Add(new Cardholder("11111",111,"one","man",1000));
lists.Add(new Cardholder("22222",222,"two","man",2000));
lists.Add(new Cardholder("33333",333,"three","man",3000));
lists.Add(new Cardholder("44444",444,"four","man",4000))  ;
top:
while(true){
    try{
        Console.WriteLine("Welcome to simple ATM :)\nEnter Debit card num :");
        string num=Console.ReadLine();
        currentuser=lists.FirstOrDefault(a=>a.Cardnum==num);
        if (currentuser!=null){break;}
        else{Console.WriteLine("enter correct card num!");}

    }
    catch{Console.WriteLine("enter correct card num!");}
}
Console.WriteLine("Enter PIN:");
int pin=int.Parse(Console.ReadLine());
int opt;
if (currentuser.Pass==pin)
{ Console.WriteLine("Welcome to ATM "+currentuser.first+currentuser.last+" "+":)");
  do{
    opt=0;
    printoptions();
    opt=int.Parse(Console.ReadLine());
    if (opt==1){deposit();}
    if (opt==2){withdraw();}
    if (opt==3){Console.WriteLine("Your balance is $"+currentuser.getbalance());}
    
  }
  while(opt!=4);
}
else{goto top;}
Console.WriteLine("Thankyou!!!");
}


}
}
