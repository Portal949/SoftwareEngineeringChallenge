using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftwareEngineeringChallenge.Entities;
using SoftwareEngineeringChallenge.Interfaces;
using System.Drawing;
using System.Xml.Linq;
using static SoftwareEngineeringChallenge.Entities.Marble;

namespace SoftwareEngineeringChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarbleController : ControllerBase
    {
        //Instance of a class that contains all of the specific methos to use in the program
        private readonly IUtilities utilities;
        private readonly IConfiguration configuration;

        public MarbleController(IUtilities utilities, IConfiguration configuration)
        {
            //Dependency Injection of a service
            this.utilities = utilities;
            this.configuration = configuration;
        }

        [HttpGet(Name = "GetMarbles")]
        public ActionResult<IEnumerable<Marble>> Get()
        {
            try
            {
                //Create the list of marbles (This line of code does not correct. Its Just FOR demOstration, you can use EF to get data from a DB).
                var listMarble = CreateListOfMarbles();
                
                //Use the service to execute the method that gets all palindrome words in the list of marbles.
                var palindromeMarbles = utilities.GetPalindrome(listMarble).ToArray();

                //From the appsettings.json get the weigh param to filter list
                float marbleWeight = float.Parse(configuration["marbleWeight"]);
                //Use the service to execute the method that gets the specific weight in the list of marbles.
                var weightMarbles =  utilities.GetByWeight(palindromeMarbles, marbleWeight).ToArray();

                //Use the service to execute the method for ordered list according its color.
                var sortedMarblesByColor = utilities.SortByColor(weightMarbles).ToArray();

                //Show to user the sorted list. 
                return sortedMarblesByColor;
            }
            catch (Exception)
            {
                return BadRequest();

            }
        }

        /// <summary>
        /// Returns List of a Marble with specific values
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Marble> CreateListOfMarbles()
        {
            List<Marble> returnList = new List<Marble>();

            var marbleToAdd = new Marble();
            marbleToAdd.Id = 1;
            marbleToAdd.Color = "blue";
            marbleToAdd.Name = "Bob";
            marbleToAdd.Weight = 0.5f;

            returnList.Add(marbleToAdd);

            //{ id: 2, color: "red", name: "John Smith", weight: 0.25 },
            var marbleToAdd1 = new Marble();
            marbleToAdd1.Id = 2;
            marbleToAdd1.Color = "red";
            marbleToAdd1.Name = "John Smith";
            marbleToAdd1.Weight = 0.25f;

            returnList.Add(marbleToAdd1);


            //{ id: 3, color: "violet", name: "Bob O'Bob", weight: 0.5 },
            var marbleToAdd2 = new Marble();
            marbleToAdd2.Id = 3;
            marbleToAdd2.Color = "violet";
            marbleToAdd2.Name = "Bob O'Bob";
            marbleToAdd2.Weight = 0.5f;

            returnList.Add(marbleToAdd2);

            //{ id: 4, color: "indigo", name: "Bob Dad-Bob", weight: 0.75 },
            var marbleToAdd3 = new Marble();
            marbleToAdd3.Id = 4;
            marbleToAdd3.Color = "indigo";
            marbleToAdd3.Name = "Bob Dad-Bob";
            marbleToAdd3.Weight = 0.75f;

            returnList.Add(marbleToAdd3);

            //{ id: 5, color: "yellow", name: "John", weight: 0.5 },
            var marbleToAdd4 = new Marble();
            marbleToAdd4.Id = 5;
            marbleToAdd4.Color = "yellow";
            marbleToAdd4.Name = "John";
            marbleToAdd4.Weight = 0.5f;

            returnList.Add(marbleToAdd4);

            //{ id: 6, color: "orange", name: "Bob", weight: 0.25 },
            var marbleToAdd5 = new Marble();
            marbleToAdd5.Id = 6;
            marbleToAdd5.Color = "orange";
            marbleToAdd5.Name = "Bob";
            marbleToAdd5.Weight = 0.25f;

            returnList.Add(marbleToAdd5);

            //{ id: 7, color: "blue", name: "Smith", weight: 0.5 },
            var marbleToAdd6 = new Marble();
            marbleToAdd6.Id = 7;
            marbleToAdd6.Color = "blue";
            marbleToAdd6.Name = "Smith";
            marbleToAdd6.Weight = 0.5f;

            returnList.Add(marbleToAdd6);

            //{ id: 8, color: "blue", name: "Bob", weight: 0.25 },
            var marbleToAdd7 = new Marble();
            marbleToAdd7.Id = 8;
            marbleToAdd7.Color = "blue";
            marbleToAdd7.Name = "Bob";
            marbleToAdd7.Weight = 0.25f;

            returnList.Add(marbleToAdd7);

            //{ id: 9, color: "green", name: "Bobb Ob", weight: 0.75 },
            var marbleToAdd8 = new Marble();
            marbleToAdd8.Id = 9;
            marbleToAdd8.Color = "green";
            marbleToAdd8.Name = "Bobb Ob";
            marbleToAdd8.Weight = 0.75f;

            returnList.Add(marbleToAdd8);

            //{ id: 10, color: "blue", name: "Bob", weight: 0.5 }
            var marbleToAdd9 = new Marble();
            marbleToAdd9.Id = 10;
            marbleToAdd9.Color = "blue";
            marbleToAdd9.Name = "Bob";
            marbleToAdd9.Weight = 0.5f;

            returnList.Add(marbleToAdd9);

            return returnList;
        }
    }
 
}
