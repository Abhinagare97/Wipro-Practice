using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Models;

namespace WebApplication2.Pages
{
    public class PeopleModel : PageModel
    {
        public List<People> people = new List<People>();
        public void OnGet()
        {
            People p = new People(1, "Abhi", "Project Engineer");
            People p2 = new People(1, "Abhi", "Project Engineer");
            People p3= new People(1, "Abhi", "Project Engineer");
            People p4= new People(1, "Abhi", "Project Engineer");
            People p5= new People(1, "Abhi", "Project Engineer");
            people.Add(p);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);
            people.Add(p5);

            
        }
    }
}
