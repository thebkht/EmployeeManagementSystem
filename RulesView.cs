using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class RulesView
    {
        public void Show()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 33)));

            string welcome = "Welcome to the Employee Management System!";
            Console.WriteLine(welcome);
            string description = "This program allows you to manage your employees' tasks and attendance.\n";
            Console.WriteLine(description);

            string theGoal = ">>> The Goal: To improve the efficiency and productivity of your company by effectively managing employee tasks and attendance records.\n";
            DisplayWrappedText(WordWrap(theGoal, 114));

            Console.WriteLine("Rules:\n");

            string rule1 = ">>> Only authorized personnel are allowed to access this program.\n";
            DisplayWrappedText(WordWrap(rule1, 114));

            string rule2 = ">>> You must enter your username and password to log in.\n";
            DisplayWrappedText(WordWrap(rule2, 114));

            string rule3 = ">>> Only employees with assigned tasks can change the status of their tasks.\n";
            DisplayWrappedText(WordWrap(rule3, 114));

            string rule4 = ">>> All attendance records must be accurate and up-to-date.\n";
            DisplayWrappedText(WordWrap(rule4, 114));

            Console.Write("[Press ENTER to continue...]");
            if (Regex.IsMatch(Console.ReadLine(), @"\.*"))
            {
                Console.WriteLine(Environment.NewLine);
                System.Threading.Thread.Sleep(800);
            }
        }
        IEnumerable<string> WordWrap(string text, int width)
        {
            const string forcedBreakZonePattern = @"\n";
            const string normalBreakZonePattern = @"\s+|(?<=[-,.;])|$";

            var forcedZones = Regex.Matches(text, forcedBreakZonePattern).Cast<Match>().ToList();
            var normalZones = Regex.Matches(text, normalBreakZonePattern).Cast<Match>().ToList();

            int start = 0;

            while (start < text.Length)
            {
                var zone =
                    forcedZones.Find(z => z.Index >= start && z.Index <= start + width) ??
                    normalZones.FindLast(z => z.Index >= start && z.Index <= start + width);

                if (zone == null)
                {
                    yield return text.Substring(start, width);
                    start += width;
                }
                else
                {
                    yield return text.Substring(start, zone.Index - start);
                    start = zone.Index + zone.Length;
                }
            }
        }

        void DisplayWrappedText(IEnumerable<string> text)
        {
            foreach (var s in text)
                Console.WriteLine(s);

            Console.WriteLine();
        }
    }
}