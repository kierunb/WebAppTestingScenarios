using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.UnitTests
{

    /// <summary>
    /// https://xunit.net/docs/shared-context
    /// </summary>

    public class TestsWithContext : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _databaseFixture;

        public TestsWithContext(DatabaseFixture databaseFixture)
        {
            _databaseFixture = databaseFixture;
        }

        [Fact]
        public void TestWithFixture()
        {
            Assert.True(true, $"It works. Connection: {_databaseFixture.SqlConnection}");
        }
    }

    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            SqlConnection = "MyConnectionString";

            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }

        public string SqlConnection { get; private set; }
    }
}
