﻿using System.Collections.Generic;

namespace RedBeard.Crawler.Model
{
    public class PaniniAlertEntry
    {
        public string Email { get; set; }
        public List<string> Links { get; set; }

        public PaniniAlertEntry()
        {
            this.Links = new List<string>();
        }
    }
}
