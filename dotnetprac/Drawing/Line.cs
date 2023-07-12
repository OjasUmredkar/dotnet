namespace Drawing{

    public class Line:Shape{

        public Point p1;
        public Point p2;


        public Line():base(){
            this.p1=new Point();
            this.p2=new Point();
        }
        public Line(Point p1,Point p2,int width,string color):base(width,color){

            this.p1=p1;
            this.p2=p2;
            this.color=color;
            

        }



        public override void Draw(){

            string str=string.Format("Startpoint: ({0},{1}), Endpoint: ({2},{3}), Color:{4}, Width:{5}",
            p1.x,p1.y,p2.x,p2.y,color,width);
            Console.WriteLine(str);
            

        } 

        

    }


}