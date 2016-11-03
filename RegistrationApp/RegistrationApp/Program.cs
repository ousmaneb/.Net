using RegistrationApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ScheduleClass(ScheduleClassDTO c, StudentDTO s)
        {
            var succeed = false;

            try
            {
                c.addStudent(s);

                return (succeed = true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return succeed;
            }
        }



    }
}
