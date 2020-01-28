using System;

class Pragram {
    static void Main(string[] args) {
        for (int i = 1; i <= 100; i++) {
            if (i % 3 != 0 && i % 5 != 0) {
                Console.Write(i);
            } else {
                Console.Write("{0}{1}",
                (i % 3 == 0) ? "Fizz" : "",
                (i % 5 == 0) ? "Buzz" : ""
                );
            }

            Console.Write("{0}", i < 100 ? " " : "\n");
        }
    }
}