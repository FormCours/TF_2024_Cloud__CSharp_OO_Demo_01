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

Voiture v2 = new Voiture();
v2.Marque = "Lada";
v2.Modele = "2101";
v2.Pilote = p1;
v2.Numero = 1;
Console.WriteLine(v2.Marque + " " + v2.Modele);


Parking_Old parking1 = new Parking_Old();
parking1.SetVoiture("42", v1);
parking1.SetVoiture("43", v2);

Voiture? v1_1 = parking1.GetVoiture("42");
Voiture? v0_1 = parking1.GetVoiture("01");
Console.WriteLine($"Voiture à la place 42 : {v1_1?.Desc}");
Console.WriteLine($"Voiture à la place 01 : {v0_1?.Desc}");


Parking parking2 = new Parking();
parking2["42"] = v1;
parking2["43"] = v2;

Voiture? v2_1 = parking2["43"];
Voiture? v0_2 = parking2["02"];
Console.WriteLine($"Voiture à la place 43 : {v2_1?.Desc}");
Console.WriteLine($"Voiture à la place 02 : {v0_2?.Desc}");