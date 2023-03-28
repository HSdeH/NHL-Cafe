using System;

namespace WebdevProjectStarterTemplate.Models;

public class CafeUser
{
    public int UniqueGuid { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public string Location { get; set; }
    public DateTime Date { get; set; }
}