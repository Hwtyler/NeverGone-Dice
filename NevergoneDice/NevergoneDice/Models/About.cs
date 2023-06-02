using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevergoneDice.Models
{
    class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;

        public string MoreInfoUrl => "https://aka.ms/maui"; //Change this to my company page later
        public string Message => "Application developed by Tyler Hudgens. Because losing my dice is getting old.";
    }
}
