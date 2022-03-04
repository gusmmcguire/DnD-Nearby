﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace DnD_Nearby.Models
{
    [CollectionName("Accounts")]
    public class ApplicationUser : MongoIdentityUser<Guid>
    {

    }
}
