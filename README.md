# DiscordQuickMessage
Semester long group project for Software Engineering II at UML

The Discord Quick Message is a Discord bot that allows the user to easily reply to Discord mentions, without having to spend time thinking and typing a response back to the user, especially if they are busy and cannot respond effectively. When a user is mentioned in a server by another user, it will utilize OpenAI to generate a positive, neutral, and negative response, and display the answers to the mentioned user, allowing them to pick a response. Once a response is confirmed, it will automatically reply to the original user with the chosen response.

# Requirements
Create a bot on the Discord Developer page as well as create a profile on OpenAI's website to acquire an API token from each. This is necessary for later steps.

# How to Run
1. Clone the respository and open the .sln file in Visual Studio 2022.
2. Under Test > Test Explorer, click the dropdown on the settings cog and check off "Run Tests After Build" to auto run unit tests.
3. Press F6 to build the project. This will generate necessary folders for the next step.
4. Create files named token.txt and openai_token.txt in the run directory (..\DiscordQuickMessage\bin\Debug\net6.0) of the project, and paste in your Discord bot token and OpenAI token, respectively.
5. Press F5 or Alt+F5 to run the bot.
6. A console window will appear. After the message "Ready" is logged, the bot is ready to be interacted with.

# How to Use
1. When you are mentioned by another user in a channel, the bot will send you a Direct Message on Discord.
2. Click the corresponding number to the response you would like to send. You can also click "Ignore" to ignore the response or "Original Message" to jump to the original message.
3. After choosing a response, the bot will have you confirm your selection. Click "Yes" to send the message or "No" to start over.
4. If "Yes" is selected, the bot will send the corresponding response in the channel you were mentioned in.

# Todo
- 預設不觸發回應，使用指令讓使用者切換啟用狀態並使用SQLite保存
- 將回應按鈕的CustomId加入GUID亂數，且直接從Embed抓取回應
