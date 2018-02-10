﻿using System.Collections.Generic;

namespace Bitbucket.Net.Models.Projects
{
    public class Diff : DiffInfo
    {
        public Path Source { get; set; }
        public Path Destination { get; set; }
        public List<DiffHunk> Hunks { get; set; }
    }
}