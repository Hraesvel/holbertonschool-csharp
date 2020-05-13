using System;
class Door : Base, IInteractive {

    public Door (string name = "Door") {
        this.name = name;
    }
    public void Interact() {
        System.Console.WriteLine($"You try to open the {this.name}. It's locked");
    }

}