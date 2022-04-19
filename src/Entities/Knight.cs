namespace dotnet___poo.src.Entities{
    public class Knight:Hero{

        public override string Attack(){
            return this.Name+" atacou com a sua espada";
        }
        public string Attack(int Bonus){
             if(Bonus > 6){
                return this.Name +" atacou com a sua espada super efetiva com bonus de ataque de "+Bonus;
            }else{
                return this.Name +" atacou com a sua espada com força fraca com bonus de ataque de "+Bonus;
        
            }
        }

         public Knight(string name,int level, string hero, int xp){
            this.Name = name;
            this.Level = level;
            this.HeroType = hero;
            this.XP = xp;
        }
    }}