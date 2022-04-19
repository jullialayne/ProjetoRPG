using dotnet___poo.src.Entities;

namespace Program{
    class ProjetoRPG{
        static void Main(string[] args){
            Knight hero = new Knight("Arus",23,"Knight",20);
            Wizard wizard = new Wizard("Jennica",23,"Whiite Wizard",20);

            while(true){
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("XP ATUAL");
                Console.WriteLine();
                Console.WriteLine($"{hero.Name}: {hero.XP}");
                Console.WriteLine($"{wizard.Name}: {wizard.XP}");
                Console.WriteLine();
                
                Console.WriteLine("----------------------------------------------------------------------------------");    
                Console.WriteLine("Ataque de "+hero.Name);
                int attackHero = int.Parse(Console.ReadLine());
                Console.WriteLine("Ataque: "+hero.Attack(attackHero));
                wizard.XP-=attackHero;

                if(wizard.XP<=0){
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine($"{wizard.Name} kill, GAME OVER");
                    break;
                }

                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("Ataque de "+wizard.Name);
                int attackWizard = int.Parse(Console.ReadLine());
                Console.WriteLine("Ataque: "+wizard.Attack(attackWizard));
                hero.XP-=attackWizard;
                
                if(hero.XP<=0){
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.WriteLine($"{hero.Name} kill, GAME OVER");
                    break;
                }
            }
        }
    }
}