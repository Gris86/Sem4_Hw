// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размерность массива: ");
int size=int.Parse(Console.ReadLine()!);
while(size<=0) {
    Console.WriteLine("Введите число >0: ");
    size=int.Parse(Console.ReadLine()!);}

int[] array1=RandomArray(size); // для произвольного количества элементов в массиве
Console.WriteLine($"[{String.Join(",",array1)}]");


int[] RandomArray(int a){
int[] array=new int[a];
for(int i=0;i<a;i++) array[i]=new Random().Next();

return array;
}
