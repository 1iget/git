using GVFS.Common;
using GVFS.DiskLayoutUpgrades;

namespace GVFS.Platform.Linux
{
    public class LinuxDiskLayoutUpgradeData : IDiskLayoutUpgradeData
    {
        public DiskLayoutUpgrade[] Upgrades
        {
            get
            {
                return new DiskLayoutUpgrade[0];
            }
        }

        public DiskLayoutVersion Version => new DiskLayoutVersion(
            currentMajorVersion: 18,
            currentMinorVersion: 0,
            minimumSupportedMajorVersion: 18);

        public bool TryParseLegacyDiskLayoutVersion(string dotGVFSPath, out int majorVersion)
        {
            majorVersion = 0;
            return false;
        }
    }
}
