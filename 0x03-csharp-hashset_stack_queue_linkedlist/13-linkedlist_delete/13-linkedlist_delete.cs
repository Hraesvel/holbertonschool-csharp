using System;
using System.Collections.Generic;

class LList {
    public static void Delete (LinkedList<int> myLList, int index) {
        if (myLList.Count == 0 || index < 0 || index > myLList.Count)
            return;

        int value = 0;
        int idx = 0;
       
        foreach (int i in myLList) {
            value = i;
            if(idx == index)
                break;
            idx++;
        }

        myLList.Remove(value);
    }
}