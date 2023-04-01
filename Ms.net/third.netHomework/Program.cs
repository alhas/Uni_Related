namespace third.netHomeWork {
    using System;

    internal abstract class Executor {
        private static void Main(string[] args) {
            var exercise = new Exercise();
            // exercise.SamplePrograms();
            // exercise.PrintIntegers();
            // exercise.ForLoopFactorial();
            // exercise.InRangeDivisibleByTwo();
            // exercise.InRangeDivisibleByThree();
            // exercise.InRangeEvenNumbers();
            // exercise.AlphabetFunction();
            // exercise.AddIntDoWhile();
            // exercise.SumEvenIntFor();
            // exercise.InRangeDivTwoAndThree();
            // exercise.InRangeDivTwoNotDivThreeAndEight();
            // exercise.MultiplicationTable();
        }
    }

    class Exercise {
        public void SamplePrograms() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Value of i: {0}", i);
            }

            int b = 0;
            while (b < 10) {
                Console.WriteLine("Value of i: {0}", b);
                b++;
            }

            int c = 0;
            do {
                Console.WriteLine("Value of i: {0}", c);
                c++;
            } while (c < 10);

            for (int i = 0;; i++) {
                // A loop without exit criterion
                Console.WriteLine("Value of i: {0}", i);
                if (i == 10) {
                    break;
                }
            }

            int d = 10;
            for (;;) {
                //Endless loop
                Console.WriteLine("Value of i: {0}", d);
                if (d++ >= 10) {
                    break;
                }
            }

            int a1 = 0, x1 = 100;
            do {
                a1++;
                x1--;
                if (x1 <= 80) break;
            } while (a1 > 30);

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 10; j++) {
                    //Nested loop
                    Console.WriteLine("i:{0} j:{1}", i, j);
                    if (j == 5) break;
                }
            }

            for (int i = 0; i < 30; i++) {
                if (i % 2 == 0) continue;
                Console.WriteLine("Value of i: {0}", i);
            }
        }

        public void PrintIntegers() {
            for (var i = 0; i < 10; i++) {
                Console.WriteLine($" I value = {i}");
            }

            var b = 0;
            while (b < 9) {
                b++;
                Console.WriteLine($" B value {b} in while loop");
            }

            var a = 0;
            do {
                a++;
                Console.WriteLine($"Do while value = {a}");
            } while (a < 9);
        }

        public void ForLoopFactorial() {
            Console.WriteLine("Enter a value to find factorial :");
            var x = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (var i = 1; i <= x; i++) {
                factorial *= i;
            }

            Console.WriteLine($"Factorial is = {factorial}");
        }

        public void InRangeDivisibleByTwo() {
            for (var i = 1; i < 20; i++) {
                if (i % 2 == 0) Console.WriteLine($"Number {i} divisible by 2");
            }
        }

        public void InRangeDivisibleByThree() {
            var i = 1;

            while (i < 30) {
                if (i % 3 == 0) Console.WriteLine($" Value {i} divisible by 3");
                ++i;
            }
        }

        public void InRangeEvenNumbers() {
            for (var i = 0; i < 30; i++) {
                if (i % 2 == 1) continue; //checks odd numbers
                Console.WriteLine($"Value {i} is even");
            }
        }

        public void AlphabetFunction() {
            Console.WriteLine("Enter a letter: ");
            var x = Console.ReadKey().KeyChar;
            Console.WriteLine();
            var letter = 'a';

            while (letter <= x) {
                Console.WriteLine($"{letter}");
                letter++;
            }
        }

        public void AddIntDoWhile() {
            Console.WriteLine("Enter a number to find sum in sequence");
            var x = Convert.ToInt32(Console.ReadLine());
            var i = 0;
            var total = 0;
            do {
                total += i;
                i++;
            } while (i <= x);

            Console.WriteLine($"Total sum is = {total}");
        }

        public void SumEvenIntFor() {
            Console.WriteLine("Enter a number to find sum of even numbers: ");
            var x = Convert.ToInt32(Console.ReadLine());
            var total = 0;

            for (var i = 0; i <= x; i++) {
                if (i % 2 == 0) total += i;
            }

            Console.WriteLine($"Sum of even numbers in {x} is {total}");
        }

        public void InRangeDivTwoAndThree() {
            for (var i = 100; i > 0; i--) {
                if (i % 2 == 0 & i % 3 == 0) Console.WriteLine($" For Loop Number {i} is div by 2 and 3.");
            }

            var wLoop = 100;
            while (wLoop > 0) {
                if (wLoop % 2 == 0 & wLoop % 3 == 0)
                    Console.WriteLine($" While Loop Number {wLoop} is div by 2 and 3.");
                wLoop--;
            }

            var doLoop = 100;
            do {
                if (doLoop % 2 == 0 & doLoop % 3 == 0)
                    Console.WriteLine($" Do While Loop Number {doLoop} is div by 2 and 3.");
                doLoop--;
            } while (doLoop > 0);
        }

        public void InRangeDivTwoNotDivThreeAndEight() {
            for (var i = 100; i >= -100; i--) {
                if (i % 2 != 0 || i % 3 == 0 || i % 8 == 0) continue;
                Console.WriteLine($"Number {i} divisible by 2 and not div 3 and 8.");
            }
        }

        public void MultiplicationTable() {
            for (var i = 1; i <= 5; i++) {
                Console.WriteLine($"Multiplication table for {i}");
                Console.WriteLine("-------------------------");
                for (var j = 1; j <= 10; j++) {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine();
            }
        }
    }
}