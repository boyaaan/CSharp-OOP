using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class Engine
    {
        private AnimalCentre animalCentre;

        public Engine()
        {
            this.animalCentre = new AnimalCentre();
        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split();

                string command = inputArgs[0];
                string[] args = inputArgs.Skip(1).ToArray();

                string result = string.Empty;

                try
                {
                    switch (command)
                    {
                        case "RegisterAnimal":

                            string type = args[0];
                            string name = args[1];
                            int energy = int.Parse(args[2]);
                            int happiness = int.Parse(args[3]);
                            int procedureTime = int.Parse(args[4]);

                            result = animalCentre.RegisterAnimal(type, name, energy, happiness, procedureTime);
                            break;
                        case "Chip":

                            string typeChip = args[0];
                            int nameChip = int.Parse(args[1]);

                            result = animalCentre.Chip(typeChip, nameChip);
                            break;
                        case "Vaccinate":
                            string typeVaccinate = args[0];
                            int nameVaccinate = int.Parse(args[1]);

                            result = animalCentre.Vaccinate(typeVaccinate, nameVaccinate);
                            break;
                        case "Fitness":
                            string typeFitness = args[0];
                            int nameFitness = int.Parse(args[1]);

                            result = animalCentre.Fitness(typeFitness, nameFitness);
                            break;
                        case "Play":
                            string typePlay = args[0];
                            int namePlay = int.Parse(args[1]);

                            result = animalCentre.Play(typePlay, namePlay);
                            break;
                        case "DentalCare":
                            string typeDentalCare = args[0];
                            int nameDentalCare = int.Parse(args[1]);

                            result = animalCentre.DentalCare(typeDentalCare, nameDentalCare);
                            break;
                        case "NailTrim":
                            string typeNailTrim = args[0];
                            int nameNailTrim = int.Parse(args[1]);

                            result = animalCentre.NailTrim(typeNailTrim, nameNailTrim);
                            break;
                        case "Adopt":
                            string typeAdopt = args[0];
                            string nameAdopt = args[1];

                            result = animalCentre.Adopt(typeAdopt, nameAdopt);
                            break;
                        case "History":

                            string typeHistory = args[0];

                            result = animalCentre.History(typeHistory);
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("InvalidOperationException: " + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("ArgumentException: " + ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
