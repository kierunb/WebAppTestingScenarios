## Automated Testing in C# and .NET scenarios knowledge base

### Libraries:

- XUnit:				https://xunit.net/
- NUnit:				https://nunit.org/

- Moq:				    https://github.com/Moq/moq4/wiki/Quickstart
- FakeItEasy            https://fakeiteasy.github.io/
- JustMockLite		    https://github.com/telerik/JustMockLite

- FluentAssertions:	    https://fluentassertions.com/introduction
- Shouldy               https://docs.shouldly.io/documentation/getting-started
- AutoFixture:		    https://github.com/AutoFixture/AutoFixture/wiki/Cheat-Sheet
- MyTested.AspNetCore.Mvc     https://github.com/ivaylokenov/MyTested.AspNetCore.Mvc

Additional:
- Bogus:				https://github.com/bchavez/Bogus
- AngleSharp:			https://anglesharp.github.io/docs/core/03-Examples
- Respawn               https://github.com/jbogard/Respawn
- RestSharp             https://restsharp.dev/intro.html

E2E:
- Selenium:			    https://www.toolsqa.com/selenium-c-sharp/
- Playwright:			https://playwright.dev/dotnet/docs/intro

### Visual Studio Add-ons
- xUnit Code Snippets
- xUnit Test Generator
- NCrunch (https://www.ncrunch.net/) - $$$

### Google Chrome Add-ons
- Selenium IDE
- k6 Browser Recorder

### Best practices:
https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
https://stackify.com/unit-testing-basics-best-practices/
https://dzone.com/articles/unit-testing-best-practices-how-to-get-the-most-ou

### Stack Overflow:
https://stackoverflow.com/questions/1383/what-is-unit-testing
https://stackoverflow.com/questions/652292/what-is-unit-testing-and-how-do-you-do-it?noredirect=1&lq=1
https://stackoverflow.com/questions/10752/what-is-the-difference-between-integration-and-unit-tests?rq=1
https://stackoverflow.com/questions/520064/what-are-unit-tests-integration-tests-smoke-tests-and-regression-tests

### Knowledge base, TDD, BDD, ATDD
https://www.wikiwand.com/en/Test-driven_development
https://www.wikiwand.com/en/Behavior-driven_development
https://cucumber.io/docs/bdd/
https://www.wikiwand.com/en/Acceptance_test%E2%80%93driven_development

### Martin Fowler
https://martinfowler.com/articles/practical-test-pyramid.html
https://martinfowler.com/articles/mocksArentStubs.html
https://stackoverflow.com/questions/3459287/whats-the-difference-between-a-mock-stub

### Docs:
http://xunitpatterns.com/index.html
https://xunit.net/docs/shared-context
http://dontcodetired.com/blog/post/xUnitnet-2-Cheat-Sheet
- Parallelism: https://xunit.net/docs/running-tests-in-parallel
- Filtering: https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest
https://www.manning.com/books/unit-testing

### XUnit vs NUnit vs MSUnitt
https://xunit.net/docs/comparisons

### Unit Tests
https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-6.0

### Naming Conventions:
https://stackoverflow.com/questions/155436/unit-test-naming-best-practices
https://stackoverflow.com/questions/96297/what-are-some-popular-naming-conventions-for-unit-tests
https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html

```
[UnitOfWork_StateUnderTest_ExpectedBehavior]
[MethodName_StateUnderTest_ExpectedBehavior]

Sum_NegativeNumberAs1stParam_ExceptionThrown() 
Sum_NegativeNumberAs2ndParam_ExceptionThrown() 
Sum_simpleValues_Calculated()
ParseLogLine_StartsAndEndsWithSpace_ReturnsTrimmedResult()
GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
```

### Code Coverage
https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows

### Live Unit Tests
https://docs.microsoft.com/en-us/visualstudio/test/live-unit-testing-start?view=vs-2022

### Integration tests:
https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-6.0
https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/test/integration-tests/samples
https://dotnetthoughts.net/dotnet-minimal-api-integration-testing/
https://docs.microsoft.com/en-us/aspnet/core/migration/50-to-60-samples?view=aspnetcore-6.0
https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/test/integration-tests/samples/3.x/IntegrationTestsSample/tests/RazorPagesProject.Tests/IntegrationTests/BasicTests.cs
https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/test/integration-tests/samples/3.x/IntegrationTestsSample/tests/RazorPagesProject.Tests/IntegrationTests/IndexPageTests.cs

### Respawn, Database tests
https://github.com/jbogard/Respawn/blob/master/Respawn.DatabaseTests/SqlServerTests.cs

### E2E Tests
- WebDriver
	- https://www.w3.org/TR/webdriver2/
- Selenium
	- https://www.toolsqa.com/selenium-c-sharp/
- Playwright
	- https://playwright.dev/dotnet/docs/intro
	- https://playwright.dev/dotnet/docs/trace-viewer

### Load & Stress Testing
https://docs.microsoft.com/en-us/aspnet/core/test/load-tests?view=aspnetcore-6.0
https://docs.microsoft.com/en-us/azure/load-testing/overview-what-is-azure-load-testing
https://docs.microsoft.com/en-us/azure/architecture/example-scenario/banking/banking-system-cloud-transformation
https://docs.microsoft.com/en-us/azure/architecture/example-scenario/banking/jmeter-load-testing-pipeline-implementation-reference

#### Tools:
- JMeter
	- https://jmeter.apache.org/
- k6
	- https://k6.io/docs/
	- https://k6.io/docs/examples/
	- https://k6.io/docs/examples/functional-testing/
	- https://github.com/grafana/k6/releases
- Locust
	- https://github.com/locustio/locust


### Exploratory Testing
https://www.wikiwand.com/en/Exploratory_testing
Tools:
- Exploratory Testing Chrome Extension
- Microsoft Test & Feedback

### Behavior Driven Devleopment
https://www.wikiwand.com/en/Behavior-driven_development
https://specflow.org/
https://docs.specflow.org/projects/getting-started/en/latest/index.html


### Samples of Unit Tests
https://github.com/dotnet/aspnetcore/tree/main/src/Identity/test
https://github.com/dotnet/aspnetcore/blob/main/src/HealthChecks/HealthChecks/test/DefaultHealthCheckServiceTest.cs
https://github.com/moq/moq4/tree/main/tests/Moq.Tests
https://github.com/ivaylokenov/MyTested.AspNetCore.Mvc/tree/version-3.1/samples
https://github.com/dotnet-architecture/eShopOnWeb
https://github.com/vkhorikov/UnitTestingPPP
https://github.com/jbogard/MediatR/tree/master/test
