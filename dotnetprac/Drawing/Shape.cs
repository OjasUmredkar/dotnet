namespace Drawing {

    public abstract class Shape{

        public int width;
        public string color;

        public Shape(){
            this.color="Black";
            this.width=5;
        }

        public Shape(int width,string color){
            this.width=width;
            this.color=color;
        } 

        public abstract void Draw();

    }
}