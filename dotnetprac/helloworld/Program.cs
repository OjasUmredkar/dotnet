using Drawing;
using Selling;
using System.Collections.Generic;
using Intro;
using Name;
Console.WriteLine("Hello, World!");


Point p1=new Point(2,10);
Point p2=new Point(5,25);
Shape l1=new Line(p1,p2,10,"Red");
l1.Draw();


Product pro1 = new Product(1,"Lays","Chips",10,20);
//ISellable i=new Product(1,"Lays","Chips",10,20);
List<ISellable> proList=new List<ISellable>();
pro1.Test();
pro1.Promote();
pro1.Sold();
proList.Add(pro1);

foreach(ISellable isell in proList){
    isell.Test();
    isell.Promote();
    isell.Sold();
}

// i.Test();
// i.Promote();
// i.Sold();


Profile profile=new Profile(1,"a1","A1","S1","C1",25,'M');
Console.WriteLine(profile);

Maths m=new Maths();
double area;
Maths.CalculateArea(5,out area);

Console.WriteLine("Area: "+area);

int a=50;
int b=60;

object o1=(object)a;
object o2=(object)b;
Console.WriteLine("O1: "+o1+ " A: "+a+" O2: "+o2+" B: "+b);
Maths.Swap(ref o1,ref o2);
Console.WriteLine("O1: "+o1+ " A: "+a+" O2: "+o2+" B: "+b);


