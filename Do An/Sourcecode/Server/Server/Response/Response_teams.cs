﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_football;

namespace Response
{
    public class Response_teams_and_venue
    {
        public Team team { get; set; }
        public Venue venue { get; set; }
    }
    public class root_teams_and_venue
    {
        public Response_teams_and_venue[] response { get; set; }
    }
}
