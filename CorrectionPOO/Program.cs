using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPOO
{
    class Program
    {
        static List<Realty> realties;
        static void Main(string[] args)
        {
            // On declare une liste de type Realty (pour pouvoir stocker tout les objets dans celle-ci 
            realties = new List<Realty>();
            // Appelle la methode pour afficher le menu
            // On stock le return de la méthode dans la variable choice
            int choice = DisplayMenu();
            //T Tant que le choix est diffrent de 6, on applique la méthode
            // Si choice = 6, on quitte l'application
            while (choice != 6)
            {
                switch (choice)
                {
                    case 1:
                        ListRealty();
                        break;
                    case 2:
                        AddFlat();
                        break;
                    case 3:
                        AddHome();
                        break;
                    case 4:
                        AddParking();
                        break;
                    case 5:
                        DeleteRealty();
                        break;
                }
                choice = DisplayMenu();
            }
        }

        private static void ListRealty()
        {
            foreach (Realty realty in realties)
            {
                Console.WriteLine(realty);
            }
        }

        private static void AddFlat()
        {
            // Console.WriteLine permet d'afficher du texte dans la console.
            Console.WriteLine("Ajoute un appartement. \n");
            // Console.Write permet d'afficher du tewte dans la console sans passer à la ligne 
            Console.WriteLine("Renseigner le numéro d'enregistrement : ");
            // On vient tester la validité du nombre avec la méthode getValidNumber()
            int registerNumber = getValidNumber();
            Console.WriteLine("Renseigner le lieu : ");
            string location = Console.ReadLine();
            Console.WriteLine("Renseigner la superficie : ");
            // On vient tester la validité du nombre et une valeur null avec la méthode getValidNotNullNumber()
            int area = getValidNotNullNumber();
            Console.WriteLine("Renseigner l'étage : ");
            int floor = getValidNumber();
            Console.WriteLine("Renseigner le nombre de pièces : ");
            int room = getValidNotNullNumber();
            Console.WriteLine("Renseigner le loyer : ");
            double rent = getValidDouble();
            // On déclare un objet de classe Flat et on vient renseigner les paramètres à l'interieur des parenthèses
            Flat flat = new Flat(registerNumber, location, area, rent, room, floor);
            realties.Add(flat);
            Console.WriteLine("L'appartement numéro {0} à été ajouté.", registerNumber);
        }

        private static double getValidDouble()
        {
            // Tant que la vleur entrée n'est pas un nombre, on demande d'en entrer un
            while (true)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    // Si on entre un nombre non null, on retourne celui ci
                    if (number > 0)
                        return number;
                }

            }
        }
        private static int getValidNotNullNumber()
        {
            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                    {
                        return number;
                    }
                }

            }
        }
        private static int getValidNumber()
        {
            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }

            }
        }

        private static void AddHome()
        {
            // Console.WriteLine permet d'afficher du texte dans la console.
            Console.Write("Ajoute une maison. \n");
            // Console.Write permet d'afficher du tewte dans la console sans passer à la ligne 
            Console.Write("Renseigner le numéro d'enregistrement : ");
            // On vient tester la validité du nombre avec la méthode getValidNumber()
            int registerNumber = getValidNumber();
            Console.Write("Renseigner le lieu : ");
            string location = Console.ReadLine();
            Console.Write("Renseigner la superficie : ");
            // On vient tester la validité du nombre et une valeur null avec la méthode getValidNotNullNumber()
            int area = getValidNotNullNumber();
            Console.WriteLine("Renseigner le nombre de pièces : ");
            int room = getValidNotNullNumber();
            Console.WriteLine("Renseigner le loyer : ");
            double rent = getValidDouble();
            // On déclare un objet de classe Flat et on vient renseigner les paramètres à l'interieur des parenthèses
            Home home = new Home(registerNumber, location, area, rent, room);
            realties.Add(home);
            Console.WriteLine("La maison numéro {0} à été ajouté.", registerNumber);
        }

        private static void AddParking()
        {
            // Console.WriteLine permet d'afficher du texte dans la console.
            Console.Write("Ajoute un parking. \n");
            // Console.Write permet d'afficher du tewte dans la console sans passer à la ligne 
            Console.Write("Renseigner le numéro d'enregistrement : ");
            // On vient tester la validité du nombre avec la méthode getValidNumber()
            int registerNumber = getValidNumber();
            Console.Write("Renseigner le lieu : ");
            string location = Console.ReadLine();
            Console.Write("Renseigner la superficie : ");
            // On vient tester la validité du nombre et une valeur null avec la méthode getValidNotNullNumber()
            int area = getValidNotNullNumber();
            Console.WriteLine("Renseigner le loyer : ");
            double rent = getValidDouble();
            // On déclare un objet de classe Flat et on vient renseigner les paramètres à l'interieur des parenthèses
            Parking parking = new Parking(registerNumber, location, area, rent);
            realties.Add(parking);
            Console.WriteLine("Le parking numéro {0} à été ajouté.", registerNumber);
        }

        private static void DeleteRealty()
        {
            ListRealty();
            Console.WriteLine("\nQuel bien souhaitez-vous supprimé ?");
            int registerNumber = getValidNumber();
            int index = getRealtyIndex(registerNumber);
            if (index >= 0)
            {
                realties.RemoveAt(index);
                Console.WriteLine("Le bien a bien été supprimé.");
            }
            else
            {
                Console.WriteLine("Le bien que vous désirez supprimer n'éxiste pas.");
            }
        }

        private static int getRealtyIndex(int registerNumber)
        {
            int index = -1;
            foreach (Realty realty in realties)
            {
                if (registerNumber == realty.RegisterNumber)
                {
                    index = realties.IndexOf(realty);
                }
            }
            return index;
        }

        private static int DisplayMenu()
        {
            // Tant que la metgode n'a rien retourné
            while (true)
            {
                Console.WriteLine("Menu de l'application : \n");
                Console.WriteLine("Le nombre de bien est de {0}", realties.Count());
                Console.WriteLine("\n 1. Afficher la liste des biens.");
                Console.WriteLine("2. Ajouter un appartement.");
                Console.WriteLine("3. Ajouter une maison.");
                Console.WriteLine("4. Ajouter un parking.");
                Console.WriteLine("5. Supprimer un bien.");
                Console.WriteLine("6. Quitter l'application.");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice >= 1 && choice <= 6)
                    {
                        return choice;
                    }
                }
                Console.Clear();
            }
        }
    }
}
