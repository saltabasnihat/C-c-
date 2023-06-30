using System;
using System.Collections.Generic;

namespace Midterm
{
    internal class TravelAgency
    {
        private const double TicketFee = 500.0;

        static void Main(string[] args)
        {
            List<Itinerary> itineraries = new List<Itinerary>();

            Console.WriteLine("Welcome to Algonquin College Student Travel Agency!");

            Console.Write("\nEnter V to view all itineraries, A to add a new itinerary. \n" +
                            "      C to change an existing itinerary, and E to exit: ");
            string action = Console.ReadLine();
            Console.WriteLine();

            while (action.ToUpper() != "E")
            {
                if (action.ToUpper() == "V")
                {
                    if (itineraries.Count == 0)
                    {
                        Console.WriteLine("No itineraries exist yet.");
                    }
                    else
                    {
                        Console.WriteLine("List of Itineraries:");
                        DisplayItineraries(itineraries);
                    }
                }

                else if (action.ToUpper() == "A")
                {
                    Console.Write("Enter the passenger name: ");
                    string passengerName = Console.ReadLine();

                    Console.Write("Enter the departure city: ");
                    string departureCity = Console.ReadLine();

                    Console.Write("Enter the arriving city: ");
                    string arrivingCity = Console.ReadLine();

                    try
                    {
                        Itinerary newItinerary = new Itinerary(passengerName, departureCity, arrivingCity);
                        itineraries.Add(newItinerary);
                        Console.WriteLine("Itinerary added successfully!");
                        Console.WriteLine("Passenger " + passengerName + " has been charged $" + TicketFee + " for the ticket.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
                else if (action.ToUpper() == "C")
                {
                    if (itineraries.Count == 0)
                    {
                        Console.WriteLine("There are no itineraries available to change.");
                    }
                    else
                    {
                        Console.Write("Enter the index of the itinerary to change (0-{0}): ", itineraries.Count - 1);
                        int index = int.Parse(Console.ReadLine());

                        if (index >= 0 && index < itineraries.Count)
                        {
                            Itinerary itinerary = itineraries[index];

                            Console.WriteLine("Current Itinerary:");
                            Console.WriteLine("Index: " + index);
                            DisplayItinerary(itinerary);

                            Console.Write("Enter the new departure city: ");
                            string newDepartureCity = Console.ReadLine();

                            Console.Write("Enter the new arriving city: ");
                            string newArrivingCity = Console.ReadLine();

                            try
                            {
                                double oldCost = itinerary.Cost;

                                itinerary.ChangeItinerary(newDepartureCity, newArrivingCity);
                                double changeFee = itinerary.Cost - oldCost;

                                Console.WriteLine("Itinerary changed successfully!");
                                Console.WriteLine("New Cost: " + itinerary.Cost);
                                Console.WriteLine("Change Fee: " + changeFee);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error: " + e.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index. No itinerary found at the specified index.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid action. Please enter a valid action.");
                }

                Console.WriteLine("\nEnter V to view all itineraries, A to add a new itinerary. \n" +
                                    "      C to change an existing itinerary, and E to exit: ");
                action = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using Algonquin College Student Travel Agency!");
            Console.WriteLine("Press return key to complete the application!");
            Console.ReadLine();
        }

        static void DisplayItinerary(Itinerary itinerary)
        {
            Console.WriteLine("Passenger Name: " + itinerary.PassengerName);
            Console.WriteLine("Departure City: " + itinerary.DepartureCity);
            Console.WriteLine("Arriving City: " + itinerary.ArrivingCity);
            Console.WriteLine("Cost: " + itinerary.Cost);
            Console.WriteLine();
        }

        static void DisplayItineraries(List<Itinerary> itineraries)
        {
            for (int i = 0; i < itineraries.Count; i++)
            {
                Console.WriteLine("Index: " + i);
                DisplayItinerary(itineraries[i]);
            }
        }
    }
}
