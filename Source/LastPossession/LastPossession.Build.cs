// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LastPossession : ModuleRules
{
	public LastPossession(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"LastPossession",
			"LastPossession/Variant_Horror",
			"LastPossession/Variant_Horror/UI",
			"LastPossession/Variant_Shooter",
			"LastPossession/Variant_Shooter/AI",
			"LastPossession/Variant_Shooter/UI",
			"LastPossession/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
