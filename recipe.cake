#load nuget:?package=Chocolatey.Cake.Recipe&version=0.28.4

///////////////////////////////////////////////////////////////////////////////
// RECIPE SCRIPT
///////////////////////////////////////////////////////////////////////////////

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./src",
                            solutionFilePath: "./src/fakerepository.sln",
                            solutionDirectoryPath: "./src/fakerepository",
                            resharperSettingsFileName: "fakerepository.sln.DotSettings",
                            title: "Fake Repository",
                            repositoryOwner: "gittools",
                            repositoryName: "fakerepository",
                            productName: "Fake Project",
                            productDescription: "The Ultimate Fake Repository.",
                            productCopyright: string.Format("Copyright © 2025 - {0} gep13.", DateTime.Now.Year),
                            shouldStrongNameSignDependentAssemblies: true,
                            strongNameDependentAssembliesInputPath: string.Format("{0}{1}", ((FilePath)("./src")).FullPath, "\\packages\\RestSharp*"),
                            treatWarningsAsErrors: false,
                            shouldRunILMerge: false);

ToolSettings.SetToolSettings(context: Context);

BuildParameters.PrintParameters(Context);

Build.Run();
