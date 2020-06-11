using System;

    namespace Dojodachi
    {
        public class Pet
    {
        public string Name { get; set; }
        public int Fullness { get; set; }
        public int Happiness { get; set; }
        public int Meals {get; set;}
        public int Energy { get; set; }
        public string Message { get; set;} = "Save the Land of Zaron!";
            public Pet(string name, int fullness, int happiness, int energy, int meals)
            {
                Name = name;
                Fullness = fullness;
                //potions
                Happiness = happiness;
                //elves
                Energy = energy;
                // health
                Meals = meals;
                // flames
            }
            public Pet(string name)
            {
            Name = name;
            Fullness = 20;
            Happiness = 15;
            Energy = 10;
            Meals = 20;
            }
            public int Eat()
            // Surge : subtract random amnt of elves & health
            {
            Random rand = new Random();
            int chance = rand.Next(1,3);

            Random dmg = new Random();
            int damage = dmg.Next(1,6);

                if(Energy >= 1)
                {
                    Happiness -= chance;
                    Message = $"{Name} got {chance} elves but lost {damage} health points, perfect attacks are tiring!"; 
                    Energy -= damage;                   
                    return Energy;
                    }
                    else
                    Message = $"{Name} doesn't have enough energy to use his surge power!";
                    return Fullness;
                }
                public int Play()
                // Flame Strike subtract 2 flames, 25% chance of flame landing, if lands kill random amount of elves, if not 1 hit one elf.
            {
                Random rand = new Random();
                int chance = rand.Next(2,5);

                Random landed = new Random();
                int flamelanded = landed.Next(1,5);

                Random damage = new Random();
                int dmg = damage.Next(1,2);

                    if(Meals>=1)
                    {
                        if(flamelanded == 1)
                        {
                        Happiness -= chance;
                        Meals -= 2;
                        Energy -= dmg;
                        Message = $"Nice! {Name} landed the flame throw & got {chance} elves, but lost 2 Flames!";
                        return Happiness;
                        }
                        else
                        Happiness -= 1;
                        Energy -= dmg;
                        Message = $"{Name} only swiped the elves & got 1, but lost 2 Flames!";
                        return Happiness;
                    }
                    else
                    Message = $"{Name} doesn't have enough flames left!";
                    return Happiness;
                }
                public int Work()
                // Gluttony subtract one potion, add random amount of health.
                {
                Random rand = new Random();
                int chance = rand.Next(1,6);
                if(Fullness >= 1)
                {
                    Energy += chance;
                    Fullness -= 1;
                    Message = $"{Name} revived {chance} health points using his potion, but only has {Fullness} potions left!";
                    return Fullness;
                    }
                else
                Message = $"{Name} doesn't have enough potions left!";
                return Energy;
                }
                public void Sleep()
                // curse subtract random amount of elves & health.
                {
                Random rand = new Random();
                int chance = rand.Next(1,5);

                Random dmg = new Random();
                int damage = dmg.Next(1,6);

                if(Energy >=1)
                {
                    Happiness -= chance;
                    Energy -= damage;
                    Message = $"{Name} took out {chance} elves, but lost {damage} health points. Putting out curses is tiring!!";
                }
                else
                Message = $"{Name} doesn't have enough health left to fight!";
                }
                public bool Win()
                {
                    if((Happiness <= 0))
                    //elves are all dead
                    {
                        return true;
                    }
                    else
                    return false;
                }
                public bool Lose()
                {
                    if((Fullness <= 1) || (Meals <= 1) || (Energy<=1))
                    //potions health or flames run out
                    {
                        return true;
                    }
                    else
                    return false;
                }
            }
        }