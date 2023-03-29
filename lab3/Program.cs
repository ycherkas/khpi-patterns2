// See https://aka.ms/new-console-template for more information
using Lab3;

Console.WriteLine("Hello, World!");


var cabinet = new Cabinet();
var caretaker = new Caretaker(cabinet);
caretaker.CreateBackup();

cabinet.PersonalNotificationsAllowed = true;
caretaker.CreateBackup();

cabinet.PromodionNotificationsAllowed = true;
caretaker.CreateBackup();

cabinet.AdNotificationsAllowed = true;
caretaker.CreateBackup();

caretaker.Undo();
cabinet.ShowSate();

caretaker.Undo();
cabinet.ShowSate();

caretaker.Undo();
cabinet.ShowSate();

caretaker.Undo();
cabinet.ShowSate();

Console.WriteLine();