const int NbMystere = 7;
System.Console.WriteLine("Saissir un nombre entre 1 & 10");
int nombre = int.Parse(Console.ReadLine());
 if (nombre == NbMystere)
 
{ 
    System.Console.WriteLine("Félicitationt Vous avez gagné at trouver nomber mystere");
    
 }
 else 
 {
    if (nombre > NbMystere)
    {
        System.Console.WriteLine("Le nombre de mystère est plus petit");
    }
    else
    {
        System.Console.WriteLine("le nombre mystère et plus grand");

    }
 }
 


