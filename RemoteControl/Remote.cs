using System.Security.Cryptography.X509Certificates;

public class Remote
{
    Screen screen = new Screen();
    //int prevVolume = 0;

    public void remoteOn()
    {
        screen.Off();
        Console.WriteLine("TV is turned off.");
        Console.WriteLine("Press Q to turn on the TV.");
        string a = Console.ReadLine();
        screen.Input(a);
    }
    /*public void RemoteInput()
    {
        while (true)
        {
            Console.WriteLine("Turning on TV...");
            screen.Display();
            string input = Console.ReadLine();
            
            switch (input){
                case "q":
                    Console.WriteLine("Turning off TV...");
                    screen.Off();
                    Console.WriteLine("TV is turned off.");
                    Console.WriteLine("Press Q to turn on the TV again.");
                    string a = Console.ReadLine();
                    Input(a);
                    break;

                case "v":
                Console.WriteLine("Enter volume change amount (positive or negative):");
                int volumeChange = int.Parse(Console.ReadLine());
                Volume(volumeChange);
                screen.Display();
                break;

                case "o":
                Volume(10);
                screen.Display();
                break;

                case "p":
                Volume(-10);
                screen.Display();
                break;

                case "m":
                Mute();
                screen.Display();
                break;

                case "c":
                Console.WriteLine("Enter channel number:");
                Console.WriteLine("Channel #:");
                Console.WriteLine("1:KTLA   2:CBSNews     3:ESPN");
                Console.WriteLine("4:HBO    5:CNN         6:FOX");
                Console.WriteLine("7:NBC    8:Disney      9:CartoonNetwork");

                int channelNum = int.Parse(Console.ReadLine());
                Channel(channelNum);
                screen.Display();
                break;

                case "j":
                singleChannel(1);
                screen.Display();
                break;
                
                case "k":
                singleChannel(-1);
                screen.Display();
                break;

                case "s":
                screen.Settings();
                break;

                case "i":
                screen.InternetScreen();
                break;

                default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
            }
        }
    }*/
/*
    public void Volume(int amount)
    {
        screen.volume += amount;
        if (screen.volume < 0){screen.volume = 0;}
        if (screen.volume > 100){screen.volume = 100;}
    }
    public void Channel(int num)
    {
        screen.channel = num;
        if (screen.channel < 0){screen.channel = 0;}
        if (screen.channel >= screen.channels.Length){screen.channel = screen.channels.Length - 1;}
    }

    public void singleChannel(int num)
    {
        screen.channel += num;
        if (screen.channel < 0){screen.channel = 0;}
        if (screen.channel >= screen.channels.Length){screen.channel = screen.channels.Length - 1;}
        
    }

    public void Mute()
    {
        if (!screen.muted)
        {
            Console.WriteLine("Muting TV...");
            prevVolume = screen.volume;
            screen.volume = 0;
            screen.muted = true;
            screen.Display();

        } else {
            Console.WriteLine("Unmuting TV...");
            screen.volume = prevVolume;
            screen.muted = false;
            screen.Display();
        }
    }

    */

    /*
    public void Input(string button)
    {
        
        if (button == "q")
        {
            RemoteInput();
        } else {
            Console.WriteLine("TV is turned off.");
            Console.WriteLine("Press Q to turn on the TV.");
            string input = Console.ReadLine(); 
            Input(input);
        }
    }*/
}