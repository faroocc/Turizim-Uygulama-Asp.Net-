using System;
using Microsoft.AspNetCore.Identity;

namespace TraversalCoreUi.Models
{
    public class ErrorViewModel: IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code="PasswordTooShort",
                Description=$"Parola Minumum {length} karekter olmalıdır"
            
            };  
        }
    }
}
