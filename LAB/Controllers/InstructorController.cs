using Microsoft.AspNetCore.Mvc;
using LAB.Models;

namespace LAB.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
            {

                new Instructor()
                {
                    Id =  1,
                    FirstName ="Draico",
                    LastName = "Gallardo",
                    IsTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("12/08/2022"),
                },

                 new Instructor()
                {
                    Id =  2,
                    FirstName ="Marsoll",
                    LastName = "Timbre",
                    IsTenured = false,
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("10/09/2022"),
                },

                  new Instructor()
                {
                    Id =  3,
                    FirstName ="Marshall",
                    LastName = "Gallardo",
                    IsTenured = true,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("05/08/2023"),
                },

                   new Instructor()
                {
                    Id =  4,
                    FirstName ="Jimmy",
                    LastName = "Timbre",
                    IsTenured = true,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("01/08/2023"),
                }

            };
        public IActionResult Index()

        {

            return View(InstructorList);
        }
        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault( Instructor=> Instructor.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            else
            {
                return NotFound();
            }

           
        }
    }
}
