using POOconcepts;
try
{
    var date1 = new Date();
    var date2 = new Date(2005, 01, 26);
    var date3 = new Date(2020, 12, 03);

    date1.Year = 2025;
    date1.Month = 2;
    date1.Day = 13;

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}