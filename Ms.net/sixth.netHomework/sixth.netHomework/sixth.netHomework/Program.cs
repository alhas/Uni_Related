namespace sixth.netHomework {
	using System;

	internal abstract class Executor {
		private static void Main(string[] args) {

			Cat bengal = new Cat();
			Cat persian = new Cat("Oliver", 5, "white");
			Cat clone = new Cat(persian);
			bengal.Name = "Kitty";
			clone.setAge(4);
			clone.setName("Oliver II");
			persian.Mew();
			Console.WriteLine("The name of the bengal cat is {0}, it is {1} years old an {2} in color",
				bengal.getName(), bengal.getAge(), bengal.getColor());
			Console.WriteLine("The name of the persian cat is {0}, it is {1} years old and {2} in color",
				persian.getName(), persian.getAge(), persian.getColor());
			Console.WriteLine("The name of the clone of the persian cat is {0}, it is {1} years old and {2} in color",
				clone.getName(), clone.getAge(), clone.getColor());
			Console.ReadKey();


			Dog spaniel = new Dog("Spaniel", 3, 10.5);
			Dog bulldog = new Dog("Bulldog", 5, 15.2);
			Dog dachshund = new Dog("Dachshund", 2, 8.7);

			spaniel.Bark();
			bulldog.Bark();
			dachshund.Bark();

			Console.WriteLine($"Spaniel: Name={spaniel.Name}, Age={spaniel.Age}, Weight={spaniel.Weight}");
			Console.WriteLine($"Bulldog: Name={bulldog.Name}, Age={bulldog.Age}, Weight={bulldog.Weight}");
			Console.WriteLine($"Dachshund: Name={dachshund.Name}, Age={dachshund.Age}, Weight={dachshund.Weight}");


			Moneybox moneybox = new Moneybox();

			moneybox.InsertMoney(10.50m);
			moneybox.InsertMoney(5.25m);
			moneybox.InsertMoney(3.75m);

			decimal accumulatedFunds = moneybox.BreakMoneyBox();

			Console.WriteLine($"Accumulated funds: {accumulatedFunds}");


			Rectangle rectangle = new Rectangle();
			rectangle.ReadData();

			Console.WriteLine($"Perimeter: {rectangle.CalcPerimeter()}");
			Console.WriteLine($"Area: {rectangle.CalcArea()}");

			rectangle.Draw();


			Books[] bookArray = new Books[2];

			// Insert data into the array
			for (int i = 0; i < bookArray.Length; i++) {
				Books book = new Books();

				Console.WriteLine($"Enter the author of book {i + 1}:");
				var author = Console.ReadLine();
				book.SetAuthor(author);

				Console.WriteLine($"Enter the title of book {i + 1}:");
				var title = Console.ReadLine();
				book.SetTitle(title);

				Console.WriteLine($"Enter the year of publication for book {i + 1}:");
				int year = Convert.ToInt32(Console.ReadLine());
				book.SetYear(year);

				bookArray[i] = book;
			}

			// Print all the information for all items in the array
			Console.WriteLine("Book Information:");
			for (int i = 0; i < bookArray.Length; i++) {
				Console.WriteLine($"Book {i + 1}:");
				Console.WriteLine($"Author: {bookArray[i].GetAuthor()}");
				Console.WriteLine($"Title: {bookArray[i].GetTitle()}");
				Console.WriteLine($"Year of Publication: {bookArray[i].GetYear()}");
				Console.WriteLine();
			}
			
			
			Counter counter = new Counter();

			counter.IncNr(); // Person enters the building
			counter.IncNr(); // Person enters the building
			counter.IncNr(); // Another person enters the building
			counter.DecNr(); // One person exits the building

			int currentCount = counter.CheckNr(); // Check the current number of people

			Console.WriteLine("Current number of people in the building: " + currentCount);
			
			
		}
	}
}

class Cat {
	public string Name;
	private int age;

	protected string color;

	public void Mew() {
		Console.WriteLine("Meeooowwwww");
	}

	void Sleep() {
		Console.WriteLine("Zzzzzzzzzzzzz");
	}

	public string getName() {
		return Name;
	}

	public int getAge() {
		return age;
	}

	public string getColor() {
		return color;
	}

	public void setName(string n) {
		Name = n;
	}

	public void setAge(int a) {
		age = a;
	}

	public void setColor(string c) {
		color = c;
	}

	public Cat() {
		Console.WriteLine("A constructor with no parameters has been started!");
		Name = "Kitty";
		age = 7;
		color = "grey";
	}

	public Cat(string n, int a, string c) {
		Name = n;
		age = a;
		color = c;
	}

	public Cat(Cat c) {
		Name = c.Name;
		age = c.age;
		color = c.color;
	}
}

public class Dog {
	private string name;
	private int age;
	private double weight;

	public string Name {
		get { return name; }
		set { name = value; }
	}

	public int Age {
		get { return age; }
		set { age = value; }
	}

	public double Weight {
		get { return weight; }
		set { weight = value; }
	}

	public Dog() {
		// Default constructor
	}

	public Dog(string name, int age, double weight) {
		this.name = name;
		this.age = age;
		this.weight = weight;
	}

	public Dog(Dog otherDog) {
		name = otherDog.name;
		age = otherDog.age;
		weight = otherDog.weight;
	}

	public void Bark() {
		Console.WriteLine($"{name} is barking!");
	}
}

public class Moneybox {
	private decimal amount;

	public Moneybox() {
		amount = 0;
	}

	public void InsertMoney(decimal money) {
		amount += money;
	}

	public decimal BreakMoneyBox() {
		decimal accumulatedFunds = amount;
		amount = 0;
		return accumulatedFunds;
	}
}

public class Rectangle {
	private double sideA;
	private double sideB;

	public void ReadData() {
		Console.WriteLine("Enter the length of side A:");
		sideA = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter the length of side B:");
		sideB = Convert.ToDouble(Console.ReadLine());
	}

	public double CalcPerimeter() {
		return 2 * (sideA + sideB);
	}

	public double CalcArea() {
		return sideA * sideB;
	}

	public void Draw() {
		string horizontalLine = "─".PadRight(Convert.ToInt32(sideA), '─');
		string verticalLine = "│";

		Console.WriteLine("┌" + horizontalLine + "┐");

		for (int i = 0; i < Convert.ToInt32(sideB); i++) {
			Console.WriteLine(verticalLine.PadRight(Convert.ToInt32(sideA) + 2, ' ') + verticalLine);
		}

		Console.WriteLine("└" + horizontalLine + "┘");
	}
}

public class Books {
	private string author;
	private string title;
	private int year;

	public void SetAuthor(string author) {
		this.author = author;
	}

	public string GetAuthor() {
		return author;
	}

	public void SetTitle(string title) {
		this.title = title;
	}

	public string GetTitle() {
		return title;
	}

	public void SetYear(int year) {
		this.year = year;
	}

	public int GetYear() {
		return year;
	}
}

public class Counter {
	private int count;

	public Counter() {
		count = 0;
	}

	public void IncNr() {
		count++;
	}

	public void DecNr() {
		if (count > 0) {
			count--;
		}
	}

	public int CheckNr() {
		return count;
	}
}