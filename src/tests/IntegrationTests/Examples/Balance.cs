/*
order: 30
title: Check Balance
slug: balance

Shows how to check the current credit balance.
*/

namespace Meshy.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CheckBalance()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve the current credit balance.
        var balance = await client.Balance.GetBalanceAsync();
        balance.Balance.Should().NotBeNull();
        Console.WriteLine($"Credits: {balance.Balance}");
    }
}
