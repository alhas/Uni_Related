namespace fifth.netHomework {
	using System;
	using System.Linq;


	internal abstract class Executor {
		private static void Main(string[] args) {
			var sample = new SamplePrograms();
			var homeWork = new Exercises();
			// sample.increase_val(5);
			// var b = 5;
			// sample.increase_ref(ref b);
			// sample.Factorial(5);

			homeWork.IterativeSum(5);
			homeWork.RecursiveSum(5);
			homeWork.IterativeFactorial(5);
			homeWork.RecursiveFactorial(5);
			homeWork.FibonacciRecursive(5);
			homeWork.FibonacciIterative(5);
			homeWork.ArithmeticSequence(2, 3, 5);
			homeWork.GeometricSequenceRecursive(2.0, 3.0, 5);
			int[] numbers = { 1, 2, 3, 4, 5 };
			homeWork.FindMinMax(numbers);
			homeWork.Hanoi(3, 'A', 'B', 'C');

		}
	}

	public class SamplePrograms {
		public void increase_val(int a) {
			++a; // passing a variable by value, the function has no effect,
			// because only the local copy of variable a is changed
		}

		public void increase_ref(ref int b) {
			++b; // passing a variable to a method by reference
			// in this function the modified variable b is returned outside the method
		}

		public int Factorial(int x) {
			if (x == 0)
				return 1;
			return x * Factorial(x - 1);

		}
	}

	public class Exercises {
		public int IterativeSum(int n) {
			var sum = 0;
			for (var i = 1; i <= n; i++) {
				sum += i;
			}

			return sum;
		}

		public int RecursiveSum(int n) {
			if (n == 0) {
				return 0;
			}
			else {
				return n + RecursiveSum(n - 1);
			}
		}

		public int IterativeFactorial(int n) {
			var result = 1;
			while (n > 0) {
				result *= n;
				n--;
			}

			return result;
		}

		public int RecursiveFactorial(int n) {
			if (n == 0)
				return 1;
			return n * RecursiveFactorial(n - 1);
		}

		public int FibonacciRecursive(int n) {
			if (n == 0 | n == 1) {
				return n;
			}
			else {
				return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
			}
		}

		public int FibonacciIterative(int n) {
			if (n <= 1) {
				return n;
			}

			var fib = 1;
			var prevFib = 1;

			for (var i = 2; i < n; i++) {
				var temp = fib;
				fib += prevFib;
				prevFib = temp;
			}

			return fib;
		}

		public int ArithmeticSequence(int a, int d, int n) {
			return n == 1 ? a : ArithmeticSequence(a + d, d, n - 1);
		}

		public double GeometricSequenceRecursive(double a1, double r, int n) {
			if (n == 1) {
				return a1;
			}
			else {
				return r * GeometricSequenceRecursive(a1, r, n - 1);
			}
		}

		public (int, int) FindMinMax(int[] numbers) {
			if (numbers == null || numbers.Length == 0) {
				throw new ArgumentException("Array cannot be null or empty.");
			}

			var min = numbers.Min();
			var max = numbers.Max();
			return (min, max);
		}

		public void Hanoi(int n, char fromRod, char toRod, char auxRod) {
			if (n == 1) {
				Console.WriteLine($"Move disk 1 from rod {fromRod} to rod {toRod}");
				return;
			}

			Hanoi(n - 1, fromRod, auxRod, toRod);
			Console.WriteLine($"Move disk {n} from rod {fromRod} to rod {toRod}");
			Hanoi(n - 1, auxRod, toRod, fromRod);
		}
	}
}