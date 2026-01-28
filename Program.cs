using System;

class COSC365{
    public static void Main(string[] args){
        MyClass mc = new MyClass();
        COSC365 c = mc as COSC365
        Console.WriteLine(mc.i);
    }
    public void Hello(){
        Console.WriteLine("Hello");
    }
    public int i = 5
}

class MyClass : COSC365{

    public int i = 15
}
