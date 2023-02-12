namespace Swapping{
class Pointerswap{
    static void Main(String []args){
        int a=10;
        int b=20;
        int *p= &a ; 
        int *q= &b;
        Console.WriteLine("Before Swap a= {0} , b={1}", a,b);
        int temp=*p;
        *p=*q;
        *q=temp;   
        Console.WriteLine("After Swap a= {0} , b={1}", a,b);

    }
  }
}
