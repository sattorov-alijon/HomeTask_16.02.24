int Sumdig (int n)
{
    if(n==0)
return 0;
    else 
    {
        return Sumdig(n/10)+1;
}
}
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sumdig(a));