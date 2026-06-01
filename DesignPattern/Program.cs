// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.Builder;

using DesignPattern.BehaviouralDesignPatterns.ObserverPattern;
using DesignPattern.CreationalDesignPattern.AbstractFactory.Problem;
using DesignPattern.CreationalDesignPattern.AbstractFactory.Solution;
using DesignPattern.CreationalDesignPattern.BuilderDesign.Problem.Problem_1;
using DesignPattern.CreationalDesignPattern.BuilderDesign.Problem.Problem_2;
using DesignPattern.CreationalDesignPattern.BuilderDesign.Solution.Solution_2;
using DesignPattern.CreationalDesignPattern.BuilderDesign.Solution.Soultion_1;
using DesignPattern.CreationalDesignPattern.FactoryMethod;
using DesignPattern.CreationalDesignPattern.SimpleFactory.Problem;
using DesignPattern.CreationalDesignPattern.SimpleFactory.Solution;
using DesignPattern.CreationalDesignPattern.singleton.Problem;
using DesignPattern.CreationalDesignPattern.singleton.Solution;
using static DesignPattern.StructuralDesignPattern.Adaper.XmlDataProviderAdapter;


Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"***************** singleton Design pattern *******************");
Console.ResetColor();
/*   singleton  */
UserWithoutsingleton.Main();
singletonClient.clientMethod();

Console.WriteLine("\n");

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"***************** Simple Factory Design pattern **************");
Console.ResetColor();
/*  Factory */
DataBaseConnectionSerivceProblem.GetDataBaseConnectionClientProblem();
DataBaseConnectionSerivceSolution.GetDataBaseConnectionClientSolution();

Console.WriteLine("\n");

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"*****************  Factory Method Design pattern **************");
Console.ResetColor();

DataBaseConnectionSerivceFactoryMethodSolution.GetDataBaseConnectionClientSolution();

Console.WriteLine("\n");

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"***************** Abstract Factory Design pattern *************");
Console.ResetColor();

ApplicationService.GetUISwitchConfiguration();
Console.WriteLine("\n");
ApplicationServiceSolution.GetUISwitchConfiguration();

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"************************ Builder Design pattern ****************");
Console.ResetColor();


WithoutBuilderPatternProblem.BuilderServiceClient();
WithBuilderPatternSolution.WithBuilderPattern();

Console.WriteLine("\n");
WithoutBuilderProblem2.Main();
Console.WriteLine("\n");
MainClientSoultion2.main();
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"************************ Adapter Design pattern ****************");
Console.ResetColor();
AdapterPattern.main();

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"************************ Observer  Design pattern ****************");
Console.ResetColor();
ObserverDesignPattern.main();

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"************************Strategy  Design pattern ****************");
Console.ResetColor();

//var builder = WebApplication.CreateBuilder(args);



ObserverDesignPattern.main();


Console.WriteLine();
Console.ReadLine();