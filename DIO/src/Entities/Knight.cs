namespace DIO.src.Entities
{
    public class Knight:Hero
    {
        public Knight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }  

        public override string ToMoveRight(){
            return this.Name + " andou para a direita!";
        }

        public override string ToMoveLeft(){
            return this.Name + " andou para a esquerda!";
        }

        public override string ToJump(){
            return this.Name + " pulou!";
        }


    }
}