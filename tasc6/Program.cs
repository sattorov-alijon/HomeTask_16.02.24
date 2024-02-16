// void juft (int a,int b)
// {
//     if(a==b)
// System.Console.WriteLine();
//     else 
//     {
//     if(a%2==0)
//         System.Console.Write(a+" ");
//         juft(a+1,b);
// }
// }
// int a=Convert.ToInt32(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// juft(a,b);

void toq (int a,int b)
{
    if(a==b)
System.Console.WriteLine();
    else 
    {
    if(a%2!=0)
        System.Console.Write(a+" ");
        toq(a+1,b);
}
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
toq(a,b);