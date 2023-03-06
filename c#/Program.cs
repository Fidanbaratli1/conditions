
//TASK 4 - Verilmiş dördrəqəmli natural ədədini tərsinə çevirin. 
//Math.floor-bir ededi yuxari asagi yuvarlaqlasdirir
int num = 3251;
int rev = 0;
int lastDigit;
if (num < 0)
{
    Console.WriteLine("False");
}
while (num > 0)
{
    lastDigit = num % 10;
    num = num / 10;
    rev = (rev * 10) + lastDigit;
}
Console.WriteLine(rev);

        }