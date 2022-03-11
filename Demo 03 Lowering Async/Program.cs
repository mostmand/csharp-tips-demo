async Task<int> GetNumberAsync()
{
    await Task.CompletedTask;
    return 3;
}

var result = await GetNumberAsync();

 