# tstrbx
This launcher has no regards for keeping your servers safe aside from FilteringEnabled.
All the files are called "tstrblx" because I made a spelling mistake when making the launcher gui and decided tstrbx sounded nicer.

You have to provide your own clients, I'm not giving them to you.
They also have to be studio clients.

tip: you can still download 2020E+ clients from [ROBLOX servers](https://setup.rbxcdn.com/DeployHistory.txt).
I'll let you figure out how to put everything together.

another tip: https://archive.org/download/roblox-clients-2006-2021 and https://archive.roblonium.com/Client/Windows/RobloxStudio/

v12 Future-is-Bright is a 2018M client.
Early Future-is-Bright builds are 2017.
The only avatar-evolution build is a 2020E client.

May 2020 and above clients have broken corescripts, as they (probably) get big parts of the CoreGui from ROBLOX servers or something like that. I honestly don't know.

## Compiling
You really want to compile this?
Well then, beware, the code is bad. A never-nesters nightmare.
1. Clone the repo
    - Surely you know how to do this. For the three people that don't know this
       ```bash
       git clone https://github.com/MonkeTGG/tstrbx.git
       cd tstrbx
       ```
2. Build
   - Open it in Visual Studio (I used 2022. should be compatible with 2017+, but does use 2022 build tools).
   - Ctrl + Shift + B.
   - Wait
   
It should now be in `tstrbx/tstrblx/bin/Release/tstrblx.exe`, or `tstrbx/tstrblx/bin/Debug/tstrblx.exe` depending on how you compiled it (it doesn't matter, they're both the same).
