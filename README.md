![picture alt](https://www.publicdomainpictures.net/pictures/160000/nahled/musical-notes-1460211364ty6.jpg)

# Search song lyrics

A C# Windows Forms application for finding song lyrics using [lyrics.ovh](https://lyrics.ovh/) API(RESTful web service)

Options:

* You can make txt file from song lyrics and send by e-mail to friend.

* You can send song lyrics to friend's WhatsApp(using WhatsApp API).

* If it is serbian song ,you can translate it from Latin to Cyrillic.

* You can listen song on YouTube

* Also you can copy song lyrics to clipboard and print it if you like.

* Next to song lyrics there is displayed image of an artist fetched from google images(random) using [HttpAgilityPack](https://html-agility-pack.net/) and LINQ for web crawling)

## Installation

Clone from Git 

1. In Team Explorer, go to Manage Connections then open the Connect view.
2. Select Clone under Local Git Repositories and enter the URL for your Git repo

```bash
https://github.com/LukaJo/LyricsApp
```

3. Select a folder where you want your cloned repo to be kept.
4. Select Clone to clone the repo.

## Note

Also you need to replace phone number(for sending to WhatsApp),email and email password(for sending email to friend),paths on your computer(to find generated excel file and for saving file to txt)).

## Motivation

I love listening to music so i decide to make an application for finding song lyrics. :)

## Development
This app is developed in C# with Visual Studio Community 2017.

## API Reference
[lyrics.ovh](https://lyrics.ovh/) API is used in this application.
Lyrics.ovh API is a RESTful web service which allows you to find the lyrics for a song quickly and without ads.

## Author
[Luka Jovic](https://www.linkedin.com/in/lukajovic/)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
This project is licensed under the [MIT License](https://choosealicense.com/licenses/mit/)
