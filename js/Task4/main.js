//Verilmiş dördrəqəmli natural ədədini tərsinə çevirin.
//Math.floor-ededi yuxari asagi yuvarlaqlasdirir
let num=5461
let rev=0;
let rem
if(num<0){
    console.log("False");
}
while(num>0){
    rem=num%10;
    rev=rev*10+rem;
    num=Math.floor(num/10);
}
console.log(rev);