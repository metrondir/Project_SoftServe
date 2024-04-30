﻿using SoftServeCinema.Core.DTOs.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeCinema.Core.DTOs.Users
{
    public class UserWithTicketsDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public ICollection<TicketDTO> Tickets { get; set; } = [];
    }
}