﻿using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Bitbucket.Cloud.Net.Tests
{
	public partial class BitbucketCloudClientShould
	{
		[Theory]
		[InlineData("luve")]
		public async Task GetUserByNameAsync(string userName)
		{
			var result = await _client.GetUserByNameAsync(userName).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Theory]
		[InlineData("luve")]
		public async Task GetUserWebhooksAsync(string userName)
		{
			var result = await _client.GetUserWebhooksAsync(userName).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Theory]
		[InlineData("luve")]
		public async Task GetUserVariablesAsync(string userName)
		{
			var user = await _client.GetUserByNameAsync(userName).ConfigureAwait(false);
			var result = await _client.GetUserVariablesAsync(user?.Uuid.ToString("B")).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Theory]
		[InlineData("luve")]
		public async Task GetUserVariableAsync(string userName)
		{
			var results = await _client.GetUserVariablesAsync(userName).ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult == null)
			{
				return;
			}

			var result = await _client.GetUserVariableAsync(userName, firstResult.Uuid.ToString("B")).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Theory]
		[InlineData("luve")]
		public async Task GetUserRepositoriesAsync(string userName)
		{
			var result = await _client.GetUserRepositoriesAsync(userName).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Theory]
		[InlineData("luve")]
		public async Task SearchCodeAsync(string userName)
		{
			var result = await _client.SearchCodeAsync(userName, "\"something\"").ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Theory]
		[InlineData("luve")]
		public async Task GetUserSshKeysAsync(string userName)
		{
			var result = await _client.GetUserSshKeysAsync(userName).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
