using System.Text;

string star = "*";
string tre = new String('-', 30);

char[] stars = ['*'];

for (int i = 1; i < 6; i++)
{
    Array.Resize(ref stars, 1 + i);
    stars[i] = '*';
}

var str = new StringBuilder();

for (int i = 0; i < stars.Length; i++)
{
    str.Append(stars[i]);
}

Console.WriteLine(tre);
//Task 1//

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(str.ToString().Substring(0, i));
}


Console.WriteLine(tre);
//Task 2//

char[] chars1 = str.ToString().ToCharArray();

for (int i = 0; i < chars1.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine(string.Join(' ', chars1));
    }
    if (i > 1 && i< chars1.Length)
    {
        string st = string.Join(' ', chars1);
        st = st.Replace('*', ' ');
        st = st.Insert(0, "*").Insert(st.Length-1, "*");
        Console.WriteLine(st);
    }
    if(i == chars1.Length-1)
    {
        Console.WriteLine(string.Join(' ', chars1));
    }
}




Console.WriteLine(tre);
//Task 3//
char[] chars2 = str.ToString().ToCharArray();


for (int i = 0; i < 6; i++)
{
    Console.WriteLine(string.Join(" ", chars2));
}
