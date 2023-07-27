﻿using System.Reflection;
using Kafe.TheClapper.Properties;
using MelonLoader;


[assembly: AssemblyVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyFileVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyInformationalVersion(AssemblyInfoParams.Version)]
[assembly: AssemblyTitle(nameof(Kafe.TheClapper))]
[assembly: AssemblyCompany(AssemblyInfoParams.Author)]
[assembly: AssemblyProduct(nameof(Kafe.TheClapper))]

[assembly: MelonInfo(
    typeof(Kafe.TheClapper.TheClapper),
    nameof(Kafe.TheClapper),
    AssemblyInfoParams.Version,
    AssemblyInfoParams.Author,
    downloadLink: "https://github.com/kafeijao/Kafe_CVR_Mods"
)]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.MONO)]
[assembly: MelonColor(255, 0, 255, 0)]
[assembly: MelonAuthorColor(255, 128, 128, 0)]

namespace Kafe.TheClapper.Properties;
internal static class AssemblyInfoParams {
    public const string Version = "1.0.2";
    public const string Author = "kafeijao";
}
