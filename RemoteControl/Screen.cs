public class Screen
{
    Remote remote = new Remote();
    public bool power = false;
    public int volume = 0;
    public bool muted = false;
    public int channel = 0;
    public bool connected = false;
    public string connectionStatus = "Not Connected";
    public string googlestatus = "There is no Internet connection";
    public string wifipassword = "password123";
    int prevVolume = 0;

    public string[] channels = new string[10] { "Home", "KTLA", "CBSNews", "ESPN", "HBO", "CNN", "FOX", "NBC", "Disney", "CartoonNetwork" };
    public void BeginRemote()
    {
        remote.remoteOn();
    }
    public void Off()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("|                                                          |");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("                ______//______________\\_______             ");
        Console.WriteLine("                |              -              |             ");
        Console.WriteLine("                -------------------------------             ");
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($" Volume: {volume}                                          ");
        Console.WriteLine($" Channel: {channel}                                        ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine($" You are watching: {channels[channel]}                     ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("                ______//______________\\_______             ");
        Console.WriteLine("                |              *              |             ");
        Console.WriteLine("                -------------------------------             ");
        Console.WriteLine("Press Q to turn off the TV.");
        Console.WriteLine("");
        Console.WriteLine("Press C to change the channel.");
        Console.WriteLine("Press J to go to the next channel.");
        Console.WriteLine("Press K to go to the previous channel.");
        Console.WriteLine("");
        Console.WriteLine("Press V to change the volume.");
        Console.WriteLine("Press O to increase the volume by 10.");
        Console.WriteLine("Press P to decrease the volume by 10.");
        Console.WriteLine("Press M to mute or unmute the TV.");
        Console.WriteLine("");
        Console.WriteLine("Press S to open the Settings menu.");
        Console.WriteLine("Press I to open the Web Browser.");
    }

    public void Settings()
    {
        Console.Clear();
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("                       Settings Menu                        ");
        Console.WriteLine("                                                            ");
        Console.WriteLine($" Connection Status: {connectionStatus}                     ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                 1. Enter Wi-Fi Password                    ");
        Console.WriteLine("                 2. Back to Main Menu                       ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("                ______//______________\\_______             ");
        Console.WriteLine("                |              *              |             ");
        Console.WriteLine("                -------------------------------             ");
        Console.WriteLine("Settings Menu");
        Console.WriteLine("1. Enter Wi-Fi Password");
        Console.WriteLine("2. Back to Main Menu");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Enter Wi-Fi password:");
                string check = Console.ReadLine();
                if (check == wifipassword)
                {
                    Console.WriteLine("password is correct.");
                    connectionStatus = "Connected";
                    googlestatus = "Google";
                    connected = true;
                    Settings();
                    break;
                } else {
                    Console.WriteLine("Incorrect password. Please try again.");
                    connectionStatus = "Not Connected";
                    googlestatus = "There is no Internet connection";
                    connected = false;
                    Settings();
                    break;
                }

            case "2":
                Display();
                break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    }

    public void InternetScreen()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine(" https://www.google.com                                     ");
        Console.WriteLine("                                                            ");
        Console.WriteLine($"                    {googlestatus}                         ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine("                                                            ");
        Console.WriteLine($"{connectionStatus}                                         ");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("                ______//______________\\_______             ");
        Console.WriteLine("                |              *              |             ");
        Console.WriteLine("                -------------------------------             ");
        Console.WriteLine("Internet Screen");
        Console.WriteLine("1. Back to Main Menu");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Display();
                break;
            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    }

    public void Volume(int amount)
    {
        this.volume += amount;
        if (this.volume < 0){this.volume = 0;}
        if (this.volume > 100){this.volume = 100;}
    }
    public void Channel(int num)
    {
        this.channel = num;
        if (this.channel < 0){this.channel = 0;}
        if (this.channel >= this.channels.Length){this.channel = this.channels.Length - 1;}
    }

    public void singleChannel(int num)
    {
        this.channel += num;
        if (this.channel < 0){this.channel = 0;}
        if (this.channel >= this.channels.Length){this.channel = this.channels.Length - 1;}
        
    }

    public void Mute()
    {
        if (!this.muted)
        {
            Console.WriteLine("Muting TV...");
            prevVolume = this.volume;
            this.volume = 0;
            this.muted = true;
            this.Display();

        } else {
            Console.WriteLine("Unmuting TV...");
            this.volume = prevVolume;
            this.muted = false;
            this.Display();
        }
    }

    public void RemoteInput()
    {
        while (true)
        {
            Console.WriteLine("Turning on TV...");
            this.Display();
            string input = Console.ReadLine();
            
            switch (input){
                case "q":
                    Console.WriteLine("Turning off TV...");
                    this.Off();
                    Console.WriteLine("TV is turned off.");
                    Console.WriteLine("Press Q to turn on the TV again.");
                    string a = Console.ReadLine();
                    Input(a);
                    break;

                case "v":
                Console.WriteLine("Enter volume change amount (positive or negative):");
                int volumeChange = int.Parse(Console.ReadLine());
                Volume(volumeChange);
                this.Display();
                break;

                case "o":
                Volume(10);
                this.Display();
                break;

                case "p":
                Volume(-10);
                this.Display();
                break;

                case "m":
                Mute();
                this.Display();
                break;

                case "c":
                Console.WriteLine("Enter channel number:");
                Console.WriteLine("Channel #:");
                Console.WriteLine("1:KTLA   2:CBSNews     3:ESPN");
                Console.WriteLine("4:HBO    5:CNN         6:FOX");
                Console.WriteLine("7:NBC    8:Disney      9:CartoonNetwork");

                int channelNum = int.Parse(Console.ReadLine());
                Channel(channelNum);
                this.Display();
                break;

                case "j":
                singleChannel(1);
                this.Display();
                break;
                
                case "k":
                singleChannel(-1);
                this.Display();
                break;

                case "s":
                this.Settings();
                break;

                case "i":
                this.InternetScreen();
                break;

                default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
            }
        }
    }
    public void Input(string button)
    {
        
        if (button == "q")
        {
            this.RemoteInput();
        } else {
            Console.WriteLine("TV is turned off.");
            Console.WriteLine("Press Q to turn on the TV.");
            string input = Console.ReadLine(); 
            Input(input);
        }
    }
}