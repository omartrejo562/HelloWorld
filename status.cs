public class Help : ModuleBase<SocketCommandContext>
{
  [Command("test")]
  public async Task TestAsync()
  {
    await Context.Client.SetGameAsync("Listening to !help");
    
    await Task.CompleteTask;
  }
}




