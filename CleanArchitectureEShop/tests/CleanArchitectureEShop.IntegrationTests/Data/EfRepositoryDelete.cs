﻿using CleanArchitectureEShop.Core.Entities;
using CleanArchitectureEShop.UnitTests;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitectureEShop.IntegrationTests.Data
{
    public class EfRepositoryDelete : BaseEfRepoTestFixture
    {
        [Fact]
        public async Task DeletesItemAfterAddingIt()
        {
            // add an item
            var repository = GetRepository();
            var initialTitle = Guid.NewGuid().ToString();
            var item = new ToDoItemBuilder().Title(initialTitle).Build();
            await repository.AddAsync(item);

            // delete the item
            await repository.DeleteAsync(item);

            // verify it's no longer there
            Assert.DoesNotContain(await repository.ListAsync<ToDoItem>(),
                i => i.Title == initialTitle);
        }
    }
}
