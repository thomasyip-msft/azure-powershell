// ----------------------------------------------------------------------------------
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

namespace CAT //Commands.Automation.Test
{
    using Microsoft.Azure.Commands.Automation.Test;
    using Microsoft.WindowsAzure.Commands.ScenarioTest;
    using Microsoft.Azure.ServiceManagemenet.Common.Models;
    using Xunit;

    public class WebhookTests : AutomationScenarioTestsBase
    {
        public XunitTracingInterceptor logger;

        public WebhookTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(logger);
        }

        //[Fact(Skip = "Test needs to be re-recorded.")]
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Service, Category.Automation)]
        public void BasicWebhookCrud()
        {
            RunPowerShellTest(logger, "Test-BasicWebhookCrud");
        }

        //[Fact(Skip = "Test needs to be re-recorded.")]
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Service, Category.Automation)]
        public void NewAutomationWebhookWithParameters()
        {
            RunPowerShellTest(logger, "Test-NewAutomationWebhookWithParameters");
        }

        //[Fact(Skip = "Test needs to be re-recorded.")]
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Service, Category.Automation)]
        public void WebhookCreateFailsIfMandatoryParametersNotSpecified()
        {
            RunPowerShellTest(logger, "Test-WebhookCreateFailsIfMandatoryParametersNotSpecified");
        }

        //[Fact(Skip = "Test needs to be re-recorded.")]
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Service, Category.Automation)]
        public void GetWebhookSuccessScenarios()
        {
            RunPowerShellTest(logger, "Test-GetWebhookSuccessScenarios");
        }

        //[Fact(Skip = "Test needs to be re-recorded.")]
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Service, Category.Automation)]
        public void GetWebhookFailureScenarios()
        {
            RunPowerShellTest(logger, "Test-GetWebhookFailureScenarios");
        }
    }
}