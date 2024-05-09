using System.Entities;
using System.Providers;

namespace System.BussinessRules
{
    public class UserBusinessRules
    {
        private readonly UserProvider _logProvider;

        public UserBusinessRules(UserProvider logProvider)
        {
            _logProvider = logProvider;
        }




    }
}
