using Console = System.Console;
using System;

namespace fourth.netHomework {
	internal abstract class Program {
		private static void Main(string[] args) {
			var sample = new Exercise();
			// sample.Sample();
			var exercise = new Exercise();
			//exercise.ExerciseTwo();
			//exercise.ExerciseTree();
			//exercise.ExerciseFour();
			//exercise.ExerciseFive();
			//exercise.ExerciseSix();
			//exercise.ExerciseSeven();
			//exercise.ExerciseEight();
			//exercise.ExerciseNine();
			exercise.ExerciseTen();
		}
	}

	public class Exercise {
		public void Sample() {

			char[] tabc = { 'H', 'e', '1', '1', 'o' };
			foreach (var t in tabc)
				Console.Write(t + " ");

			int[,] tablica = { { 1, 2, 3, 4, 5 }, { 2, 4, 6, 8, 9 } };
			tablica[1, 4] = 35;
			for (var i = 0; i < 2; ++i) {
				Console.WriteLine();
				for (var j = 0; j < 5; ++j) Console.Write(tablica[i, j] + " ");
			}

			var tabdni = new string[7, 3];
			tabdni[0, 0] = "Poniedziałek";
			tabdni[1, 0] = "Wtorek";
			tabdni[2, 0] = "Środa";
			tabdni[3, 0] = "Czwartek";
			tabdni[4, 0] = "Piątek";
			tabdni[5, 0] = "Sobota";
			tabdni[6, 0] = "Niedziela";
			tabdni[0, 1] = "Monday";
			tabdni[1, 1] = "Tuesday";
			tabdni[2, 1] = "Wednesday";
			tabdni[3, 1] = "Thursday";
			tabdni[4, 1] = "Friday";
			tabdni[5, 1] = "Saturday";
			tabdni[6, 1] = "Sunday";
			tabdni[0, 2] = "Montag";
			tabdni[1, 2] = "Dienstag";
			tabdni[2, 2] = "Mittwoch";
			tabdni[3, 2] = "Donnerstag";
			tabdni[4, 2] = "Freitag";
			tabdni[5, 2] = "Samstag";
			tabdni[6, 2] = "Sonntag";
			for (var i = 0; i <= 6; ++i) {
				Console.WriteLine(tabdni[i, 0] + " is in english " + tabdni[i, 1] + " and in german " + tabdni[i, 2]);
			}

		}

		public int[] ExerciseTwo() {
			var numbers = new int[20];
			var number = 20;
			for (var i = 0; i < numbers.Length; i++) {
				numbers[i] = number;
				number--;
			}

			return numbers;
		}

		public void ExerciseTree() {
			var numbers = ExerciseTwo();

			var i = 0;
			while (i < numbers.Length) {
				Console.WriteLine(numbers[i]);
				i++;
			}
		}

		public void ExerciseFour() {

			var array = new int[50];
			var i = 0;
			Console.WriteLine("You will enter 50 number");
			while (i < array.Length) {
				Console.WriteLine($"Please Enter {i}. Number: ");
				var number = Convert.ToInt32(Console.ReadLine());
				array[i] = number;
				i++;
			}

			var mean = (double)array.Sum() / array.Length;
			Console.WriteLine(mean);


		}

		public void ExerciseFive() {

			Console.WriteLine("Enter Four real number: ");
			var numbers = new double[4];

			for (var i = 0; i < numbers.Length; i++) {
				Console.WriteLine($"Enter {i + 1}. real number: ");
				var number = Convert.ToDouble(Console.ReadLine());
				numbers[i] = number;
			}

			Console.WriteLine($"The max real number = {numbers.Max()}");


		}

		public void ExerciseSix() {

			var marks = new int[5];
			Console.WriteLine("Please enter 5 marks between 0 and 20");
			for (var i = 0; i < marks.Length; i++) {
				Console.WriteLine($"Please enter {i + 1} mark.");
				var mark = Convert.ToInt32(Console.ReadLine());
				if (mark >= 0 & mark <= 20) {
					marks[i] = mark;
				}
				else {
					Console.WriteLine("Please Enter numbers between 0 and 20");
					i += -1;
				}
			}

			var sumOfThree = marks.Where(mark => mark != marks.Max() & mark != marks.Min()).Sum();

			Console.WriteLine($"The Style marks = {sumOfThree}");

		}

		public void ExerciseSeven() {

			object[,] tabc = { { 'H', 'e', '1', '1', 'o' }, { 1, 2, 4, 5, 6 } };
			foreach (var t in tabc)
				Console.Write(t + " ");

			object[,] tablica =
				{ { 1, 2, 3, 4, 5 }, { 2, 4, 6, 8, 9 }, { "this", "is", "two", "dimensional", "array" } };
			tablica[1, 4] = 35;
			for (var i = 0; i < 3; ++i) {
				Console.WriteLine();
				for (var j = 0; j < 5; ++j) Console.Write(tablica[i, j] + " ");
			}

			var tabdni = new object[7, 4];
			tabdni[0, 0] = 1;
			tabdni[1, 0] = 2;
			tabdni[2, 0] = 3;
			tabdni[3, 0] = 4;
			tabdni[4, 0] = 5;
			tabdni[5, 0] = 6;
			tabdni[6, 0] = 7;
			tabdni[0, 1] = "Poniedziałek";
			tabdni[1, 1] = "Wtorek";
			tabdni[2, 1] = "Środa";
			tabdni[3, 1] = "Czwartek";
			tabdni[4, 1] = "Piątek";
			tabdni[5, 1] = "Sobota";
			tabdni[6, 1] = "Niedziela";
			tabdni[0, 2] = "Monday";
			tabdni[1, 2] = "Tuesday";
			tabdni[2, 2] = "Wednesday";
			tabdni[3, 2] = "Thursday";
			tabdni[4, 2] = "Friday";
			tabdni[5, 2] = "Saturday";
			tabdni[6, 2] = "Sunday";
			tabdni[0, 3] = "Montag";
			tabdni[1, 3] = "Dienstag";
			tabdni[2, 3] = "Mittwoch";
			tabdni[3, 3] = "Donnerstag";
			tabdni[4, 3] = "Freitag";
			tabdni[5, 3] = "Samstag";
			tabdni[6, 3] = "Sonntag";
			for (var i = 0; i <= 6; ++i) {
				Console.WriteLine(
					$"\n{tabdni[i, 0]} day {tabdni[i, 1]} is in english {tabdni[i, 2]} and in german {tabdni[i, 3]}");
			}


		}

		public void ExerciseEight() {

			const int n = 5;
			var numbers = new int[n, n];

			for (var i = 0; i < n; i++) {

				for (var j = 0; j < i + 1; j++) {
					numbers[i, j] = j + 1;
				}

				for (var j = i + 1; j < n; j++) {
					numbers[i, j] = i + 1;
				}
			}

			for (var i = 0; i < n; i++) {
				for (var j = 0; j < n; j++) {
					Console.Write(numbers[i, j]);
				}

				Console.WriteLine();
			}

		}

		public void ExerciseNine() {
			Console.WriteLine("Enter Row and Column Respectively");

			var rows = Convert.ToInt32(Console.ReadLine());
			var columns = Convert.ToInt32((Console.ReadLine()));

			var numbers = new int[rows, columns];


			for (var row = 0; row < rows; row++) {
				for (var column = 0; column < columns; column++) {
					numbers[row, column] = (row + 1) * (column + 1);
				}
			}

			for (var i = 0; i < rows; i++) {
				for (var j = 0; j < columns; j++) {
					Console.Write(numbers[i, j] + " ");
				}

				Console.WriteLine();
			}


		}

		public void ExerciseTen() {

			string[][] dictionary = new string[10][];
			dictionary[0] = new string[] { "apple", "jabłko", "Apfel" };
			dictionary[1] = new string[] { "book", "książka", "Buch" };
			dictionary[2] = new string[] { "cat", "kot", "Katze" };
			dictionary[3] = new string[] { "dog", "pies", "Hund" };
			dictionary[4] = new string[] { "car", "samochód", "Auto" };
			dictionary[5] = new string[] { "house", "dom", "Haus" };
			dictionary[6] = new string[] { "computer", "komputer", "Computer" };
			dictionary[7] = new string[] { "sun", "słońce", "Sonne" };
			dictionary[8] = new string[] { "tree", "drzewo", "Baum" };
			dictionary[9] = new string[] { "water", "woda", "Wasser" };

			Console.WriteLine("English-Polish-German Dictionary");
			Console.WriteLine("--------------------------------");

			foreach (var t in dictionary) {
				Console.WriteLine($"{t[0]} - {t[1]} - {t[2]}");
			}
			

		}
	}
}