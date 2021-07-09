using System;

namespace StoreUI
{
    public class MainMenu : IMenu 
    {
        public void menu() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;  
            Console.WriteLine(@"
   ___                 _     _       _   _       _ _                                _____                           _                 
  |_  |               | |   ( )     | | | |     | | |                              |  ___|                         (_)                
    | | __ _  ___ ___ | |__ |/ ___  | |_| | __ _| | | _____      _____  ___ _ __   | |__ _ __ ___  _ __   ___  _ __ _ _   _ _ __ ___  
    | |/ _` |/ __/ _ \| '_ \  / __| |  _  |/ _` | | |/ _ \ \ /\ / / _ \/ _ \ '_ \  |  __| '_ ` _ \| '_ \ / _ \| '__| | | | | '_ ` _ \ 
/\__/ / (_| | (_| (_) | |_) | \__ \ | | | | (_| | | | (_) \ V  V /  __/  __/ | | | | |__| | | | | | |_) | (_) | |  | | |_| | | | | | |
\____/ \__,_|\___\___/|_.__/  |___/ \_| |_/\__,_|_|_|\___/ \_/\_/ \___|\___|_| |_| \____/_| |_| |_| .__/ \___/|_|  |_|\__,_|_| |_| |_|
                                                                                                  | |                                 
                                                                                                  |_|                                 
                                  .-----.
                          .'       `.
                         :      ^v^  :
                         :           :
                         '           '
          |~        www   `.       .'
         /.\       /#^^\_   `-/\--'
        /#  \     /#%    \   /# \
       /#%   \   /#%______\ /#%__\
      /#%     \   |= I I ||  |- |
      ~~|~~~|~~   |_=_-__|'  |[]|
        |[] |_______\__|/_ _ |= |`.
 ^V^    |-  /= __   __    /-\|= | :;
        |= /- /\/  /\/   /=- \.-' :;
        | /_.=========._/_.-._\  .:'
        |= |-.'.- .'.- |  /|\ |.:'
        \  |=|:|= |:| =| |~|~||'|
         |~|-|:| -|:|  |-|~|~||=|      ^V^
         |=|=|:|- |:|- | |~|~|| |
         | |-_~__=_~__=|_^^^^^|/___
         |-(=-=-=-=-=-(|=====/=_-=/\
         | |=_-= _=- _=| -_=/=_-_/__\
         | |- _ =_-  _-|=_- |]#| I II
         |=|_/ \_-_= - |- = |]#| I II
         | /  _/ \. -_=| =__|]!!!I_II!!
        _|/-'/  ` \_/ \|/' _ ^^^^`.==_^.
      _/  _/`-./`-; `-.\_ / \_'\`. `. ===`.
     / .-'  __/_   `.   _/.' .-' `-. ; ====;\
    /.    ./    \ `. \ / -  /  .-'.' ====='  >
   /  \  /  .-' `--.  / .' /  `-.' ======.' /
            
            ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[3] Enter store menu (add or view list of stores)");
            Console.WriteLine("[2] Enter the customer menu (add or list customers).");
            Console.WriteLine("[1] Enter Product Menu");
            Console.WriteLine("[0] Exit.");
        }

        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "3":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.CustomerMenu;
                case "1":
                    return MenuType.ProductMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("That is not a valid input.");
                    return MenuType.MainMenu;
            }
        }
    }
}