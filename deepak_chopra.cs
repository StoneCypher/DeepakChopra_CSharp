
using System;

public static class Program {

  static string[] starts     = {"Experiential truth ", "The physical world ", "Non-judgment ", "Quantum physics "};
  static string[] middles    = {"nurtures an ", "projects onto ", "imparts reality to ", "constructs with "};
  static string[] qualifiers = {"abundance of ", "the barrier of ", "self-righteous ", "potential "};
  static string[] finishes   = {"marvel.", "choices.", "creativity.", "actions."};

  public static void Main () {

    Random rnd = new Random();
    Console.WriteLine(starts[rnd.Next(4)] + middles[rnd.Next(4)] + qualifiers[rnd.Next(4)] + finishes[rnd.Next(4)]);

  }

}