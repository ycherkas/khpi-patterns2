// See https://aka.ms/new-console-template for more information
using Lab10.Concrete;
using Lab10.Interfaces;

var firstNameInput = new Input("firstNameInput");
var lastNameInput = new Input("firstNameInput");

var userBaseInfoFieldset = new Fieldset("userInfoFieldset", new List<IHTMLElement> { firstNameInput, lastNameInput });

var genderSelect = new Select("genderSelect", new[] { "male", "female" });
var ageSelect = new Select("ageSelect", new[] { "below 18", "18 - 25", "26 - 35", "35 - 45", "45 - 60", "60+" });
var userGeneralInfoFieldset = new Fieldset("userGeneralInfoFieldset", new List<IHTMLElement> { genderSelect, ageSelect });

var userForm = new Form("userForm", new List<IHTMLElement>() { userBaseInfoFieldset, userGeneralInfoFieldset });

var userFormHtml = userForm.Render();

Console.WriteLine("Rendered HTML for User Form based on Composite Pattern:");
Console.WriteLine(userFormHtml);
