// See https://aka.ms/new-console-template for more information
using Lab1;
using Lab1.Concrete;


var touristPlaces = new List<TouristPlace>()
{
    new TouristPlace() { Name = "Rynok Square" },
    new TouristPlace() { Name = "National Opera" },
    new TouristPlace() { Name = "City Hall" },
    new TouristPlace() { Name = "Lychakiv Cemetery" },
    new TouristPlace() { Name = "The House of Scientist" }
};

var collection = new TouristPlaceCollection(touristPlaces);
var touristIterator = collection.CreateTouristIterator();
var navigatorIterator = collection.CreateNavigatorIterator();
var guideIterator = collection.CreateGuideIterator();

var visitor = new TouristVisitor();
visitor.Visit(touristIterator, "Tourist Iterator");
visitor.Visit(navigatorIterator, "Navigator Iterator");
visitor.Visit(guideIterator, "Guide Iterator");
