// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RuntimeMeshTerrain : ModuleRules
{
	public RuntimeMeshTerrain(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "ProceduralMeshComponent", "SimplexNoise" });

        PublicDependencyModuleNames.AddRange(new string[] { "RenderCore", "RHI" });
    }
}
