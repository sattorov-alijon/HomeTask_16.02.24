int Sum (int n)
{
    if(n==1)
return 1;
    else 
    {
        return Sum(n-1)+n;
}
}
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(a));