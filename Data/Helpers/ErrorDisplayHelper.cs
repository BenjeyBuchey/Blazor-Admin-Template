using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAdminTemplate.Data.Helpers
{
    public static class ErrorDisplayHelper
    {
        public static string GetErrorsFromIdentityResult(IdentityResult result)
        {
            if (result is null) return null;

            var errors = new StringBuilder();
            foreach (var error in result.Errors)
            {
                errors.AppendLine(error.Description);
            }
            return errors.ToString();
        }
    }
}
