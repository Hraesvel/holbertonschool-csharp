using System;
class Decoration: Base, IInteractive, IBreakable {

    bool isQuestItem;
    public int durability {get;set;}

    public Decoration(
        string name = "Decoration",
        int durability = 1,
        bool isQuestItem = false 
        )
        {
            if (durability <= 0) 
                throw new System.Exception("Durability must be greater than 0");

            this.name = name;
            this.durability = durability;
            
        }

    public void Interact() {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
            return;
        }
        
        if (isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    
    }

    public void Break() {
        durability -= 1;

        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else
            Console.WriteLine("The {0} is already broken.", name);

    }
}