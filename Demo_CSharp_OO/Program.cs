using Demo_CSharp_OO.Models;


Pilote p1 = new Pilote();
p1.SetFirstname("Zaza");
p1.SetLastname("Vanderquack");
p1.SetPseudo("Zaz");

Console.WriteLine(p1.GetFirstname() + " " + p1.GetLastname());

Voiture v1 = new Voiture();
v1.Marque = "Porsche";
v1.Modele = "911";
v1.Pilote = p1;
v1.Numero = 42;

Console.WriteLine(v1.Marque + " " + v1.Modele);