namespace Name
{

    public class Maths{


        public Maths(){

        }
        public static void CalculateArea(int r,out double area){
            area=3.14*r*r;
        }

        public static void Swap(ref object o1,ref object o2){
            object temp=o1;
            o1=o2;
            o2=temp;

        }


    }
    
}