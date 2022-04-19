namespace dotnet___poo.src.Entities{
    public class Wizard:Hero{

        public override string Attack(){
            return this.Name +" lançou magia";
        }
        public string Attack(int Bonus){

            if(Bonus > 6){
                return this.Name +" lançou magia super efetiva com bonus de ataque de "+Bonus;
            }else{
                return this.Name +" lançou magia com força fraca com bonus de ataque de "+Bonus;
        
            }
        }

         public Wizard(string name,int level, string hero, int xp){
            this.Name = name;
            this.Level = level;
            this.HeroType = hero;
            this.XP = xp;
        }
    }}