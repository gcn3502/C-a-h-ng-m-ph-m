using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMP.Class
{
    public class User
    {
        // Private static variable that holds the single instance
        private static User instance = null;
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        // Lock synchronization object
        private static readonly object padlock = new object();

        // Private constructor to prevent instantiation from other classes
        private User()
        {
        }

        // Public static method to get the instance of the class
        public static User Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new User();
                    }
                    return instance;
                }
            }
        }
    }

}
