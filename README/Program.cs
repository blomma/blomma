using System;
using Octokit;

namespace README {
    class Program {
        static async System.Threading.Tasks.Task Main(string[] args) {
            var client = new GitHubClient(new ProductHeaderValue("README"));
            var issues = await client.Issue.GetAllForRepository("blomma", "blomma");

            var template = $@"
### Hi there 👋, Guru Meditation

<!--
**blomma/blomma** is a ✨ _special_ ✨ repository because its `README.md` (this file) appears on your GitHub profile.

Here are some ideas to get you started:

- 🔭 I’m currently working on ...
- 🌱 I’m currently learning ...
- 👯 I’m looking to collaborate on ...
- 🤔 I’m looking for help with ...
- 💬 Ask me about ...
- 📫 How to reach me: ...
- 😄 Pronouns: ...
- ⚡ Fun fact: ...
-->
";

            System.IO.File.WriteAllText("README.md", template);
        }
    }
}
