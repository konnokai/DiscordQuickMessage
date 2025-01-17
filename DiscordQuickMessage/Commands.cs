﻿using Discord;
using Discord.Interactions;

namespace DiscordQuickMessage
{
    // This class is where all slash command logic goes

    public class Commands : InteractionModuleBase<SocketInteractionContext>
    {
        // a simple command which responds with the word "Pong!"
        // here we use the [SlashCommand] attribute to designate this function as a slash command with the name "ping" and the description "Pong!"
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/
        [SlashCommand("ping", "Pong!")]
        public async Task Ping()
        {
            // we can respond to the user with this function
            // this will also "acknowledge" Discord that we received the command
            await RespondAsync("Pong!");
        }

        // another simple command that will repeat whatever the user inputs
        // this example shows how to allow the user to input parameters
        // the [Summary] attribute allows us to give a name and description to command parameters
        [SlashCommand("echo", "Repeats whatever is input")]
        public async Task Echo([Summary("text", "The text to repeat")]string text)
        {
            await RespondAsync(text);
        }

        // Dev command to clean out DMs
        [SlashCommand("purgedms", "Deletes all previous messages from your dms")]
        public async Task Purge()
        {
            IDMChannel channel = await Context.User.CreateDMChannelAsync();
            var messages = await channel.GetMessagesAsync().FlattenAsync();
            messages = messages.Where(x => x.Author.Id == Context.Client.CurrentUser.Id);
            int count = messages.Count();
            foreach (var message in messages)
            {
                await message.DeleteAsync();
            }
            await RespondAsync($"Purged {count} messages.", ephemeral: true);
        }
    }
}
