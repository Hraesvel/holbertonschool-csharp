using System;
using System.Collections.Generic;

class RoomObjects
{
    /// <summary>
    ///  Method that will perform primary action on set of given object and 
    /// type.
    /// </summary>
    /// <param name="roomObjects"> List of objects to perform actions on
    /// </param>
    /// <param name="type">Interface action to invoke</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        switch (type.Name)
        {
            case "IInteractive":
                foreach (var i in roomObjects)
                    if (i is IInteractive)
                    {
                        IInteractive item = i as IInteractive;
                        item.Interact();
                    }

                break;
            case "IBreakable":
                foreach (var i in roomObjects)
                    if (i is IBreakable)
                    {
                        IBreakable item = i as IBreakable;
                        item.Break();
                    }

                break;
            case "ICollectable":
                foreach (var i in roomObjects)
                    if (i is ICollectable)
                    {
                        ICollectable item = i as ICollectable;
                        item.Collect();
                    }

                break;
        }
    }
}