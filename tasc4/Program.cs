void recur3 (int n)
{
    if(n==0)
    System.Console.Write("");
    else 
    {

    recur3(n/10);
    System.Console.Write(n%10+" ");
    }
}
int a=Convert.ToInt32(Console.ReadLine());
recur3(a);