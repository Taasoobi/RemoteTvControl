public class Screen
{
    public bool power = false;
    public int volume = 0;
    public bool muted = false;
    public int channel = 0;
    public bool connected = false;
    public string connectionStatus = "Not Connected";
    public string googlestatus = "There is no Internet connection";
    public string wifipassword = "password123";
    public string[] channels = new string[10] { "Home", "KTLA", "CBSNews", "ESPN", "HBO", "CNN", "FOX", "NBC", "Disney", "CartoonNetwork" };
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
}