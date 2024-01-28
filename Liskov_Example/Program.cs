// See https://aka.ms/new-console-template for more information
using Liskov_Example;

List<string> newPatitent = new List<string>();
newPatitent.Add("1234");
newPatitent.Add("2222");
newPatitent.Add("01222");
FileDatabase file = new FileDatabase();
Patient patient=null; 
foreach (var pat in newPatitent)
{
    if (pat.StartsWith("0"))
    {
        patient = new Normal();
    }
    else if (pat.StartsWith("1"))
    {
        patient = new Male();
    }
    else if(pat.StartsWith("2"))
    {
        patient = new Female();
    }
    string result = patient.CreateFile(file, pat);
    Console.WriteLine(result);
}
