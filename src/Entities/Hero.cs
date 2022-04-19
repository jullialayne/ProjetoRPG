namespace dotnet___poo.src.Entities{
    public abstract class Hero{

        public Hero(string name,int level, string hero, int xp){
            this.Name = name;
            this.Level = level;
            this.HeroType = hero;
            this.XP = xp;
        }

        public Hero(){
          
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int XP;

        public override string ToString(){
            return "Nome: "+this.Name+"\nLevel: "+this.Level+"\nHero Type: "+this.HeroType;
        }

        public virtual string Attack(){
            return this.Name+" atacou com a sua espada";
        }

    }
}

