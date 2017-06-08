# RadioCSharp

This app created by the VLC .net Library for stream every online audio stream from URL. Also you can add playlist file (.pls) for show list of URLs .

(**As soon as possible, will be added comments**)

## What is new ##
### Version 1.0.5.0 ###

 - Show animated file name in title
 - record stream
 - now can play stream from rtmp protocol

## Built With

* [Visual Studio 2017](https://www.visualstudio.com/) - The Windows IDE With .net Framework 4.6 
* [ Bunifu UI](https://devtools.bunifu.co.ke/) - Third Party Libraries
* [NAudio](https://github.com/naudio/NAudio) - An Open Source Audio Library ( **NOT USED BY THIS BRANCH!** )
* [VLC .NET](https://github.com/ZeBobo5/Vlc.DotNet) - An Library For Using VLC DLLs or Plugins Without need to register VLC ActiveX Plugin. 

## Getting Started

1.  you must add and config [vlc .net - wiki](https://github.com/ZeBobo5/Vlc.DotNet/wiki) to your project.
 
2. In file 'MainRadio.cs' you should change this line to vlc folder (I upload version 2.6.0 into this branch.So you can copy and paste where exist your "execute" files or other path that you want)**

	 `mVlc = new Vlc.DotNet.Core.VlcMediaPlayer(new DirectoryInfo(mPath + "\\vlc"));` 

## Running the tests

Test system:

* Visual Studio 2017
* Windows 10
* .Net framework 4.6.1 

![First Page](https://raw.githubusercontent.com/c0mm4nDer/RadioCSharp/ver_1.0.5.0_vlc/RadioCSharp/Snapshots/s1.PNG)

![Add URLs](https://raw.githubusercontent.com/c0mm4nDer/RadioCSharp/ver_1.0.5.0_vlc/RadioCSharp/Snapshots/s2.PNG)


## Authors

* **Sayed Amir Ahmadi** - *Initial work* - [ITIUM.IR](http://itium.ir)


## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/c0mm4nDer/RadioCSharp/blob/ver_1.0.5.0_vlc/RadioCSharp/LICENSE.TXT) file for details

## Acknowledgments

* Thanks to [alireza](https://github.com/alireza6677) for their support in this project.


