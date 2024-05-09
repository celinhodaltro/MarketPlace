using System.Entities;
using System.Providers;

namespace System.BussinessRules
{
    public class AuthBusinessRules
    {
        private readonly UserProvider _logProvider;

        public AuthBusinessRules(UserProvider logProvider)
        {
            _logProvider = logProvider;
        }




    }
}
