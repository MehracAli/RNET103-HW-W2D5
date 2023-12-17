string star = "******";
string tre = new String('-', 30);

Console.WriteLine(tre);
//1. task

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(star.Substring(0, i));

}


Console.WriteLine(tre);
//2. task



Console.WriteLine(tre);
//3. task

char[] chars = star.ToCharArray();

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(string.Join(" ", chars));
}
