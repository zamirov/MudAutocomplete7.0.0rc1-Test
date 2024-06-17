namespace MudAutocomplete7._0._0rc1_Test.Pages
{
    public partial class Home
    {
        private string Query { get; set; }
        private void QuerySelected()
        {

        }

        private Task<IEnumerable<string>> Search(string value, CancellationToken token)
        {
            var trimmedText = value.Trim(); 
            return Task.FromResult(new string[] { "query 1", "query 2", "query 3" }
            .Where(s => s.Contains(trimmedText) || string.IsNullOrWhiteSpace(trimmedText)));
        }
    }
}