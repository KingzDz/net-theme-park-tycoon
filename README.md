# Codename: Theme Park Tycoon Game

*Except it's not really a game, but a simulator for theme parks.*

![Theme Park Tycoon logo of pixelated floating island and theme park rides](https://raw.githubusercontent.com/timothywalter/net-theme-park-tycoon/8e045619f80b3c6dfd557e76e25d19081edd72b7/Resources/logo-small.png)

This is a text and menu-based game surrounding the management of a theme park. It allows you to buy rides and shops. Guests will want to go on these rides and buy from your stores. All based on random stats (with the guests) and stat boosts (from rides and consumption).



## Getting this running

### Requirements

#### For development

* [.NET Framework 4.7 Developer Pack](<https://dotnet.microsoft.com/download/visual-studio-sdks>). *Needed for the WPF and WinForms projects*

* [.NET Core 2.0 SDK (x64 or x86)](<https://dotnet.microsoft.com/download/visual-studio-sdks>) for your version of Visual Studio. *This contains .NET Standard 2.0, needed for the Core project*

* [Git CLI](<https://git-scm.com/downloads>) with the binaries [added to your PATH](<https://hackernoon.com/install-git-on-windows-9acf2a1944f0>) (needed to run `SYNC_FORK.bat`)



#### For users

- [.NET Framework 4.7 Runtime](<https://dotnet.microsoft.com/download/visual-studio-sdks>)

- [.NET Core 2.0 Runtime (x64 or x86)](<https://dotnet.microsoft.com/download/visual-studio-sdks>)



### Step-by-step

In these step-by-step instructions you can read how to get this solution running. Choosing to either use console commands, or just following the instructions in your own way.

*Make sure you installed all requirements for development (listed above)*

1. Clone this repo to a folder by running

   `git clone https://github.com/timothywalter/net-theme-park-tycoon.git`

   (Or using your favourite Git Client)

2. Enter that folder

   `cd net-theme-park-tycoon`

3. Open the .sln file to open the solution

4. There are three different projects, described below...

5. Right-click the project you wish to start and "Set as StartUp project"

   * **ThemeParkTycoonGame.Forms** is a WinForms version
   * **ThemeParkTycoonGame.Fancy** is a WPF version *(please help me complete it)*
   * ThemeParkTycoonGame.Core is the fundamental basics of the simulation. *It contains no UI and can't be started directly.*

6. Press 'Start' or F5



## Contributing

If you wish to contribute, check out the [wiki](https://github.com/timothywalter/net-theme-park-tycoon/wiki) in this repository. Please help expand it so new contributors can help understand how this solution works.



To contribute:

1. Create a [fork](<https://github.com/timothywalter/net-theme-park-tycoon/fork>) of this repository

2. Strategize with your team (or self): what are you going to make

3. Make changes (with your team) to your fork (keep the [CONVENTIONS](CONVENTIONS.md) in mind)

4. When done, make sure you have committed your changes

5. When ready to make a pull request, first: synchronize your fork with the upstream (original repository) using the `SYNC_FORK.bat` script. It will automatically execute [these instructions](<https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/syncing-a-fork>) for you

6. Resolve any merge conflicts by going through the conflicts and deciding which code needs to stay

7. Test the software on your fork

8. When satisfied with the tested result, you can create a [Pull Request](<https://github.com/timothywalter/net-theme-park-tycoon/pulls>) to this repository

9. [@timothywalter](<https://github.com/timothywalter/>) will check your code and merge it into the master:

   *Only tested code is merged into the master. If there are too many errors your changes will be rejected*

10. Start over from `step 2`.



## Attribution
* Idea and initial project by [Timothy Walter Lutt](https://github.com/timothywalter)
* Mental support by [@feddman](https://github.com/Feddman)
* All icons by [Icons8](https://icons8.com/)

