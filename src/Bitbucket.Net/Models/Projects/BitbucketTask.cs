﻿namespace Bitbucket.Net.Models.Projects
{
    public class BitbucketTask : TaskRef
    {
        public TaskAnchor Anchor { get; set; }
        public string State { get; set; }
    }
}
