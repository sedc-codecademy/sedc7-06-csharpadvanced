using System;

namespace Comparable
{
    public class DBScript : IComparable<DBScript>
    {
        public string Name { get; set; }

        public DBScript()
        {

        }

        public DBScript(string name)
        {
            Name = name;
        }

        public int CompareTo(DBScript other)
        {
            var versionsCurrent = this.Name.Split('_');
            var versionsOther = this.Name.Split('_');

            var currentMain = Convert.ToInt32(versionsCurrent[0]);
            var currentMinor = Convert.ToInt32(versionsCurrent[1]);

            var currentOtherMain = Convert.ToInt32(versionsOther[0]);
            var currentOtherMinor = Convert.ToInt32(versionsOther[1]);

            if (currentMain > currentOtherMain)
                return -1;
            else if (currentMain < currentOtherMain)
                return 1;
            else
            {
                if (currentMinor > currentOtherMinor)
                    return -1;
                if (currentMinor > currentOtherMinor)
                    return 1;
            }

            return 0;
        }
    }
}