namespace DIO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " atacou com sua espada!";
        }

        public virtual string ToMoveRight(){
            return this.Name + " andou para a direita!";
        }

        public virtual string ToMoveLeft(){
            return this.Name + " andou para a esquerda!";
        }

        public virtual string ToJump(){
            return this.Name + " pulou!";
        }

        
    }
}