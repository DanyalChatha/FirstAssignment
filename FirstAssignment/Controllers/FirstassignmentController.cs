using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAssignment.Controllers
{
    public class FirstassignmentController : ApiController
    {
        /// <summary>
        /// Add 10 from the input number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>the input plus ten</returns>
        /// <example>
        /// GET: api/addten/13" -> 23
        /// GET: api/addten/-8" -> 2     
        /// </example>
        [Route("api/AddTen/{id}")]
        [HttpGet]
        public int Get(int id)
        {
            int answer = id + 10;
            return answer;
        }


        /// <summary>
        /// The userinput id square itself
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Square of the integer input</returns>
        /// <example>
        /// GET: api/sqaure/10 -> 100
        /// GET: api/sqaure/-5 -> 25
        /// </example>
        [Route("api/square/{id}")]
        [HttpGet]
        public int Equation(int id)
        {
            int answer = id * id;
            return answer;
        }


        /// <summary>
        /// Returns the string "Hello World"
        /// </summary>
        /// <returns>"Hello World" is return</returns>
        /// <example>
        /// GET: api/greeting
        /// </example>
        [Route("api/greeting")]
        [HttpGet]
        public string Post()
        {
            return "Hello World!";
        }


        /// <summary>
        /// Returns the string "Greeting to {ID} people!"
        /// </summary>
        /// <param name="id"></param>
        /// <returns>returns an intger for the id within a string</returns>
        /// <example>
        /// GET: api/greeting/8 -> "Greeting to 8 people!"
        /// GET: api/greeting/132 -> "Greeting to 132 people!"
        /// </example>
        [Route("api/greeting/{id}")]
        [HttpGet]
        public string Numbers(int id)
        {
            string sentence = "Greeting to ";
            string Identify = id.ToString();
            String complete = " people!";
            return sentence + Identify + complete;
        }


        /// <summary>
        /// Input goes through 4 different mathematical operations
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Input first times the id by 5, divides by 2, Add by 6, Subtract by 11</returns>
        /// <example>
        /// GET: api/numbermachine/10 -> 20
        /// GET: api/numbermachine/20 -> 45
        /// </example>
        [Route("api/numbermachine/{id}")]
        [HttpGet]

        public int numbermachine(int id)
        {
            int answer = (id * 5 / 2 + 6 - 11);
            return answer;
        }

        /*[Route("api/hostingCost/{id}")]
        [HttpGet]

        public int hostingCost(int id)
        {
            int fortnight = 5 / 14;
            int hst = 1.13;
            int total = fortnight * hst;
            return total;
            
       I was trying many different ways to work this coding question such as the "if statement" but I still 
       couldn't find myself figuring out how to do it. With this coding strat I knew all the variables but 
       I didn't know how to put in to the code the "id" into the situation it had me stumped.
       Could you please show us next week how to do this problem?
        


        }

        
        */
    }
}
 