// Verilmiş 3 rəqəmli ədədin rəqəmləri cəmini tapın
int num = 381;
int rev = 0;
int rem;
if (num <= 0)
{
    Console.WriteLine("False");
}
while (num > 0)
{
    rem = num % 10;
    rev = rev + rem;
    num = num / 10;
}
Console.WriteLine(rev);
