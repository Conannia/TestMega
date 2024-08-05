using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mega.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MegaUser class
public class MegaUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(255)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(255)")]
    public string LastName { get; set; }
}

