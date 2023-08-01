// See https://aka.ms/new-console-template for more information
Console.Write("Введите число A: ");
int A=int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B=int.Parse(Console.ReadLine()!);

Console.WriteLine($" Если число {A} возвести в степень {B}, получиться {funct(A,B)}.");

int funct (int A, int B){
int res=A;
int i=2;
while(i<=B){
    res*=A;
    i++;
}
return res;
}
