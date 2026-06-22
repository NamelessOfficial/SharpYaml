using SharpYaml;
using SharpYaml.Serialization;

namespace SharpYaml.AotSmokeLib;

internal sealed class SmokeLibraryConfig
{
    public string Name { get; set; } = string.Empty;
}

internal static class SmokeLibraryYaml
{
    public static YamlTypeInfo<SmokeLibraryConfig> TypeInfo => SmokeLibraryYamlContext.Default.SmokeLibraryConfig;
}

[YamlSerializable(typeof(SmokeLibraryConfig))]
internal partial class SmokeLibraryYamlContext : YamlSerializerContext
{
}
