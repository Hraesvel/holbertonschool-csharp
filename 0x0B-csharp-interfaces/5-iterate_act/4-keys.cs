using System;

class Key : Base , ICollectable {

    private bool _isCollected;
    public Key (string name = "Key", bool isCollected = false)
    {
        this.name = name;
        _isCollected = isCollected;
    }
    public bool isCollected { get => _isCollected; }

    public void Collect()
    {
        if (!_isCollected)
           { _isCollected = true;
            Console.WriteLine("You pickup the {0}.", name);
           }
        else 
            Console.WriteLine("You have already picked up the {0}.", name);
    }
}