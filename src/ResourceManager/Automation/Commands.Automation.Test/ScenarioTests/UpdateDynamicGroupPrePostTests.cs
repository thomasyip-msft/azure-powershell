﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Commands.Automation.Test
{
    using Microsoft.Azure.Commands.Automation.Test;
    using Microsoft.Azure.ServiceManagemenet.Common.Models;
    using Microsoft.WindowsAzure.Commands.ScenarioTest;   
    using Xunit;

    public class UpdateDynamicGroupPrePostTests : AutomationScenarioTestsBase
    {
        public XunitTracingInterceptor logger;
        public UpdateDynamicGroupPrePostTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(logger);
        }

        [Fact]
        [Trait(Category.Service, Category.Automation)]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestCreateAndGetSoftwareUpdateConfigurationWithDynamicGroups()
        {
            RunPowerShellTest(logger, "Test-CreateAndGetSoftwareUpdateConfigurationWithDynamicGroups");
        }

        [Fact]
        [Trait(Category.Service, Category.Automation)]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestCreateAndGetSoftwareUpdateConfigurationWithPrePost()
        {
            RunPowerShellTest(logger, "Test-CreateAndGetSoftwareUpdateConfigurationWithPrePost");
        }

        [Fact]
        [Trait(Category.Service, Category.Automation)]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestGetSoftwareUpdateConfigurationRunWithPrePost()
        {
            RunPowerShellTest(logger, "Test-GetSoftwareUpdateConfigurationRunWithPrePost");
        }

    }
}
