using System;
using System.Collections.Generic;

class LList {
    public static int Length(LinkedList<int> myLList) {
        int len = 0;
        foreach(int i in myLList)
            len++;
        return len;
    }
}