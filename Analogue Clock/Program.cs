// See https://aka.ms/new-console-template for more information
using Analogue_Clock;
using System.Text.RegularExpressions;

Console.WriteLine("Enter time in format HH:mm");
string timeString = Console.ReadLine();
int[] time = Utility.getTime(timeString);
if(time == null) { return; }

AnalogueClock clock = new AnalogueClock();
clock.setHours(time[0]);
clock.setMinutes(time[1]);

Console.WriteLine();
Console.WriteLine("Angle between hands: " +  clock.calculateAngle() + " degrees");

