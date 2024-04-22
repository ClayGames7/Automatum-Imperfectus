using UnrealBuildTool;

public class FYP_ProjectTarget : TargetRules
{
	public FYP_ProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FYP_Project");
	}
}
