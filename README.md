# Cloudphoto
CLI application for bucket management in Yandex.Cloud. Allows you to upload, download, delete and display photos in albums. Generates site for viewing albums and photos.

Installing:
* Download release version of application for [win-64](https://github.com/d7chelovechek/CloudTechnology/releases/tag/latest-win-64) or [linux-64](https://github.com/d7chelovechek/CloudTechnology/releases/tag/latest-linux-64);
* Download .NET 6 for win using **"winget install Microsoft.DotNet.SDK.6"** or linux using **"sudo apt-get install -y dotnet6"** by CLI;
* (only linux) Set chmod 777 for executable file **"cloudphoto"**;
* Use (path)/./cloudphoto init in CLI;
* After executing command, application will automatically update PATH environment variable so that you can use "cloudphoto" application without specifying a path;
* Enjoy.

Commands:
* delete -a (--album) -p (--photo) | Delete album or photo from bucket.
* download -a (--album) -p (--path) | Download photos from bucket.
* init | Init settings file and create bucket.
* list -a (--album) | Display albums or photos in bucket.
* mksite | Generates and publishes web pages for bucket.
* upload -a (--album) -p (--path) | Upload photos to bucket. 
