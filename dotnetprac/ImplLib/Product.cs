namespace Selling{
public class Product:ISellable
{

    private int id;
    private string name;
    private string description;
    private int qty;
    private double price;

   

    public Product(int id, string name, string description, int qty, double price)
    {
        this.Id = id;
        this.name = name;
        this.description = description;
        this.qty = qty;
        this.price = price;
    }

    public int Id{
        get{return this.id;}
        set{this.id=value;}
    }

    public string Name{
        get{return this.name;}
        set{this.name=value;}
    }

    public string Description{
        get{return this.name;}
        set{this.description=value;}
    }

    public int Qty{
        get{return this.qty;}
        set{this.qty=value;}
    }

    public double Price{
        get{return this.price;}
        set{this.price=value;}
    }

   
    public override string ToString()
    {
        string str= base.ToString();
        return str+" [ Id:"+id+" Name:"+name+" Description: "+description+" Quantity: "+qty+" Price: "+price+" ]";
    }

    public void Sold(){
        Console.WriteLine("Selling Product");
    }

    public void Promote(){
        Console.WriteLine("Promoting The Product");
    }

    public void Test(){
        Console.WriteLine("Testing the Product");
    }
}
}
