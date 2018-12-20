﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DockerFileBuildHelper
{
    public class DockerInfo
    {
        public string DockerFilePath { get; set; }
        public string DockerFilePathARM32v7 { get; set; }
        public string DockerFilePathARM64v8 { get; set; }
        public string DockerHubLink { get; set; }
        public string GitLink { get; set; }
        public string GitRef { get; set; }
        public Image Image { get; internal set; }

        public string GetGithubLinkOf(string path)
        {
            return $"https://raw.githubusercontent.com/{GitLink.Substring("https://github.com/".Length)}/{GitRef}/{path}";
        }
    }
}