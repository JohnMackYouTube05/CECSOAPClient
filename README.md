# CEC SOAP Client
## A GUI interface written in C#, designed to communicate with Chuck E Cheese's "PlayPassWS" SOAP API.

#### Please do NOTE:
I believe CEC and/or Semnox has caught onto my shenanigans regarding to what I've pentested to get this program working, and has subsequently shut down their public-facing web service. Cloudflare continuously shows HTTP Error 520 every time I attempt to access the site now.
![The error I keep getting when accessing the web service](https://i.ibb.co/GMnD2GG/image.png)

But regardless, I have chosen to share my codebase so far with you all anyway.


Unfortunately, this does render the program somewhat broken, as the submenus won't load without data to populate them.
If anyone does find a workaround, or any other way to access a live version of the PlayPassWS service, do let me know or submit a pull request.


Also included with this program is a **SQLite database** with pictures of **just about every game/kiddie ride in the CEC system at the last time it was properly accessible.** The file should take up about 75 MB of space.
This database was *supposed* to allow for thumbnail previews of each game to appear in the Arcade Machine Viewer menu, but I only got to test that once before the service shut down, and never got proper screenshots of it in action.


## Screenshots
#### Back when the program was working, of course....

##### The Main Menu
![The Main Menu](https://i.ibb.co/Xzm8Swv/image.png)
Do keep in mind that Card and Customer Services were never finished before the service got shut down.
##### The Location Viewer
![The locations viewer dropdown menu](https://i.ibb.co/74WC5Jd/image.png)

![The location viewer populated with metadata](https://i.ibb.co/FH5ZRKG/image.png)

##### The Arcade Machine Viewer
![The arcade machine viewer](https://i.ibb.co/5snDyRr/image.png)
