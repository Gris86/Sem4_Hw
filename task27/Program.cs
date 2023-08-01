// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int num=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} равна {sum1(num)}.");



int sum1(int number){
    int n=number;
    int res=0;
    while(n>9){
        res+=n%10;
        n=n/10;
    }
    res+=n;
    return res;
}



