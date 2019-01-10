using System;
using Xunit;
using temp.Services;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async System.Threading.Tasks.Task TestViewModelAsync()
        {
            SqLiteDataStore SqLiteDataStore = new SqLiteDataStore();
            await SqLiteDataStore.GetItemsAsync(false);
        }
    }
}
