﻿namespace Bitbucket.Net.Models.Projects
{
    public class LineRef
    {
        public int Destination { get; set; }
        public int Source { get; set; }
        public string Line { get; set; }
        public bool Truncated { get; set; }
    }
}