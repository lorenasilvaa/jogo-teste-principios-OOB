namespace DIO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public overrride string Attack(){
            return this.Name + " lançou magia!";
        }
        public string Attack(int bonus){
            if(bonus > 6){
                return this.Name + " lançou magia super efetiva com bônus de ataque de " + bonus;
            }else{
                return this.Name + " lançou magia com força fraca com bônus de ataque de " + bonus;
            }
            
        }

        public override string ToMoveRight(){
            return this.Name + " voou para a direita!";
        }

        public override string ToMoveLeft(){
            return this.Name + " voou para a esquerda!";
        }

        public override string ToJump(){
            return this.Name + " pulou!";
        }

        
        
    }
}