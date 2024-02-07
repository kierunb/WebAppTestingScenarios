## Automated Testing in C# and .NET scenarios knowledge base

### Libraries and Tools:

- XUnit:				https://xunit.net/
- NUnit:				https://nunit.org/

- Moq:				    https://github.com/Moq/moq4/wiki/Quickstart
- FakeItEasy            https://fakeiteasy.github.io/
- JustMockLite		    https://github.com/telerik/JustMockLite
- NSubstitute           https://nsubstitute.github.io/

- FluentAssertions:	    https://fluentassertions.com/introduction
- Shouldy               https://docs.shouldly.io/documentation/getting-started
- AutoFixture:		    https://github.com/AutoFixture/AutoFixture/wiki/Cheat-Sheet
- MyTested.AspNetCore.Mvc     https://github.com/ivaylokenov/MyTested.AspNetCore.Mvc

- SpecFlow (BDD)        https://specflow.org/

Additional:
- Bogus:				https://github.com/bchavez/Bogus
- AngleSharp:			https://anglesharp.github.io/docs/core/03-Examples
- Respawn               https://github.com/jbogard/Respawn
- RestSharp             https://restsharp.dev/intro.html

E2E:
- Selenium:			    https://www.toolsqa.com/selenium-c-sharp/
- Playwright:			https://playwright.dev/dotnet/docs/intro
- Cypress:              https://www.cypress.io/

API Tests:
- https://dev.to/m4rri4nne/nunit-and-c-tutorial-to-automate-your-api-tests-from-scratch-24nf
- https://timdeschryver.dev/blog/how-to-test-your-csharp-web-api#one-off-test-setups
- **Tools:**
	- WireMock          https://wiremock.org/

DB Tests:
- EF Migrations         https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- DbUp                  https://dbup.readthedocs.io/en/latest/
- Respawn               https://github.com/jbogard/Respawn

Infrastructure:
- Docker                https://docs.docker.com/
- TestContainers        https://testcontainers.com/

### Visual Studio Add-ons
- xUnit Code Snippets
- xUnit Test Generator
- NCrunch (https://www.ncrunch.net/) - $$$

### Google Chrome Add-ons
- [Selenium IDE](https://chromewebstore.google.com/detail/selenium-ide/mooikfkahbdckldjjndioackbalphokd?pli=1)
- [k6 Browser Recorder](https://chromewebstore.google.com/detail/k6-browser-recorder/phjdhndljphphehjpgbmpocddnnmdbda)

### eBooks:
- [Unit testing in C#](https://docs.educationsmediagroup.com/unit-testing-csharp/)

### Best practices:
- https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
- https://stackify.com/unit-testing-basics-best-practices/
- https://dzone.com/articles/unit-testing-best-practices-how-to-get-the-most-ou

### Stack Overflow:
- https://stackoverflow.com/questions/1383/what-is-unit-testing
- https://stackoverflow.com/questions/652292/what-is-unit-testing-and-how-do-you-do-it?noredirect=1&lq=1
- https://stackoverflow.com/questions/10752/what-is-the-difference-between-integration-and-unit-tests?rq=1
- https://stackoverflow.com/questions/520064/what-are-unit-tests-integration-tests-smoke-tests-and-regression-tests

### Knowledge base, TDD, BDD, ATDD
- https://www.wikiwand.com/en/Test-driven_development
- https://www.wikiwand.com/en/Behavior-driven_development
- https://cucumber.io/docs/bdd/
- https://www.wikiwand.com/en/Acceptance_test%E2%80%93driven_development

### Martin Fowler
- https://martinfowler.com/articles/practical-test-pyramid.html
- https://martinfowler.com/articles/mocksArentStubs.html
- https://stackoverflow.com/questions/3459287/whats-the-difference-between-a-mock-stub

### Docs:
- http://xunitpatterns.com/index.html
- https://xunit.net/docs/shared-context
- http://dontcodetired.com/blog/post/xUnitnet-2-Cheat-Sheet
- Parallelism: https://xunit.net/docs/running-tests-in-parallel
- Filtering: https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest
- https://www.manning.com/books/unit-testing

### XUnit vs NUnit vs MSUnitt
- https://xunit.net/docs/comparisons

### Unit Tests
https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-6.0

### Naming Conventions:
- https://stackoverflow.com/questions/155436/unit-test-naming-best-practices
- https://stackoverflow.com/questions/96297/what-are-some-popular-naming-conventions-for-unit-tests
- https://osherove.com/blog/2005/4/3/naming-standards-for-unit-tests.html

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
- https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows

### Live Unit Tests
- https://docs.microsoft.com/en-us/visualstudio/test/live-unit-testing-start?view=vs-2022

### Integration tests:
- https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-6.0
- https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/test/integration-tests/samples
- https://dotnetthoughts.net/dotnet-minimal-api-integration-testing/
- https://docs.microsoft.com/en-us/aspnet/core/migration/50-to-60-samples?view=aspnetcore-6.0
- https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/test/integration-tests/samples/3.x/IntegrationTestsSample/tests/RazorPagesProject.Tests/IntegrationTests/BasicTests.cs
- https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/test/integration-tests/samples/3.x/IntegrationTestsSample/tests/RazorPagesProject.Tests/IntegrationTests/IndexPageTests.cs

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
- Cypress
	- https://www.cypress.io/
	- https://docs.cypress.io/guides/overview/why-cypress

### Load & Stress Testing
- https://docs.microsoft.com/en-us/aspnet/core/test/load-tests?view=aspnetcore-6.0
- https://docs.microsoft.com/en-us/azure/load-testing/overview-what-is-azure-load-testing
- https://docs.microsoft.com/en-us/azure/architecture/example-scenario/banking/banking-system-cloud-transformation
- https://docs.microsoft.com/en-us/azure/architecture/example-scenario/banking/jmeter-load-testing-pipeline-implementation-reference

### Perfromance Tests recommendations
- https://learn.microsoft.com/en-us/azure/well-architected/performance-efficiency/performance-test

#### Tools:
- JMeter
	- https://jmeter.apache.org/
- Azure Load Studio
	- https://azure.microsoft.com/en-us/products/load-testing
- k6
	- https://k6.io/docs/
	- https://k6.io/docs/examples/
	- https://k6.io/docs/examples/functional-testing/
	- https://github.com/grafana/k6/releases
- Locust
	- https://github.com/locustio/locust


### Exploratory Testing
- https://www.wikiwand.com/en/Exploratory_testing
Tools:
- Exploratory Testing Chrome Extension
- Microsoft Test & Feedback

### Behavior Driven Devleopment
- https://www.wikiwand.com/en/Behavior-driven_development
- https://specflow.org/
- https://docs.specflow.org/projects/getting-started/en/latest/index.html


### Samples of Unit Tests
- https://github.com/dotnet/aspnetcore/tree/main/src/Identity/test
- https://github.com/dotnet/aspnetcore/blob/main/src/HealthChecks/HealthChecks/test/DefaultHealthCheckServiceTest.cs
- https://github.com/moq/moq4/tree/main/tests/Moq.Tests
- https://github.com/ivaylokenov/MyTested.AspNetCore.Mvc/tree/version-3.1/samples
- https://github.com/dotnet-architecture/eShopOnWeb
- https://github.com/vkhorikov/UnitTestingPPP
- https://github.com/jbogard/MediatR/tree/master/test

## Security Testing
- [OWASP Web Security Testing Guide](https://owasp.org/www-project-web-security-testing-guide/)
- [Threat Modelling](https://www.microsoft.com/en-us/securityengineering/sdl/threatmodeling)
- [Threat Modeling Tool](https://learn.microsoft.com/en-us/azure/security/develop/threat-modeling-tool-getting-started)
- [Awesome Fuzz Testing](https://github.com/secfigo/Awesome-Fuzzing)
- [Awesome Fuzz Testing](https://github.com/cpuu/awesome-fuzzing)
- [Payload samples](https://github.com/swisskyrepo/PayloadsAllTheThings)
- [Dynamic Application Security Testing (DAST) Software](https://www.g2.com/categories/dynamic-application-security-testing-dast)
- [DevSecOps Tools](https://www.g2.com/categories/devsecops)
- [Secure DevOps](https://www.microsoft.com/en-us/securityengineering/devsecops)
- [DevSecOps controls](https://learn.microsoft.com/en-us/azure/cloud-adoption-framework/secure/devsecops-controls)
- [GitHub Advanced Security](https://docs.github.com/en/get-started/learning-about-github/about-github-advanced-security)
- [Static Application Security Testing (SAST) Software](https://www.g2.com/categories/static-application-security-testing-sast)
- Ethical Hacking:
	- [Kali Linux Tools](https://www.kali.org/tools/)
- Online Tool Sample: https://pentest-tools.com/
- DAST Tools:
	- [OWASP ZAP](https://www.zaproxy.org/)
	- [Burp Suite](https://portswigger.net/burp)
	- [Netsparker](https://www.netsparker.com/)
	- [Acunetix](https://www.acunetix.com/)
	- [Arachni](https://www.arachni-scanner.com/)
	- [Wapiti](https://wapiti.sourceforge.io/)

## Test Automation and CI/CD

- [dotnet test](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test)
- [Azure Pipelines and tests](https://learn.microsoft.com/en-us/azure/devops/pipelines/test/review-continuous-test-results-after-build?view=azure-devops)
- [GitHub Actions for testing](https://github.com/marketplace?category=testing&type=actions)
- [GitHUb Actions - automating build and tests](https://docs.github.com/en/actions/automating-builds-and-tests)
- **Architectures**:
	- [DevSecOps on Azure Kubernetes Service (AKS)](https://learn.microsoft.com/en-us/azure/architecture/guide/devsecops/devsecops-on-aks)
	- [DevSecOps with a rolling main branching strategy](https://learn.microsoft.com/en-us/azure/architecture/solution-ideas/articles/devsecops-rolling-branch)