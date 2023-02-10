class Pointer{
    public static void Main(){
        unsafe{
        int x   = 40;
        int y   = 9;

        int *p1=&x;
        int *p2=&y;
        Console.WriteLine(*p1); // displaying value
        Console.WriteLine(*p2); // displaying value
        Console.WriteLine((int)&p1); //displaying address
        Console.WriteLine((int)&p2); //displaying address
        }
   }
}
