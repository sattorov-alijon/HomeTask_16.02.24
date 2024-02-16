void recur2 (int n)
{
    if(n==1)
    System.Console.Write(1);
    else 
    {

    System.Console.Write(n+" ");
    recur2(n-1);
    }
}
int a=Convert.ToInt32(Console.ReadLine());
recur2(a);