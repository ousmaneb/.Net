using System;

public class Animal { public virtual string Breathe() { return "Animal::Breathe"; } public virtual string Eat() { return "Animal::Eat"; } public virtual string Sleep() { return "Animal::Sleep"; } }
public class Fish : Animal { public string Breathe() { return "Fish::Breathe"; } public override string Eat() { return "Fish::Eat"; } public new string Sleep() { return "Fish::Sleep"; } }
[STAThread]
static void Main(string[] args) { Animal objFish = new Fish(); Console.WriteLine(objFish.Breathe()); Console.WriteLine(objFish.Eat()); Console.WriteLine(objFish.Sleep()); }